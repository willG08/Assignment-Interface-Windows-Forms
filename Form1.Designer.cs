namespace Assignment3WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            countsBox = new GroupBox();
            numAssignmentsErr = new Label();
            numStudentsErr = new Label();
            submitCounts = new Button();
            numAssignmentsTxt = new TextBox();
            numStudentsTxt = new TextBox();
            NumAssignmentslbl = new Label();
            NumStudentslbl = new Label();
            resetBtn = new Button();
            navigateBox = new GroupBox();
            pickStudentErr = new Label();
            lastBtn = new Button();
            nextBtn = new Button();
            prevBtn = new Button();
            firstBtn = new Button();
            infoBox = new GroupBox();
            studentNameErr = new Label();
            saveNameBtn = new Button();
            nameTxt = new TextBox();
            namelbl = new Label();
            assignmentBox = new GroupBox();
            assignmentScoreErr = new Label();
            assignmentSelectionErr = new Label();
            saveScoreBtn = new Button();
            assignmentScoreTxt = new TextBox();
            assignmentNumTxt = new TextBox();
            assignmentScorelbl = new Label();
            assignmentNumlbl = new Label();
            mainTxt = new RichTextBox();
            displayScoresBtn = new Button();
            countsBox.SuspendLayout();
            navigateBox.SuspendLayout();
            infoBox.SuspendLayout();
            assignmentBox.SuspendLayout();
            SuspendLayout();
            // 
            // countsBox
            // 
            countsBox.Controls.Add(numAssignmentsErr);
            countsBox.Controls.Add(numStudentsErr);
            countsBox.Controls.Add(submitCounts);
            countsBox.Controls.Add(numAssignmentsTxt);
            countsBox.Controls.Add(numStudentsTxt);
            countsBox.Controls.Add(NumAssignmentslbl);
            countsBox.Controls.Add(NumStudentslbl);
            countsBox.Location = new Point(18, 16);
            countsBox.Name = "countsBox";
            countsBox.Size = new Size(392, 123);
            countsBox.TabIndex = 0;
            countsBox.TabStop = false;
            countsBox.Text = "Counts";
            countsBox.Enter += groupBox1_Enter;
            // 
            // numAssignmentsErr
            // 
            numAssignmentsErr.AutoSize = true;
            numAssignmentsErr.Location = new Point(152, 97);
            numAssignmentsErr.Name = "numAssignmentsErr";
            numAssignmentsErr.Size = new Size(237, 15);
            numAssignmentsErr.TabIndex = 6;
            numAssignmentsErr.Text = "Please enter between 1 and 99 assignments.";
            numAssignmentsErr.Visible = false;
            // 
            // numStudentsErr
            // 
            numStudentsErr.AutoSize = true;
            numStudentsErr.Location = new Point(170, 19);
            numStudentsErr.Name = "numStudentsErr";
            numStudentsErr.Size = new Size(216, 15);
            numStudentsErr.TabIndex = 5;
            numStudentsErr.Text = "Please enter between 1 and 10 students.";
            numStudentsErr.Visible = false;
            // 
            // submitCounts
            // 
            submitCounts.Location = new Point(257, 55);
            submitCounts.Name = "submitCounts";
            submitCounts.Size = new Size(98, 23);
            submitCounts.TabIndex = 4;
            submitCounts.Text = "Submit Counts";
            submitCounts.UseVisualStyleBackColor = true;
            submitCounts.Click += submitCounts_Click;
            // 
            // numAssignmentsTxt
            // 
            numAssignmentsTxt.Location = new Point(162, 71);
            numAssignmentsTxt.Name = "numAssignmentsTxt";
            numAssignmentsTxt.Size = new Size(62, 23);
            numAssignmentsTxt.TabIndex = 3;
            // 
            // numStudentsTxt
            // 
            numStudentsTxt.Location = new Point(162, 40);
            numStudentsTxt.Name = "numStudentsTxt";
            numStudentsTxt.Size = new Size(62, 23);
            numStudentsTxt.TabIndex = 2;
            // 
            // NumAssignmentslbl
            // 
            NumAssignmentslbl.AutoSize = true;
            NumAssignmentslbl.Location = new Point(14, 74);
            NumAssignmentslbl.Name = "NumAssignmentslbl";
            NumAssignmentslbl.Size = new Size(142, 15);
            NumAssignmentslbl.TabIndex = 1;
            NumAssignmentslbl.Text = "Number of Assignments: ";
            // 
            // NumStudentslbl
            // 
            NumStudentslbl.AutoSize = true;
            NumStudentslbl.Location = new Point(39, 40);
            NumStudentslbl.Name = "NumStudentslbl";
            NumStudentslbl.Size = new Size(117, 15);
            NumStudentslbl.TabIndex = 0;
            NumStudentslbl.Text = "Number of Students:";
            NumStudentslbl.Click += NumStudentsTxt_Click;
            // 
            // resetBtn
            // 
            resetBtn.Enabled = false;
            resetBtn.Location = new Point(451, 62);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(76, 41);
            resetBtn.TabIndex = 1;
            resetBtn.Text = "Reset Scores";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // navigateBox
            // 
            navigateBox.Controls.Add(pickStudentErr);
            navigateBox.Controls.Add(lastBtn);
            navigateBox.Controls.Add(nextBtn);
            navigateBox.Controls.Add(prevBtn);
            navigateBox.Controls.Add(firstBtn);
            navigateBox.Location = new Point(17, 145);
            navigateBox.Name = "navigateBox";
            navigateBox.Size = new Size(510, 98);
            navigateBox.TabIndex = 2;
            navigateBox.TabStop = false;
            navigateBox.Text = "Navigate";
            // 
            // pickStudentErr
            // 
            pickStudentErr.AutoSize = true;
            pickStudentErr.Location = new Point(163, 80);
            pickStudentErr.Name = "pickStudentErr";
            pickStudentErr.Size = new Size(180, 15);
            pickStudentErr.TabIndex = 4;
            pickStudentErr.Text = "Out of bounds student selection.";
            pickStudentErr.Visible = false;
            // 
            // lastBtn
            // 
            lastBtn.Enabled = false;
            lastBtn.Location = new Point(389, 33);
            lastBtn.Name = "lastBtn";
            lastBtn.Size = new Size(101, 27);
            lastBtn.TabIndex = 3;
            lastBtn.Text = ">> Last Student";
            lastBtn.UseVisualStyleBackColor = true;
            lastBtn.Click += lastBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.Enabled = false;
            nextBtn.Location = new Point(258, 33);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(110, 27);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "> Next Student";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Enabled = false;
            prevBtn.Location = new Point(142, 33);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(96, 27);
            prevBtn.TabIndex = 1;
            prevBtn.Text = "< Prev Student";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // firstBtn
            // 
            firstBtn.Enabled = false;
            firstBtn.Location = new Point(15, 33);
            firstBtn.Name = "firstBtn";
            firstBtn.Size = new Size(102, 27);
            firstBtn.TabIndex = 0;
            firstBtn.Text = "<< First Student";
            firstBtn.UseVisualStyleBackColor = true;
            firstBtn.Click += firstBtn_Click;
            // 
            // infoBox
            // 
            infoBox.Controls.Add(studentNameErr);
            infoBox.Controls.Add(saveNameBtn);
            infoBox.Controls.Add(nameTxt);
            infoBox.Controls.Add(namelbl);
            infoBox.Location = new Point(15, 243);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(512, 87);
            infoBox.TabIndex = 3;
            infoBox.TabStop = false;
            infoBox.Text = "Student Info.";
            infoBox.Enter += infoBox_Enter;
            // 
            // studentNameErr
            // 
            studentNameErr.AutoSize = true;
            studentNameErr.Location = new Point(157, 67);
            studentNameErr.Name = "studentNameErr";
            studentNameErr.Size = new Size(121, 15);
            studentNameErr.TabIndex = 3;
            studentNameErr.Text = "Invalid Student Name";
            studentNameErr.Visible = false;
            // 
            // saveNameBtn
            // 
            saveNameBtn.Enabled = false;
            saveNameBtn.Location = new Point(417, 30);
            saveNameBtn.Name = "saveNameBtn";
            saveNameBtn.Size = new Size(75, 23);
            saveNameBtn.TabIndex = 2;
            saveNameBtn.Text = "Save Name";
            saveNameBtn.UseVisualStyleBackColor = true;
            saveNameBtn.Click += saveNameBtn_Click;
            // 
            // nameTxt
            // 
            nameTxt.Enabled = false;
            nameTxt.Location = new Point(96, 31);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(299, 23);
            nameTxt.TabIndex = 1;
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.Location = new Point(20, 33);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(67, 15);
            namelbl.TabIndex = 0;
            namelbl.Text = "Student #1:";
            // 
            // assignmentBox
            // 
            assignmentBox.Controls.Add(assignmentScoreErr);
            assignmentBox.Controls.Add(assignmentSelectionErr);
            assignmentBox.Controls.Add(saveScoreBtn);
            assignmentBox.Controls.Add(assignmentScoreTxt);
            assignmentBox.Controls.Add(assignmentNumTxt);
            assignmentBox.Controls.Add(assignmentScorelbl);
            assignmentBox.Controls.Add(assignmentNumlbl);
            assignmentBox.Location = new Point(9, 336);
            assignmentBox.Name = "assignmentBox";
            assignmentBox.Size = new Size(520, 92);
            assignmentBox.TabIndex = 4;
            assignmentBox.TabStop = false;
            assignmentBox.Text = "Assignment Info.";
            // 
            // assignmentScoreErr
            // 
            assignmentScoreErr.AutoSize = true;
            assignmentScoreErr.Location = new Point(272, 73);
            assignmentScoreErr.Name = "assignmentScoreErr";
            assignmentScoreErr.Size = new Size(184, 15);
            assignmentScoreErr.TabIndex = 6;
            assignmentScoreErr.Text = "Assignment Score is out of range.";
            assignmentScoreErr.Visible = false;
            // 
            // assignmentSelectionErr
            // 
            assignmentSelectionErr.AutoSize = true;
            assignmentSelectionErr.Location = new Point(274, 26);
            assignmentSelectionErr.Name = "assignmentSelectionErr";
            assignmentSelectionErr.Size = new Size(197, 15);
            assignmentSelectionErr.TabIndex = 5;
            assignmentSelectionErr.Text = "Assignment number is out of range.";
            assignmentSelectionErr.Visible = false;
            // 
            // saveScoreBtn
            // 
            saveScoreBtn.Enabled = false;
            saveScoreBtn.Location = new Point(300, 44);
            saveScoreBtn.Name = "saveScoreBtn";
            saveScoreBtn.Size = new Size(75, 23);
            saveScoreBtn.TabIndex = 4;
            saveScoreBtn.Text = "Save Score";
            saveScoreBtn.UseVisualStyleBackColor = true;
            saveScoreBtn.Click += saveScoreBtn_Click;
            // 
            // assignmentScoreTxt
            // 
            assignmentScoreTxt.Enabled = false;
            assignmentScoreTxt.Location = new Point(207, 63);
            assignmentScoreTxt.Name = "assignmentScoreTxt";
            assignmentScoreTxt.Size = new Size(39, 23);
            assignmentScoreTxt.TabIndex = 3;
            // 
            // assignmentNumTxt
            // 
            assignmentNumTxt.Enabled = false;
            assignmentNumTxt.ForeColor = SystemColors.WindowText;
            assignmentNumTxt.Location = new Point(208, 30);
            assignmentNumTxt.Name = "assignmentNumTxt";
            assignmentNumTxt.Size = new Size(38, 23);
            assignmentNumTxt.TabIndex = 2;
            // 
            // assignmentScorelbl
            // 
            assignmentScorelbl.AutoSize = true;
            assignmentScorelbl.Location = new Point(95, 62);
            assignmentScorelbl.Name = "assignmentScorelbl";
            assignmentScorelbl.Size = new Size(105, 15);
            assignmentScorelbl.TabIndex = 1;
            assignmentScorelbl.Text = "Assignment Score:";
            // 
            // assignmentNumlbl
            // 
            assignmentNumlbl.AutoSize = true;
            assignmentNumlbl.Location = new Point(22, 32);
            assignmentNumlbl.Name = "assignmentNumlbl";
            assignmentNumlbl.Size = new Size(179, 15);
            assignmentNumlbl.TabIndex = 0;
            assignmentNumlbl.Text = "Enter Assignment Number (1-X):";
            // 
            // mainTxt
            // 
            mainTxt.Location = new Point(9, 483);
            mainTxt.Name = "mainTxt";
            mainTxt.ReadOnly = true;
            mainTxt.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            mainTxt.Size = new Size(741, 172);
            mainTxt.TabIndex = 5;
            mainTxt.Text = "";
            mainTxt.WordWrap = false;
            // 
            // displayScoresBtn
            // 
            displayScoresBtn.Enabled = false;
            displayScoresBtn.Location = new Point(263, 444);
            displayScoresBtn.Name = "displayScoresBtn";
            displayScoresBtn.Size = new Size(91, 23);
            displayScoresBtn.TabIndex = 6;
            displayScoresBtn.Text = "Display Scores";
            displayScoresBtn.UseVisualStyleBackColor = true;
            displayScoresBtn.Click += displayScoresBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 647);
            Controls.Add(displayScoresBtn);
            Controls.Add(mainTxt);
            Controls.Add(assignmentBox);
            Controls.Add(infoBox);
            Controls.Add(navigateBox);
            Controls.Add(resetBtn);
            Controls.Add(countsBox);
            Name = "Form1";
            Text = "Form1";
            countsBox.ResumeLayout(false);
            countsBox.PerformLayout();
            navigateBox.ResumeLayout(false);
            navigateBox.PerformLayout();
            infoBox.ResumeLayout(false);
            infoBox.PerformLayout();
            assignmentBox.ResumeLayout(false);
            assignmentBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox countsBox;
        private Label NumAssignmentslbl;
        private Label NumStudentslbl;
        private TextBox numStudentsTxt;
        private TextBox numAssignmentsTxt;
        private Button submitCounts;
        private Button resetBtn;
        private GroupBox navigateBox;
        private Button lastBtn;
        private Button nextBtn;
        private Button prevBtn;
        private Button firstBtn;
        private GroupBox infoBox;
        private Button saveNameBtn;
        private TextBox nameTxt;
        private Label namelbl;
        private GroupBox assignmentBox;
        private Label assignmentScorelbl;
        private Label assignmentNumlbl;
        private Button saveScoreBtn;
        private TextBox assignmentScoreTxt;
        private TextBox assignmentNumTxt;
        private RichTextBox mainTxt;
        private Button displayScoresBtn;
        private Label numAssignmentsErr;
        private Label numStudentsErr;
        private Label pickStudentErr;
        private Label studentNameErr;
        private Label assignmentScoreErr;
        private Label assignmentSelectionErr;
    }
}
