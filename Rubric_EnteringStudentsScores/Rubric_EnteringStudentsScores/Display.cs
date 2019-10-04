// This form is to display finished of the RUBRIC at user request.  
using System;
using System.Windows.Forms;

namespace Rubric_EnteringStudentsScores
{
    public partial class Display : Form
    {
        public Display(string[] arr)
        {
            InitializeComponent();
            //   Display the Array of the students names, tests and scores.
            for (int i = 0; i < arr.Length; i++)
                txtDisplay.Text += $"{arr[i]}\r\n\r\n";
        }            
        private void button1_Click(object sender, EventArgs e)  {
            Close();     /* exit the program */   }
    }
}