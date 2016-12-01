using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	class DataManagement {
		
		/*
		High Level Overview:
		This class is basically to store two objects: Person and Project
		Person is self explanatory.
		Project object contains:
			- List of Requirements
			- List of Team Members (Person)
			- Basic project properties (names, owners, etc)
			- etc.
		
		Once you call getProject(ID), it returns the project that you are looking for. 
		This returns everything that is stored in the Project object (as mentioned above, 
		and explained in the Project.cs file where the class resides.
		
		Assuming you called getProject to make some changes to the project like add requirements,
		hours, teammembers, etc. you WILL need to call updateProject(Project) to save it to the database.
		Essentially evetything you change, you will change in the local Project variable you stored the getProject(ID) in.
		
		For example, a flow might be:
		
		DataManagement data = new DataManagement();
		Project p = getProject(Guid <-- You need to know this);
		p.setDescription("My new description");
		
		//The following statement is what SAVES it to the database, so any other tab that might try to get information
		//about the current Project, will have the latest information (your changes)
		data.updateProject(p); 
		*/

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

		public Project getProject(Guid x) {
			Project project;
			using (var db = new LiteDatabase(database)) {
				var projectsCollection = db.GetCollection<Project>("projects");

				project = projectsCollection.FindById((BsonValue)x);
			}
			return project;
		}

		public void deleteProject(Project p) {
			using (var db = new LiteDatabase(database)) {
				var projectsCollection = db.GetCollection<Project>("projects");
				projectsCollection.Delete((BsonValue)p.ProjectID);
			}
		}
	}
}
