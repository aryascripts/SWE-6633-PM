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
	public partial class AddTaskHours : Form {
		Project currentProject;
		DataManagement data;
		int req, task;

		public AddTaskHours(Project p, int req, int task) {
			InitializeComponent();

			currentProject = p;
			data = new DataManagement();

			this.req = req;
			this.task = task;
		}

		private void UI_AddHrsBtn_Click(object sender, EventArgs e) {
			currentProject.requirements[req].tasks[task].addHours((float)Convert.ToDouble(this.UI_TaskHours.Text));
			data.updateProject(currentProject);
			this.Close();
		}
	}
}
