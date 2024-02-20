namespace Quick_Grader
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            remarks = new Label();
            averageGradeValue = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(192, 31);
            label1.TabIndex = 0;
            label1.Text = "Grade Summary:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 104);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 1;
            label2.Text = "Grade Average:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 176);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Remarks: ";
            // 
            // remarks
            // 
            remarks.AutoSize = true;
            remarks.Location = new Point(259, 176);
            remarks.Name = "remarks";
            remarks.Size = new Size(72, 20);
            remarks.TabIndex = 3;
            remarks.Text = "Remarks: ";
            remarks.Click += remark_Click;
            // 
            // averageGradeValue
            // 
            averageGradeValue.Location = new Point(259, 104);
            averageGradeValue.Name = "averageGradeValue";
            averageGradeValue.Size = new Size(72, 27);
            averageGradeValue.TabIndex = 4;
            averageGradeValue.TextChanged += averageGrade_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 450);
            Controls.Add(averageGradeValue);
            Controls.Add(remarks);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label remarks;
        private TextBox averageGradeValue;
    }
}