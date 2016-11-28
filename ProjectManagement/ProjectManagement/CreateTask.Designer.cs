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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddUserTask = new System.Windows.Forms.Button();
            this.buttonAddReqTask = new System.Windows.Forms.Button();
            this.buttonSaveTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 82);
            this.textBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Requirements Analysis",
            "Designing",
            "Coding",
            "Testing",
            "Project Management"});
            this.comboBox1.Location = new System.Drawing.Point(75, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // buttonAddUserTask
            // 
            this.buttonAddUserTask.Location = new System.Drawing.Point(41, 202);
            this.buttonAddUserTask.Name = "buttonAddUserTask";
            this.buttonAddUserTask.Size = new System.Drawing.Size(86, 23);
            this.buttonAddUserTask.TabIndex = 6;
            this.buttonAddUserTask.Text = "Add User";
            this.buttonAddUserTask.UseVisualStyleBackColor = true;
            this.buttonAddUserTask.Click += new System.EventHandler(this.buttonAddUserTask_Click);
            // 
            // buttonAddReqTask
            // 
            this.buttonAddReqTask.Location = new System.Drawing.Point(143, 202);
            this.buttonAddReqTask.Name = "buttonAddReqTask";
            this.buttonAddReqTask.Size = new System.Drawing.Size(101, 23);
            this.buttonAddReqTask.TabIndex = 7;
            this.buttonAddReqTask.Text = "Add Requirement";
            this.buttonAddReqTask.UseVisualStyleBackColor = true;
            // 
            // buttonSaveTask
            // 
            this.buttonSaveTask.Location = new System.Drawing.Point(94, 237);
            this.buttonSaveTask.Name = "buttonSaveTask";
            this.buttonSaveTask.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveTask.TabIndex = 8;
            this.buttonSaveTask.Text = "Save";
            this.buttonSaveTask.UseVisualStyleBackColor = true;
            this.buttonSaveTask.Click += new System.EventHandler(this.buttonSaveTask_Click);
            // 
            // CreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 272);
            this.Controls.Add(this.buttonSaveTask);
            this.Controls.Add(this.buttonAddReqTask);
            this.Controls.Add(this.buttonAddUserTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateTask";
            this.Text = "CreateTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddUserTask;
        private System.Windows.Forms.Button buttonAddReqTask;
        private System.Windows.Forms.Button buttonSaveTask;
    }
}