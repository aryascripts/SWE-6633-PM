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

			Person p = new Person("First", "Last", "Title");
			Project pro = new Project(p, p, "Project Name");

			data.addProject(pro);
			data.addPerson(p);

			allPersons = data.allPersons();
			allProjects = data.allProjects();

			var bindingProjects = new BindingList<Project>(allProjects);
			this.allProjectsUI.DataSource = bindingProjects;

			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void label1_Click(object sender, EventArgs e) {

		}

		private void buttonNew_Click(object sender, EventArgs e) {
			Person p = new Person("First", "Last", "Title");
			//data.addPerson(p);

			p = new Person("Aman", "Bhimani", "PM");
			//data.addPerson(p);
		}

		private void buttonOpen_Click(object sender, EventArgs e) {
			allPersons = data.allPersons();
			Console.Clear();
			foreach (Person person in allPersons) {
				Console.WriteLine(person.PersonId + " " + person.fName + " " + person.lName + " is a " + person.title);
			}
		}
	}
}
