namespace ProjectManagementTool
{
    partial class Form1
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
			this.projectsDataGrid = new System.Windows.Forms.DataGridView();
			this.titleOfApp = new System.Windows.Forms.Label();
			this.buttonNew = new System.Windows.Forms.Button();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.UI_deleteBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.projectsDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// projectsDataGrid
			// 
			this.projectsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.projectsDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.projectsDataGrid.Location = new System.Drawing.Point(10, 48);
			this.projectsDataGrid.Name = "projectsDataGrid";
			this.projectsDataGrid.Size = new System.Drawing.Size(394, 292);
			this.projectsDataGrid.TabIndex = 0;
			// 
			// titleOfApp
			// 
			this.titleOfApp.AutoSize = true;
			this.titleOfApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleOfApp.Location = new System.Drawing.Point(57, 7);
			this.titleOfApp.Name = "titleOfApp";
			this.titleOfApp.Size = new System.Drawing.Size(330, 37);
			this.titleOfApp.TabIndex = 1;
			this.titleOfApp.Text = "Project Manager 2016";
			this.titleOfApp.Click += new System.EventHandler(this.label1_Click);
			// 
			// buttonNew
			// 
			this.buttonNew.Location = new System.Drawing.Point(12, 346);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(121, 25);
			this.buttonNew.TabIndex = 2;
			this.buttonNew.Text = "New";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(139, 346);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(121, 25);
			this.buttonOpen.TabIndex = 3;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// UI_deleteBtn
			// 
			this.UI_deleteBtn.Location = new System.Drawing.Point(349, 346);
			this.UI_deleteBtn.Name = "UI_deleteBtn";
			this.UI_deleteBtn.Size = new System.Drawing.Size(55, 25);
			this.UI_deleteBtn.TabIndex = 4;
			this.UI_deleteBtn.Text = "Delete";
			this.UI_deleteBtn.UseVisualStyleBackColor = true;
			this.UI_deleteBtn.Click += new System.EventHandler(this.UI_deleteBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(262, 373);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 395);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UI_deleteBtn);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.titleOfApp);
			this.Controls.Add(this.projectsDataGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Project Manager 2016";
			((System.ComponentModel.ISupportInitialize)(this.projectsDataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView projectsDataGrid;
        private System.Windows.Forms.Label titleOfApp;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Button UI_deleteBtn;
		private System.Windows.Forms.Label label1;
	}
}

