namespace ProjectManagementTool {
	partial class ProjectBasics {
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
			this.UI_personDataGrid = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.UI_editableProjectName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UI_editableProjectDescription = new System.Windows.Forms.RichTextBox();
			this.UI_save = new System.Windows.Forms.Button();
			this.UI_newPersonBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.UI_personDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// UI_personDataGrid
			// 
			this.UI_personDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UI_personDataGrid.Location = new System.Drawing.Point(9, 74);
			this.UI_personDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UI_personDataGrid.Name = "UI_personDataGrid";
			this.UI_personDataGrid.RowTemplate.Height = 24;
			this.UI_personDataGrid.Size = new System.Drawing.Size(369, 145);
			this.UI_personDataGrid.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Project Name";
			// 
			// UI_editableProjectName
			// 
			this.UI_editableProjectName.Location = new System.Drawing.Point(11, 24);
			this.UI_editableProjectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UI_editableProjectName.Name = "UI_editableProjectName";
			this.UI_editableProjectName.Size = new System.Drawing.Size(368, 20);
			this.UI_editableProjectName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 55);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Project Owner";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 254);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Project Description";
			// 
			// UI_editableProjectDescription
			// 
			this.UI_editableProjectDescription.Location = new System.Drawing.Point(10, 271);
			this.UI_editableProjectDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UI_editableProjectDescription.Name = "UI_editableProjectDescription";
			this.UI_editableProjectDescription.Size = new System.Drawing.Size(369, 93);
			this.UI_editableProjectDescription.TabIndex = 5;
			this.UI_editableProjectDescription.Text = "";
			// 
			// UI_save
			// 
			this.UI_save.Location = new System.Drawing.Point(161, 367);
			this.UI_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UI_save.Name = "UI_save";
			this.UI_save.Size = new System.Drawing.Size(73, 28);
			this.UI_save.TabIndex = 6;
			this.UI_save.Text = "Save";
			this.UI_save.UseVisualStyleBackColor = true;
			this.UI_save.Click += new System.EventHandler(this.UI_save_Click);
			// 
			// UI_newPersonBtn
			// 
			this.UI_newPersonBtn.Location = new System.Drawing.Point(305, 223);
			this.UI_newPersonBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UI_newPersonBtn.Name = "UI_newPersonBtn";
			this.UI_newPersonBtn.Size = new System.Drawing.Size(73, 26);
			this.UI_newPersonBtn.TabIndex = 7;
			this.UI_newPersonBtn.Text = "New Person";
			this.UI_newPersonBtn.UseVisualStyleBackColor = true;
			this.UI_newPersonBtn.Click += new System.EventHandler(this.UI_newPersonBtn_Click);
			// 
			// ProjectBasics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 403);
			this.Controls.Add(this.UI_newPersonBtn);
			this.Controls.Add(this.UI_save);
			this.Controls.Add(this.UI_editableProjectDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.UI_editableProjectName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UI_personDataGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ProjectBasics";
			this.Text = "Change Project Properties";
			((System.ComponentModel.ISupportInitialize)(this.UI_personDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView UI_personDataGrid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox UI_editableProjectName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox UI_editableProjectDescription;
		private System.Windows.Forms.Button UI_save;
		private System.Windows.Forms.Button UI_newPersonBtn;
	}
}