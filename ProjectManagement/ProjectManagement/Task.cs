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
		public string name { get; set; }
		public string description { get; set; }
		public Person taskOwner { get; set; }
		public TaskCategory category { get; set; }
		public float hoursExpended;

		public Task() {
			name = null;
			description = null;
			taskOwner = null;
			hoursExpended = 0;
		}

		public Task(string name, string desc, Person owner, TaskCategory cat, float hours) {
			this.name = name;
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

