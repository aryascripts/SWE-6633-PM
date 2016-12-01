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
			this.UI_HrsNonFunctional = new System.Windows.Forms.Label();
			this.UI_HrsFunctional = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.UI_HrsPM = new System.Windows.Forms.Label();
			this.UI_HrsTesting = new System.Windows.Forms.Label();
			this.UI_HrsCoding = new System.Windows.Forms.Label();
			this.UI_HrsDesign = new System.Windows.Forms.Label();
			this.UI_HrsTotal = new System.Windows.Forms.Label();
			this.UI_HrsReqAnalysis = new System.Windows.Forms.Label();
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
			this.UI_NewProjectBtn = new System.Windows.Forms.Button();
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
			label1.Location = new System.Drawing.Point(5, 18);
			label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(86, 13);
			label1.TabIndex = 0;
			label1.Text = "Team Members: ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(5, 35);
			label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(78, 13);
			label2.TabIndex = 1;
			label2.Text = "Requirements: ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(5, 53);
			label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(39, 13);
			label3.TabIndex = 2;
			label3.Text = "Risks: ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(5, 72);
			label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(42, 13);
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
			this.projectOverview.Location = new System.Drawing.Point(31, 8);
			this.projectOverview.Name = "projectOverview";
			this.projectOverview.Size = new System.Drawing.Size(200, 339);
			this.projectOverview.TabIndex = 0;
			this.projectOverview.TabStop = false;
			this.projectOverview.Text = "Project Overvew";
			// 
			// UI_projectDescription
			// 
			this.UI_projectDescription.Location = new System.Drawing.Point(8, 162);
			this.UI_projectDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.UI_projectDescription.Name = "UI_projectDescription";
			this.UI_projectDescription.Size = new System.Drawing.Size(188, 139);
			this.UI_projectDescription.TabIndex = 4;
			this.UI_projectDescription.Text = "";
			// 
			// UI_projectOwner
			// 
			this.UI_projectOwner.AutoSize = true;
			this.UI_projectOwner.Location = new System.Drawing.Point(10, 100);
			this.UI_projectOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_projectOwner.Name = "UI_projectOwner";
			this.UI_projectOwner.Size = new System.Drawing.Size(35, 13);
			this.UI_projectOwner.TabIndex = 3;
			this.UI_projectOwner.Text = "label2";
			// 
			// UI_projectLabel
			// 
			this.UI_projectLabel.AutoSize = true;
			this.UI_projectLabel.Location = new System.Drawing.Point(8, 42);
			this.UI_projectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_projectLabel.Name = "UI_projectLabel";
			this.UI_projectLabel.Size = new System.Drawing.Size(35, 13);
			this.UI_projectLabel.TabIndex = 2;
			this.UI_projectLabel.Text = "label2";
			// 
			// UI_editButton
			// 
			this.UI_editButton.Location = new System.Drawing.Point(55, 306);
			this.UI_editButton.Name = "UI_editButton";
			this.UI_editButton.Size = new System.Drawing.Size(75, 23);
			this.UI_editButton.TabIndex = 1;
			this.UI_editButton.Text = "Edit";
			this.UI_editButton.UseVisualStyleBackColor = true;
			this.UI_editButton.Click += new System.EventHandler(this.UI_editButton_Click);
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(6, 145);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(96, 13);
			this.labelDescription.TabIndex = 1;
			this.labelDescription.Text = "Project Description";
			// 
			// labelprojectOwner
			// 
			this.labelprojectOwner.AutoSize = true;
			this.labelprojectOwner.Location = new System.Drawing.Point(6, 83);
			this.labelprojectOwner.Name = "labelprojectOwner";
			this.labelprojectOwner.Size = new System.Drawing.Size(74, 13);
			this.labelprojectOwner.TabIndex = 1;
			this.labelprojectOwner.Text = "Project Owner";
			// 
			// labelprojectName
			// 
			this.labelprojectName.AutoSize = true;
			this.labelprojectName.Location = new System.Drawing.Point(6, 25);
			this.labelprojectName.Name = "labelprojectName";
			this.labelprojectName.Size = new System.Drawing.Size(71, 13);
			this.labelprojectName.TabIndex = 1;
			this.labelprojectName.Text = "Project Name";
			// 
			// tabPageRisk
			// 
			this.tabPageRisk.Controls.Add(this.button4);
			this.tabPageRisk.Controls.Add(this.button2);
			this.tabPageRisk.Controls.Add(this.UI_RiskDataGrid);
			this.tabPageRisk.Location = new System.Drawing.Point(4, 22);
			this.tabPageRisk.Name = "tabPageRisk";
			this.tabPageRisk.Size = new System.Drawing.Size(806, 415);
			this.tabPageRisk.TabIndex = 4;
			this.tabPageRisk.Text = "Risk";
			this.tabPageRisk.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(627, 389);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(51, 23);
			this.button4.TabIndex = 2;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(684, 389);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 23);
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
			this.UI_RiskDataGrid.Location = new System.Drawing.Point(2, 0);
			this.UI_RiskDataGrid.Name = "UI_RiskDataGrid";
			this.UI_RiskDataGrid.Size = new System.Drawing.Size(801, 385);
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
			this.tabPageRequirements.Location = new System.Drawing.Point(4, 22);
			this.tabPageRequirements.Name = "tabPageRequirements";
			this.tabPageRequirements.Size = new System.Drawing.Size(806, 415);
			this.tabPageRequirements.TabIndex = 2;
			this.tabPageRequirements.Text = "Requirements";
			this.tabPageRequirements.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(621, 389);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "View Tasks";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// deleteBtn
			// 
			this.deleteBtn.Location = new System.Drawing.Point(566, 389);
			this.deleteBtn.Name = "deleteBtn";
			this.deleteBtn.Size = new System.Drawing.Size(49, 23);
			this.deleteBtn.TabIndex = 2;
			this.deleteBtn.Text = "Delete";
			this.deleteBtn.UseVisualStyleBackColor = true;
			this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
			// 
			// buttonNewRequirement
			// 
			this.buttonNewRequirement.Location = new System.Drawing.Point(720, 389);
			this.buttonNewRequirement.Name = "buttonNewRequirement";
			this.buttonNewRequirement.Size = new System.Drawing.Size(83, 23);
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
			this.dataGridRequirements.Location = new System.Drawing.Point(3, 3);
			this.dataGridRequirements.Name = "dataGridRequirements";
			this.dataGridRequirements.Size = new System.Drawing.Size(800, 384);
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
			this.tabPageMembers.Location = new System.Drawing.Point(4, 22);
			this.tabPageMembers.Name = "tabPageMembers";
			this.tabPageMembers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageMembers.Size = new System.Drawing.Size(806, 415);
			this.tabPageMembers.TabIndex = 1;
			this.tabPageMembers.Text = "Team Members";
			this.tabPageMembers.UseVisualStyleBackColor = true;
			// 
			// UI_deleteTeamMemberButton
			// 
			this.UI_deleteTeamMemberButton.Location = new System.Drawing.Point(606, 389);
			this.UI_deleteTeamMemberButton.Name = "UI_deleteTeamMemberButton";
			this.UI_deleteTeamMemberButton.Size = new System.Drawing.Size(94, 23);
			this.UI_deleteTeamMemberButton.TabIndex = 2;
			this.UI_deleteTeamMemberButton.Text = "Delete Selected";
			this.UI_deleteTeamMemberButton.UseVisualStyleBackColor = true;
			this.UI_deleteTeamMemberButton.Click += new System.EventHandler(this.UI_deleteTeamMemberButton_Click);
			// 
			// UI_AddMemberBtn
			// 
			this.UI_AddMemberBtn.Location = new System.Drawing.Point(706, 389);
			this.UI_AddMemberBtn.Name = "UI_AddMemberBtn";
			this.UI_AddMemberBtn.Size = new System.Drawing.Size(94, 23);
			this.UI_AddMemberBtn.TabIndex = 1;
			this.UI_AddMemberBtn.Text = "Create New";
			this.UI_AddMemberBtn.UseVisualStyleBackColor = true;
			this.UI_AddMemberBtn.Click += new System.EventHandler(this.buttonCreateUser_Click);
			// 
			// UI_teamDataGrid
			// 
			this.UI_teamDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UI_teamDataGrid.Location = new System.Drawing.Point(3, 3);
			this.UI_teamDataGrid.Name = "UI_teamDataGrid";
			this.UI_teamDataGrid.Size = new System.Drawing.Size(797, 383);
			this.UI_teamDataGrid.TabIndex = 0;
			// 
			// tabPageHours
			// 
			this.tabPageHours.Controls.Add(this.groupBox2);
			this.tabPageHours.Controls.Add(this.groupBox1);
			this.tabPageHours.Location = new System.Drawing.Point(4, 22);
			this.tabPageHours.Name = "tabPageHours";
			this.tabPageHours.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageHours.Size = new System.Drawing.Size(806, 415);
			this.tabPageHours.TabIndex = 0;
			this.tabPageHours.Text = "Project Hours";
			this.tabPageHours.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.UI_HrsNonFunctional);
			this.groupBox2.Controls.Add(this.UI_HrsFunctional);
			this.groupBox2.Controls.Add(this.label20);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.UI_HrsPM);
			this.groupBox2.Controls.Add(this.UI_HrsTesting);
			this.groupBox2.Controls.Add(this.UI_HrsCoding);
			this.groupBox2.Controls.Add(this.UI_HrsDesign);
			this.groupBox2.Controls.Add(this.UI_HrsTotal);
			this.groupBox2.Controls.Add(this.UI_HrsReqAnalysis);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Location = new System.Drawing.Point(176, 6);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.groupBox2.Size = new System.Drawing.Size(293, 146);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Porject Hours";
			// 
			// UI_HrsNonFunctional
			// 
			this.UI_HrsNonFunctional.AutoSize = true;
			this.UI_HrsNonFunctional.Location = new System.Drawing.Point(255, 61);
			this.UI_HrsNonFunctional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_HrsNonFunctional.Name = "UI_HrsNonFunctional";
			this.UI_HrsNonFunctional.Size = new System.Drawing.Size(13, 13);
			this.UI_HrsNonFunctional.TabIndex = 15;
			this.UI_HrsNonFunctional.Text = "0";
			// 
			// UI_HrsFunctional
			// 
			this.UI_HrsFunctional.AutoSize = true;
			this.UI_HrsFunctional.Location = new System.Drawing.Point(255, 43);
			this.UI_HrsFunctional.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_HrsFunctional.Name = "UI_HrsFunctional";
			this.UI_HrsFunctional.Size = new System.Drawing.Size(13, 13);
			this.UI_HrsFunctional.TabIndex = 14;
			this.UI_HrsFunctional.Text = "0";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(151, 61);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(82, 13);
			this.label20.TabIndex = 13;
			this.label20.Text = "Non-Functional:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(151, 43);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(62, 13);
			this.label19.TabIndex = 12;
			this.label19.Text = "Functional: ";
			// 
			// UI_HrsPM
			// 
			this.UI_HrsPM.AutoSize = true;
			this.UI_HrsPM.Location = new System.Drawing.Point(104, 113);
			this.UI_HrsPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_HrsPM.Name = "UI_HrsPM";
			this.UI_HrsPM.Size = new System.Drawing.Size(13, 13);
			this.UI_HrsPM.TabIndex = 11;
			this.UI_HrsPM.Text = "0";
			// 
			// UI_HrsTesting
			// 
			this.UI_HrsTesting.AutoSize = true;
			this.UI_HrsTesting.Location = new System.Drawing.Point(104, 95);
			this.UI_HrsTesting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_HrsTesting.Name = "UI_HrsTesting";
			this.UI_HrsTesting.Size = new System.Drawing.Size(13, 13);
			this.UI_HrsTesting.TabIndex = 10;
			this.UI_HrsTesting.Text = "0";
			// 
			// UI_HrsCoding
			// 
			this.UI_HrsCoding.AutoSize = true;
			this.UI_HrsCoding.Location = new System.Drawing.Point(104, 78);
			this.UI_HrsCoding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_HrsCoding.Name = "UI_HrsCoding";
			this.UI_HrsCoding.Size = new System.Drawing.Size(13, 13);
			this.UI_HrsCoding.TabIndex = 9;
			this.UI_HrsCoding.Text = "0";
			// 
			// UI_HrsDesign
			// 
			this.UI_HrsDesign.AutoSize = true;
			this.UI_HrsDesign.Location = new System.Drawing.Point(104, 61);
			this.UI_HrsDesign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_HrsDesign.Name = "UI_HrsDesign";
			this.UI_HrsDesign.Size = new System.Drawing.Size(13, 13);
			this.UI_HrsDesign.TabIndex = 8;
			this.UI_HrsDesign.Text = "0";
			// 
			// UI_HrsTotal
			// 
			this.UI_HrsTotal.AutoSize = true;
			this.UI_HrsTotal.Location = new System.Drawing.Point(104, 18);
			this.UI_HrsTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_HrsTotal.Name = "UI_HrsTotal";
			this.UI_HrsTotal.Size = new System.Drawing.Size(13, 13);
			this.UI_HrsTotal.TabIndex = 7;
			this.UI_HrsTotal.Text = "0";
			// 
			// UI_HrsReqAnalysis
			// 
			this.UI_HrsReqAnalysis.AutoSize = true;
			this.UI_HrsReqAnalysis.Location = new System.Drawing.Point(104, 44);
			this.UI_HrsReqAnalysis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_HrsReqAnalysis.Name = "UI_HrsReqAnalysis";
			this.UI_HrsReqAnalysis.Size = new System.Drawing.Size(13, 13);
			this.UI_HrsReqAnalysis.TabIndex = 6;
			this.UI_HrsReqAnalysis.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(5, 113);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(23, 13);
			this.label10.TabIndex = 5;
			this.label10.Text = "PM";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(5, 95);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 13);
			this.label9.TabIndex = 4;
			this.label9.Text = "Testing";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(5, 78);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 13);
			this.label8.TabIndex = 3;
			this.label8.Text = "Coding";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(5, 61);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Design";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 44);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Req. Analysis";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 18);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
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
			this.groupBox1.Location = new System.Drawing.Point(6, 6);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.groupBox1.Size = new System.Drawing.Size(158, 99);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "General Properties";
			// 
			// UI_TaskCount
			// 
			this.UI_TaskCount.AutoSize = true;
			this.UI_TaskCount.Location = new System.Drawing.Point(102, 68);
			this.UI_TaskCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_TaskCount.Name = "UI_TaskCount";
			this.UI_TaskCount.Size = new System.Drawing.Size(13, 13);
			this.UI_TaskCount.TabIndex = 7;
			this.UI_TaskCount.Text = "0";
			// 
			// UI_RiskCount
			// 
			this.UI_RiskCount.AutoSize = true;
			this.UI_RiskCount.Location = new System.Drawing.Point(102, 51);
			this.UI_RiskCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_RiskCount.Name = "UI_RiskCount";
			this.UI_RiskCount.Size = new System.Drawing.Size(13, 13);
			this.UI_RiskCount.TabIndex = 6;
			this.UI_RiskCount.Text = "0";
			// 
			// UI_ReqCount
			// 
			this.UI_ReqCount.AutoSize = true;
			this.UI_ReqCount.Location = new System.Drawing.Point(102, 35);
			this.UI_ReqCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_ReqCount.Name = "UI_ReqCount";
			this.UI_ReqCount.Size = new System.Drawing.Size(13, 13);
			this.UI_ReqCount.TabIndex = 5;
			this.UI_ReqCount.Text = "0";
			// 
			// UI_MemberCount
			// 
			this.UI_MemberCount.AutoSize = true;
			this.UI_MemberCount.Location = new System.Drawing.Point(102, 18);
			this.UI_MemberCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.UI_MemberCount.Name = "UI_MemberCount";
			this.UI_MemberCount.Size = new System.Drawing.Size(13, 13);
			this.UI_MemberCount.TabIndex = 4;
			this.UI_MemberCount.Text = "0";
			// 
			// tabControlHours
			// 
			this.tabControlHours.Controls.Add(this.tabPageHours);
			this.tabControlHours.Controls.Add(this.tabPageMembers);
			this.tabControlHours.Controls.Add(this.tabPageRequirements);
			this.tabControlHours.Controls.Add(this.tabPageRisk);
			this.tabControlHours.Controls.Add(this.tabTask);
			this.tabControlHours.Location = new System.Drawing.Point(237, 13);
			this.tabControlHours.Name = "tabControlHours";
			this.tabControlHours.SelectedIndex = 0;
			this.tabControlHours.Size = new System.Drawing.Size(814, 441);
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
			this.tabTask.Location = new System.Drawing.Point(4, 22);
			this.tabTask.Margin = new System.Windows.Forms.Padding(2);
			this.tabTask.Name = "tabTask";
			this.tabTask.Padding = new System.Windows.Forms.Padding(2);
			this.tabTask.Size = new System.Drawing.Size(806, 415);
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
			this.UI_TasksTabTasks.Location = new System.Drawing.Point(222, 20);
			this.UI_TasksTabTasks.Margin = new System.Windows.Forms.Padding(2);
			this.UI_TasksTabTasks.Name = "UI_TasksTabTasks";
			this.UI_TasksTabTasks.RowTemplate.Height = 24;
			this.UI_TasksTabTasks.Size = new System.Drawing.Size(580, 368);
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
			this.UI_TasksTabReqs.Location = new System.Drawing.Point(5, 20);
			this.UI_TasksTabReqs.Margin = new System.Windows.Forms.Padding(2);
			this.UI_TasksTabReqs.Name = "UI_TasksTabReqs";
			this.UI_TasksTabReqs.RowTemplate.Height = 24;
			this.UI_TasksTabReqs.Size = new System.Drawing.Size(212, 367);
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
			this.label18.Location = new System.Drawing.Point(220, 3);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(159, 13);
			this.label18.TabIndex = 5;
			this.label18.Text = "Tasks for Selected Requirement";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(3, 3);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(67, 13);
			this.label17.TabIndex = 4;
			this.label17.Text = "Requirement";
			// 
			// buttonAddHours
			// 
			this.buttonAddHours.Location = new System.Drawing.Point(598, 388);
			this.buttonAddHours.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAddHours.Name = "buttonAddHours";
			this.buttonAddHours.Size = new System.Drawing.Size(97, 22);
			this.buttonAddHours.TabIndex = 3;
			this.buttonAddHours.Text = "Add Hours";
			this.buttonAddHours.UseVisualStyleBackColor = true;
			this.buttonAddHours.Click += new System.EventHandler(this.buttonAddHours_Click);
			// 
			// buttonDeleteTask
			// 
			this.buttonDeleteTask.Location = new System.Drawing.Point(546, 388);
			this.buttonDeleteTask.Margin = new System.Windows.Forms.Padding(2);
			this.buttonDeleteTask.Name = "buttonDeleteTask";
			this.buttonDeleteTask.Size = new System.Drawing.Size(48, 22);
			this.buttonDeleteTask.TabIndex = 2;
			this.buttonDeleteTask.Text = "Delete";
			this.buttonDeleteTask.UseVisualStyleBackColor = true;
			this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
			// 
			// buttonCreateTask
			// 
			this.buttonCreateTask.Location = new System.Drawing.Point(699, 388);
			this.buttonCreateTask.Margin = new System.Windows.Forms.Padding(2);
			this.buttonCreateTask.Name = "buttonCreateTask";
			this.buttonCreateTask.Size = new System.Drawing.Size(103, 23);
			this.buttonCreateTask.TabIndex = 1;
			this.buttonCreateTask.Text = "New Task";
			this.buttonCreateTask.UseVisualStyleBackColor = true;
			this.buttonCreateTask.Click += new System.EventHandler(this.buttonCreateTask_Click);
			// 
			// UI_NewProjectBtn
			// 
			this.UI_NewProjectBtn.Location = new System.Drawing.Point(35, 427);
			this.UI_NewProjectBtn.Name = "UI_NewProjectBtn";
			this.UI_NewProjectBtn.Size = new System.Drawing.Size(196, 23);
			this.UI_NewProjectBtn.TabIndex = 2;
			this.UI_NewProjectBtn.Text = "Open New Project";
			this.UI_NewProjectBtn.UseVisualStyleBackColor = true;
			this.UI_NewProjectBtn.Click += new System.EventHandler(this.UI_NewProjectBtn_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1063, 464);
			this.Controls.Add(this.UI_NewProjectBtn);
			this.Controls.Add(this.tabControlHours);
			this.Controls.Add(this.projectOverview);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
		private System.Windows.Forms.Label UI_HrsPM;
		private System.Windows.Forms.Label UI_HrsTesting;
		private System.Windows.Forms.Label UI_HrsCoding;
		private System.Windows.Forms.Label UI_HrsDesign;
		private System.Windows.Forms.Label UI_HrsTotal;
		private System.Windows.Forms.Label UI_HrsReqAnalysis;
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
		private System.Windows.Forms.Label UI_HrsNonFunctional;
		private System.Windows.Forms.Label UI_HrsFunctional;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TabControl tabControlHours;
		private System.Windows.Forms.Button UI_NewProjectBtn;
	}
}