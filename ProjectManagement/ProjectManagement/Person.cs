using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	public class Person {

		[BsonId]
		public Guid PersonId { get; set; }

		public String fName { get; set; }
		public String lName { get; set; }
		public String title { get; set; }

		public Person() {
			fName = null;
			lName = null;
			title = null;
			PersonId = Guid.NewGuid();
		}

		public Person(String f, String l, String t) {
			fName = f;
			lName = l;
			title = t;
		}
	}
}
