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

		public Form2() {
			InitializeComponent();
		}

		public Form2(Project p) {
			InitializeComponent();
			currentProject = p;

			this.UI_projectDescription.ReadOnly = true;
			refresh(currentProject);

		}

		public void refresh(Project p) {
			currentProject = p;
			refresh();
		}

		public void refresh() {
			setBasicProjectProperties();
		}

		private void setBasicProjectProperties() {
			this.UI_projectDescription.Text = currentProject.projectDescription;
			this.UI_projectLabel.Text = currentProject.projectName;
			this.UI_projectOwner.Text = currentProject.projectOwner.fName + " " + currentProject.projectOwner.lName;
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

		}

		private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void UI_editButton_Click(object sender, EventArgs e) {
			var formProjectBasics = new ProjectBasics(currentProject, this);
			formProjectBasics.Show();
		}
	}
}
