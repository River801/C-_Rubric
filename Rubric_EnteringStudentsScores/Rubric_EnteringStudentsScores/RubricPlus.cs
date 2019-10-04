using System;
using System.Windows.Forms;
using System.IO;

namespace Rubric_EnteringStudentsScores
{
    public partial class RubricPlus : Form
    {
        private StreamWriter fileWriter; // writes data to text file

        int c = 0;          // counter
        int numOf = 0;      // size of arrays Or secondary counter

        // Arrays to be used in different event driven functions 
        string[] tName; //  To hold the separateed test name and total questions for said test.
        string[] testNames;
        string[] studentNameTestPercentRubric;

        public RubricPlus()
        { InitializeComponent(); }
        private void btnFileName_Click(object sender, EventArgs e)
        {
            btnDisplay.Visible = true;
            // create and show dialog box enabling user to save file
            DialogResult result; // result of SaveFileDialog
            string fileName; // name of file containing data

            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; // let user create file 
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // name of file to save data
            }
            // ensure that user clicked "OK"
            if (result == DialogResult.OK)
            {
                // show error if user specified invalid file
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Invalid File Name", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // save file via FileStream if user specified valid file
                    try
                    {
                        // open file with write access
                        var output = new FileStream(fileName,
                           FileMode.OpenOrCreate, FileAccess.Write);

                        // sets file to where data is written
                        fileWriter = new StreamWriter(output);
                        for (int i = 0; i < studentNameTestPercentRubric.Length; i++)
                            fileWriter.WriteLine(studentNameTestPercentRubric[i]); // writing the array to the file one line at a time
                    }
                    catch (IOException)
                    {
                        // notify user if file does not exist
                        MessageBox.Show("Error opening file", "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            fileWriter.Close(); // closing the file Writer.
        }
        private void btnHowManyTests_Click(object sender, EventArgs e)
        {
            lblHowManyTests.Text = "How many Tests";
            
            // Verifying that the user has entered digits.
            if (int.TryParse(txtHowManyTests.Text.Trim(), out int tests) && tests > 0) 
            {
                // turning off / one the visibility of buttons, labels and textboxes.
                txtNameOfTest.Visible = true; lblNameOfTest.Visible = true; btnNameOfTest.Visible = true; lblTestNumber.Visible = true;
                txtHowManyTests.Visible = false; lblHowManyTests.Visible = false; btnHowManyTests.Visible = false;
            }
            else
            {
                txtHowManyTests.Clear();    // Clearing textBox to user can enter correctly formatted data
                MessageBox.Show("Positive digits must be entered\n***********Try again***********",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHowManyTests.Focus();    // setting focus
            }
            txtNameOfTest.Focus();  // setting focus
        }
        private void btnNameOfTest_Click(object sender, EventArgs e)
        {
            txtNameOfTest.Focus(); // setting focus

            numOf = int.Parse(txtHowManyTests.Text); // Putting the size of the array into the variable numof,

            if (c == 0) // Initializing the array, but only once.
                testNames = new string[numOf];

            if (c < numOf)
            {
                // Entering the users input of "Name of the Test" into the array.
                testNames[c] = $"{txtNameOfTest.Text} ";
                txtNameOfTest.Clear();
                c++;
            }
            lblTestNumber.Text = $"{c + 1}"; // Displaying which test the user should name

            if (c >= numOf)
            {
                // turning off / one the visibility of buttons, labels and textboxes.
                txtNameOfTest.Visible = false; lblNameOfTest.Visible = false; btnNameOfTest.Visible = false; 
                txtHowMantQuestions.Visible = true; lblHowManyQuestions.Visible = true; btnHowManyQuestions.Visible = true;
                lblTestNumber.Visible = false;  lblNumQuestions.Visible = true;

                c = 0;  // resetting the counter
                lblNumQuestions.Text = testNames[c]; // Loading the label with correct data for the next stage of the program
            }
            txtHowMantQuestions.Focus();    // setting focus
        }
        private void btnHowManyQuestions_Click(object sender, EventArgs e)
        {
            txtHowMantQuestions.Focus();    // setting focus

            // Verifying that the user has entered digits.
            if (int.TryParse(txtHowMantQuestions.Text.Trim(), out int questions) && questions > 0)
            {
                c++;
                testNames[c - 1] += $"{questions} "; // Users input of the total number of question on the test entered into the array
                if (c <= testNames.Length - 1)
                {
                    lblNumQuestions.Text = testNames[c]; // loading the next test name.
                    txtHowMantQuestions.Clear();
                }
                if (c > testNames.Length - 1)
                {
                    // turning off / one the visibility of buttons, labels and textboxes.
                    txtHowMantQuestions.Visible = false;    lblHowManyQuestions.Visible = false;    btnHowManyQuestions.Visible = false;
                    txtHowManyStudents.Visible = true;     lblHowManyStudents.Visible = true;     btnHowManyStudents.Visible = true;
                    lblNumQuestions.Visible = false;        txtStudentsNameOrID.Focus();
                    c = 0; // resetting the counter
                }
                txtHowManyStudents.Focus(); // setting focus
            }
            else
            {
                txtHowMantQuestions.Clear();     // Clearing textBox to user can enter correctly formatted data
                MessageBox.Show("Possitive digits must be entered\n***********Try again***********"
                    , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHowManyTests.Focus();    // setting focus
            }
        }
        private void btnStudentsNameOrID_Click(object sender, EventArgs e)
        {
            string studentNameOrID_Temp; // Temp storage of students identifier.

            numOf = int.Parse(txtHowManyStudents.Text); // getting the array size.
            txtStudentsNameOrID.Focus();    // setting focus
            studentNameOrID_Temp = txtStudentsNameOrID.Text.Trim(); // Storing student identifer

            if (c == 0)  // Initializing the array, but only once.
                studentNameTestPercentRubric = new string[numOf];

            studentNameTestPercentRubric[c] = studentNameOrID_Temp + " "; // Inputing students identifier into the array
            c++;

            if (string.IsNullOrEmpty(txtStudentsNameOrID.Text)) // If text box is empty catch
                MessageBox.Show("Student's name or ID must be entered\n **************Try again**************",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            if (c > studentNameTestPercentRubric.Length - 1)
            {
                // turning off / one the visibility of buttons, labels and textboxes.
                txtStudentsNameOrID.Visible = false; lblStudentsNameOrID.Visible = false; btnStudentsNameOrID.Visible = false;
                txtCorrectQuestions.Visible = true; lblCorrectQuestions.Visible = true; btnCorrectQuestions.Visible = true;
                lblTest.Visible = true; lblStudent.Visible = true; lblQuestion.Visible = true;
                txtCorrectQuestions.Focus();    // setting focus

                numOf = 0;  // resetting the counter
                c = 0;      // resetting the counter

                // Loading the next set of labels with correct data
                string[] Name;
                Name = testNames[0].Split();    //  To hold the separateed test name and total questions for said test.
                lblTest.Text = $"Test: {Name[0]}";
                lblQuestion.Text = $"Total possible: {Name[1]}";
                lblStudent.Text = $"For: {studentNameTestPercentRubric[c]}";
            }
            txtStudentsNameOrID.Clear(); // clearing data
        }
        private void btnCorrectQuestions_Click(object sender, EventArgs e)
        {
            string rubric;
            string[] name;

            if (numOf == 0 && c == 0)   //  To hold the separateed test name and total questions for said test.
                tName = testNames[numOf].Split();

            if (int.TryParse(txtCorrectQuestions.Text.Trim(), out int cQuestions))   // Verifying that the user has entered digits.
            {
                if (cQuestions >= 0 && cQuestions <= int.Parse(tName[1]))   // Verifying that the number enter is in the correct range,
                {
                    if (numOf < testNames.Length) 
                    {
                        numOf++;
                        rubric = GetRubric(cQuestions, tName[1]);   // Getting the Rubric!
                        
                        studentNameTestPercentRubric[c] += $"   Test-{tName[0]}  {cQuestions}-out-of-{tName[1]}  a_Rubric_of_{rubric}";

                        if (numOf < testNames.Length)
                        {
                            tName = testNames[numOf].Split();
                            txtCorrectQuestions.Focus();    // setting focus
                            lblTest.Text = $"Test: {tName[0]}";
                            lblQuestion.Text = $"Total possible: {tName[1]}";
                            name = studentNameTestPercentRubric[c].Split();
                            lblStudent.Text = $"For: {name[0]}";
                        }
                        else
                        {
                            c++;
                            numOf = 0;  // resetting the counter
                            tName = testNames[numOf].Split(); 
                            txtCorrectQuestions.Focus();    // setting focus
                            lblTest.Text = $"Test: {tName[0]}";
                            lblQuestion.Text = $"Total possible: {tName[1]}";

                            if (c == studentNameTestPercentRubric.Length)
                            {
                                // turning off / one the visibility of buttons, labels and textboxes.
                                lblCorrectQuestions.Visible = false; txtCorrectQuestions.Visible = false; 
                                lblTest.Visible = false; lblStudent.Visible = false; lblQuestion.Visible = false;
                                btnFileName.Visible = true; btnFileName.Enabled = false; btnDisplay.Visible = true;
                                btnCorrectQuestions.Visible = false; btnClose.Visible = true; btnSave.Enabled = true;
                            }
                            else
                            {
                                name = studentNameTestPercentRubric[c].Split(); // To get just the students identifier
                                lblStudent.Text = $"For: {name[0]}";
                            }
                        }
                    }
                }
                else
                {
                    // Clearing textBox to user can enter correctly formatted data
                    MessageBox.Show("Can not be Greater than possible questions\n" +
                                        "        Nor less than zero ", "Opps", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCorrectQuestions.Focus();
                }
            }
            else
            {
                txtCorrectQuestions.Focus();    // Clearing textBox to user can enter correctly formatted data
                MessageBox.Show("Digits must be entered\n*******Try again*******", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCorrectQuestions.Clear();
            txtStudentsNameOrID.Clear();
        }
        private string GetRubric(int correct, string possiable)
        {
            /* Rubric is a scoring system for elementey schools that is in the range from 4.0 to 1.0 with .5 increment 
               1.0 being the lowest and 4.0 being the highest */
            double percent = 100 * correct / double.Parse(possiable); // Getting percentage
            string rubric = "";

            if (percent < 35)
                rubric = "1.0";
            else if (percent < 45)
                rubric = "1.5";
            else if (percent < 60)
                rubric = "2.0";
            else if (percent < 70)
                rubric = "2.5";
            else if (percent < 85)
                rubric = "3.0";
            else if (percent < 95)
                rubric = "3.5";
            else if (percent >= 95)
                rubric = "4.0";

            else        // catch if something goes wrong the message box will display this.
                MessageBox.Show("Oops! Score will not be input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return rubric;  // returnin the students rubric score.
        }
        private void RubricPlus_Load(object sender, EventArgs e)    // to hide labels until nedded
        {   lblTestNumber.Visible = false;
            lblNumQuestions.Visible = false;
            btnSave.Enabled = false;
        }
        private void btnHowManyStudents_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtHowManyStudents.Text.Trim(), out numOf) && numOf > 0)    // Verifying that the user has entered digits.
            {
                // turning off / one the visibility of buttons, labels and textboxes.
                txtHowManyStudents.Visible = false; lblHowManyStudents.Visible = false; btnHowManyStudents.Visible = false;
                txtStudentsNameOrID.Visible = true; lblStudentsNameOrID.Visible = true; btnStudentsNameOrID.Visible = true;
                txtStudentsNameOrID.Focus();    // setting focus
            }
            else
            {
                txtHowManyStudents.Clear(); // Clearing textBox to user can enter correctly formatted data
                MessageBox.Show("Positive digits must be entered\n***********Try again***********",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHowManyStudents.Focus();
            }
            c = 0;  // resetting the counter
        }
        private void lblNameOfTest_Click(object sender, EventArgs e)    {}
        private void btnDisplay_Click(object sender, EventArgs e)
        {   // Opening a new form to display a array
            Display ds = new Display(studentNameTestPercentRubric);
            ds.Show();
        }
        private void btnClose_Click(object sender, EventArgs e) {
            Close();    /* exit the program */  }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    int len = studentNameTestPercentRubric.Length;
                    for (int c = 0; c < len; c++)
                    {
                        sw.WriteLine(studentNameTestPercentRubric[c]);
                    }
                }
            }                  
        }   
    }
}