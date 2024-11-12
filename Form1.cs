using System.Diagnostics.Metrics;

namespace Assignment3WinForms
{
    public partial class Form1 : Form
    {
        #region Attributes
        /// <summary>
        /// All global variables for the document
        /// </summary>
        /// records number 
        int numStudents = 1;
        /// <summary>
        /// records number of assignments
        /// </summary>
        int numAssignments = 1;
        /// <summary>
        /// records current selected student
        /// </summary>
        int studentPointer = 0;

        /// <summary>
        /// initializes an empty students array but then I'm not sure how to resize it properly without making it a list
        /// </summary>
        string[] Students;
        /// <summary>
        /// initializes an empty Assignments array but then I'm not sure how to resize it properly without making it a list
        /// </summary>
        int[,] Assignments;

        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NumStudentsTxt_Click(object sender, EventArgs e)
        {

        }

        #region CreateArrays

        /// <summary>
        /// This will save the numstudents and numassignments if inputted correctly and make the appropriate arrays
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitCounts_Click(object sender, EventArgs e)
        {
            ///check if the input is a number
            if (Int32.TryParse(numStudentsTxt.Text, out numStudents) == true)
            {
                ///if it is a number check if it is in range
                if (numStudents < 1 || numStudents > 10)
                {
                    ///show wrong label if the number is out of range
                    numStudentsErr.Visible = true;
                    ///delete invalid response
                    numStudentsTxt.Text = "";
                    ///return to stop running code due to an incorrect input
                    return;
                }
            }
            else
            {
                ///show wrong label if the input is not a string
                numStudentsErr.Visible = true;
                ///delete invalid response
                numStudentsTxt.Text = "";
                ///return to stop running code due to an incorrect input
                return;
            }

            ///if you made it to this point it means the numStudents is a valid input 
            ///hide wrong label if the number is valid
            numStudentsErr.Visible = false;
            ///wonka is beast callie is beast check if the input is a number
            if (Int32.TryParse(numAssignmentsTxt.Text, out numAssignments) == true)
            {
                ///if it is a number check if it is in range
                if (numAssignments < 1 || numAssignments > 99)
                {
                    ///show wrong label if the number is out of range
                    numAssignmentsErr.Visible = true;
                    ///delete invalid response
                    numAssignmentsTxt.Text = "";
                    ///return to stop running code due to an incorrect input
                    return;
                }
            }
            else
            {
                ///show wrong label if the input is not a string
                numAssignmentsErr.Visible = true;
                ///delete invalid response
                numAssignmentsTxt.Text = "";
                ///return to stop running code due to an incorrect input
                return;
            }
            ///hide wrong label if the number is valid
            numAssignmentsErr.Visible = false;

            /// <summary>
            /// Create the array for students
            /// </summary>
            Students = new string[numStudents];

            /// <summary>
            /// create the array for assignments
            /// </summary>
            Assignments = new int[numStudents, numAssignments];

            ///disable the numStudents textbox
            numStudentsTxt.Enabled = false;
            ///disable the numAssignments textbox
            numAssignmentsTxt.Enabled = false;
            ///disable the submit counts button until the reset is hit
            submitCounts.Enabled = false;

            ///reenable all of the textboxes and the buttons outside of the counts group
            ///reenable the reset button
            resetBtn.Enabled = true;
            ///reenable the first button
            firstBtn.Enabled = true;
            ///reenable the prev button
            prevBtn.Enabled = true;
            ///reenable the next button
            nextBtn.Enabled = true;
            ///reenable the last button
            lastBtn.Enabled = true;
            ///reenable the name textbox
            nameTxt.Enabled = true;
            ///reenable the save name button
            saveNameBtn.Enabled = true;
            ///reenable the assignement number textbox
            assignmentNumTxt.Enabled = true;
            ///reenable the assignment score textbox
            assignmentScoreTxt.Enabled = true;
            ///reenable the save score button
            saveScoreBtn.Enabled = true;
            ///reenable the display scores button
            displayScoresBtn.Enabled = true;
            ///this reenables the richtextbox, I am commenting it out to prevent people from typing in it 
            ///mainTxt.Enabled = true;
            assignmentNumlbl.Text = $"Enter Assignment Number (1-" + numAssignments + "):";
        }

