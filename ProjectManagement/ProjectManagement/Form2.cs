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

		private Project currentProject;
		private DataGridView teamGridView;
		private DataManagement data;

		public Form2() {
			InitializeComponent();
			data = new DataManagement();

			Project p = new Project(new Person("CHANGE", "ME", "PLEASE"), new Person("CHANGE", "ME", "PLEASE"), "Change Me");
			data.addProject(p);
			currentProject = p;

			init();
		}

		public Form2(Project p) {
			InitializeComponent();
			data = new DataManagement();

			currentProject = data.getProject(p.ProjectID);
			init();
		}

		private void init() {
			
			teamGridView = this.UI_teamDataGrid;
			this.UI_projectDescription.ReadOnly = true;

			initializeTeamTab();
			refreshTeamMembers();
			initializeProjectProperties();
		}

		public void refresh() {
			currentProject = data.getProject(currentProject.ProjectID);
			initializeProjectProperties();
			refreshTeamMembers();
		}

		private void initializeProjectProperties() {
			this.UI_projectDescription.Text = currentProject.projectDescription;
			this.UI_projectLabel.Text = currentProject.projectName;
			this.UI_projectOwner.Text = currentProject.projectOwner.fName + " " + currentProject.projectOwner.lName;
		}
		
		private void initializeTeamTab() {
			teamGridView.ReadOnly = true;
			 
			teamGridView.ColumnCount = 3;
			teamGridView.Columns[0].Name = "First";
			teamGridView.Columns[1].Name = "Last ";
			teamGridView.Columns[2].Name = "Title";
		}

		private void refreshTeamMembers() {
			teamGridView.Rows.Clear();
			string[] row;

			foreach(Person p in currentProject.team) {
				row = new string[] {p.fName, p.lName, p.title};
				teamGridView.Rows.Add(row);
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e) {

		}

		private void tabPage2_Click(object sender, EventArgs e) {

		}

		private void tabPage1_Click(object sender, EventArgs e) {

		}

		private void label1_Click(object sender, EventArgs e) {

		}

		private void buttonCreateUser_Click(object sender, EventArgs e) {
			var addTeamMember = new AddTeamMember(currentProject);
			addTeamMember.ShowDialog();
			refreshTeamMembers();
		}

		private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void UI_editButton_Click(object sender, EventArgs e) {
			var formProjectBasics = new ProjectBasics(currentProject, this);
			formProjectBasics.ShowDialog();
			refresh();
		}

		private void buttonAddExistingPerson_Click(object sender, EventArgs e) {

		}

		private void UI_deleteTeamMemberButton_Click(object sender, EventArgs e) {
			currentProject.removeTeamMember(currentProject.team[this.teamGridView.SelectedCells[0].RowIndex]);
			data.updateProject(currentProject);
			refreshTeamMembers();
		}

        private void buttonCreateTask_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
