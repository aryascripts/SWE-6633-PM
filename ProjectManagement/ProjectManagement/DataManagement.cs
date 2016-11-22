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

        public void addRequirement(Requirement r)
        {
            using (var db = new LiteDatabase(database))
            {
                var requirementsCollection = db.GetCollection<Requirement>("Requirements");
                requirementsCollection.Insert(r);
            }
        }

        public List<Requirement> allReqs()
        {
            List<Requirement> returnList = new List<Requirement>();
            using (var db = new LiteDatabase(database))
            {
                var requirements = db.GetCollection<Requirement>("Requirements");
                var results = requirements.FindAll();
                foreach (Requirement r in results)
                {
                    returnList.Add(r);
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

		public Project getProject(Guid x) {
			Project project;
			using (var db = new LiteDatabase(database)) {
				var projectsCollection = db.GetCollection<Project>("projects");

				project = projectsCollection.FindById((BsonValue)x);

				Console.WriteLine(project.projectDescription);
			}
			return project;
		}
	}
}
