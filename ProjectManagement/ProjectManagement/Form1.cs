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
	public partial class Form1 : Form {
		DataManagement data;
		List<Person> allPersons = new List<Person>();
        List<Requirement> allReqs = new List<Requirement>();
        List<Risk> allRisks = new List<Risk>();

		List<Project> allProjects = new List<Project>();

		public Form1() {
			InitializeComponent();
			data = new ProjectManagementTool.DataManagement();

			allPersons = data.allPersons();
			allProjects = data.allProjects();

			setUpDataGrid(allProjects);
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void label1_Click(object sender, EventArgs e) {

		}

		private void buttonNew_Click(object sender, EventArgs e) {
			this.Hide();
			var form2 = new Form2();
			form2.Closed += (s, args) => this.Close();
			form2.Show();

		}

		private void buttonOpen_Click(object sender, EventArgs e) {
			this.Hide();
			var form2 = new Form2(allProjects[this.projectsDataGrid.CurrentCell.RowIndex]);
			form2.Closed += (s, args) => this.Close();
			form2.Show();

		}

		private void setUpDataGrid(List<Project> projects) {
			var dataGrid = this.projectsDataGrid;

			dataGrid.ReadOnly = true;

			dataGrid.ColumnCount = 3;
			dataGrid.Columns[0].Name = "ID";
			dataGrid.Columns[1].Name = "Project Name";
			dataGrid.Columns[2].Name = "Project Owner";

			string[] row;
			int i = 0;

			foreach(Project p in projects) {
				row = new string[] { ""+i++, p.projectName, p.projectOwner.fName+" "+p.projectOwner.lName };
				dataGrid.Rows.Add(row);
			}
		}
	}
}
