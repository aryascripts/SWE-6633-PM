using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * This file basically loads a list of Projects that are in our database currently
 * You are also able to create new projects from this screen.
 * 
 * After you select a project (or create new one) this form is trashed. Only opens
 * on first start up.
 */

namespace ProjectManagementTool {
	public partial class Form1 : Form {
		DataManagement data;
		List<Project> allProjects = new List<Project>();

		//Gets the all the projects from the database and sets fills the datagridview. 
		public Form1() {
			InitializeComponent();
			data = new ProjectManagementTool.DataManagement();

			allProjects = data.allProjects();

			setUpDataGrid(allProjects);
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void label1_Click(object sender, EventArgs e) {

		}

		//Creates a new "Form2" with a blank constructor indicating that it is a NEW project
		//The constructor of "Form2" creates a dummy project for the user to edit. 
		private void buttonNew_Click(object sender, EventArgs e) {
			this.Hide();
			var form2 = new Form2();
			form2.Closed += (s, args) => this.Close();
			form2.Show();

		}

		//Gets the index of the cell that is currently selected in the datagridview,
		//hides the current window,
		//passes the Project that is in the index in "allProjects" List, to Form
		//After form2 is open, Form1 is closed. 
		private void buttonOpen_Click(object sender, EventArgs e) {
			this.Hide();
			var form2 = new Form2(allProjects[this.projectsDataGrid.CurrentCell.RowIndex]);
			form2.Show();

		}

		//use the allProjects List<Project> to fill the datagrid.
		//you first add the columns to the "Datagrid"
		//then create a string[] which will become rows in the datagrid. 
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
