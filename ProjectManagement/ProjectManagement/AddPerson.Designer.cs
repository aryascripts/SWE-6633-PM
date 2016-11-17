namespace ProjectManagementTool {
	partial class AddPerson {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.UI_firstName = new System.Windows.Forms.TextBox();
			this.UI_lastName = new System.Windows.Forms.TextBox();
			this.UI_title = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UI_addButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UI_firstName
			// 
			this.UI_firstName.Location = new System.Drawing.Point(93, 12);
			this.UI_firstName.Name = "UI_firstName";
			this.UI_firstName.Size = new System.Drawing.Size(300, 22);
			this.UI_firstName.TabIndex = 0;
			// 
			// UI_lastName
			// 
			this.UI_lastName.Location = new System.Drawing.Point(93, 40);
			this.UI_lastName.Name = "UI_lastName";
			this.UI_lastName.Size = new System.Drawing.Size(300, 22);
			this.UI_lastName.TabIndex = 1;
			// 
			// UI_title
			// 
			this.UI_title.Location = new System.Drawing.Point(93, 68);
			this.UI_title.Name = "UI_title";
			this.UI_title.Size = new System.Drawing.Size(300, 22);
			this.UI_title.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "First Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Title";
			// 
			// UI_addButton
			// 
			this.UI_addButton.Location = new System.Drawing.Point(307, 96);
			this.UI_addButton.Name = "UI_addButton";
			this.UI_addButton.Size = new System.Drawing.Size(86, 36);
			this.UI_addButton.TabIndex = 6;
			this.UI_addButton.Text = "Add";
			this.UI_addButton.UseVisualStyleBackColor = true;
			this.UI_addButton.Click += new System.EventHandler(this.UI_addButton_Click);
			// 
			// AddPerson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 144);
			this.Controls.Add(this.UI_addButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UI_title);
			this.Controls.Add(this.UI_lastName);
			this.Controls.Add(this.UI_firstName);
			this.Name = "AddPerson";
			this.Text = "l";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox UI_firstName;
		private System.Windows.Forms.TextBox UI_lastName;
		private System.Windows.Forms.TextBox UI_title;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button UI_addButton;
	}
}