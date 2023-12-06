namespace COSC2100Assignment5BrodyDentinger
{
    partial class ReadHelpForm
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
            this.editStudentInfoButton = new System.Windows.Forms.Button();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighSchoolGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdmissionTestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampusLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.sinComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.loadRecordsButton = new System.Windows.Forms.Button();
            this.removeAllRecordsButton = new System.Windows.Forms.Button();
            this.updateRecordButton = new System.Windows.Forms.Button();
            this.deleteRecordButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.programsComboBox = new System.Windows.Forms.ComboBox();
            this.campusLocationComboBox = new System.Windows.Forms.ComboBox();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.studyPeriodTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.studentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.highSchoolGradeComboBox = new System.Windows.Forms.ComboBox();
            this.admissonScoreComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.sinTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRecordsToServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalSupportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDCRegistrationAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.studentInformationGroupBox.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editStudentInfoButton
            // 
            this.editStudentInfoButton.Enabled = false;
            this.editStudentInfoButton.Location = new System.Drawing.Point(385, 239);
            this.editStudentInfoButton.Name = "editStudentInfoButton";
            this.editStudentInfoButton.Size = new System.Drawing.Size(164, 23);
            this.editStudentInfoButton.TabIndex = 29;
            this.editStudentInfoButton.Text = "Edit Student Info";
            this.editStudentInfoButton.UseVisualStyleBackColor = true;
            // 
            // studentGridView
            // 
            this.studentGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.SIN,
            this.Email,
            this.HighSchoolGrade,
            this.AdmissionTestScore,
            this.CampusLocation,
            this.Program});
            this.studentGridView.Enabled = false;
            this.studentGridView.Location = new System.Drawing.Point(237, 408);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.RowHeadersWidth = 51;
            this.studentGridView.RowTemplate.Height = 24;
            this.studentGridView.Size = new System.Drawing.Size(1011, 164);
            this.studentGridView.TabIndex = 28;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 125;
            // 
            // SIN
            // 
            this.SIN.HeaderText = "SIN";
            this.SIN.MinimumWidth = 6;
            this.SIN.Name = "SIN";
            this.SIN.ReadOnly = true;
            this.SIN.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // HighSchoolGrade
            // 
            this.HighSchoolGrade.HeaderText = "High School Grade";
            this.HighSchoolGrade.MinimumWidth = 6;
            this.HighSchoolGrade.Name = "HighSchoolGrade";
            this.HighSchoolGrade.ReadOnly = true;
            this.HighSchoolGrade.Width = 125;
            // 
            // AdmissionTestScore
            // 
            this.AdmissionTestScore.HeaderText = "Admission Test Score";
            this.AdmissionTestScore.MinimumWidth = 6;
            this.AdmissionTestScore.Name = "AdmissionTestScore";
            this.AdmissionTestScore.ReadOnly = true;
            this.AdmissionTestScore.Width = 125;
            // 
            // CampusLocation
            // 
            this.CampusLocation.HeaderText = "Campus Location";
            this.CampusLocation.MinimumWidth = 6;
            this.CampusLocation.Name = "CampusLocation";
            this.CampusLocation.ReadOnly = true;
            this.CampusLocation.Width = 125;
            // 
            // Program
            // 
            this.Program.HeaderText = "Program";
            this.Program.MinimumWidth = 6;
            this.Program.Name = "Program";
            this.Program.ReadOnly = true;
            this.Program.Width = 125;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.Location = new System.Drawing.Point(22, 44);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 27;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sinComboBox
            // 
            this.sinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sinComboBox.Enabled = false;
            this.sinComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sinComboBox.FormattingEnabled = true;
            this.sinComboBox.Location = new System.Drawing.Point(289, 616);
            this.sinComboBox.Name = "sinComboBox";
            this.sinComboBox.Size = new System.Drawing.Size(260, 24);
            this.sinComboBox.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 619);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "SIN";
            // 
            // loadRecordsButton
            // 
            this.loadRecordsButton.Enabled = false;
            this.loadRecordsButton.Location = new System.Drawing.Point(785, 583);
            this.loadRecordsButton.Name = "loadRecordsButton";
            this.loadRecordsButton.Size = new System.Drawing.Size(193, 27);
            this.loadRecordsButton.TabIndex = 24;
            this.loadRecordsButton.Text = "Load Records to Server";
            this.loadRecordsButton.UseVisualStyleBackColor = true;
            // 
            // removeAllRecordsButton
            // 
            this.removeAllRecordsButton.Enabled = false;
            this.removeAllRecordsButton.Location = new System.Drawing.Point(575, 583);
            this.removeAllRecordsButton.Name = "removeAllRecordsButton";
            this.removeAllRecordsButton.Size = new System.Drawing.Size(180, 27);
            this.removeAllRecordsButton.TabIndex = 23;
            this.removeAllRecordsButton.Text = "Remove All Records";
            this.removeAllRecordsButton.UseVisualStyleBackColor = true;
            // 
            // updateRecordButton
            // 
            this.updateRecordButton.Enabled = false;
            this.updateRecordButton.Location = new System.Drawing.Point(412, 583);
            this.updateRecordButton.Name = "updateRecordButton";
            this.updateRecordButton.Size = new System.Drawing.Size(133, 27);
            this.updateRecordButton.TabIndex = 22;
            this.updateRecordButton.Text = "Update Record";
            this.updateRecordButton.UseVisualStyleBackColor = true;
            // 
            // deleteRecordButton
            // 
            this.deleteRecordButton.Enabled = false;
            this.deleteRecordButton.Location = new System.Drawing.Point(237, 583);
            this.deleteRecordButton.Name = "deleteRecordButton";
            this.deleteRecordButton.Size = new System.Drawing.Size(145, 27);
            this.deleteRecordButton.TabIndex = 21;
            this.deleteRecordButton.Text = "Delete Record";
            this.deleteRecordButton.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(237, 367);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(130, 27);
            this.registerButton.TabIndex = 20;
            this.registerButton.Text = "Register Student";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.programsComboBox);
            this.groupBox2.Controls.Add(this.campusLocationComboBox);
            this.groupBox2.Controls.Add(this.totalCostTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.studyPeriodTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(235, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1031, 73);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Programs";
            // 
            // programsComboBox
            // 
            this.programsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.programsComboBox.Enabled = false;
            this.programsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.programsComboBox.FormattingEnabled = true;
            this.programsComboBox.Location = new System.Drawing.Point(457, 27);
            this.programsComboBox.Name = "programsComboBox";
            this.programsComboBox.Size = new System.Drawing.Size(317, 24);
            this.programsComboBox.TabIndex = 7;
            // 
            // campusLocationComboBox
            // 
            this.campusLocationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campusLocationComboBox.Enabled = false;
            this.campusLocationComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.campusLocationComboBox.FormattingEnabled = true;
            this.campusLocationComboBox.Location = new System.Drawing.Point(125, 27);
            this.campusLocationComboBox.Name = "campusLocationComboBox";
            this.campusLocationComboBox.Size = new System.Drawing.Size(254, 24);
            this.campusLocationComboBox.TabIndex = 6;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Enabled = false;
            this.totalCostTextBox.Location = new System.Drawing.Point(913, 41);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.ReadOnly = true;
            this.totalCostTextBox.Size = new System.Drawing.Size(100, 22);
            this.totalCostTextBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(925, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Total Cost";
            // 
            // studyPeriodTextBox
            // 
            this.studyPeriodTextBox.Enabled = false;
            this.studyPeriodTextBox.Location = new System.Drawing.Point(789, 42);
            this.studyPeriodTextBox.Name = "studyPeriodTextBox";
            this.studyPeriodTextBox.ReadOnly = true;
            this.studyPeriodTextBox.Size = new System.Drawing.Size(100, 22);
            this.studyPeriodTextBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(796, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Study Period";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Programs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Campus Location";
            // 
            // checkButton
            // 
            this.checkButton.Enabled = false;
            this.checkButton.Location = new System.Drawing.Point(235, 239);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(93, 23);
            this.checkButton.TabIndex = 18;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // studentInformationGroupBox
            // 
            this.studentInformationGroupBox.Controls.Add(this.highSchoolGradeComboBox);
            this.studentInformationGroupBox.Controls.Add(this.admissonScoreComboBox);
            this.studentInformationGroupBox.Controls.Add(this.emailTextBox);
            this.studentInformationGroupBox.Controls.Add(this.sinTextBox);
            this.studentInformationGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentInformationGroupBox.Controls.Add(this.label6);
            this.studentInformationGroupBox.Controls.Add(this.label5);
            this.studentInformationGroupBox.Controls.Add(this.label4);
            this.studentInformationGroupBox.Controls.Add(this.label3);
            this.studentInformationGroupBox.Controls.Add(this.label2);
            this.studentInformationGroupBox.Controls.Add(this.label1);
            this.studentInformationGroupBox.Location = new System.Drawing.Point(232, 113);
            this.studentInformationGroupBox.Name = "studentInformationGroupBox";
            this.studentInformationGroupBox.Size = new System.Drawing.Size(1031, 109);
            this.studentInformationGroupBox.TabIndex = 17;
            this.studentInformationGroupBox.TabStop = false;
            this.studentInformationGroupBox.Text = "Student Information";
            // 
            // highSchoolGradeComboBox
            // 
            this.highSchoolGradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.highSchoolGradeComboBox.Enabled = false;
            this.highSchoolGradeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.highSchoolGradeComboBox.FormattingEnabled = true;
            this.highSchoolGradeComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.highSchoolGradeComboBox.Location = new System.Drawing.Point(895, 65);
            this.highSchoolGradeComboBox.Name = "highSchoolGradeComboBox";
            this.highSchoolGradeComboBox.Size = new System.Drawing.Size(121, 24);
            this.highSchoolGradeComboBox.TabIndex = 11;
            // 
            // admissonScoreComboBox
            // 
            this.admissonScoreComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.admissonScoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admissonScoreComboBox.Enabled = false;
            this.admissonScoreComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admissonScoreComboBox.FormattingEnabled = true;
            this.admissonScoreComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.admissonScoreComboBox.Location = new System.Drawing.Point(895, 31);
            this.admissonScoreComboBox.Name = "admissonScoreComboBox";
            this.admissonScoreComboBox.Size = new System.Drawing.Size(121, 24);
            this.admissonScoreComboBox.TabIndex = 10;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(414, 65);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(250, 22);
            this.emailTextBox.TabIndex = 9;
            // 
            // sinTextBox
            // 
            this.sinTextBox.Enabled = false;
            this.sinTextBox.Location = new System.Drawing.Point(414, 31);
            this.sinTextBox.Name = "sinTextBox";
            this.sinTextBox.Size = new System.Drawing.Size(249, 22);
            this.sinTextBox.TabIndex = 8;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(124, 62);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(178, 22);
            this.lastNameTextBox.TabIndex = 7;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(125, 32);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(177, 22);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(734, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "High School Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Admission Test Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1409, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1409, 28);
            this.menuStrip2.TabIndex = 16;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.recordToolStripMenuItem,
            this.deleteAToolStripMenuItem,
            this.loadRecordsToServerToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.registerToolStripMenuItem.Text = "Register";
            // 
            // recordToolStripMenuItem
            // 
            this.recordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRecordToolStripMenuItem,
            this.deleteRecordToolStripMenuItem});
            this.recordToolStripMenuItem.Name = "recordToolStripMenuItem";
            this.recordToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.recordToolStripMenuItem.Text = "Record";
            // 
            // updateRecordToolStripMenuItem
            // 
            this.updateRecordToolStripMenuItem.Name = "updateRecordToolStripMenuItem";
            this.updateRecordToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.updateRecordToolStripMenuItem.Text = "Update Record";
            // 
            // deleteRecordToolStripMenuItem
            // 
            this.deleteRecordToolStripMenuItem.Name = "deleteRecordToolStripMenuItem";
            this.deleteRecordToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.deleteRecordToolStripMenuItem.Text = "Delete Record";
            // 
            // deleteAToolStripMenuItem
            // 
            this.deleteAToolStripMenuItem.Name = "deleteAToolStripMenuItem";
            this.deleteAToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.deleteAToolStripMenuItem.Text = "Delete All Records";
            // 
            // loadRecordsToServerToolStripMenuItem
            // 
            this.loadRecordsToServerToolStripMenuItem.Name = "loadRecordsToServerToolStripMenuItem";
            this.loadRecordsToServerToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.loadRecordsToServerToolStripMenuItem.Text = "Load Records to Server";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(242, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(245, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readHelpToolStripMenuItem,
            this.technicalSupportsToolStripMenuItem,
            this.aboutDCRegistrationAppToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // readHelpToolStripMenuItem
            // 
            this.readHelpToolStripMenuItem.Name = "readHelpToolStripMenuItem";
            this.readHelpToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.readHelpToolStripMenuItem.Text = "Read Help";
            // 
            // technicalSupportsToolStripMenuItem
            // 
            this.technicalSupportsToolStripMenuItem.Name = "technicalSupportsToolStripMenuItem";
            this.technicalSupportsToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.technicalSupportsToolStripMenuItem.Text = "Technical Supports";
            // 
            // aboutDCRegistrationAppToolStripMenuItem
            // 
            this.aboutDCRegistrationAppToolStripMenuItem.Name = "aboutDCRegistrationAppToolStripMenuItem";
            this.aboutDCRegistrationAppToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.aboutDCRegistrationAppToolStripMenuItem.Text = "About DC - Registration App";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(232, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(454, 51);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "1. This is the student information Section. This is where you will input all the " +
    "student\'s information.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(1269, 103);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(110, 129);
            this.textBox2.TabIndex = 33;
            this.textBox2.Text = "2. Use the drop down menu\'s to select the student\'s admission scores, and high sc" +
    "hool grades.";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(22, 148);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(192, 90);
            this.textBox3.TabIndex = 34;
            this.textBox3.Text = "4. When finished entering information, hit \"check\". This will check if the studen" +
    "t meets the requirements for various campus admissions.";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(22, 252);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(192, 76);
            this.textBox4.TabIndex = 35;
            this.textBox4.Text = "5. If the student meets any campus requirements, the \"Available Programs\" section" +
    " will unlock.";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Location = new System.Drawing.Point(575, 228);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(434, 47);
            this.textBox5.TabIndex = 36;
            this.textBox5.Text = "3. This is the available program section. This is where you will be selecting cam" +
    "pus location, and the desired program for the student.";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.Location = new System.Drawing.Point(1269, 278);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(119, 98);
            this.textBox6.TabIndex = 37;
            this.textBox6.Text = "6. The study period, and cost, will be shown here when you select a program.";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Info;
            this.textBox7.Location = new System.Drawing.Point(373, 349);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(579, 53);
            this.textBox7.TabIndex = 38;
            this.textBox7.Text = "7. Once you\'ve finished selecting a campus and program, the register student butt" +
    "on will unlock. This confirms all selections, and populates the below grid view " +
    "with the completed admission record.";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Info;
            this.textBox8.Location = new System.Drawing.Point(39, 392);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(192, 76);
            this.textBox8.TabIndex = 39;
            this.textBox8.Text = "8. This is the \"Student Data Grid View\". This will collect all registered admissi" +
    "on records for your day.";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.Location = new System.Drawing.Point(39, 543);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(192, 92);
            this.textBox9.TabIndex = 40;
            this.textBox9.Text = "9. The \"Delete Record\" button is used to delete a registered admission record. Ma" +
    "ke sure to select a SIN first from the drop down menu!";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Info;
            this.textBox10.Location = new System.Drawing.Point(248, 655);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(507, 49);
            this.textBox10.TabIndex = 41;
            this.textBox10.Text = "10. This is a drop down menu that collects all registered admission records stude" +
    "nt SIN numbers. It is used to select which student you would like to Delete or U" +
    "pdate.";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Info;
            this.textBox11.Location = new System.Drawing.Point(385, 508);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(192, 69);
            this.textBox11.TabIndex = 42;
            this.textBox11.Text = "11. Update record is used to fetch a registered record for editing. It will delet" +
    "e the record in the process.";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Info;
            this.textBox12.Location = new System.Drawing.Point(583, 508);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(192, 73);
            this.textBox12.TabIndex = 43;
            this.textBox12.Text = "12. Remove all records is used to erase all data and start from the beginning. Tr" +
    "eat this as a reset all button.";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Info;
            this.textBox13.Location = new System.Drawing.Point(984, 578);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(231, 114);
            this.textBox13.TabIndex = 44;
            this.textBox13.Text = "13. The \"Load Records to Server\" button, takes all registered records from the Da" +
    "ta Grid View, and uploads them to the external JSON file. It will delete all rec" +
    "ords sitting in the Data Grid View.";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Info;
            this.textBox14.Location = new System.Drawing.Point(12, 73);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(117, 51);
            this.textBox14.TabIndex = 45;
            this.textBox14.Text = "Press the above exit button to return to the main form.";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Info;
            this.textBox15.Location = new System.Drawing.Point(12, 464);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(219, 59);
            this.textBox15.TabIndex = 46;
            this.textBox15.Text = "You can also double click a row header to populate the student information with t" +
    "hat record.";
            // 
            // ReadHelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 704);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editStudentInfoButton);
            this.Controls.Add(this.studentGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.sinComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.loadRecordsButton);
            this.Controls.Add(this.removeAllRecordsButton);
            this.Controls.Add(this.updateRecordButton);
            this.Controls.Add(this.deleteRecordButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.studentInformationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReadHelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Help ";
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.studentInformationGroupBox.ResumeLayout(false);
            this.studentInformationGroupBox.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editStudentInfoButton;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighSchoolGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdmissionTestScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampusLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox sinComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button loadRecordsButton;
        private System.Windows.Forms.Button removeAllRecordsButton;
        private System.Windows.Forms.Button updateRecordButton;
        private System.Windows.Forms.Button deleteRecordButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox programsComboBox;
        private System.Windows.Forms.ComboBox campusLocationComboBox;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox studyPeriodTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox studentInformationGroupBox;
        private System.Windows.Forms.ComboBox highSchoolGradeComboBox;
        private System.Windows.Forms.ComboBox admissonScoreComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox sinTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRecordsToServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalSupportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDCRegistrationAppToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
    }
}