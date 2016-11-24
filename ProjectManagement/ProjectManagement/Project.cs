using System;
using LiteDB;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	public class Project {

		[BsonId]
		public Guid ProjectID { get; set; }

		public String projectName { get; set; }
		public Person projectManager { get; set; }
		public Person projectOwner { get; set; }
		public String projectDescription { get; set; }

		public List<Requirement> requirements { get; set; }
		public List<Risk> risks { get; set; }
		public List<Person> team { get; set; }

		public Project() {

		}

		public Project(Person owner, Person manager, String name) {
			projectName = name;
			projectManager = manager;
			projectOwner = owner;

			init();
		}

		private void init() {
			requirements = new List<Requirement>();
			risks = new List<Risk>();
			team = new List<Person>();
		}

		public void addRequirement(Requirement r) {
			requirements.Add(r);
		}

        public void removeRequirement (Requirement r)
        {
            requirements.Remove(r);
        }

		public void addRisk(Risk r) {
			risks.Add(r);
		}

		public void addTeamMember(Person p) {
			team.Add(p);
		}

		public void removeTeamMember(Person p) {
			team.Remove(p);
		}

		public void setDescription(String s) {
			projectDescription = s;
		}
	}
}
