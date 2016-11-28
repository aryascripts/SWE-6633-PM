using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {
	public enum RequirementCategory {
		FUNCTIONAL,
		NONFUNCTIONAL
	}

	public class Requirement {

		[BsonId]
		public ObjectId RequirementId { get; set; }
		public String description { get;  set; }
		public int priority { get;  set; }
		public List<Task> tasks { get;  set; }
		public RequirementCategory cat { get;  set; }

		public Requirement() {
			description = null;
			priority = 0;
			tasks = new List<Task>();
			RequirementId = ObjectId.NewObjectId();
		}

		public Requirement(String desc, int priorityIn, RequirementCategory cat) {
			description = desc;
			priority = priorityIn;
			tasks = new List<Task>();
			this.cat = cat;
		}

		public void addTask(Task inTask) {
			tasks.Add(inTask);
		}

		public void removeTask(Task target) {
			tasks.Remove(target);
		}
	}
}


