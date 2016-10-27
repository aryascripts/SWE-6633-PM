using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement {
	class Person {

		public String fName { get; set; }
		public String lName { get; set; }
		public String title { get; set; }

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

		public void addPerson(Person p) {
		}
	}
}
