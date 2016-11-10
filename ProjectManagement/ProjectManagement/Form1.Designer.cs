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
			this.mainScreenData = new System.Windows.Forms.DataGridView();
			this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProjectOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProjectDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titleOfApp = new System.Windows.Forms.Label();
			this.buttonNew = new System.Windows.Forms.Button();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.fNameOnForm = new System.Windows.Forms.Label();
			this.count = new System.Windows.Forms.Label();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonCount = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.mainScreenData)).BeginInit();
			this.SuspendLayout();
			// 
			// mainScreenData
			// 
			this.mainScreenData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mainScreenData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.ProjectOwner,
            this.ProjectDate});
			this.mainScreenData.Location = new System.Drawing.Point(578, 263);
			this.mainScreenData.Margin = new System.Windows.Forms.Padding(6);
			this.mainScreenData.Name = "mainScreenData";
			this.mainScreenData.Size = new System.Drawing.Size(688, 288);
			this.mainScreenData.TabIndex = 0;
			// 
			// ProjectName
			// 
			this.ProjectName.HeaderText = "Project Name";
			this.ProjectName.Name = "ProjectName";
			// 
			// ProjectOwner
			// 
			this.ProjectOwner.HeaderText = "Project Owner";
			this.ProjectOwner.Name = "ProjectOwner";
			// 
			// ProjectDate
			// 
			this.ProjectDate.HeaderText = "Modified Date";
			this.ProjectDate.Name = "ProjectDate";
			// 
			// titleOfApp
			// 
			this.titleOfApp.AutoSize = true;
			this.titleOfApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleOfApp.Location = new System.Drawing.Point(564, 87);
			this.titleOfApp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.titleOfApp.Name = "titleOfApp";
			this.titleOfApp.Size = new System.Drawing.Size(664, 73);
			this.titleOfApp.TabIndex = 1;
			this.titleOfApp.Text = "Project Manager 2016";
			this.titleOfApp.Click += new System.EventHandler(this.label1_Click);
			// 
			// buttonNew
			// 
			this.buttonNew.Location = new System.Drawing.Point(688, 688);
			this.buttonNew.Margin = new System.Windows.Forms.Padding(6);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(188, 48);
			this.buttonNew.TabIndex = 2;
			this.buttonNew.Text = "New";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(926, 688);
			this.buttonOpen.Margin = new System.Windows.Forms.Padding(6);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(188, 48);
			this.buttonOpen.TabIndex = 3;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// fNameOnForm
			// 
			this.fNameOnForm.AutoSize = true;
			this.fNameOnForm.Location = new System.Drawing.Point(1378, 569);
			this.fNameOnForm.Name = "fNameOnForm";
			this.fNameOnForm.Size = new System.Drawing.Size(0, 25);
			this.fNameOnForm.TabIndex = 4;
			// 
			// count
			// 
			this.count.AutoSize = true;
			this.count.Location = new System.Drawing.Point(1133, 766);
			this.count.Name = "count";
			this.count.Size = new System.Drawing.Size(70, 25);
			this.count.TabIndex = 5;
			this.count.Text = "label1";
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(688, 754);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(188, 49);
			this.buttonClear.TabIndex = 6;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonCount
			// 
			this.buttonCount.Location = new System.Drawing.Point(926, 754);
			this.buttonCount.Name = "buttonCount";
			this.buttonCount.Size = new System.Drawing.Size(188, 49);
			this.buttonCount.TabIndex = 7;
			this.buttonCount.Text = "Count";
			this.buttonCount.UseVisualStyleBackColor = true;
			this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1840, 994);
			this.Controls.Add(this.buttonCount);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.count);
			this.Controls.Add(this.fNameOnForm);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.titleOfApp);
			this.Controls.Add(this.mainScreenData);
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Form1";
			this.Text = "Project Manager 2016";
			((System.ComponentModel.ISupportInitialize)(this.mainScreenData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainScreenData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectOwner;
        private System.Windows.Forms.Label titleOfApp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectDate;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Label fNameOnForm;
		private System.Windows.Forms.Label count;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonCount;
	}
}

