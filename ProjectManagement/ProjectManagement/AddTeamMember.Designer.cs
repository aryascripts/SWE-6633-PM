namespace ProjectManagementTool {
	partial class AddTeamMember {
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
			this.UI_newPersonBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.UI_personDataGrid = new System.Windows.Forms.DataGridView();
			this.UI_addMemberButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.UI_personDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// UI_newPersonBtn
			// 
			this.UI_newPersonBtn.Location = new System.Drawing.Point(302, 213);
			this.UI_newPersonBtn.Name = "UI_newPersonBtn";
			this.UI_newPersonBtn.Size = new System.Drawing.Size(97, 32);
			this.UI_newPersonBtn.TabIndex = 10;
			this.UI_newPersonBtn.Text = "New Person";
			this.UI_newPersonBtn.UseVisualStyleBackColor = true;
			this.UI_newPersonBtn.Click += new System.EventHandler(this.UI_newPersonBtn_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Select Team Member";
			// 
			// UI_personDataGrid
			// 
			this.UI_personDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UI_personDataGrid.Location = new System.Drawing.Point(15, 29);
			this.UI_personDataGrid.Name = "UI_personDataGrid";
			this.UI_personDataGrid.RowTemplate.Height = 24;
			this.UI_personDataGrid.Size = new System.Drawing.Size(487, 178);
			this.UI_personDataGrid.TabIndex = 8;
			// 
			// UI_addMemberButton
			// 
			this.UI_addMemberButton.Location = new System.Drawing.Point(405, 213);
			this.UI_addMemberButton.Name = "UI_addMemberButton";
			this.UI_addMemberButton.Size = new System.Drawing.Size(97, 32);
			this.UI_addMemberButton.TabIndex = 13;
			this.UI_addMemberButton.Text = "Add Member";
			this.UI_addMemberButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.UI_addMemberButton.UseVisualStyleBackColor = true;
			this.UI_addMemberButton.Click += new System.EventHandler(this.addMember_Click);
			// 
			// AddTeamMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 255);
			this.Controls.Add(this.UI_addMemberButton);
			this.Controls.Add(this.UI_newPersonBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.UI_personDataGrid);
			this.Name = "AddTeamMember";
			this.Text = "AddTeamMember";
			((System.ComponentModel.ISupportInitialize)(this.UI_personDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button UI_newPersonBtn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView UI_personDataGrid;
		private System.Windows.Forms.Button UI_addMemberButton;
	}
}