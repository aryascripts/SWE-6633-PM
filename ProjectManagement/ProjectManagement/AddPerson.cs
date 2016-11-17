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
	public partial class AddPerson : Form {
		ProjectBasics lastWindow;
		public AddPerson(ProjectBasics t) {
			InitializeComponent();

			lastWindow = t;

		}

		private void UI_addButton_Click(object sender, EventArgs e) {
			DataManagement data = new DataManagement();
			Person p = new ProjectManagementTool.Person(this.UI_firstName.Text, this.UI_lastName.Text, this.UI_title.Text);
			data.addPerson(p);

			lastWindow.refresh();
			this.Close();
		}
	}
}
