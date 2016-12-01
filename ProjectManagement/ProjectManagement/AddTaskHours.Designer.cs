namespace ProjectManagementTool {
	partial class AddTaskHours {
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
			this.label1 = new System.Windows.Forms.Label();
			this.UI_TaskHours = new System.Windows.Forms.TextBox();
			this.UI_AddHrsBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hours: ";
			// 
			// UI_TaskHours
			// 
			this.UI_TaskHours.Location = new System.Drawing.Point(72, 6);
			this.UI_TaskHours.Name = "UI_TaskHours";
			this.UI_TaskHours.Size = new System.Drawing.Size(150, 22);
			this.UI_TaskHours.TabIndex = 1;
			// 
			// UI_AddHrsBtn
			// 
			this.UI_AddHrsBtn.Location = new System.Drawing.Point(228, 3);
			this.UI_AddHrsBtn.Name = "UI_AddHrsBtn";
			this.UI_AddHrsBtn.Size = new System.Drawing.Size(86, 30);
			this.UI_AddHrsBtn.TabIndex = 2;
			this.UI_AddHrsBtn.Text = "Add Hours";
			this.UI_AddHrsBtn.UseVisualStyleBackColor = true;
			this.UI_AddHrsBtn.Click += new System.EventHandler(this.UI_AddHrsBtn_Click);
			// 
			// AddTaskHours
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 47);
			this.Controls.Add(this.UI_AddHrsBtn);
			this.Controls.Add(this.UI_TaskHours);
			this.Controls.Add(this.label1);
			this.Name = "AddTaskHours";
			this.Text = "AddTaskHours";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox UI_TaskHours;
		private System.Windows.Forms.Button UI_AddHrsBtn;
	}
}