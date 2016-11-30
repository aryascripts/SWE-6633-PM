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
	public partial class AddTeamMember : Form {

		List<Person> persons; //this stores ALL persons in the database. This will populate the list from which you can pick who to add as a Team Member to the current Project. 
		DataManagement data; //object to access the database.
		Project currentProject; // to store the current most project we are working with. ALWAYS make sure this is updated with the database. 

		//This takes in a Project because we need to add Team member to a PROJECT
		//After any updates to "currentProject" we will update it in the database using data.updateProject(currentProject);
		public AddTeamMember(Project p) {
			InitializeComponent();

			currentProject = p;
			data = new ProjectManagementTool.DataManagement();
			fillPersonDataGrid();
		}
		
		//Show the window to add a new person to the database
		private void UI_newPersonBtn_Click(object sender, EventArgs e) {
			var addPersonForm = new AddPerson();
			addPersonForm.ShowDialog();
			fillPersonDataGrid();
		}

		//This fills the database with all current PERSONS in the database.
		//Flow of this goes as follows:
		/*
			1. get all persons from the database
			2. clear the current data grid holding persons
			3. name the columns as needed "first, last, title"
			4. all persons stored in list "persons" is used to create a string[] array
			5. the rows are added to datagrid.row
		*/
		private void fillPersonDataGrid() {
			persons = data.allPersons();
			var datagrid = this.UI_personDataGrid;

			datagrid.Rows.Clear();

			datagrid.ColumnCount = 3;
			datagrid.Columns[0].Name = "First";
			datagrid.Columns[1].Name = "Last";
			datagrid.Columns[2].Name = "Title";

			string[] row;
			foreach (Person p in persons) {
				row = new string[] { p.fName, p.lName, p.title };
				datagrid.Rows.Add(row);
			}
		}
		
		/*
		This is the most important method in this class.
			We call the "addTeamMember" method for the currentProject, which adds the team member. 
			The "Person" is the highlighted one in the list of All persons (previous method)
			The index for the persons LIST, and the DataGRidView match exactly since that is what we use to populate the grid.
					      this widnow
		So we get the index from this.UI_personDataGrid.SelectedCells[0].RowIndex which reads:
			this window, the data grid view holding persons, the first index in the array of selected cells, and the RowIndex property of that.
		
		After we get that index, we browse to that in "persons" list, and add that person to the currentProject.
		
		Then we have to update the currentProject (since we just changed it) in the database so all other classes are aware of it. 
		*/
		private void addMember_Click(object sender, EventArgs e) {
			currentProject.addTeamMember(persons[this.UI_personDataGrid.SelectedCells[0].RowIndex]);
			data.updateProject(currentProject);
			this.Close();
		}
	}
}
