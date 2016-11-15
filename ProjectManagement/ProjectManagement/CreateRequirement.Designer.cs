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
            this.reqDescription = new System.Windows.Forms.TextBox();
            this.comboBoxReqType = new System.Windows.Forms.ComboBox();
            this.labelReqType = new System.Windows.Forms.Label();
            this.comboBoxReqPriority = new System.Windows.Forms.ComboBox();
            this.labelReqPriority = new System.Windows.Forms.Label();
            this.buttonReqSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelReqSummary
            // 
            this.labelReqSummary.AutoSize = true;
            this.labelReqSummary.Location = new System.Drawing.Point(584, 62);
            this.labelReqSummary.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReqSummary.Name = "labelReqSummary";
            this.labelReqSummary.Size = new System.Drawing.Size(108, 25);
            this.labelReqSummary.TabIndex = 0;
            this.labelReqSummary.Text = "Summary:";
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(522, 92);
            this.textBoxSummary.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSummary.Multiline = true;
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.Size = new System.Drawing.Size(256, 35);
            this.textBoxSummary.TabIndex = 1;
            // 
            // labelReqDescription
            // 
            this.labelReqDescription.AutoSize = true;
            this.labelReqDescription.Location = new System.Drawing.Point(584, 156);
            this.labelReqDescription.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReqDescription.Name = "labelReqDescription";
            this.labelReqDescription.Size = new System.Drawing.Size(120, 25);
            this.labelReqDescription.TabIndex = 2;
            this.labelReqDescription.Text = "Description";
            // 
            // reqDescription
            // 
            this.reqDescription.Location = new System.Drawing.Point(522, 204);
            this.reqDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.reqDescription.Multiline = true;
            this.reqDescription.Name = "reqDescription";
            this.reqDescription.Size = new System.Drawing.Size(256, 169);
            this.reqDescription.TabIndex = 3;
            // 
            // comboBoxReqType
            // 
            this.comboBoxReqType.FormattingEnabled = true;
            this.comboBoxReqType.Items.AddRange(new object[] {
            "Functional",
            "Non Functional"});
            this.comboBoxReqType.Location = new System.Drawing.Point(522, 431);
            this.comboBoxReqType.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxReqType.Name = "comboBoxReqType";
            this.comboBoxReqType.Size = new System.Drawing.Size(256, 33);
            this.comboBoxReqType.TabIndex = 4;
            this.comboBoxReqType.SelectedIndexChanged += new System.EventHandler(this.comboBoxReqType_SelectedIndexChanged);
            // 
            // labelReqType
            // 
            this.labelReqType.AutoSize = true;
            this.labelReqType.Location = new System.Drawing.Point(558, 400);
            this.labelReqType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReqType.Name = "labelReqType";
            this.labelReqType.Size = new System.Drawing.Size(188, 25);
            this.labelReqType.TabIndex = 5;
            this.labelReqType.Text = "Requirement Type";
            // 
            // comboBoxReqPriority
            // 
            this.comboBoxReqPriority.FormattingEnabled = true;
            this.comboBoxReqPriority.Items.AddRange(new object[] {
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
            this.comboBoxReqPriority.Location = new System.Drawing.Point(522, 556);
            this.comboBoxReqPriority.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBoxReqPriority.Name = "comboBoxReqPriority";
            this.comboBoxReqPriority.Size = new System.Drawing.Size(256, 33);
            this.comboBoxReqPriority.TabIndex = 6;
            this.comboBoxReqPriority.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelReqPriority
            // 
            this.labelReqPriority.AutoSize = true;
            this.labelReqPriority.Location = new System.Drawing.Point(614, 506);
            this.labelReqPriority.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelReqPriority.Name = "labelReqPriority";
            this.labelReqPriority.Size = new System.Drawing.Size(79, 25);
            this.labelReqPriority.TabIndex = 7;
            this.labelReqPriority.Text = "Priority";
            // 
            // buttonReqSave
            // 
            this.buttonReqSave.Location = new System.Drawing.Point(564, 638);
            this.buttonReqSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonReqSave.Name = "buttonReqSave";
            this.buttonReqSave.Size = new System.Drawing.Size(150, 44);
            this.buttonReqSave.TabIndex = 8;
            this.buttonReqSave.Text = "Save";
            this.buttonReqSave.UseVisualStyleBackColor = true;
            this.buttonReqSave.Click += new System.EventHandler(this.buttonReqSave_Click);
            // 
            // CreateRequirement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 706);
            this.Controls.Add(this.buttonReqSave);
            this.Controls.Add(this.labelReqPriority);
            this.Controls.Add(this.comboBoxReqPriority);
            this.Controls.Add(this.labelReqType);
            this.Controls.Add(this.comboBoxReqType);
            this.Controls.Add(this.reqDescription);
            this.Controls.Add(this.labelReqDescription);
            this.Controls.Add(this.textBoxSummary);
            this.Controls.Add(this.labelReqSummary);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateRequirement";
            this.Text = "CreateRequirement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReqSummary;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.Label labelReqDescription;
        private System.Windows.Forms.TextBox reqDescription;
        private System.Windows.Forms.ComboBox comboBoxReqType;
        private System.Windows.Forms.Label labelReqType;
        private System.Windows.Forms.ComboBox comboBoxReqPriority;
        private System.Windows.Forms.Label labelReqPriority;
        private System.Windows.Forms.Button buttonReqSave;
    }
}