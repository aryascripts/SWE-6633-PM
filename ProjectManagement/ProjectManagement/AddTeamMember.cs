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

		List<Person> persons;
		DataManagement data;
		Project currentProject;

		public AddTeamMember(Project p) {
			InitializeComponent();

			currentProject = p;
			data = new ProjectManagementTool.DataManagement();
			fillPersonDataGrid();
		}

		private void UI_newPersonBtn_Click(object sender, EventArgs e) {
			var addPersonForm = new AddPerson();
			addPersonForm.ShowDialog();
			fillPersonDataGrid();

		}

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

		private void addMember_Click(object sender, EventArgs e) {
			currentProject.addTeamMember(persons[this.UI_personDataGrid.SelectedCells[0].RowIndex]);
			data.updateProject(currentProject);
			this.Close();
		}
	}
}