        #endregion

        /// <summary>
        /// This will reset all textboxes and buttons to their initial state which is either enabled or disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetBtn_Click(object sender, EventArgs e)
        {
            ///reset text on richtextbox
            mainTxt.Text = "";

            ///enable/disable necessary sections of the group called counts
            ///reenable the numStudents textbox
            numStudentsTxt.Enabled = true;
            ///reset textbox text
            numStudentsTxt.Text = "";
            ///reenable the numAssignments textbox
            numAssignmentsTxt.Enabled = true;
            ///reset textbox text
            numAssignmentsTxt.Text = "";
            ///reenable the submit counts button until the reset is hit
            submitCounts.Enabled = true;
            ///disable error label
            numAssignmentsErr.Visible = false;

            ///disable the reset button
            resetBtn.Enabled = false;

            ///disable all of the textboxes and the buttons that arent a part of the group called Navigate
            ///disable the first button
            firstBtn.Enabled = false;
            ///disable the prev button
            prevBtn.Enabled = false;
            ///disable the next button
            nextBtn.Enabled = false;
            ///disable the last button
            lastBtn.Enabled = false;
            ///disable error label
            pickStudentErr.Visible = false;


            ///disable everything necessary in the student info group
            ///disable the name textbox
            nameTxt.Enabled = false;
            ///reset text
            nameTxt.Text = "";
            ///disable the save name button
            saveNameBtn.Enabled = false;
            ///disable error label
            studentNameErr.Visible = false;

            ///disable everything necessary in the Assignment Info. group
            ///disable the assignement number textbox
            assignmentNumTxt.Enabled = false;
            ///reset textbox text
            assignmentNumTxt.Text = "";
            ///disable the assignment score textbox
            assignmentScoreTxt.Enabled = false;
            ///reset textbox text
            assignmentScoreTxt.Text = "";
            ///disable the save score button
            saveScoreBtn.Enabled = false;
            ///hide error label
            assignmentSelectionErr.Visible = false;
            ///hide error label
            assignmentScoreErr.Visible = false;

            ///disable the display scores button
            displayScoresBtn.Enabled = false;
            ///reset name textbox
            nameTxt.Text = "";
        }

        /// <summary>
        /// This will reset the studentPointer and student number label to the start position
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstBtn_Click(object sender, EventArgs e)
        {
            ///set it to 0
            studentPointer = 0;
            ///display the student pointer location
            namelbl.Text = $"Student #" + (studentPointer + 1) + ":";
            ///reset name textbox
            nameTxt.Text = "";

            ///disable error label
            pickStudentErr.Visible = false;
        }

        /// <summary>
        /// This will move the student pointer and student number label one downwards while staying at least 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void prevBtn_Click(object sender, EventArgs e)
        {
            ///if pointer is greater than 0 decrement
            if (studentPointer > 0)
            {
                ///decrement pointer
                studentPointer--;
                ///disable error label
                pickStudentErr.Visible = false;
            }
            else
            {
                ///enable error label
                pickStudentErr.Visible = true;
            }
            ///display the student pointer location
            namelbl.Text = $"Student #" + (studentPointer + 1) + ":";

            ///reset name textbox
            nameTxt.Text = "";
        }

        /// <summary>
        /// This will increment the student pointer and student number label as long as it stays in bounds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextBtn_Click(object sender, EventArgs e)
        {
            ///if below max increment pointer
            if (studentPointer < (numStudents - 1))
            {
                ///increment pointer
                studentPointer++;
                ///disable error label
                pickStudentErr.Visible = false;
            }
            else
            {
                ///enable error label
                pickStudentErr.Visible = true;
            }
            ///display the student pointer location
            namelbl.Text = $"Student #" + (studentPointer + 1) + ":";

            ///reset name textbox
            nameTxt.Text = "";
        }

