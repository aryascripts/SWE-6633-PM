using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	class DataManagement {

		public Guid currentProject { get; private set; }
		private const String database = "database.db";

		public void addPerson(Person p) {
			using (var db = new LiteDatabase(database)) {
				var personsCollection = db.GetCollection<Person>("persons");
				personsCollection.Insert(p);
			}
		}

		public List<Person> allPersons() {
			List<Person> returnList = new List<Person>();
			using (var db = new LiteDatabase(database)) {
				var persons = db.GetCollection<Person>("persons");
				var results = persons.FindAll();
				foreach (Person p in results) {
					returnList.Add(p);
				}
				return returnList;
			}
		}

		public List<Project> allProjects() {
			List<Project> returnList = new List<Project>();
			using (var db = new LiteDatabase(database)) {
				var projects = db.GetCollection<Project>("projects");
				var results = projects.FindAll();
				foreach (Project p in results) {
					returnList.Add(p);
				}
				return returnList;
			}
		}

		public void addProject(Project p) {
			using (var db = new LiteDatabase(database)) {
				var projectsCollection = db.GetCollection<Project>("projects");
				projectsCollection.Insert(p);
			}
		}

		public void updateProject(Project p) {
			using (var db = new LiteDatabase(database)) {
				var projectsCollection = db.GetCollection<Project>("projects");

				projectsCollection.Update(p);
			}
		}
	}
}
