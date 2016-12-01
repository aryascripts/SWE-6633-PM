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
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label4;
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
			this.UI_RiskDataGrid = new System.Windows.Forms.DataGridView();
			this.rDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rLikelyhood = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageRequirements = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.deleteBtn = new System.Windows.Forms.Button();
			this.buttonNewRequirement = new System.Windows.Forms.Button();
			this.dataGridRequirements = new System.Windows.Forms.DataGridView();
			this.RequirementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequirementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RequirmentPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPageMembers = new System.Windows.Forms.TabPage();
			this.UI_deleteTeamMemberButton = new System.Windows.Forms.Button();
			this.UI_AddMemberBtn = new System.Windows.Forms.Button();
			this.UI_teamDataGrid = new System.Windows.Forms.DataGridView();
			this.tabPageHours = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.UI_TaskCount = new System.Windows.Forms.Label();
			this.UI_RiskCount = new System.Windows.Forms.Label();
			this.UI_ReqCount = new System.Windows.Forms.Label();
			this.UI_MemberCount = new System.Windows.Forms.Label();
			this.addProjectHours = new System.Windows.Forms.Button();
			this.tabControlHours = new System.Windows.Forms.TabControl();
			this.tabTask = new System.Windows.Forms.TabPage();
			this.UI_TasksTabTasks = new System.Windows.Forms.DataGridView();
			this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taskHrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taskDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taskOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.taskCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UI_TasksTabReqs = new System.Windows.Forms.DataGridView();
			this.req = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.buttonAddHours = new System.Windows.Forms.Button();
			this.buttonDeleteTask = new System.Windows.Forms.Button();
			this.buttonCreateTask = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label4 = new System.Windows.Forms.Label();
			this.projectOverview.SuspendLayout();
			this.tabPageRisk.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UI_RiskDataGrid)).BeginInit();
			this.tabPageRequirements.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridRequirements)).BeginInit();
			this.tabPageMembers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UI_teamDataGrid)).BeginInit();
			this.tabPageHours.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControlHours.SuspendLayout();
			this.tabTask.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UI_TasksTabTasks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UI_TasksTabReqs)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(7, 22);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(114, 17);
			label1.TabIndex = 0;
			label1.Text = "Team Members: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(7, 43);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(104, 17);
			label2.TabIndex = 1;
			label2.Text = "Requirements: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(7, 65);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(50, 17);
			label3.TabIndex = 2;
			label3.Text = "Risks: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(7, 89);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(54, 17);
			label4.TabIndex = 3;
			label4.Text = "Tasks: ";
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
			this.UI_projectDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.UI_projectDescription.Name = "UI_projectDescription";
			this.UI_projectDescription.Size = new System.Drawing.Size(249, 170);
			this.UI_projectDescription.TabIndex = 4;
			this.UI_projectDescription.Text = "";
			// 
			// UI_projectOwner
			// 
			this.UI_projectOwner.AutoSize = true;
			this.UI_projectOwner.Location = new System.Drawing.Point(13, 123);
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
			this.UI_editButton.Location = new System.Drawing.Point(73, 377);
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
			this.tabPageRisk.Controls.Add(this.UI_RiskDataGrid);
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
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// UI_RiskDataGrid
			// 
			this.UI_RiskDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UI_RiskDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rDescription,
            this.rPriority,
            this.rLikelyhood});
			this.UI_RiskDataGrid.Location = new System.Drawing.Point(3, 0);
			this.UI_RiskDataGrid.Margin = new System.Windows.Forms.Padding(4);
			this.UI_RiskDataGrid.Name = "UI_RiskDataGrid";
			this.UI_RiskDataGrid.Size = new System.Drawing.Size(865, 474);
			this.UI_RiskDataGrid.TabIndex = 0;
			this.UI_RiskDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
			// 
			// rDescription
			// 
			this.rDescription.HeaderText = "Risk Description";
			this.rDescription.MinimumWidth = 250;
			this.rDescription.Name = "rDescription";
			this.rDescription.ReadOnly = true;
			this.rDescription.Width = 300;
			// 
			// rPriority
			// 
			this.rPriority.HeaderText = "Risk Priority";
			this.rPriority.Name = "rPriority";
			this.rPriority.ReadOnly = true;
			// 
			// rLikelyhood
			// 
			this.rLikelyhood.HeaderText = "Risk Likelyhood";
			this.rLikelyhood.Name = "rLikelyhood";
			this.rLikelyhood.ReadOnly = true;
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
			this.button1.Size = new System.Drawing.Size(109, 28);
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
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// buttonNewRequirement
			// 
			this.buttonNewRequirement.Location = new System.Drawing.Point(789, 482);
			this.buttonNewRequirement.Margin = new System.Windows.Forms.Padding(4);
			this.buttonNewRequirement.Name = "buttonNewRequirement";
			this.buttonNewRequirement.Size = new System.Drawing.Size(77, 28);
			this.buttonNewRequirement.TabIndex = 1;
			this.buttonNewRequirement.Text = "New";
			this.buttonNewRequirement.UseVisualStyleBackColor = true;
			this.buttonNewRequirement.Click += new System.EventHandler(this.buttonNewRequirement_Click);
			// 
			// dataGridRequirements
			// 
			this.dataGridRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridRequirements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequirementName,
            this.RequirementType,
            this.RequirmentPriority});
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
			// RequirementType
			// 
			this.RequirementType.HeaderText = "Type";
			this.RequirementType.Name = "RequirementType";
			// 
			// RequirmentPriority
			// 
			this.RequirmentPriority.HeaderText = "Priority";
			this.RequirmentPriority.Name = "RequirmentPriority";
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
			this.tabPageHours.Controls.Add(this.groupBox2);
			this.tabPageHours.Controls.Add(this.groupBox1);
			this.tabPageHours.Controls.Add(this.addProjectHours);
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(235, 7);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox2.Size = new System.Drawing.Size(209, 180);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Porject Hours";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(139, 139);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(16, 17);
			this.label16.TabIndex = 11;
			this.label16.Text = "0";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(139, 117);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(16, 17);
			this.label15.TabIndex = 10;
			this.label15.Text = "0";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(139, 96);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(16, 17);
			this.label14.TabIndex = 9;
			this.label14.Text = "0";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(139, 75);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(16, 17);
			this.label13.TabIndex = 8;
			this.label13.Text = "0";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(139, 22);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(16, 17);
			this.label12.TabIndex = 7;
			this.label12.Text = "0";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(139, 54);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(16, 17);
			this.label11.TabIndex = 6;
			this.label11.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 139);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(28, 17);
			this.label10.TabIndex = 5;
			this.label10.Text = "PM";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 117);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(55, 17);
			this.label9.TabIndex = 4;
			this.label9.Text = "Testing";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(7, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 17);
			this.label8.TabIndex = 3;
			this.label8.Text = "Coding";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 75);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 17);
			this.label7.TabIndex = 2;
			this.label7.Text = "Design";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 54);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 17);
			this.label6.TabIndex = 1;
			this.label6.Text = "Req. Analysis";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Total Hours";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.UI_TaskCount);
			this.groupBox1.Controls.Add(this.UI_RiskCount);
			this.groupBox1.Controls.Add(this.UI_ReqCount);
			this.groupBox1.Controls.Add(this.UI_MemberCount);
			this.groupBox1.Controls.Add(label4);
			this.groupBox1.Controls.Add(label3);
			this.groupBox1.Controls.Add(label2);
			this.groupBox1.Controls.Add(label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 7);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(211, 122);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General Properties";
			// 
			// UI_TaskCount
			// 
			this.UI_TaskCount.AutoSize = true;
			this.UI_TaskCount.Location = new System.Drawing.Point(136, 84);
			this.UI_TaskCount.Name = "UI_TaskCount";
			this.UI_TaskCount.Size = new System.Drawing.Size(16, 17);
			this.UI_TaskCount.TabIndex = 7;
			this.UI_TaskCount.Text = "0";
			// 
			// UI_RiskCount
			// 
			this.UI_RiskCount.AutoSize = true;
			this.UI_RiskCount.Location = new System.Drawing.Point(136, 63);
			this.UI_RiskCount.Name = "UI_RiskCount";
			this.UI_RiskCount.Size = new System.Drawing.Size(16, 17);
			this.UI_RiskCount.TabIndex = 6;
			this.UI_RiskCount.Text = "0";
			// 
			// UI_ReqCount
			// 
			this.UI_ReqCount.AutoSize = true;
			this.UI_ReqCount.Location = new System.Drawing.Point(136, 43);
			this.UI_ReqCount.Name = "UI_ReqCount";
			this.UI_ReqCount.Size = new System.Drawing.Size(16, 17);
			this.UI_ReqCount.TabIndex = 5;
			this.UI_ReqCount.Text = "0";
			// 
			// UI_MemberCount
			// 
			this.UI_MemberCount.AutoSize = true;
			this.UI_MemberCount.Location = new System.Drawing.Point(136, 22);
			this.UI_MemberCount.Name = "UI_MemberCount";
			this.UI_MemberCount.Size = new System.Drawing.Size(16, 17);
			this.UI_MemberCount.TabIndex = 4;
			this.UI_MemberCount.Text = "0";
			// 
			// addProjectHours
			// 
			this.addProjectHours.Location = new System.Drawing.Point(753, 476);
			this.addProjectHours.Margin = new System.Windows.Forms.Padding(1);
			this.addProjectHours.Name = "addProjectHours";
			this.addProjectHours.Size = new System.Drawing.Size(107, 30);
			this.addProjectHours.TabIndex = 1;
			this.addProjectHours.Text = "Add Hours";
			this.addProjectHours.UseVisualStyleBackColor = true;
			// 
			// tabControlHours
			// 
			this.tabControlHours.Controls.Add(this.tabPageHours);
			this.tabControlHours.Controls.Add(this.tabPageMembers);
			this.tabControlHours.Controls.Add(this.tabPageRequirements);
			this.tabControlHours.Controls.Add(this.tabPageRisk);
			this.tabControlHours.Controls.Add(this.tabTask);
			this.tabControlHours.Location = new System.Drawing.Point(316, 16);
			this.tabControlHours.Margin = new System.Windows.Forms.Padding(4);
			this.tabControlHours.Name = "tabControlHours";
			this.tabControlHours.SelectedIndex = 0;
			this.tabControlHours.Size = new System.Drawing.Size(879, 543);
			this.tabControlHours.TabIndex = 1;
			// 
			// tabTask
			// 
			this.tabTask.Controls.Add(this.UI_TasksTabTasks);
			this.tabTask.Controls.Add(this.UI_TasksTabReqs);
			this.tabTask.Controls.Add(this.label18);
			this.tabTask.Controls.Add(this.label17);
			this.tabTask.Controls.Add(this.buttonAddHours);
			this.tabTask.Controls.Add(this.buttonDeleteTask);
			this.tabTask.Controls.Add(this.buttonCreateTask);
			this.tabTask.Location = new System.Drawing.Point(4, 25);
			this.tabTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabTask.Name = "tabTask";
			this.tabTask.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tabTask.Size = new System.Drawing.Size(871, 514);
			this.tabTask.TabIndex = 5;
			this.tabTask.Text = "Task";
			this.tabTask.UseVisualStyleBackColor = true;
			// 
			// UI_TasksTabTasks
			// 
			this.UI_TasksTabTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UI_TasksTabTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskName,
            this.taskHrs,
            this.taskDesc,
            this.taskOwner,
            this.taskCat});
			this.UI_TasksTabTasks.Location = new System.Drawing.Point(296, 24);
			this.UI_TasksTabTasks.Name = "UI_TasksTabTasks";
			this.UI_TasksTabTasks.RowTemplate.Height = 24;
			this.UI_TasksTabTasks.Size = new System.Drawing.Size(569, 453);
			this.UI_TasksTabTasks.TabIndex = 7;
			// 
			// taskName
			// 
			this.taskName.HeaderText = "Task Name";
			this.taskName.Name = "taskName";
			this.taskName.ReadOnly = true;
			// 
			// taskHrs
			// 
			this.taskHrs.HeaderText = "Hours";
			this.taskHrs.Name = "taskHrs";
			this.taskHrs.ReadOnly = true;
			// 
			// taskDesc
			// 
			this.taskDesc.HeaderText = "Task Description";
			this.taskDesc.Name = "taskDesc";
			this.taskDesc.ReadOnly = true;
			// 
			// taskOwner
			// 
			this.taskOwner.HeaderText = "Task Owner";
			this.taskOwner.Name = "taskOwner";
			this.taskOwner.ReadOnly = true;
			// 
			// taskCat
			// 
			this.taskCat.HeaderText = "Task Category";
			this.taskCat.Name = "taskCat";
			this.taskCat.ReadOnly = true;
			// 
			// UI_TasksTabReqs
			// 
			this.UI_TasksTabReqs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UI_TasksTabReqs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.req});
			this.UI_TasksTabReqs.Location = new System.Drawing.Point(7, 25);
			this.UI_TasksTabReqs.Name = "UI_TasksTabReqs";
			this.UI_TasksTabReqs.RowTemplate.Height = 24;
			this.UI_TasksTabReqs.Size = new System.Drawing.Size(283, 452);
			this.UI_TasksTabReqs.TabIndex = 6;
			this.UI_TasksTabReqs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UI_TasksTabReqs_CellContentClick);
			// 
			// req
			// 
			this.req.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.req.HeaderText = "Requirement";
			this.req.Name = "req";
			this.req.ReadOnly = true;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(293, 4);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(211, 17);
			this.label18.TabIndex = 5;
			this.label18.Text = "Tasks for Selected Requirement";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(4, 4);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(89, 17);
			this.label17.TabIndex = 4;
			this.label17.Text = "Requirement";
			// 
			// buttonAddHours
			// 
			this.buttonAddHours.Location = new System.Drawing.Point(679, 482);
			this.buttonAddHours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonAddHours.Name = "buttonAddHours";
			this.buttonAddHours.Size = new System.Drawing.Size(89, 27);
			this.buttonAddHours.TabIndex = 3;
			this.buttonAddHours.Text = "Add Hours";
			this.buttonAddHours.UseVisualStyleBackColor = true;
			this.buttonAddHours.Click += new System.EventHandler(this.buttonAddHours_Click);
			// 
			// buttonDeleteTask
			// 
			this.buttonDeleteTask.Location = new System.Drawing.Point(568, 481);
			this.buttonDeleteTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonDeleteTask.Name = "buttonDeleteTask";
			this.buttonDeleteTask.Size = new System.Drawing.Size(105, 28);
			this.buttonDeleteTask.TabIndex = 2;
			this.buttonDeleteTask.Text = "Delete Task";
			this.buttonDeleteTask.UseVisualStyleBackColor = true;
			this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
			// 
			// buttonCreateTask
			// 
			this.buttonCreateTask.Location = new System.Drawing.Point(774, 482);
			this.buttonCreateTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonCreateTask.Name = "buttonCreateTask";
			this.buttonCreateTask.Size = new System.Drawing.Size(91, 28);
			this.buttonCreateTask.TabIndex = 1;
			this.buttonCreateTask.Text = "New Task";
			this.buttonCreateTask.UseVisualStyleBackColor = true;
			this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1220, 571);
			this.Controls.Add(this.tabControlHours);
			this.Controls.Add(this.projectOverview);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form2";
			this.Text = "Project Manager 2016";
			this.projectOverview.ResumeLayout(false);
			this.projectOverview.PerformLayout();
			this.tabPageRisk.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UI_RiskDataGrid)).EndInit();
			this.tabPageRequirements.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridRequirements)).EndInit();
			this.tabPageMembers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UI_teamDataGrid)).EndInit();
			this.tabPageHours.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControlHours.ResumeLayout(false);
			this.tabTask.ResumeLayout(false);
			this.tabTask.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.UI_TasksTabTasks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UI_TasksTabReqs)).EndInit();
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
		private System.Windows.Forms.DataGridView UI_RiskDataGrid;
		private System.Windows.Forms.TabPage tabPageRequirements;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button deleteBtn;
		private System.Windows.Forms.Button buttonNewRequirement;
		private System.Windows.Forms.DataGridView dataGridRequirements;
		private System.Windows.Forms.TabPage tabPageMembers;
		private System.Windows.Forms.Button UI_AddMemberBtn;
		private System.Windows.Forms.DataGridView UI_teamDataGrid;
		private System.Windows.Forms.TabPage tabPageHours;
		private System.Windows.Forms.Button addProjectHours;
		private System.Windows.Forms.TabControl tabControlHours;
		private System.Windows.Forms.RichTextBox UI_projectDescription;
		private System.Windows.Forms.Label UI_projectOwner;
		private System.Windows.Forms.Label UI_projectLabel;
		private System.Windows.Forms.Button UI_deleteTeamMemberButton;
        private System.Windows.Forms.TabPage tabTask;
        private System.Windows.Forms.Button buttonDeleteTask;
        private System.Windows.Forms.Button buttonCreateTask;
        private System.Windows.Forms.Button buttonAddHours;
		private System.Windows.Forms.DataGridViewTextBoxColumn rDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn rPriority;
		private System.Windows.Forms.DataGridViewTextBoxColumn rLikelyhood;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label UI_TaskCount;
		private System.Windows.Forms.Label UI_RiskCount;
		private System.Windows.Forms.Label UI_ReqCount;
		private System.Windows.Forms.Label UI_MemberCount;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirmentPriority;
		private System.Windows.Forms.DataGridView UI_TasksTabTasks;
		private System.Windows.Forms.DataGridView UI_TasksTabReqs;
		private System.Windows.Forms.DataGridViewTextBoxColumn req;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
		private System.Windows.Forms.DataGridViewTextBoxColumn taskHrs;
		private System.Windows.Forms.DataGridViewTextBoxColumn taskDesc;
		private System.Windows.Forms.DataGridViewTextBoxColumn taskOwner;
		private System.Windows.Forms.DataGridViewTextBoxColumn taskCat;
	}
}