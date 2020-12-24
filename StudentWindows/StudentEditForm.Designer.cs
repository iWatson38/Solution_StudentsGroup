namespace StudentWindows
{
    partial class StudentEditForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label sessionIDLabel;
            System.Windows.Forms.Label modeStudyIDLabel;
            System.Windows.Forms.Label studentFirstNameLabel;
            System.Windows.Forms.Label studentLastNameLabel;
            System.Windows.Forms.Label studentMiddleNameLabel;
            System.Windows.Forms.Label studentDataBirthLabel;
            System.Windows.Forms.Label studentGroupLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionIDComboBox = new System.Windows.Forms.ComboBox();
            this.sessionlistbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeStudyIDComboBox = new System.Windows.Forms.ComboBox();
            this.modeStudyListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.studentLastNameTextBox = new System.Windows.Forms.TextBox();
            this.studentMiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.studentDataBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentGroupTextBox = new System.Windows.Forms.TextBox();
            sessionIDLabel = new System.Windows.Forms.Label();
            modeStudyIDLabel = new System.Windows.Forms.Label();
            studentFirstNameLabel = new System.Windows.Forms.Label();
            studentLastNameLabel = new System.Windows.Forms.Label();
            studentMiddleNameLabel = new System.Windows.Forms.Label();
            studentDataBirthLabel = new System.Windows.Forms.Label();
            studentGroupLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionlistbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeStudyListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sessionIDLabel
            // 
            sessionIDLabel.AutoSize = true;
            sessionIDLabel.Location = new System.Drawing.Point(12, 172);
            sessionIDLabel.Name = "sessionIDLabel";
            sessionIDLabel.Size = new System.Drawing.Size(45, 13);
            sessionIDLabel.TabIndex = 14;
            sessionIDLabel.Text = "Оценка";
            // 
            // modeStudyIDLabel
            // 
            modeStudyIDLabel.AutoSize = true;
            modeStudyIDLabel.Location = new System.Drawing.Point(12, 145);
            modeStudyIDLabel.Name = "modeStudyIDLabel";
            modeStudyIDLabel.Size = new System.Drawing.Size(81, 13);
            modeStudyIDLabel.TabIndex = 17;
            modeStudyIDLabel.Text = "Mode Study ID:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(15, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(286, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataSource = typeof(StudentLibrary.StudentInfo);
            // 
            // sessionIDComboBox
            // 
            this.sessionIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentInfoBindingSource, "SessionID", true));
            this.sessionIDComboBox.DataSource = this.sessionlistbindingSource;
            this.sessionIDComboBox.DisplayMember = "SessionMark";
            this.sessionIDComboBox.FormattingEnabled = true;
            this.sessionIDComboBox.Location = new System.Drawing.Point(130, 169);
            this.sessionIDComboBox.Name = "sessionIDComboBox";
            this.sessionIDComboBox.Size = new System.Drawing.Size(231, 21);
            this.sessionIDComboBox.TabIndex = 15;
            this.sessionIDComboBox.ValueMember = "SessionID";
            // 
            // sessionlistbindingSource
            // 
            this.sessionlistbindingSource.DataSource = typeof(StudentLibrary.StudentList);
            // 
            // modeStudyIDComboBox
            // 
            this.modeStudyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.modeStudyListBindingSource, "ModeStudyID", true));
            this.modeStudyIDComboBox.DataSource = this.modeStudyListBindingSource;
            this.modeStudyIDComboBox.DisplayMember = "ModeStudyName";
            this.modeStudyIDComboBox.FormattingEnabled = true;
            this.modeStudyIDComboBox.Location = new System.Drawing.Point(130, 142);
            this.modeStudyIDComboBox.Name = "modeStudyIDComboBox";
            this.modeStudyIDComboBox.Size = new System.Drawing.Size(231, 21);
            this.modeStudyIDComboBox.TabIndex = 18;
            this.modeStudyIDComboBox.ValueMember = "ModeStudyID";
            // 
            // modeStudyListBindingSource
            // 
            this.modeStudyListBindingSource.DataSource = typeof(StudentLibrary.ModeStudyList);
            // 
            // studentFirstNameLabel
            // 
            studentFirstNameLabel.AutoSize = true;
            studentFirstNameLabel.Location = new System.Drawing.Point(12, 15);
            studentFirstNameLabel.Name = "studentFirstNameLabel";
            studentFirstNameLabel.Size = new System.Drawing.Size(100, 13);
            studentFirstNameLabel.TabIndex = 18;
            studentFirstNameLabel.Text = "Student First Name:";
            // 
            // studentFirstNameTextBox
            // 
            this.studentFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "StudentFirstName", true));
            this.studentFirstNameTextBox.Location = new System.Drawing.Point(130, 12);
            this.studentFirstNameTextBox.Name = "studentFirstNameTextBox";
            this.studentFirstNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.studentFirstNameTextBox.TabIndex = 19;
            // 
            // studentLastNameLabel
            // 
            studentLastNameLabel.AutoSize = true;
            studentLastNameLabel.Location = new System.Drawing.Point(11, 41);
            studentLastNameLabel.Name = "studentLastNameLabel";
            studentLastNameLabel.Size = new System.Drawing.Size(101, 13);
            studentLastNameLabel.TabIndex = 19;
            studentLastNameLabel.Text = "Student Last Name:";
            // 
            // studentLastNameTextBox
            // 
            this.studentLastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "StudentLastName", true));
            this.studentLastNameTextBox.Location = new System.Drawing.Point(130, 38);
            this.studentLastNameTextBox.Name = "studentLastNameTextBox";
            this.studentLastNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.studentLastNameTextBox.TabIndex = 20;
            // 
            // studentMiddleNameLabel
            // 
            studentMiddleNameLabel.AutoSize = true;
            studentMiddleNameLabel.Location = new System.Drawing.Point(12, 67);
            studentMiddleNameLabel.Name = "studentMiddleNameLabel";
            studentMiddleNameLabel.Size = new System.Drawing.Size(112, 13);
            studentMiddleNameLabel.TabIndex = 20;
            studentMiddleNameLabel.Text = "Student Middle Name:";
            // 
            // studentMiddleNameTextBox
            // 
            this.studentMiddleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "StudentMiddleName", true));
            this.studentMiddleNameTextBox.Location = new System.Drawing.Point(130, 64);
            this.studentMiddleNameTextBox.Name = "studentMiddleNameTextBox";
            this.studentMiddleNameTextBox.Size = new System.Drawing.Size(231, 20);
            this.studentMiddleNameTextBox.TabIndex = 21;
            // 
            // studentDataBirthLabel
            // 
            studentDataBirthLabel.AutoSize = true;
            studentDataBirthLabel.Location = new System.Drawing.Point(12, 96);
            studentDataBirthLabel.Name = "studentDataBirthLabel";
            studentDataBirthLabel.Size = new System.Drawing.Size(97, 13);
            studentDataBirthLabel.TabIndex = 21;
            studentDataBirthLabel.Text = "Student Data Birth:";
            // 
            // studentDataBirthDateTimePicker
            // 
            this.studentDataBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentInfoBindingSource, "StudentDataBirth", true));
            this.studentDataBirthDateTimePicker.Location = new System.Drawing.Point(130, 90);
            this.studentDataBirthDateTimePicker.Name = "studentDataBirthDateTimePicker";
            this.studentDataBirthDateTimePicker.Size = new System.Drawing.Size(231, 20);
            this.studentDataBirthDateTimePicker.TabIndex = 22;
            // 
            // studentGroupLabel
            // 
            studentGroupLabel.AutoSize = true;
            studentGroupLabel.Location = new System.Drawing.Point(12, 119);
            studentGroupLabel.Name = "studentGroupLabel";
            studentGroupLabel.Size = new System.Drawing.Size(79, 13);
            studentGroupLabel.TabIndex = 22;
            studentGroupLabel.Text = "Student Group:";
            // 
            // studentGroupTextBox
            // 
            this.studentGroupTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInfoBindingSource, "StudentGroup", true));
            this.studentGroupTextBox.Location = new System.Drawing.Point(130, 116);
            this.studentGroupTextBox.Name = "studentGroupTextBox";
            this.studentGroupTextBox.Size = new System.Drawing.Size(231, 20);
            this.studentGroupTextBox.TabIndex = 23;
            // 
            // StudentEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 280);
            this.Controls.Add(studentGroupLabel);
            this.Controls.Add(this.studentGroupTextBox);
            this.Controls.Add(studentDataBirthLabel);
            this.Controls.Add(this.studentDataBirthDateTimePicker);
            this.Controls.Add(studentMiddleNameLabel);
            this.Controls.Add(this.studentMiddleNameTextBox);
            this.Controls.Add(studentLastNameLabel);
            this.Controls.Add(this.studentLastNameTextBox);
            this.Controls.Add(studentFirstNameLabel);
            this.Controls.Add(this.studentFirstNameTextBox);
            this.Controls.Add(modeStudyIDLabel);
            this.Controls.Add(this.modeStudyIDComboBox);
            this.Controls.Add(sessionIDLabel);
            this.Controls.Add(this.sessionIDComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "StudentEditForm";
            this.Text = "CardStudent";
            this.Load += new System.EventHandler(this.StudentEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionlistbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeStudyListBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private System.Windows.Forms.ComboBox sessionIDComboBox;
        private System.Windows.Forms.BindingSource sessionlistbindingSource;
        private System.Windows.Forms.ComboBox modeStudyIDComboBox;
        private System.Windows.Forms.BindingSource modeStudyListBindingSource;
        private System.Windows.Forms.TextBox studentFirstNameTextBox;
        private System.Windows.Forms.TextBox studentLastNameTextBox;
        private System.Windows.Forms.TextBox studentMiddleNameTextBox;
        private System.Windows.Forms.DateTimePicker studentDataBirthDateTimePicker;
        private System.Windows.Forms.TextBox studentGroupTextBox;
    }
}