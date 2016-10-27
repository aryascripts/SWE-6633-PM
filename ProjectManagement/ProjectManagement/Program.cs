using System;
using LiteDB;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Startup());
        }
		public class Customer {
			public int Id { get; set; }
			public string Name { get; set; }
			public string[] Phones { get; set; }
			public bool IsActive { get; set; }
		}

		// Open database (or create if doesn't exist)
using(var db = new LiteDatabase(@"C:\Temp\MyData.db"))
{
    // Get a collection (or create, if doesn't exist)
    var col = db.GetCollection<Customer>("customers");

	// Create your new customer instance
	var customer = new Customer {
		Name = "John Doe",
		Phones = new string[] { "8000-0000", "9000-0000" },
		IsActive = true
	};

	// Insert new customer document (Id will be auto-incremented)
	col.Insert(customer);

    // Update a document inside a collection
    customer.Name = "Joana Doe";

    col.Update(customer);

    // Index document using document Name property
    col.EnsureIndex(x => x.Name);

    // Use LINQ to query documents
    var results = col.Find(x => x.Name.StartsWith("Jo"));
}

	}

	
}