        /// <summary>
        /// This will take the student pointer and student number label to the highest number in bounds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lastBtn_Click(object sender, EventArgs e)
        {
            ///go to the max sutdent pointer value
            studentPointer = numStudents - 1;
            ///display the student pointer location
            namelbl.Text = $"Student #" + (studentPointer + 1) + ":";

            ///reset name textbox
            nameTxt.Text = "";

            ///disable error label
            pickStudentErr.Visible = false;
        }

        /// <summary>
        /// Validate name typed by user and save it in array if valid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveNameBtn_Click(object sender, EventArgs e)
        {
            ///check if the box is empty
            if (nameTxt.Text == "" || nameTxt.Text == " ")
            {
                ///show error message
                studentNameErr.Visible = true;
                ///reset name textbox
                nameTxt.Text = "";
                ///return to exit method
                return;
            }

            ///loop through each character in the name textbox
            foreach (char c in nameTxt.Text)
            {
                ///check if each character is a digit or symbol, if so exit method
                if (char.IsDigit(c))
                {
                    ///show error message
                    studentNameErr.Visible = true;
                    ///reset name textbox
                    nameTxt.Text = "";
                    ///return to exit method
                    return;
                }
            }
            ///remove error message
            studentNameErr.Visible = false;
            ///if validated store the text from user into the value at the studentpointer in the students array
            Students[studentPointer] = nameTxt.Text;

            ///hide text to show user it is submitted
            nameTxt.Text = "";
        }

        /// <summary>
        /// This method will save the score into the appropriate assignment for the student pointed at by the student pointer if the inputs are valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveScoreBtn_Click(object sender, EventArgs e)
        {
            

            ///local variable to store assignment number if input is a number
            int assignmentNum = 0;
            ///local variable to store assignment score if input is a number
            int assignmentScore = 0;
            ///check if the assignment num input is a number
            if (Int32.TryParse(assignmentNumTxt.Text, out assignmentNum) == true)
            {
                ///if it is a number check if it is in range, if out of range show so
                if (assignmentNum < 1 || assignmentNum > numAssignments)
                {
                    ///show wrong label if the number is out of range
                    assignmentSelectionErr.Visible = true;
                    ///delete invalid response
                    assignmentNumTxt.Text = "";
                    ///return to stop running code due to an incorrect input
                    return;
                }
            }
            else
            {
                ///show wrong label if the input is not a string
                assignmentSelectionErr.Visible = true;
                ///delete invalid response
                assignmentNumTxt.Text = "";
                ///return to stop running code due to an incorrect input
                return;
            }

            ///hide error label if it was being displayed
            assignmentSelectionErr.Visible = false;
            
            ///check if the assignment score input is a number
            if (Int32.TryParse(assignmentScoreTxt.Text, out assignmentScore) == true)
            {
                ///if it is a number check if it is in range, if out of range show so
                if (assignmentScore < 0 || assignmentScore > 100)
                {
                    ///show wrong label if the number is out of range
                    assignmentScoreErr.Visible = true;
                    ///delete invalid response
                    assignmentScoreTxt.Text = "";
                    ///return to stop running code due to an incorrect input
                    return;
                }
            }
            else
            {
                ///show wrong label if the input is not a string
                assignmentScoreErr.Visible = true;
                ///delete invalid response
                assignmentScoreTxt.Text = "";
                ///return to stop running code due to an incorrect input
                return;
            }

            
            ///hide error label if it was being displayed
            assignmentScoreErr.Visible = false;

            ///Update score using studentpointer, shown in the navigate bar, and the assignmentnum - 1 because it is indexed to zero
            Assignments[studentPointer, assignmentNum - 1] = assignmentScore;

            ///hide text to show user it is submitted
            assignmentScoreTxt.Text = "";

            ///hide text to show user it is submitted
            assignmentNumTxt.Text = "";


        }

