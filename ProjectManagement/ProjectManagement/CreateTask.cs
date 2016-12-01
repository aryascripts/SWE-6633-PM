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
	public partial class CreateTask : Form {

		DataManagement data;
		Project currentProject;
		List<Person> persons;
		int index;


		public CreateTask(Project p, int reqIndex) {
			InitializeComponent();
			currentProject = p;
			index = reqIndex;
			data = new ProjectManagementTool.DataManagement();
			fillPersonDataGrid();
		}

		private void buttonSaveTask_Click(object sender, EventArgs e) {
			Person selected = persons[this.UI_personDataGrid.SelectedCells[0].RowIndex];
			string category = this.UI_TaskCategory.Text;
			TaskCategory cat = new TaskCategory();
			
			if(category.StartsWith("0")) {
				cat = TaskCategory.REQ_ANALYSIS;
			} else if(category.StartsWith("1")) {
				cat = TaskCategory.DESIGN;
			} else if (category.StartsWith("2")) {
				cat = TaskCategory.CODING;
			} else if (category.StartsWith("3")) {
				cat = TaskCategory.TESTING;
			} else if (category.StartsWith("4")) {
				cat = TaskCategory.PM;
			}

			float hrs = (float)Convert.ToDouble(this.UI_InitialHours.Text);

			Task t = new ProjectManagementTool.Task(this.UI_TaskName.Text, this.UI_TaskDescription.Text, selected, cat, hrs);

			currentProject.requirements[index].tasks.Add(t);
			data.updateProject(currentProject);
			this.Close();
		}

		private void buttonAddUserTask_Click(object sender, EventArgs e) {

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

		private void UI_addPersonBtn_Click(object sender, EventArgs e) {
			var addPersonForm = new AddPerson();
			addPersonForm.ShowDialog();
			fillPersonDataGrid();
		}
	}
}
