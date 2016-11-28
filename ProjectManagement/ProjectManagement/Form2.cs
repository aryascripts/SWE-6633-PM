using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementTool {

	public partial class Form2 : Form {

		/*	currentProject always stores the most updated information about the current Project loaded. Always make sure that you sync this with the database by calling data.updateProject(currentProject) after making changes to this local variable.
			teamGridView is a shorter name for the DataGridView displaying team members. 
			data is how you access the DataManagement class for retreiving information from and save to the database. */
		
		private Project currentProject; 
		private DataGridView teamGridView;
		private DataManagement data;
        private Requirement currentRequirement;

		/* CONSTRUCTOR.
			This is when a NEW project is created. Dummy text is applied to project properties
			that the user will need to change. 
		*/
		public Form2() {
			InitializeComponent();
			data = new DataManagement();

			Project p = new Project(new Person("CHANGE", "ME", "PLEASE"), new Person("CHANGE", "ME", "PLEASE"), "Change Me");
			data.addProject(p);
			currentProject = p;

			init();
		}

		/* CONSTRUCTOR
			This one is used for loading a previous project. 
			"data" is used for the 
		*/
		public Form2(Project p) {
			InitializeComponent();
			data = new DataManagement();

			currentProject = data.getProject(p.ProjectID);
			init();
		}

		//Anything that you need to run the FIRST time the Form loads, things like initialize the column names,
		//refresh some data, make a new method for it, and add it here so it is updated. 
		private void init() {
			
			teamGridView = this.UI_teamDataGrid;
			this.UI_projectDescription.ReadOnly = true;

			initializeTeamTab();
			refreshTeamMembers();
			initializeProjectProperties();
			populateRiskDataGrid();
			updateHomePage();
            updateReqs();
		}

		//Anything that needs to update AFTER the initial start.
		//This might include things like change of "project properties", refreshing team list, refreshing requirements list, etc.
		//This will only be called if the WHOLE WINDOW needs a refresh. Otherwise, use the individual methods like refreshTeamMembers() to 
		//just update the team members list. No need to update the whole window if everything else stayed the same.
		public void refresh() {
			currentProject = data.getProject(currentProject.ProjectID);
			initializeProjectProperties();
			refreshTeamMembers();
			updateHomePage();
			populateRiskDataGrid();
		}

		//Update the home page with all the details of the currentProject
		public void updateHomePage() {
			getLatestProjectFromDatabase();

			this.UI_MemberCount.Text = "" + currentProject.team.Count;
			this.UI_RiskCount.Text = "" + currentProject.risks.Count;

		}

		private void populateRiskDataGrid() {
			var d = this.UI_RiskDataGrid;

			string[] row;

			foreach (Risk r in currentProject.risks) {
				row = new string[] { r.description, "" + r.likelihood, "" + r.priority };
				d.Rows.Add(row);
			}
		}

		public void getLatestProjectFromDatabase() {
			currentProject = data.getProject(currentProject.ProjectID);
		}

		//This shold really be called "refreshProjectProperties" because that's what it does. It just
		//updates the project properties after a potential update. 
		private void initializeProjectProperties() {
			this.UI_projectDescription.Text = currentProject.projectDescription;
			this.UI_projectLabel.Text = currentProject.projectName;
			this.UI_projectOwner.Text = currentProject.projectOwner.fName + " " + currentProject.projectOwner.lName;
		}
		
		//Adds columns to the team tab. 
		//These are them populated by "refreshTeamMembers"
		private void initializeTeamTab() {
			teamGridView.ReadOnly = true;
			 
			teamGridView.ColumnCount = 3;
			teamGridView.Columns[0].Name = "First";
			teamGridView.Columns[1].Name = "Last ";
			teamGridView.Columns[2].Name = "Title";
		}

		//This takes the currentProject, extracts the List<Person> team from it, and
		//populates the teamGridView, which is on the Team Members tab. 
		private void refreshTeamMembers() {
			teamGridView.Rows.Clear();
			string[] row;

			foreach(Person p in currentProject.team) {
				row = new string[] {p.fName, p.lName, p.title};
				teamGridView.Rows.Add(row);
			}
		}

		private void buttonCreateUser_Click(object sender, EventArgs e) {
			var addTeamMember = new AddTeamMember(currentProject);
			addTeamMember.ShowDialog();
			refreshTeamMembers();
			updateHomePage();
		}

		private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		//Shows the dialog to edit the basic properties shown on the right side
		//TO-DO: change refresh() to initializeProjectProperties() since we do not need to update the whole Window. 
		private void UI_editButton_Click(object sender, EventArgs e) {
			var formProjectBasics = new ProjectBasics(currentProject, this);
			formProjectBasics.ShowDialog();
			refresh();
		}

		private void buttonAddExistingPerson_Click(object sender, EventArgs e) {

		}

		//This is an example of a successful edit in the Project.
		//It deletes the team member that is currently highlighted
		//Then updates the DATABASE using data.updateProject
		//Then refreshes the local team members DataGRidView using refreshTeamMembers();
		private void UI_deleteTeamMemberButton_Click(object sender, EventArgs e) {
			currentProject.removeTeamMember(currentProject.team[this.teamGridView.SelectedCells[0].RowIndex]);
			data.updateProject(currentProject);
			refreshTeamMembers();
		}

		private void buttonCreateTask_Click(object sender, EventArgs e) {

            var addTask = new CreateTask();
            addTask.ShowDialog();
			updateHomePage();
		}
           
            
        // Implementation code for Requirements Tab

        private void buttonNewRequirement_Click(object sender, EventArgs e)
        {
			var addReqs = new CreateRequirement(currentProject);
            addReqs.ShowDialog();
            updateReqs();
			updateHomePage();
		}

		//Update the current project: getLatestProjectFromDatabase();
		//Then use currentProject.requirements which holds all the requirements to get
		//each Requirement.

		private void updateReqs()
        {
            List<Requirement> reqList = currentProject.requirements;
            var datagrid = this.dataGridRequirements;

            datagrid.Rows.Clear();

            string[] req;
            foreach (Requirement r in reqList)
            {
                req = new string[] { r.description, Convert.ToString(r.cat), Convert.ToString(r.priority)  };
                datagrid.Rows.Add(req);
            }
            datagrid.AutoResizeColumns();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
  /*          var datagrid = this.dataGridRequirements;

            foreach (DataGridViewRow r in datagrid.SelectedRows)
            {
                string reqCatText = Convert.ToString(r.Cells[2].Value);
                RequirementCategory reqCat = (RequirementCategory)Enum.Parse(typeof(RequirementCategory), reqCatText);
                Requirement tempreq = new Requirement(Convert.ToString(r.Cells[0].Value), Convert.ToInt32(r.Cells[1].Value), reqCat);
                currentProject.removeRequirement(tempreq);
            } */

            currentProject.removeRequirement(currentProject.requirements[this.dataGridRequirements.SelectedCells[0].RowIndex]);
            data.updateProject(currentProject);
            updateReqs();
            updateHomePage();
        }
        //MISC STUFF IDK
        private void groupBox1_Enter(object sender, EventArgs e) {

		}

		private void tabPage2_Click(object sender, EventArgs e) {

		}

		private void tabPage1_Click(object sender, EventArgs e) {

		}

		private void label1_Click(object sender, EventArgs e) {

		}

        private void buttonDeleteTask_Click(object sender, EventArgs e)
        {
            currentRequirement.removeTask(currentRequirement.tasks[this.taskGridView.SelectedCells[0].RowIndex]);
			getLatestProjectFromDatabase();
        }

		private void button2_Click(object sender, EventArgs e) {
			var createRisk = new CreateRisk(currentProject);
			createRisk.ShowDialog();
			getLatestProjectFromDatabase();
			refresh();
		}

        
    }
}
