using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementTool {

	public enum TaskCategory {
		REQ_ANALYSIS,
		DESIGN,
		CODING,
		TESTING,
		PM
	}

	public class Task {
		public Guid TaskId;
		public string description { get; set; }
		public Person taskOwner { get; private set; }
		public TaskCategory category { get; private set; }
		public float hoursExpended;

		public Task() {
			description = null;
			taskOwner = null;
			hoursExpended = 0;
			TaskId = Guid.NewGuid();
		}

		public Task(string desc, Person owner, TaskCategory cat, float hours) {
			description = desc;
			taskOwner = owner;
			category = cat;
			hoursExpended = hours;
		}

		public void addHours(float hours) {
			hoursExpended += hours;
			return;
		}

		public float getHours() {
			return hoursExpended;
		}
	}
}

