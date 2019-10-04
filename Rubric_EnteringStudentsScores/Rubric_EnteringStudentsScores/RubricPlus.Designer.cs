namespace Rubric_EnteringStudentsScores
{
    partial class RubricPlus
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
            this.btnHowManyTests = new System.Windows.Forms.Button();
            this.btnNameOfTest = new System.Windows.Forms.Button();
            this.btnHowManyQuestions = new System.Windows.Forms.Button();
            this.btnStudentsNameOrID = new System.Windows.Forms.Button();
            this.lblHowManyTests = new System.Windows.Forms.Label();
            this.lblNameOfTest = new System.Windows.Forms.Label();
            this.lblHowManyQuestions = new System.Windows.Forms.Label();
            this.lblStudentsNameOrID = new System.Windows.Forms.Label();
            this.txtHowManyTests = new System.Windows.Forms.TextBox();
            this.txtNameOfTest = new System.Windows.Forms.TextBox();
            this.txtHowMantQuestions = new System.Windows.Forms.TextBox();
            this.txtStudentsNameOrID = new System.Windows.Forms.TextBox();
            this.btnCorrectQuestions = new System.Windows.Forms.Button();
            this.txtCorrectQuestions = new System.Windows.Forms.TextBox();
            this.lblCorrectQuestions = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnFileName = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblTestNumber = new System.Windows.Forms.Label();
            this.lblNumQuestions = new System.Windows.Forms.Label();
            this.lblHowManyStudents = new System.Windows.Forms.Label();
            this.txtHowManyStudents = new System.Windows.Forms.TextBox();
            this.btnHowManyStudents = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHowManyTests
            // 
            this.btnHowManyTests.Location = new System.Drawing.Point(18, 74);
            this.btnHowManyTests.Name = "btnHowManyTests";
            this.btnHowManyTests.Size = new System.Drawing.Size(75, 23);
            this.btnHowManyTests.TabIndex = 0;
            this.btnHowManyTests.Text = "Enter";
            this.btnHowManyTests.UseVisualStyleBackColor = true;
            this.btnHowManyTests.Click += new System.EventHandler(this.btnHowManyTests_Click);
            // 
            // btnNameOfTest
            // 
            this.btnNameOfTest.Location = new System.Drawing.Point(18, 74);
            this.btnNameOfTest.Name = "btnNameOfTest";
            this.btnNameOfTest.Size = new System.Drawing.Size(75, 23);
            this.btnNameOfTest.TabIndex = 1;
            this.btnNameOfTest.Text = "Enter";
            this.btnNameOfTest.UseVisualStyleBackColor = true;
            this.btnNameOfTest.Visible = false;
            this.btnNameOfTest.Click += new System.EventHandler(this.btnNameOfTest_Click);
            // 
            // btnHowManyQuestions
            // 
            this.btnHowManyQuestions.Location = new System.Drawing.Point(18, 74);
            this.btnHowManyQuestions.Name = "btnHowManyQuestions";
            this.btnHowManyQuestions.Size = new System.Drawing.Size(75, 23);
            this.btnHowManyQuestions.TabIndex = 2;
            this.btnHowManyQuestions.Text = "Enter";
            this.btnHowManyQuestions.UseVisualStyleBackColor = true;
            this.btnHowManyQuestions.Visible = false;
            this.btnHowManyQuestions.Click += new System.EventHandler(this.btnHowManyQuestions_Click);
            // 
            // btnStudentsNameOrID
            // 
            this.btnStudentsNameOrID.Location = new System.Drawing.Point(18, 74);
            this.btnStudentsNameOrID.Name = "btnStudentsNameOrID";
            this.btnStudentsNameOrID.Size = new System.Drawing.Size(75, 23);
            this.btnStudentsNameOrID.TabIndex = 3;
            this.btnStudentsNameOrID.Text = "Enter";
            this.btnStudentsNameOrID.UseVisualStyleBackColor = true;
            this.btnStudentsNameOrID.Visible = false;
            this.btnStudentsNameOrID.Click += new System.EventHandler(this.btnStudentsNameOrID_Click);
            // 
            // lblHowManyTests
            // 
            this.lblHowManyTests.AutoSize = true;
            this.lblHowManyTests.Location = new System.Drawing.Point(25, 9);
            this.lblHowManyTests.Name = "lblHowManyTests";
            this.lblHowManyTests.Size = new System.Drawing.Size(87, 13);
            this.lblHowManyTests.TabIndex = 4;
            this.lblHowManyTests.Text = "How Many Tests";
            // 
            // lblNameOfTest
            // 
            this.lblNameOfTest.AutoSize = true;
            this.lblNameOfTest.Location = new System.Drawing.Point(12, 9);
            this.lblNameOfTest.Name = "lblNameOfTest";
            this.lblNameOfTest.Size = new System.Drawing.Size(81, 13);
            this.lblNameOfTest.TabIndex = 5;
            this.lblNameOfTest.Text = "Name of Test #";
            this.lblNameOfTest.Visible = false;
            this.lblNameOfTest.Click += new System.EventHandler(this.lblNameOfTest_Click);
            // 
            // lblHowManyQuestions
            // 
            this.lblHowManyQuestions.AutoSize = true;
            this.lblHowManyQuestions.Location = new System.Drawing.Point(12, 9);
            this.lblHowManyQuestions.Name = "lblHowManyQuestions";
            this.lblHowManyQuestions.Size = new System.Drawing.Size(108, 26);
            this.lblHowManyQuestions.TabIndex = 6;
            this.lblHowManyQuestions.Text = "How Many Questions\r\nfor test :";
            this.lblHowManyQuestions.Visible = false;
            // 
            // lblStudentsNameOrID
            // 
            this.lblStudentsNameOrID.AutoSize = true;
            this.lblStudentsNameOrID.Location = new System.Drawing.Point(15, 9);
            this.lblStudentsNameOrID.Name = "lblStudentsNameOrID";
            this.lblStudentsNameOrID.Size = new System.Drawing.Size(99, 13);
            this.lblStudentsNameOrID.TabIndex = 7;
            this.lblStudentsNameOrID.Text = "Student name or ID";
            this.lblStudentsNameOrID.Visible = false;
            // 
            // txtHowManyTests
            // 
            this.txtHowManyTests.Location = new System.Drawing.Point(18, 48);
            this.txtHowManyTests.Name = "txtHowManyTests";
            this.txtHowManyTests.Size = new System.Drawing.Size(100, 20);
            this.txtHowManyTests.TabIndex = 8;
            // 
            // txtNameOfTest
            // 
            this.txtNameOfTest.Location = new System.Drawing.Point(18, 48);
            this.txtNameOfTest.Name = "txtNameOfTest";
            this.txtNameOfTest.Size = new System.Drawing.Size(100, 20);
            this.txtNameOfTest.TabIndex = 9;
            this.txtNameOfTest.Visible = false;
            // 
            // txtHowMantQuestions
            // 
            this.txtHowMantQuestions.Location = new System.Drawing.Point(18, 48);
            this.txtHowMantQuestions.Name = "txtHowMantQuestions";
            this.txtHowMantQuestions.Size = new System.Drawing.Size(100, 20);
            this.txtHowMantQuestions.TabIndex = 10;
            this.txtHowMantQuestions.Visible = false;
            // 
            // txtStudentsNameOrID
            // 
            this.txtStudentsNameOrID.Location = new System.Drawing.Point(18, 48);
            this.txtStudentsNameOrID.Name = "txtStudentsNameOrID";
            this.txtStudentsNameOrID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentsNameOrID.TabIndex = 11;
            this.txtStudentsNameOrID.Visible = false;
            // 
            // btnCorrectQuestions
            // 
            this.btnCorrectQuestions.Location = new System.Drawing.Point(18, 74);
            this.btnCorrectQuestions.Name = "btnCorrectQuestions";
            this.btnCorrectQuestions.Size = new System.Drawing.Size(75, 23);
            this.btnCorrectQuestions.TabIndex = 12;
            this.btnCorrectQuestions.Text = "Enter";
            this.btnCorrectQuestions.UseVisualStyleBackColor = true;
            this.btnCorrectQuestions.Visible = false;
            this.btnCorrectQuestions.Click += new System.EventHandler(this.btnCorrectQuestions_Click);
            // 
            // txtCorrectQuestions
            // 
            this.txtCorrectQuestions.Location = new System.Drawing.Point(18, 48);
            this.txtCorrectQuestions.Name = "txtCorrectQuestions";
            this.txtCorrectQuestions.Size = new System.Drawing.Size(100, 20);
            this.txtCorrectQuestions.TabIndex = 13;
            this.txtCorrectQuestions.Visible = false;
            // 
            // lblCorrectQuestions
            // 
            this.lblCorrectQuestions.AutoSize = true;
            this.lblCorrectQuestions.Location = new System.Drawing.Point(15, 9);
            this.lblCorrectQuestions.Name = "lblCorrectQuestions";
            this.lblCorrectQuestions.Size = new System.Drawing.Size(184, 13);
            this.lblCorrectQuestions.TabIndex = 14;
            this.lblCorrectQuestions.Text = "Enter the number of correct questions";
            this.lblCorrectQuestions.Visible = false;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(12, 22);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(31, 13);
            this.lblTest.TabIndex = 15;
            this.lblTest.Text = "Test ";
            this.lblTest.Visible = false;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(118, 22);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(48, 13);
            this.lblStudent.TabIndex = 16;
            this.lblStudent.Text = "student: ";
            this.lblStudent.Visible = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(118, 51);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(81, 13);
            this.lblQuestion.TabIndex = 17;
            this.lblQuestion.Text = "Total Questions";
            this.lblQuestion.Visible = false;
            // 
            // btnFileName
            // 
            this.btnFileName.Location = new System.Drawing.Point(18, 74);
            this.btnFileName.Name = "btnFileName";
            this.btnFileName.Size = new System.Drawing.Size(75, 23);
            this.btnFileName.TabIndex = 18;
            this.btnFileName.Text = "Enter";
            this.btnFileName.UseVisualStyleBackColor = true;
            this.btnFileName.Visible = false;
            this.btnFileName.Click += new System.EventHandler(this.btnFileName_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(15, 9);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(113, 13);
            this.lblFileName.TabIndex = 19;
            this.lblFileName.Text = "Name of file to save to";
            this.lblFileName.Visible = false;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(18, 48);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(100, 20);
            this.txtFileName.TabIndex = 20;
            this.txtFileName.Visible = false;
            // 
            // lblTestNumber
            // 
            this.lblTestNumber.AutoSize = true;
            this.lblTestNumber.Location = new System.Drawing.Point(99, 9);
            this.lblTestNumber.Name = "lblTestNumber";
            this.lblTestNumber.Size = new System.Drawing.Size(13, 13);
            this.lblTestNumber.TabIndex = 22;
            this.lblTestNumber.Text = "1";
            // 
            // lblNumQuestions
            // 
            this.lblNumQuestions.AutoSize = true;
            this.lblNumQuestions.Location = new System.Drawing.Point(59, 22);
            this.lblNumQuestions.Name = "lblNumQuestions";
            this.lblNumQuestions.Size = new System.Drawing.Size(13, 13);
            this.lblNumQuestions.TabIndex = 23;
            this.lblNumQuestions.Text = "1";
            // 
            // lblHowManyStudents
            // 
            this.lblHowManyStudents.AutoSize = true;
            this.lblHowManyStudents.Location = new System.Drawing.Point(12, 9);
            this.lblHowManyStudents.Name = "lblHowManyStudents";
            this.lblHowManyStudents.Size = new System.Drawing.Size(102, 13);
            this.lblHowManyStudents.TabIndex = 24;
            this.lblHowManyStudents.Text = "How many Students";
            this.lblHowManyStudents.Visible = false;
            // 
            // txtHowManyStudents
            // 
            this.txtHowManyStudents.Location = new System.Drawing.Point(18, 48);
            this.txtHowManyStudents.Name = "txtHowManyStudents";
            this.txtHowManyStudents.Size = new System.Drawing.Size(100, 20);
            this.txtHowManyStudents.TabIndex = 25;
            this.txtHowManyStudents.Visible = false;
            // 
            // btnHowManyStudents
            // 
            this.btnHowManyStudents.Location = new System.Drawing.Point(18, 74);
            this.btnHowManyStudents.Name = "btnHowManyStudents";
            this.btnHowManyStudents.Size = new System.Drawing.Size(75, 23);
            this.btnHowManyStudents.TabIndex = 26;
            this.btnHowManyStudents.Text = "Enter";
            this.btnHowManyStudents.UseVisualStyleBackColor = true;
            this.btnHowManyStudents.Visible = false;
            this.btnHowManyStudents.Click += new System.EventHandler(this.btnHowManyStudents_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(145, 74);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 27;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Visible = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(18, 114);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(145, 114);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // RubricPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 166);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnHowManyStudents);
            this.Controls.Add(this.txtHowManyStudents);
            this.Controls.Add(this.lblHowManyStudents);
            this.Controls.Add(this.lblNumQuestions);
            this.Controls.Add(this.lblTestNumber);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnFileName);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblCorrectQuestions);
            this.Controls.Add(this.txtCorrectQuestions);
            this.Controls.Add(this.btnCorrectQuestions);
            this.Controls.Add(this.txtStudentsNameOrID);
            this.Controls.Add(this.txtHowMantQuestions);
            this.Controls.Add(this.txtNameOfTest);
            this.Controls.Add(this.txtHowManyTests);
            this.Controls.Add(this.lblStudentsNameOrID);
            this.Controls.Add(this.lblHowManyQuestions);
            this.Controls.Add(this.lblNameOfTest);
            this.Controls.Add(this.lblHowManyTests);
            this.Controls.Add(this.btnStudentsNameOrID);
            this.Controls.Add(this.btnHowManyQuestions);
            this.Controls.Add(this.btnNameOfTest);
            this.Controls.Add(this.btnHowManyTests);
            this.Name = "RubricPlus";
            this.Text = "Rubric Plus";
            this.Load += new System.EventHandler(this.RubricPlus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHowManyTests;
        private System.Windows.Forms.Button btnNameOfTest;
        private System.Windows.Forms.Button btnHowManyQuestions;
        private System.Windows.Forms.Button btnStudentsNameOrID;
        private System.Windows.Forms.Label lblHowManyTests;
        private System.Windows.Forms.Label lblNameOfTest;
        private System.Windows.Forms.Label lblHowManyQuestions;
        private System.Windows.Forms.Label lblStudentsNameOrID;
        private System.Windows.Forms.TextBox txtHowManyTests;
        private System.Windows.Forms.TextBox txtNameOfTest;
        private System.Windows.Forms.TextBox txtHowMantQuestions;
        private System.Windows.Forms.TextBox txtStudentsNameOrID;
        private System.Windows.Forms.Button btnCorrectQuestions;
        private System.Windows.Forms.TextBox txtCorrectQuestions;
        private System.Windows.Forms.Label lblCorrectQuestions;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblTestNumber;
        private System.Windows.Forms.Label lblNumQuestions;
        private System.Windows.Forms.Label lblHowManyStudents;
        private System.Windows.Forms.TextBox txtHowManyStudents;
        private System.Windows.Forms.Button btnHowManyStudents;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
    }
}

