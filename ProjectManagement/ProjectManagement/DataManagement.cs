using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	class DataManagement {
		public void addPerson(Person p) {
			using (var db = new LiteDatabase("database.db")) {
				var personsCollection = db.GetCollection<Person>("persons");
				personsCollection.Insert(p);
			}
		}

		public List<Person> allPersons() {
			List<Person> returnList = new List<Person>();
			using (var db = new LiteDatabase("database.db")) {
				var issues = db.GetCollection<Person>("persons");
				var results = issues.FindAll();
				foreach (Person p in results) {
					returnList.Add(p);
				}
				return returnList;
			}
		}
	}
}
