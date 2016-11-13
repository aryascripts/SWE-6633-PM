using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	class Project {
		public Person projectManager { get; private set; }
		public Person projectOwner { get; private set; }

		public List<Requirement> requirements { get; private set; }
		public List<Risk> risks { get; private set; }
		public List<Person> team { get; private set; }

		public Project() {
			projectManager = null;
			projectOwner = null;

			requirements = new List<Requirement>();
			risks = new List<Risk>();
			team = new List<Person>();
		}

		public Project(Person owner, Person manager) {

		}

		public void addRequirement(Requirement r) {
			requirements.Add(r);
		}

		public void addRisk(Risk r) {
			risks.Add(r);
		}

		public void addTeamMember(Person p) {
			team.Add(p);
		}
	}
}
