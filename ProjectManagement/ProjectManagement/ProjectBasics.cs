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
	public partial class ProjectBasics : Form {
		Project currentProject;
		DataManagement data;
		Form2 lastWindow;
		List<Person> persons;

		public ProjectBasics(Project p, Form2 f) {
			InitializeComponent();
			currentProject = p;
			lastWindow = f;

			data = new ProjectManagementTool.DataManagement();

			refresh();
		}

		private void setBasicProjectProperties() {
			this.UI_editableProjectDescription.Text = currentProject.projectDescription;
			this.UI_editableProjectName.Text = currentProject.projectName;
		}

		private void fillPersonDataGrid() {
			persons = data.allPersons();
			var datagrid = this.UI_personDataGrid;
			datagrid.Rows.Clear();
			datagrid.Refresh();

			datagrid.ColumnCount = 3;
			datagrid.Columns[0].Name = "First";
			datagrid.Columns[1].Name = "Last";
			datagrid.Columns[2].Name = "Title";

			string[] row;
 			foreach(Person p in persons) {
				row = new string[] { p.fName, p.lName, p.title };
				datagrid.Rows.Add(row);
			}
		}

		private void UI_newPersonBtn_Click(object sender, EventArgs e) {
			currentProject.projectName = UI_editableProjectName.Text;
			currentProject.projectDescription = UI_editableProjectDescription.Text;

			var addPersonForm = new AddPerson();
			addPersonForm.ShowDialog();
			refresh();
		}

		private void UI_save_Click(object sender, EventArgs e) {
			currentProject.projectName = this.UI_editableProjectName.Text;
			currentProject.projectDescription = this.UI_editableProjectDescription.Text;
			currentProject.projectOwner = persons[this.UI_personDataGrid.CurrentCell.RowIndex];

			data.updateProject(currentProject);
			this.Close();
		}

		public void refresh(Project p) {
			currentProject = p;
			refresh();
		}

		public void refresh() {
			setBasicProjectProperties();
			fillPersonDataGrid();
		}
	}
}
