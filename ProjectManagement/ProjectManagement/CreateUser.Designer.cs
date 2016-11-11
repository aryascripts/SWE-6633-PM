namespace ProjectManagementTool
{
    partial class CreateUser
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
			this.labelMemberName = new System.Windows.Forms.Label();
			this.textBoxFirstName = new System.Windows.Forms.TextBox();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.buttonSaveUser = new System.Windows.Forms.Button();
			this.nameLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelMemberName
			// 
			this.labelMemberName.Location = new System.Drawing.Point(0, 0);
			this.labelMemberName.Name = "labelMemberName";
			this.labelMemberName.Size = new System.Drawing.Size(100, 23);
			this.labelMemberName.TabIndex = 5;
			// 
			// textBoxFirstName
			// 
			this.textBoxFirstName.Location = new System.Drawing.Point(80, 6);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(203, 20);
			this.textBoxFirstName.TabIndex = 1;
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(80, 32);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(203, 20);
			this.textBoxLastName.TabIndex = 3;
			// 
			// buttonSaveUser
			// 
			this.buttonSaveUser.Location = new System.Drawing.Point(80, 84);
			this.buttonSaveUser.Name = "buttonSaveUser";
			this.buttonSaveUser.Size = new System.Drawing.Size(203, 23);
			this.buttonSaveUser.TabIndex = 4;
			this.buttonSaveUser.Text = "Save";
			this.buttonSaveUser.UseVisualStyleBackColor = true;
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(11, 9);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(57, 13);
			this.nameLabel.TabIndex = 6;
			this.nameLabel.Text = "First Name";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Last Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Title";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(80, 58);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(203, 20);
			this.textBox1.TabIndex = 8;
			// 
			// CreateUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 119);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.buttonSaveUser);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.textBoxFirstName);
			this.Controls.Add(this.labelMemberName);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(311, 158);
			this.MinimumSize = new System.Drawing.Size(311, 158);
			this.Name = "CreateUser";
			this.Text = "Create User";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonSaveUser;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
	}
}