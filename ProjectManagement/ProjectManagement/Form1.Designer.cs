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
			this.allProjectsUI = new System.Windows.Forms.DataGridView();
			this.titleOfApp = new System.Windows.Forms.Label();
			this.buttonNew = new System.Windows.Forms.Button();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.allProjectsUI)).BeginInit();
			this.SuspendLayout();
			// 
			// allProjectsUI
			// 
			this.allProjectsUI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.allProjectsUI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName});
			this.allProjectsUI.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.allProjectsUI.Location = new System.Drawing.Point(13, 59);
			this.allProjectsUI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.allProjectsUI.Name = "allProjectsUI";
			this.allProjectsUI.Size = new System.Drawing.Size(1479, 359);
			this.allProjectsUI.TabIndex = 0;
			// 
			// titleOfApp
			// 
			this.titleOfApp.AutoSize = true;
			this.titleOfApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleOfApp.Location = new System.Drawing.Point(242, 9);
			this.titleOfApp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.titleOfApp.Name = "titleOfApp";
			this.titleOfApp.Size = new System.Drawing.Size(413, 46);
			this.titleOfApp.TabIndex = 1;
			this.titleOfApp.Text = "Project Manager 2016";
			this.titleOfApp.Click += new System.EventHandler(this.label1_Click);
			// 
			// buttonNew
			// 
			this.buttonNew.Location = new System.Drawing.Point(313, 426);
			this.buttonNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(125, 31);
			this.buttonNew.TabIndex = 2;
			this.buttonNew.Text = "New";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(446, 426);
			this.buttonOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(125, 31);
			this.buttonOpen.TabIndex = 3;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// ProjectName
			// 
			this.ProjectName.HeaderText = "Project Name";
			this.ProjectName.Name = "ProjectName";
			this.ProjectName.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1505, 471);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.titleOfApp);
			this.Controls.Add(this.allProjectsUI);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Project Manager 2016";
			((System.ComponentModel.ISupportInitialize)(this.allProjectsUI)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allProjectsUI;
        private System.Windows.Forms.Label titleOfApp;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
	}
}

