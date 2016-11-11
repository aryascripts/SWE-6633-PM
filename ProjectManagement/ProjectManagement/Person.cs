using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	public class Person {

		[BsonId]
		private Guid PersonId { get; set; }
		private String fName { get; set; }
		private String lName { get; set; }
		private String title { get; set; }

		public Person() {
			fName = null;
			lName = null;
			title = null;
		}

		public Person(String f, String l, String t) {
			fName = f;
			lName = l;
			title = t;
		}
	}
}