        #region DisplayScore

        /// <summary>
        /// This will update the richtextbox with the new inormation typed above to display the student names, assignment scores, averages, and letter grades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void displayScoresBtn_Click(object sender, EventArgs e)
        {
            ///reset text on richtextbox
            mainTxt.Text = "";

            ///display student
            mainTxt.AppendText($"STUDENT  \t  \t");
            ///loop number of students and display number
            for (int i = 1; i < numAssignments + 1; i++)
            {
                ///display number student number
                mainTxt.AppendText($"#" + i + "\t");

            }
            ///display average and grade
            mainTxt.AppendText($"AVG\tGRADE\n");

            ///local variable to calculate average
            int average = 0;

            ///loop through rows(names) in the Assignments array
             for (int i = 0; i < Assignments.GetLength(0); i++)
            {
                ///add student names
                mainTxt.AppendText(Students[i] + "\t\t\t");
                ///reset average
                average = 0;
                ///loop through columns(assignments) in the Assignments array
                 for (int j = 0; j < Assignments.GetLength(1); j++)
                {
                    ///add assignment scores
                    mainTxt.AppendText(Assignments[i, j] + "\t");
                    ///find sum of assignment scores
                    average += Assignments[i, j];
                }
                 ///divide by the number of assignments to find average
                average = average / numAssignments;
                ///display the average
                mainTxt.AppendText(average + "\t");

                ///CALCULATE LETTER GRADE
                ///set equal to E initially
                string letterGrade = "E";
                ///if greater than or equal to 60 set letter grade to D-
                if (average >= 60)
                {
                    letterGrade = "D-";
                }
                ///if greater than or equal to 63 set letter grade to D
                if (average >= 63)
                {
                    letterGrade = "D";
                }
                ///if greater than or equal to 67 set letter grade to D+
                if (average >= 67)
                {
                    letterGrade = "D+";
                }
                ///if greater than or equal to 70 set letter grade to C-
                if (average >= 70)
                {
                    letterGrade = "C-";
                }
                ///if greater than or equal to 73 set letter grade to C
                if (average >= 73)
                {
                    letterGrade = "C";
                }
                ///if greater than or equal to 77 set letter grade to C+
                if (average >= 77)
                {
                    letterGrade = "C+";
                }
                ///if greater than or equal to 80 set letter grade to B-
                if (average >= 80)
                {
                    letterGrade = "B-";
                }
                ///if greater than or equal to 83 set letter grade to B
                if (average >= 83)
                {
                    letterGrade = "B";
                }
                ///if greater than or equal to 87 set letter grade to B+
                if (average >= 87)
                {
                    letterGrade = "B+";
                }
                ///if greater than or equal to 90 set letter grade to A-
                if (average >= 90)
                {
                    letterGrade = "A-";
                }
                ///if greater than or equal to 93 set letter grade to A
                if (average >= 93)
                {
                    letterGrade = "A";
                }
                ///Display letter grade once computed
                mainTxt.AppendText(letterGrade + "\n");
            }

            
        }
        #endregion
        /// <summary>
        /// This method will return the average of all of the assignments under this sutdents name. It felt easier to implement this code above.
        /// This method is unused but I left it because it easily shows the logic of the code above in a different fashion for my notes.
        /// </summary>
        /// <param name="studentNum"></param>
        /// <returns></returns>
        private int Average(int studentNum)
        {
            ///local variable to calculate average
            int Average = 0;
            ///This local variable will calculate 
            int assignmentsSum = 0;

            ///loop through all assignments for this student
            for(int i =0; i< numAssignments; i++)
            {
                ///add sum of each assignment
                assignmentsSum += Assignments[studentNum, i];
            }
            ///divide by number of assignments to give average
            Average = assignmentsSum / numAssignments;
            ///return average
            return Average;
        }
        
        private void infoBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
