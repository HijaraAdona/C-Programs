namespace Quick_Grader
{
    public partial class semisRem : Form
    {
        public semisRem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateGrade_Click(object sender, EventArgs e)
        {
            if (!ValidInput(textBox1.Text) || !ValidInput(textBox2.Text) ||
        !ValidInput(textBox3.Text) || !ValidInput(textBox4.Text))
            {
                MessageBox.Show("Invalid input! Please enter valid grades that are above 60 and below 99.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if input is invalid
            }
            double numberofQuarters = 4;

            double firstGrade = double.Parse(textBox1.Text);
            double secondGrade = double.Parse(textBox2.Text);
            double thirdGrade = double.Parse(textBox3.Text);
            double fourthGrade = double.Parse(textBox4.Text);

            double gradeSum = firstGrade + secondGrade + thirdGrade + fourthGrade;
            double gradeAverage = gradeSum / numberofQuarters;

            Form2 form2 = new Form2(gradeAverage);
            form2.Show();
        }
        private bool ValidInput(string input)
        {
            if (!double.TryParse(input, out double grade))
                return false; // Not a valid double
            return grade >= 60 && grade <= 99; // Check if grade is between 60 and 99
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            preMark.Text = "";

            // Check if textBox1.Text is a valid number
            if (double.TryParse(textBox1.Text, out double textBox1Value))
            {
                // Compare the parsed value with 75
                if (textBox1Value < 60 || textBox1Value > 99)
                {
                    preMark.Text = "Must be above 60 and below 99";
                }
                else
                {
                    if (textBox1Value < 75)
                    {
                        preMark.Text = "FAILED";
                        preMark.ForeColor = Color.Red; // Set color to green
                    }

                    else
                    {
                        preMark.Text = "PASSED";
                        preMark.ForeColor = Color.Green; // Set color to green
                    }
                }
            }
            else
            {
                // Handle invalid input
                preMark.Text = "Invalid input";
                preMark.ForeColor = Color.Black; // Set color to black or any other color you prefer for invalid input
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            midMark.Text = "";

            // Check if textBox1.Text is a valid number
            if (double.TryParse(textBox2.Text, out double textBox2Value))
            {
                if (textBox2Value < 60 || textBox2Value > 99)
                {
                    midMark.Text = "Must be above 60 and below 99";
                }
                else
                {
                    // Compare the parsed value with 75
                    if (textBox2Value < 75)
                    {
                        midMark.Text = "FAILED";
                        midMark.ForeColor = Color.Red; // Set color to red
                    }
                    else
                    {
                        midMark.Text = "PASSED";
                        midMark.ForeColor = Color.Green; // Set color to green
                    }
                }
            }
            else
            {
                // Handle invalid input
                midMark.Text = "Invalid input";
                midMark.ForeColor = Color.Black; // Set color to black or any other color you prefer for invalid input
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            semiMark.Text = "";

            // Check if textBox1.Text is a valid number
            if (double.TryParse(textBox3.Text, out double textBox3Value))
            {
                if (textBox3Value < 60 || textBox3Value > 99)
                {
                    semiMark.Text = "Must be above 60 and below 99";
                }
                else
                {
                    // Compare the parsed value with 75
                    if (textBox3Value < 75)
                    {
                        semiMark.Text = "FAILED";
                        semiMark.ForeColor = Color.Red; // Set color to red
                    }
                    else
                    {
                        semiMark.Text = "PASSED";
                        semiMark.ForeColor = Color.Green; // Set color to green
                    }
                }
            }
            else
            {
                // Handle invalid input
                semiMark.Text = "Invalid input";
                semiMark.ForeColor = Color.Black; // Set color to black or any other color you prefer for invalid input
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            finalsMark.Text = "";

            // Check if textBox4.Text is a valid number
            if (double.TryParse(textBox4.Text, out double textBox4Value))
            {
                if (textBox4Value < 60 || textBox4Value > 99)
                {
                    finalsMark.Text = "Must be above 60 and below 99";
                }
                else
                {
                    // Compare the parsed value with 75
                    if (textBox4Value < 75)
                    {
                        finalsMark.Text = "FAILED";
                        finalsMark.ForeColor = Color.Red; // Set color to red
                    }
                    else
                    {
                        finalsMark.Text = "PASSED";
                        finalsMark.ForeColor = Color.Green; // Set color to green
                    }
                }
            }
            else
            {
                // Handle invalid input
                finalsMark.Text = "Invalid input";
                finalsMark.ForeColor = Color.Black; // Set color to black or any other color you prefer for invalid input
            }
        }

        private void preMark_Click(object sender, EventArgs e)
        {

        }

        private void midMark_Click(object sender, EventArgs e)
        {

        }

        private void semiMark_Click(object sender, EventArgs e)
        {

        }

        private void finalsMark_Click(object sender, EventArgs e)
        {

        }

        private void firstGrade_Click(object sender, EventArgs e)
        {

        }

        private void secondGrade_Click(object sender, EventArgs e)
        {

        }

        private void thirdGrade_Click(object sender, EventArgs e)
        {

        }

        private void fourthGrade_Click(object sender, EventArgs e)
        {

        }
    }
}