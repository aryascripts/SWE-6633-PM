namespace ProjectManagementTool
{
    partial class Form2
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
			this.projectOverview = new System.Windows.Forms.GroupBox();
			this.UI_projectDescription = new System.Windows.Forms.RichTextBox();
			this.UI_projectOwner = new System.Windows.Forms.Label();
			this.UI_projectLabel = new System.Windows.Forms.Label();
			this.UI_editButton = new System.Windows.Forms.Button();
			this.labelDescription = new System.Windows.Forms.Label();
			this.labelprojectOwner = new System.Windows.Forms.Label();
			this.labelprojectName = new System.Windows.Forms.Label();
			this.tabPageRisk = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dataGridView4 = new System.Windows.Forms.DataGridView();
			this.Risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RiskPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EditViewRisk = new System.Windows.Forms.DataGridViewButtonColumn();
			this.DeleteRisk = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tabPageRequirements = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.buttonNewRequirement = new System.Windows.Forms.Button();
			this.dataGridRequirements = new System.Windows.Forms.DataGridView();
			this.RequirementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequirmentPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequirementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequirementEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.RequirementDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.tabPageMembers = new System.Windows.Forms.TabPage();
			this.UI_deleteTeamMemberButton = new System.Windows.Forms.Button();
			this.UI_AddMemberBtn = new System.Windows.Forms.Button();
			this.UI_teamDataGrid = new System.Windows.Forms.DataGridView();
			this.tabPageHours = new System.Windows.Forms.TabPage();
			this.addProjectHours = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.ReqAnalysis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Designing = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Coding = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Testing = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProjectMng = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControlHours = new System.Windows.Forms.TabControl();
			this.projectOverview.SuspendLayout();
			this.tabPageRisk.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
			this.tabPageRequirements.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridRequirements)).BeginInit();
			this.tabPageMembers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UI_teamDataGrid)).BeginInit();
			this.tabPageHours.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabControlHours.SuspendLayout();
			this.SuspendLayout();
			// 
			// projectOverview
			// 
			this.projectOverview.Controls.Add(this.UI_projectDescription);
			this.projectOverview.Controls.Add(this.UI_projectOwner);
			this.projectOverview.Controls.Add(this.UI_projectLabel);
			this.projectOverview.Controls.Add(this.UI_editButton);
			this.projectOverview.Controls.Add(this.labelDescription);
			this.projectOverview.Controls.Add(this.labelprojectOwner);
			this.projectOverview.Controls.Add(this.labelprojectName);
			this.projectOverview.Location = new System.Drawing.Point(41, 10);
			this.projectOverview.Margin = new System.Windows.Forms.Padding(4);
			this.projectOverview.Name = "projectOverview";
			this.projectOverview.Padding = new System.Windows.Forms.Padding(4);
			this.projectOverview.Size = new System.Drawing.Size(267, 417);
			this.projectOverview.TabIndex = 0;
			this.projectOverview.TabStop = false;
			this.projectOverview.Text = "Project Overvew";
			this.projectOverview.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// UI_projectDescription
			// 
			this.UI_projectDescription.Location = new System.Drawing.Point(11, 199);
			this.UI_projectDescription.Name = "UI_projectDescription";
			this.UI_projectDescription.Size = new System.Drawing.Size(249, 170);
			this.UI_projectDescription.TabIndex = 4;
			this.UI_projectDescription.Text = "";
			// 
			// UI_projectOwner
			// 
			this.UI_projectOwner.AutoSize = true;
			this.UI_projectOwner.Location = new System.Drawing.Point(14, 123);
			this.UI_projectOwner.Name = "UI_projectOwner";
			this.UI_projectOwner.Size = new System.Drawing.Size(46, 17);
			this.UI_projectOwner.TabIndex = 3;
			this.UI_projectOwner.Text = "label2";
			// 
			// UI_projectLabel
			// 
			this.UI_projectLabel.AutoSize = true;
			this.UI_projectLabel.Location = new System.Drawing.Point(11, 52);
			this.UI_projectLabel.Name = "UI_projectLabel";
			this.UI_projectLabel.Size = new System.Drawing.Size(46, 17);
			this.UI_projectLabel.TabIndex = 2;
			this.UI_projectLabel.Text = "label2";
			// 
			// UI_editButton
			// 
			this.UI_editButton.Location = new System.Drawing.Point(73, 376);
			this.UI_editButton.Margin = new System.Windows.Forms.Padding(4);
			this.UI_editButton.Name = "UI_editButton";
			this.UI_editButton.Size = new System.Drawing.Size(100, 28);
			this.UI_editButton.TabIndex = 1;
			this.UI_editButton.Text = "Edit";
			this.UI_editButton.UseVisualStyleBackColor = true;
			this.UI_editButton.Click += new System.EventHandler(this.UI_editButton_Click);
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(8, 178);
			this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(127, 17);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "Project Description";
			// 
			// labelprojectOwner
			// 
			this.labelprojectOwner.AutoSize = true;
			this.labelprojectOwner.Location = new System.Drawing.Point(8, 102);
			this.labelprojectOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelprojectOwner.Name = "labelprojectOwner";
			this.labelprojectOwner.Size = new System.Drawing.Size(97, 17);
			this.labelprojectOwner.TabIndex = 1;
			this.labelprojectOwner.Text = "Project Owner";
			// 
			// labelprojectName
			// 
			this.labelprojectName.AutoSize = true;
			this.labelprojectName.Location = new System.Drawing.Point(8, 31);
			this.labelprojectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelprojectName.Name = "labelprojectName";
			this.labelprojectName.Size = new System.Drawing.Size(93, 17);
			this.labelprojectName.TabIndex = 1;
			this.labelprojectName.Text = "Project Name";
			// 
			// tabPageRisk
			// 
			this.tabPageRisk.Controls.Add(this.button4);
			this.tabPageRisk.Controls.Add(this.button2);
			this.tabPageRisk.Controls.Add(this.dataGridView4);
			this.tabPageRisk.Location = new System.Drawing.Point(4, 25);
			this.tabPageRisk.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageRisk.Name = "tabPageRisk";
			this.tabPageRisk.Size = new System.Drawing.Size(871, 514);
			this.tabPageRisk.TabIndex = 4;
			this.tabPageRisk.Text = "Risk";
			this.tabPageRisk.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(657, 481);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(100, 28);
			this.button4.TabIndex = 2;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(765, 481);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 28);
			this.button2.TabIndex = 1;
			this.button2.Text = "Create Risk";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// dataGridView4
			// 
			this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Risk,
            this.RiskPriority,
            this.EditViewRisk,
            this.DeleteRisk});
			this.dataGridView4.Location = new System.Drawing.Point(0, 0);
			this.dataGridView4.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView4.Name = "dataGridView4";
			this.dataGridView4.Size = new System.Drawing.Size(865, 474);
			this.dataGridView4.TabIndex = 0;
			this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
			// 
			// Risk
			// 
			this.Risk.HeaderText = "Risk Description";
			this.Risk.Name = "Risk";
			// 
			// RiskPriority
			// 
			this.RiskPriority.HeaderText = "Priority";
			this.RiskPriority.Name = "RiskPriority";
			// 
			// EditViewRisk
			// 
			this.EditViewRisk.HeaderText = "Edit/View";
			this.EditViewRisk.Name = "EditViewRisk";
			// 
			// DeleteRisk
			// 
			this.DeleteRisk.HeaderText = "Delete";
			this.DeleteRisk.Name = "DeleteRisk";
			// 
			// tabPageRequirements
			// 
			this.tabPageRequirements.Controls.Add(this.button1);
			this.tabPageRequirements.Controls.Add(this.deleteBtn);
			this.tabPageRequirements.Controls.Add(this.buttonNewRequirement);
			this.tabPageRequirements.Controls.Add(this.dataGridRequirements);
			this.tabPageRequirements.Location = new System.Drawing.Point(4, 25);
			this.tabPageRequirements.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageRequirements.Name = "tabPageRequirements";
			this.tabPageRequirements.Size = new System.Drawing.Size(871, 514);
			this.tabPageRequirements.TabIndex = 2;
			this.tabPageRequirements.Text = "Requirements";
			this.tabPageRequirements.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(672, 482);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 28);
			this.button1.TabIndex = 3;
			this.button1.Text = "View Tasks";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(583, 482);
			this.deleteBtn.Margin = new System.Windows.Forms.Padding(4);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(81, 28);
			this.deleteBtn.TabIndex = 2;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			// 
			// buttonNewRequirement
			// 
			this.buttonNewRequirement.Location = new System.Drawing.Point(790, 482);
			this.buttonNewRequirement.Margin = new System.Windows.Forms.Padding(4);
			this.buttonNewRequirement.Name = "buttonNewRequirement";
			this.buttonNewRequirement.Size = new System.Drawing.Size(77, 28);
			this.buttonNewRequirement.TabIndex = 1;
			this.buttonNewRequirement.Text = "New";
			this.buttonNewRequirement.UseVisualStyleBackColor = true;
			// 
			// dataGridRequirements
			// 
			this.dataGridRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridRequirements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequirementName,
            this.RequirmentPriority,
            this.RequirementType,
            this.RequirementEdit,
            this.RequirementDelete});
			this.dataGridRequirements.Location = new System.Drawing.Point(4, 4);
			this.dataGridRequirements.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridRequirements.Name = "dataGridRequirements";
			this.dataGridRequirements.Size = new System.Drawing.Size(863, 473);
			this.dataGridRequirements.TabIndex = 0;
			// 
			// RequirementName
			// 
			this.RequirementName.HeaderText = "Requirement Description";
			this.RequirementName.Name = "RequirementName";
			// 
			// RequirmentPriority
			// 
			this.RequirmentPriority.HeaderText = "Priority";
			this.RequirmentPriority.Name = "RequirmentPriority";
			// 
			// RequirementType
			// 
			this.RequirementType.HeaderText = "Type";
			this.RequirementType.Name = "RequirementType";
			// 
			// RequirementEdit
			// 
			this.RequirementEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RequirementEdit.HeaderText = "Edit/View";
			this.RequirementEdit.Name = "RequirementEdit";
			this.RequirementEdit.Text = "Edit";
			this.RequirementEdit.UseColumnTextForButtonValue = true;
			// 
			// RequirementDelete
			// 
			this.RequirementDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RequirementDelete.HeaderText = "Delete";
			this.RequirementDelete.Name = "RequirementDelete";
			this.RequirementDelete.Text = "Delete";
			this.RequirementDelete.UseColumnTextForButtonValue = true;
			// 
			// tabPageMembers
			// 
			this.tabPageMembers.Controls.Add(this.UI_deleteTeamMemberButton);
			this.tabPageMembers.Controls.Add(this.UI_AddMemberBtn);
			this.tabPageMembers.Controls.Add(this.UI_teamDataGrid);
			this.tabPageMembers.Location = new System.Drawing.Point(4, 25);
			this.tabPageMembers.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageMembers.Name = "tabPageMembers";
			this.tabPageMembers.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageMembers.Size = new System.Drawing.Size(871, 514);
			this.tabPageMembers.TabIndex = 1;
			this.tabPageMembers.Text = "Team Members";
			this.tabPageMembers.UseVisualStyleBackColor = true;
			this.tabPageMembers.Click += new System.EventHandler(this.tabPage2_Click);
			// 
			// UI_deleteTeamMemberButton
			// 
			this.UI_deleteTeamMemberButton.Location = new System.Drawing.Point(607, 481);
			this.UI_deleteTeamMemberButton.Margin = new System.Windows.Forms.Padding(4);
			this.UI_deleteTeamMemberButton.Name = "UI_deleteTeamMemberButton";
			this.UI_deleteTeamMemberButton.Size = new System.Drawing.Size(125, 28);
			this.UI_deleteTeamMemberButton.TabIndex = 2;
			this.UI_deleteTeamMemberButton.Text = "Delete Selected";
			this.UI_deleteTeamMemberButton.UseVisualStyleBackColor = true;
			this.UI_deleteTeamMemberButton.Click += new System.EventHandler(this.UI_deleteTeamMemberButton_Click);
			// 
			// UI_AddMemberBtn
			// 
			this.UI_AddMemberBtn.Location = new System.Drawing.Point(740, 481);
			this.UI_AddMemberBtn.Margin = new System.Windows.Forms.Padding(4);
			this.UI_AddMemberBtn.Name = "UI_AddMemberBtn";
			this.UI_AddMemberBtn.Size = new System.Drawing.Size(125, 28);
			this.UI_AddMemberBtn.TabIndex = 1;
			this.UI_AddMemberBtn.Text = "Create New";
			this.UI_AddMemberBtn.UseVisualStyleBackColor = true;
			this.UI_AddMemberBtn.Click += new System.EventHandler(this.buttonCreateUser_Click);
			// 
			// UI_teamDataGrid
			// 
			this.UI_teamDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UI_teamDataGrid.Location = new System.Drawing.Point(4, 4);
			this.UI_teamDataGrid.Margin = new System.Windows.Forms.Padding(4);
			this.UI_teamDataGrid.Name = "UI_teamDataGrid";
			this.UI_teamDataGrid.Size = new System.Drawing.Size(861, 471);
			this.UI_teamDataGrid.TabIndex = 0;
			// 
			// tabPageHours
			// 
			this.tabPageHours.Controls.Add(this.addProjectHours);
			this.tabPageHours.Controls.Add(this.dataGridView2);
			this.tabPageHours.Location = new System.Drawing.Point(4, 25);
			this.tabPageHours.Margin = new System.Windows.Forms.Padding(4);
			this.tabPageHours.Name = "tabPageHours";
			this.tabPageHours.Padding = new System.Windows.Forms.Padding(4);
			this.tabPageHours.Size = new System.Drawing.Size(871, 514);
			this.tabPageHours.TabIndex = 0;
			this.tabPageHours.Text = "Project Hours";
			this.tabPageHours.UseVisualStyleBackColor = true;
			this.tabPageHours.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// addProjectHours
			// 
			this.addProjectHours.Location = new System.Drawing.Point(753, 477);
			this.addProjectHours.Margin = new System.Windows.Forms.Padding(2);
			this.addProjectHours.Name = "addProjectHours";
			this.addProjectHours.Size = new System.Drawing.Size(107, 30);
			this.addProjectHours.TabIndex = 1;
			this.addProjectHours.Text = "Add Hours";
			this.addProjectHours.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReqAnalysis,
            this.Designing,
            this.Coding,
            this.Testing,
            this.ProjectMng,
            this.Total});
			this.dataGridView2.Location = new System.Drawing.Point(4, 8);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(856, 463);
			this.dataGridView2.TabIndex = 0;
			// 
			// ReqAnalysis
			// 
			this.ReqAnalysis.HeaderText = "Requirement Analysis";
			this.ReqAnalysis.Name = "ReqAnalysis";
			// 
			// Designing
			// 
			this.Designing.HeaderText = "Designing";
			this.Designing.Name = "Designing";
			// 
			// Coding
			// 
			this.Coding.HeaderText = "Coding";
			this.Coding.Name = "Coding";
			// 
			// Testing
			// 
			this.Testing.HeaderText = "Testing";
			this.Testing.Name = "Testing";
			// 
			// ProjectMng
			// 
			this.ProjectMng.HeaderText = "Project Management";
			this.ProjectMng.Name = "ProjectMng";
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			// 
			// tabControlHours
			// 
			this.tabControlHours.Controls.Add(this.tabPageHours);
			this.tabControlHours.Controls.Add(this.tabPageMembers);
			this.tabControlHours.Controls.Add(this.tabPageRequirements);
			this.tabControlHours.Controls.Add(this.tabPageRisk);
			this.tabControlHours.Location = new System.Drawing.Point(316, 16);
			this.tabControlHours.Margin = new System.Windows.Forms.Padding(4);
			this.tabControlHours.Name = "tabControlHours";
			this.tabControlHours.SelectedIndex = 0;
			this.tabControlHours.Size = new System.Drawing.Size(879, 543);
			this.tabControlHours.TabIndex = 1;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1205, 565);
			this.Controls.Add(this.tabControlHours);
			this.Controls.Add(this.projectOverview);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form2";
			this.Text = "Project Manager 2016";
			this.projectOverview.ResumeLayout(false);
			this.projectOverview.PerformLayout();
			this.tabPageRisk.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
			this.tabPageRequirements.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridRequirements)).EndInit();
			this.tabPageMembers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UI_teamDataGrid)).EndInit();
			this.tabPageHours.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabControlHours.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox projectOverview;
        private System.Windows.Forms.Label labelprojectName;
        private System.Windows.Forms.Button UI_editButton;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelprojectOwner;
		private System.Windows.Forms.TabPage tabPageRisk;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridView dataGridView4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Risk;
		private System.Windows.Forms.DataGridViewTextBoxColumn RiskPriority;
		private System.Windows.Forms.DataGridViewButtonColumn EditViewRisk;
		private System.Windows.Forms.DataGridViewButtonColumn DeleteRisk;
		private System.Windows.Forms.TabPage tabPageRequirements;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button buttonNewRequirement;
		private System.Windows.Forms.DataGridView dataGridRequirements;
		private System.Windows.Forms.DataGridViewTextBoxColumn RequirementName;
		private System.Windows.Forms.DataGridViewTextBoxColumn RequirmentPriority;
		private System.Windows.Forms.DataGridViewTextBoxColumn RequirementType;
		private System.Windows.Forms.DataGridViewButtonColumn RequirementEdit;
		private System.Windows.Forms.DataGridViewButtonColumn RequirementDelete;
		private System.Windows.Forms.TabPage tabPageMembers;
		private System.Windows.Forms.Button UI_AddMemberBtn;
		private System.Windows.Forms.DataGridView UI_teamDataGrid;
		private System.Windows.Forms.TabPage tabPageHours;
		private System.Windows.Forms.Button addProjectHours;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReqAnalysis;
		private System.Windows.Forms.DataGridViewTextBoxColumn Designing;
		private System.Windows.Forms.DataGridViewTextBoxColumn Coding;
		private System.Windows.Forms.DataGridViewTextBoxColumn Testing;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProjectMng;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
		private System.Windows.Forms.TabControl tabControlHours;
		private System.Windows.Forms.RichTextBox UI_projectDescription;
		private System.Windows.Forms.Label UI_projectOwner;
		private System.Windows.Forms.Label UI_projectLabel;
		private System.Windows.Forms.Button UI_deleteTeamMemberButton;
	}
}