namespace ProjectManagementTool
{
    partial class CreateRequirement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelReqSummary = new System.Windows.Forms.Label();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.labelReqDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxReqType = new System.Windows.Forms.ComboBox();
            this.labelReqType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelReqPriority = new System.Windows.Forms.Label();
            this.buttonReqSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelReqSummary
            // 
            this.labelReqSummary.AutoSize = true;
            this.labelReqSummary.Location = new System.Drawing.Point(292, 32);
            this.labelReqSummary.Name = "labelReqSummary";
            this.labelReqSummary.Size = new System.Drawing.Size(53, 13);
            this.labelReqSummary.TabIndex = 0;
            this.labelReqSummary.Text = "Summary:";
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(261, 48);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(130, 20);
            this.textBoxSummary.TabIndex = 1;
            // 
            // labelReqDescription
            // 
            this.labelReqDescription.AutoSize = true;
            this.labelReqDescription.Location = new System.Drawing.Point(292, 81);
            this.labelReqDescription.Name = "labelReqDescription";
            this.labelReqDescription.Size = new System.Drawing.Size(60, 13);
            this.labelReqDescription.TabIndex = 2;
            this.labelReqDescription.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 106);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 90);
            this.textBox1.TabIndex = 3;
            // 
            // comboBoxReqType
            // 
            this.comboBoxReqType.FormattingEnabled = true;
            this.comboBoxReqType.Items.AddRange(new object[] {
            "Functional",
            "Non Functional"});
            this.comboBoxReqType.Location = new System.Drawing.Point(261, 224);
            this.comboBoxReqType.Name = "comboBoxReqType";
            this.comboBoxReqType.Size = new System.Drawing.Size(130, 21);
            this.comboBoxReqType.TabIndex = 4;
            this.comboBoxReqType.SelectedIndexChanged += new System.EventHandler(this.comboBoxReqType_SelectedIndexChanged);
            // 
            // labelReqType
            // 
            this.labelReqType.AutoSize = true;
            this.labelReqType.Location = new System.Drawing.Point(279, 208);
            this.labelReqType.Name = "labelReqType";
            this.labelReqType.Size = new System.Drawing.Size(94, 13);
            this.labelReqType.TabIndex = 5;
            this.labelReqType.Text = "Requirement Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(261, 289);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelReqPriority
            // 
            this.labelReqPriority.AutoSize = true;
            this.labelReqPriority.Location = new System.Drawing.Point(307, 263);
            this.labelReqPriority.Name = "labelReqPriority";
            this.labelReqPriority.Size = new System.Drawing.Size(38, 13);
            this.labelReqPriority.TabIndex = 7;
            this.labelReqPriority.Text = "Priority";
            // 
            // buttonReqSave
            // 
            this.buttonReqSave.Location = new System.Drawing.Point(282, 332);
            this.buttonReqSave.Name = "buttonReqSave";
            this.buttonReqSave.Size = new System.Drawing.Size(75, 23);
            this.buttonReqSave.TabIndex = 8;
            this.buttonReqSave.Text = "Save";
            this.buttonReqSave.UseVisualStyleBackColor = true;
            // 
            // CreateRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 367);
            this.Controls.Add(this.buttonReqSave);
            this.Controls.Add(this.labelReqPriority);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelReqType);
            this.Controls.Add(this.comboBoxReqType);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelReqDescription);
            this.Controls.Add(this.textBoxSummary);
            this.Controls.Add(this.labelReqSummary);
            this.Name = "CreateRequirement";
            this.Text = "CreateRequirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReqSummary;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.Label labelReqDescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxReqType;
        private System.Windows.Forms.Label labelReqType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelReqPriority;
        private System.Windows.Forms.Button buttonReqSave;
    }
}