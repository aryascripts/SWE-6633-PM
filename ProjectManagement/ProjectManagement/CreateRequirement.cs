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
    public partial class CreateRequirement : Form
    {
        public CreateRequirement()
        {
            InitializeComponent();
        }

        private void comboBoxReqType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonReqSave_Click(object sender, EventArgs e)
        {
            //Parses the text from the Requirements Category text box into an enum
            RequirementCategory reqCat = (RequirementCategory) Enum.Parse(typeof(RequirementCategory), comboBoxReqType.Text);
            //Creates the requirement object
            Requirement reqOut = new Requirement(reqDescription.Text, Convert.ToInt32(comboBoxReqPriority.Text), reqCat);
        }
    }
}
