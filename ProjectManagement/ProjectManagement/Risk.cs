using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	public class Risk {

		public String description { get; set; }
		public float likelihood { get; set; }
		public int priority { get; set; }

		public Risk() {
			description = null;
			likelihood = 0;
		}

		public Risk(string d, float l, int p) {
			description = d;
			likelihood = l;
			priority = p;
		}
	}
}

