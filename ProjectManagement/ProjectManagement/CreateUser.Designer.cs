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
            this.textBoxMemberName = new System.Windows.Forms.TextBox();
            this.labelMemberRole = new System.Windows.Forms.Label();
            this.textBoxMemberRole = new System.Windows.Forms.TextBox();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Location = new System.Drawing.Point(207, 77);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(35, 13);
            this.labelMemberName.TabIndex = 0;
            this.labelMemberName.Text = "Name";
            // 
            // textBoxMemberName
            // 
            this.textBoxMemberName.Location = new System.Drawing.Point(173, 93);
            this.textBoxMemberName.Name = "textBoxMemberName";
            this.textBoxMemberName.Size = new System.Drawing.Size(100, 20);
            this.textBoxMemberName.TabIndex = 1;
            // 
            // labelMemberRole
            // 
            this.labelMemberRole.AutoSize = true;
            this.labelMemberRole.Location = new System.Drawing.Point(207, 127);
            this.labelMemberRole.Name = "labelMemberRole";
            this.labelMemberRole.Size = new System.Drawing.Size(29, 13);
            this.labelMemberRole.TabIndex = 2;
            this.labelMemberRole.Text = "Role";
            // 
            // textBoxMemberRole
            // 
            this.textBoxMemberRole.Location = new System.Drawing.Point(173, 153);
            this.textBoxMemberRole.Name = "textBoxMemberRole";
            this.textBoxMemberRole.Size = new System.Drawing.Size(100, 20);
            this.textBoxMemberRole.TabIndex = 3;
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Location = new System.Drawing.Point(187, 214);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveUser.TabIndex = 4;
            this.buttonSaveUser.Text = "Save";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 306);
            this.Controls.Add(this.buttonSaveUser);
            this.Controls.Add(this.textBoxMemberRole);
            this.Controls.Add(this.labelMemberRole);
            this.Controls.Add(this.textBoxMemberName);
            this.Controls.Add(this.labelMemberName);
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.TextBox textBoxMemberName;
        private System.Windows.Forms.Label labelMemberRole;
        private System.Windows.Forms.TextBox textBoxMemberRole;
        private System.Windows.Forms.Button buttonSaveUser;
    }
}