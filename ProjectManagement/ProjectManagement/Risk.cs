using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	public class Risk {

		[BsonId]
		public Guid RiskId { get; set; }
		public String description { get; private set; }
		public float likelihood { get; private set; }
		public float mitigation { get; private set; }

		public Risk() {
			description = null;
			likelihood = 0;
			mitigation = 0;
			RiskId = Guid.NewGuid();
		}

		public Risk(string d, float l, float m) {
			description = d;
			likelihood = l;
			mitigation = m;
		}
	}
}

