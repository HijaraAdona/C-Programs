using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Quick_Grader
{
    public partial class Form2 : Form
    {
        private double gradeAverage; // Define a field to store the grade average

        public Form2(double initialGradeAverage)
        {
            InitializeComponent();
            gradeAverage = initialGradeAverage; // Store the initial grade average
            averageGradeValue.Text = gradeAverage.ToString("0.00");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Do nothing for now
        }

        private void remark_Click(object sender, EventArgs e)
        {

        }

        private void averageGrade_TextChanged(object sender, EventArgs e)
        {
            // Handle the text changed event of averageGradeValue
            if (double.TryParse(averageGradeValue.Text, out double newGradeAverage))
            {
                // Update the grade average
                gradeAverage = newGradeAverage;
                averageGradeValue.Text = gradeAverage.ToString("0.00");

                // Check if the new grade average is below 75
                if (newGradeAverage < 75)
                {
                    remarks.Text = "Failed";
                    remarks.ForeColor = Color.Red; // Set color to red
                }
                else
                {
                    remarks.Text = "Passed";
                    remarks.ForeColor = Color.Green; // Set color to green
                }
            }
            else
            {
                // Handle invalid input if needed
                remarks.Text = "Invalid input";
                remarks.ForeColor = Color.Black; // Set color to black or any other color you prefer for invalid input
            }
        }
    }
}
