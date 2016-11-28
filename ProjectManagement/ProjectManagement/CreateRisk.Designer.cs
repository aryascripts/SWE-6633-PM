namespace ProjectManagementTool
{
    partial class CreateRisk
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
            this.UI_RiskDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_RiskPriority = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.UI_RiskLikelyhood = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_RiskDescription
            // 
            this.UI_RiskDescription.Location = new System.Drawing.Point(75, 5);
            this.UI_RiskDescription.Name = "UI_RiskDescription";
            this.UI_RiskDescription.Size = new System.Drawing.Size(170, 20);
            this.UI_RiskDescription.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Priority";
            // 
            // UI_RiskPriority
            // 
            this.UI_RiskPriority.FormattingEnabled = true;
            this.UI_RiskPriority.Items.AddRange(new object[] {
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
            this.UI_RiskPriority.Location = new System.Drawing.Point(75, 29);
            this.UI_RiskPriority.Name = "UI_RiskPriority";
            this.UI_RiskPriority.Size = new System.Drawing.Size(121, 21);
            this.UI_RiskPriority.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UI_RiskLikelyhood
            // 
            this.UI_RiskLikelyhood.FormattingEnabled = true;
            this.UI_RiskLikelyhood.Items.AddRange(new object[] {
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
            this.UI_RiskLikelyhood.Location = new System.Drawing.Point(75, 55);
            this.UI_RiskLikelyhood.Name = "UI_RiskLikelyhood";
            this.UI_RiskLikelyhood.Size = new System.Drawing.Size(121, 21);
            this.UI_RiskLikelyhood.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Likelyhood";
            // 
            // CreateRisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 115);
            this.Controls.Add(this.UI_RiskLikelyhood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UI_RiskPriority);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_RiskDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateRisk";
            this.Text = "CreateRisk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UI_RiskDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox UI_RiskPriority;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox UI_RiskLikelyhood;
		private System.Windows.Forms.Label label1;
	}
}