using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementTool {
    public partial class CreateTask : Form
    {

        DataManagement data;
        Project currentProject;


        public CreateTask()
        {
            InitializeComponent();
        }

        private void buttonSaveTask_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddUserTask_Click(object sender, EventArgs e)
        {
            var addUserTask = new AddTeamMember(currentProject);
            addUserTask.ShowDialog();
        }


    }
}
