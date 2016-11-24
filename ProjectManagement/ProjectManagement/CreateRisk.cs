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
	public partial class CreateRisk : Form {

		Project currentProject;
		DataManagement data;
		public CreateRisk(Project c) {
			InitializeComponent();

			currentProject = c;
			data = new ProjectManagementTool.DataManagement();
		}

		private void button1_Click_1(object sender, EventArgs e) {
			string description = this.UI_RiskDescription.Text;
			int priority = Int32.Parse(this.UI_RiskPriority.Text);
			int likelyhood = Int32.Parse(this.UI_RiskLikelyhood.Text);

			Risk r = new Risk(description, likelyhood, priority);

			currentProject.addRisk(r);
			data.updateProject(currentProject);

			this.Close();
		}
	}
}
