namespace ProjectManagementTool
{
    partial class CreateTask
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
			this.label1 = new System.Windows.Forms.Label();
			this.UI_TaskName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.UI_TaskDescription = new System.Windows.Forms.TextBox();
			this.UI_TaskCategory = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonSaveTask = new System.Windows.Forms.Button();
			this.UI_personDataGrid = new System.Windows.Forms.DataGridView();
			this.UI_addPersonBtn = new System.Windows.Forms.Button();
			this.UI_InitialHours = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.UI_personDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Task";
			// 
			// UI_TaskName
			// 
			this.UI_TaskName.Location = new System.Drawing.Point(85, 6);
			this.UI_TaskName.Name = "UI_TaskName";
			this.UI_TaskName.Size = new System.Drawing.Size(301, 20);
			this.UI_TaskName.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Description";
			// 
			// UI_TaskDescription
			// 
			this.UI_TaskDescription.Location = new System.Drawing.Point(85, 32);
			this.UI_TaskDescription.Multiline = true;
			this.UI_TaskDescription.Name = "UI_TaskDescription";
			this.UI_TaskDescription.Size = new System.Drawing.Size(301, 76);
			this.UI_TaskDescription.TabIndex = 3;
			// 
			// UI_TaskCategory
			// 
			this.UI_TaskCategory.FormattingEnabled = true;
			this.UI_TaskCategory.Items.AddRange(new object[] {
            "0 Requirements Analysis",
            "1 Designing",
            "2 Coding",
            "3 Testing",
            "4 Project Management"});
			this.UI_TaskCategory.Location = new System.Drawing.Point(85, 115);
			this.UI_TaskCategory.Name = "UI_TaskCategory";
			this.UI_TaskCategory.Size = new System.Drawing.Size(121, 21);
			this.UI_TaskCategory.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Category";
			// 
			// buttonSaveTask
			// 
			this.buttonSaveTask.Location = new System.Drawing.Point(85, 386);
			this.buttonSaveTask.Name = "buttonSaveTask";
			this.buttonSaveTask.Size = new System.Drawing.Size(294, 23);
			this.buttonSaveTask.TabIndex = 8;
			this.buttonSaveTask.Text = "Save";
			this.buttonSaveTask.UseVisualStyleBackColor = true;
			this.buttonSaveTask.Click += new System.EventHandler(this.buttonSaveTask_Click);
			// 
			// UI_personDataGrid
			// 
			this.UI_personDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UI_personDataGrid.Location = new System.Drawing.Point(85, 141);
			this.UI_personDataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UI_personDataGrid.Name = "UI_personDataGrid";
			this.UI_personDataGrid.RowTemplate.Height = 24;
			this.UI_personDataGrid.Size = new System.Drawing.Size(301, 207);
			this.UI_personDataGrid.TabIndex = 9;
			// 
			// UI_addPersonBtn
			// 
			this.UI_addPersonBtn.Location = new System.Drawing.Point(316, 352);
			this.UI_addPersonBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UI_addPersonBtn.Name = "UI_addPersonBtn";
			this.UI_addPersonBtn.Size = new System.Drawing.Size(70, 28);
			this.UI_addPersonBtn.TabIndex = 10;
			this.UI_addPersonBtn.Text = "Add Person";
			this.UI_addPersonBtn.UseVisualStyleBackColor = true;
			this.UI_addPersonBtn.Click += new System.EventHandler(this.UI_addPersonBtn_Click);
			// 
			// UI_InitialHours
			// 
			this.UI_InitialHours.Location = new System.Drawing.Point(85, 360);
			this.UI_InitialHours.Name = "UI_InitialHours";
			this.UI_InitialHours.Size = new System.Drawing.Size(121, 20);
			this.UI_InitialHours.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 363);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Initial Hours";
			// 
			// CreateTask
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 415);
			this.Controls.Add(this.UI_InitialHours);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.UI_addPersonBtn);
			this.Controls.Add(this.UI_personDataGrid);
			this.Controls.Add(this.buttonSaveTask);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.UI_TaskCategory);
			this.Controls.Add(this.UI_TaskDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.UI_TaskName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CreateTask";
			this.Text = "CreateTask";
			((System.ComponentModel.ISupportInitialize)(this.UI_personDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UI_TaskName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UI_TaskDescription;
        private System.Windows.Forms.ComboBox UI_TaskCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveTask;
		private System.Windows.Forms.DataGridView UI_personDataGrid;
		private System.Windows.Forms.Button UI_addPersonBtn;
		private System.Windows.Forms.TextBox UI_InitialHours;
		private System.Windows.Forms.Label label4;
	}
}