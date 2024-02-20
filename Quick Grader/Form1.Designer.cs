namespace Quick_Grader
{
    partial class semisRem
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
            label1 = new Label();
            label2 = new Label();
            firstGrade = new Label();
            secondGrade = new Label();
            thirdGrade = new Label();
            fourthGrade = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            generateGrade = new Button();
            finalsMark = new Label();
            semiMark = new Label();
            midMark = new Label();
            preMark = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold);
            label1.Location = new Point(31, 27);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 0;
            label1.Text = "Quick Grader";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold);
            label2.Location = new Point(31, 84);
            label2.Name = "label2";
            label2.Size = new Size(104, 30);
            label2.TabIndex = 1;
            label2.Text = "Quarter";
            // 
            // firstGrade
            // 
            firstGrade.AutoSize = true;
            firstGrade.Font = new Font("Mongolian Baiti", 10.8F);
            firstGrade.Location = new Point(35, 140);
            firstGrade.Name = "firstGrade";
            firstGrade.Size = new Size(116, 19);
            firstGrade.TabIndex = 3;
            firstGrade.Text = "Prelim Grade: ";
            firstGrade.Click += firstGrade_Click;
            // 
            // secondGrade
            // 
            secondGrade.AutoSize = true;
            secondGrade.Font = new Font("Mongolian Baiti", 10.8F);
            secondGrade.Location = new Point(35, 185);
            secondGrade.Name = "secondGrade";
            secondGrade.Size = new Size(131, 19);
            secondGrade.TabIndex = 4;
            secondGrade.Text = "Midterm Grade: ";
            secondGrade.Click += secondGrade_Click;
            // 
            // thirdGrade
            // 
            thirdGrade.AutoSize = true;
            thirdGrade.Font = new Font("Mongolian Baiti", 10.8F);
            thirdGrade.Location = new Point(35, 233);
            thirdGrade.Name = "thirdGrade";
            thirdGrade.Size = new Size(148, 19);
            thirdGrade.TabIndex = 5;
            thirdGrade.Text = "Semi-Final Grade: ";
            thirdGrade.Click += thirdGrade_Click;
            // 
            // fourthGrade
            // 
            fourthGrade.AutoSize = true;
            fourthGrade.Font = new Font("Mongolian Baiti", 10.8F);
            fourthGrade.Location = new Point(35, 279);
            fourthGrade.Name = "fourthGrade";
            fourthGrade.Size = new Size(112, 19);
            fourthGrade.TabIndex = 6;
            fourthGrade.Text = "Finals Grade: ";
            fourthGrade.Click += fourthGrade_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold);
            label3.Location = new Point(253, 86);
            label3.Name = "label3";
            label3.Size = new Size(85, 30);
            label3.TabIndex = 7;
            label3.Text = "Grade";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Mongolian Baiti", 10.8F);
            textBox1.Location = new Point(255, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(83, 28);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Mongolian Baiti", 10.8F);
            textBox2.Location = new Point(255, 178);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(83, 28);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Mongolian Baiti", 10.8F);
            textBox3.Location = new Point(255, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(83, 28);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Mongolian Baiti", 10.8F);
            textBox4.Location = new Point(255, 276);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(83, 28);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold);
            label8.Location = new Point(447, 83);
            label8.Name = "label8";
            label8.Size = new Size(119, 30);
            label8.TabIndex = 12;
            label8.Text = "Remarks";
            // 
            // generateGrade
            // 
            generateGrade.Font = new Font("Mongolian Baiti", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            generateGrade.Location = new Point(457, 329);
            generateGrade.Name = "generateGrade";
            generateGrade.Size = new Size(148, 29);
            generateGrade.TabIndex = 20;
            generateGrade.Text = "Generate Grade";
            generateGrade.UseVisualStyleBackColor = true;
            generateGrade.Click += generateGrade_Click;
            // 
            // finalsMark
            // 
            finalsMark.AutoSize = true;
            finalsMark.Font = new Font("Candara", 12F, FontStyle.Bold);
            finalsMark.Location = new Point(454, 279);
            finalsMark.Name = "finalsMark";
            finalsMark.Size = new Size(78, 24);
            finalsMark.TabIndex = 22;
            finalsMark.Text = "                 ";
            finalsMark.Click += finalsMark_Click;
            // 
            // semiMark
            // 
            semiMark.AutoSize = true;
            semiMark.Font = new Font("Candara", 12F, FontStyle.Bold);
            semiMark.Location = new Point(454, 227);
            semiMark.Name = "semiMark";
            semiMark.Size = new Size(78, 24);
            semiMark.TabIndex = 23;
            semiMark.Text = "                 ";
            semiMark.Click += semiMark_Click;
            // 
            // midMark
            // 
            midMark.AutoSize = true;
            midMark.Font = new Font("Candara", 12F, FontStyle.Bold);
            midMark.Location = new Point(454, 178);
            midMark.Name = "midMark";
            midMark.Size = new Size(78, 24);
            midMark.TabIndex = 24;
            midMark.Text = "                 ";
            midMark.Click += midMark_Click;
            // 
            // preMark
            // 
            preMark.AutoSize = true;
            preMark.Font = new Font("Candara", 12F, FontStyle.Bold);
            preMark.Location = new Point(454, 136);
            preMark.Name = "preMark";
            preMark.Size = new Size(78, 24);
            preMark.TabIndex = 25;
            preMark.Text = "                 ";
            preMark.Click += preMark_Click;
            // 
            // semisRem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 379);
            Controls.Add(preMark);
            Controls.Add(midMark);
            Controls.Add(semiMark);
            Controls.Add(finalsMark);
            Controls.Add(generateGrade);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(fourthGrade);
            Controls.Add(thirdGrade);
            Controls.Add(secondGrade);
            Controls.Add(firstGrade);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "semisRem";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label firstGrade;
        private Label secondGrade;
        private Label thirdGrade;
        private Label fourthGrade;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private Label finalRem;
        private Label semiRem;
        private Label midRem;
        private Button generateGrade;
        private Label finalsMark;
        private Label semiMark;
        private Label midMark;
        private Label preMark;
    }
}
