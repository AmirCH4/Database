namespace FinalProject
{
    partial class AddForm
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
            this.StudentIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.StudentFNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentLNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentBirthdateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StudentAddButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LessonCreditComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LessonAddButton = new System.Windows.Forms.Button();
            this.LessonIDTextBox = new System.Windows.Forms.TextBox();
            this.LessonNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CourseGradeComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CourseAddButton = new System.Windows.Forms.Button();
            this.CourseStudentIDTextBox = new System.Windows.Forms.TextBox();
            this.CourseLessonIDTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentIDTextBox
            // 
            this.StudentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIDTextBox.Location = new System.Drawing.Point(146, 15);
            this.StudentIDTextBox.MaxLength = 10;
            this.StudentIDTextBox.Name = "StudentIDTextBox";
            this.StudentIDTextBox.Size = new System.Drawing.Size(122, 26);
            this.StudentIDTextBox.TabIndex = 0;
            this.StudentIDTextBox.TextChanged += new System.EventHandler(this.StudentIDTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(297, 131);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(100, 26);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // StudentFNameTextBox
            // 
            this.StudentFNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFNameTextBox.Location = new System.Drawing.Point(146, 51);
            this.StudentFNameTextBox.MaxLength = 50;
            this.StudentFNameTextBox.Name = "StudentFNameTextBox";
            this.StudentFNameTextBox.Size = new System.Drawing.Size(122, 26);
            this.StudentFNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // StudentLNameTextBox
            // 
            this.StudentLNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentLNameTextBox.Location = new System.Drawing.Point(146, 87);
            this.StudentLNameTextBox.MaxLength = 50;
            this.StudentLNameTextBox.Name = "StudentLNameTextBox";
            this.StudentLNameTextBox.Size = new System.Drawing.Size(122, 26);
            this.StudentLNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birthday date:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.StudentBirthdateTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.StudentAddButton);
            this.groupBox1.Controls.Add(this.BrowseButton);
            this.groupBox1.Controls.Add(this.StudentIDTextBox);
            this.groupBox1.Controls.Add(this.StudentFNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StudentLNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 224);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(297, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StudentBirthdateTextBox
            // 
            this.StudentBirthdateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentBirthdateTextBox.Location = new System.Drawing.Point(146, 122);
            this.StudentBirthdateTextBox.Mask = "00/00/0000";
            this.StudentBirthdateTextBox.Name = "StudentBirthdateTextBox";
            this.StudentBirthdateTextBox.Size = new System.Drawing.Size(122, 26);
            this.StudentBirthdateTextBox.TabIndex = 3;
            this.StudentBirthdateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentAddButton
            // 
            this.StudentAddButton.Enabled = false;
            this.StudentAddButton.Location = new System.Drawing.Point(6, 176);
            this.StudentAddButton.Name = "StudentAddButton";
            this.StudentAddButton.Size = new System.Drawing.Size(396, 26);
            this.StudentAddButton.TabIndex = 2;
            this.StudentAddButton.Text = "Add";
            this.StudentAddButton.UseVisualStyleBackColor = true;
            this.StudentAddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LessonCreditComboBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.LessonAddButton);
            this.groupBox2.Controls.Add(this.LessonIDTextBox);
            this.groupBox2.Controls.Add(this.LessonNameTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(441, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 224);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Lesson";
            // 
            // LessonCreditComboBox
            // 
            this.LessonCreditComboBox.DropDownHeight = 80;
            this.LessonCreditComboBox.FormattingEnabled = true;
            this.LessonCreditComboBox.IntegralHeight = false;
            this.LessonCreditComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.LessonCreditComboBox.Location = new System.Drawing.Point(146, 90);
            this.LessonCreditComboBox.Name = "LessonCreditComboBox";
            this.LessonCreditComboBox.Size = new System.Drawing.Size(170, 24);
            this.LessonCreditComboBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name:";
            // 
            // LessonAddButton
            // 
            this.LessonAddButton.Enabled = false;
            this.LessonAddButton.Location = new System.Drawing.Point(6, 176);
            this.LessonAddButton.Name = "LessonAddButton";
            this.LessonAddButton.Size = new System.Drawing.Size(396, 26);
            this.LessonAddButton.TabIndex = 2;
            this.LessonAddButton.Text = "Add";
            this.LessonAddButton.UseVisualStyleBackColor = true;
            this.LessonAddButton.Click += new System.EventHandler(this.LessonAddButton_Click);
            // 
            // LessonIDTextBox
            // 
            this.LessonIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonIDTextBox.Location = new System.Drawing.Point(146, 15);
            this.LessonIDTextBox.MaxLength = 10;
            this.LessonIDTextBox.Name = "LessonIDTextBox";
            this.LessonIDTextBox.Size = new System.Drawing.Size(170, 26);
            this.LessonIDTextBox.TabIndex = 0;
            this.LessonIDTextBox.TextChanged += new System.EventHandler(this.LessonIDTextBox_TextChanged);
            // 
            // LessonNameTextBox
            // 
            this.LessonNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessonNameTextBox.Location = new System.Drawing.Point(146, 51);
            this.LessonNameTextBox.MaxLength = 50;
            this.LessonNameTextBox.Name = "LessonNameTextBox";
            this.LessonNameTextBox.Size = new System.Drawing.Size(170, 26);
            this.LessonNameTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Credit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CourseGradeComboBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.CourseAddButton);
            this.groupBox3.Controls.Add(this.CourseStudentIDTextBox);
            this.groupBox3.Controls.Add(this.CourseLessonIDTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 224);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Course";
            // 
            // CourseGradeComboBox
            // 
            this.CourseGradeComboBox.DropDownHeight = 80;
            this.CourseGradeComboBox.FormattingEnabled = true;
            this.CourseGradeComboBox.IntegralHeight = false;
            this.CourseGradeComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.CourseGradeComboBox.Location = new System.Drawing.Point(146, 90);
            this.CourseGradeComboBox.Name = "CourseGradeComboBox";
            this.CourseGradeComboBox.Size = new System.Drawing.Size(170, 24);
            this.CourseGradeComboBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Lesson ID:";
            // 
            // CourseAddButton
            // 
            this.CourseAddButton.Enabled = false;
            this.CourseAddButton.Location = new System.Drawing.Point(6, 176);
            this.CourseAddButton.Name = "CourseAddButton";
            this.CourseAddButton.Size = new System.Drawing.Size(396, 26);
            this.CourseAddButton.TabIndex = 2;
            this.CourseAddButton.Text = "Add";
            this.CourseAddButton.UseVisualStyleBackColor = true;
            this.CourseAddButton.Click += new System.EventHandler(this.CourseAddButton_Click);
            // 
            // CourseStudentIDTextBox
            // 
            this.CourseStudentIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseStudentIDTextBox.Location = new System.Drawing.Point(146, 15);
            this.CourseStudentIDTextBox.MaxLength = 10;
            this.CourseStudentIDTextBox.Name = "CourseStudentIDTextBox";
            this.CourseStudentIDTextBox.Size = new System.Drawing.Size(170, 26);
            this.CourseStudentIDTextBox.TabIndex = 0;
            this.CourseStudentIDTextBox.TextChanged += new System.EventHandler(this.CourseStudentIDTextBox_TextChanged);
            // 
            // CourseLessonIDTextBox
            // 
            this.CourseLessonIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseLessonIDTextBox.Location = new System.Drawing.Point(146, 51);
            this.CourseLessonIDTextBox.MaxLength = 10;
            this.CourseLessonIDTextBox.Name = "CourseLessonIDTextBox";
            this.CourseLessonIDTextBox.Size = new System.Drawing.Size(170, 26);
            this.CourseLessonIDTextBox.TabIndex = 0;
            this.CourseLessonIDTextBox.TextChanged += new System.EventHandler(this.CourseLessonIDTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Grade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Student ID:";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 475);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(877, 522);
            this.MinimumSize = new System.Drawing.Size(877, 522);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add to Database";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox StudentIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox StudentFNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentLNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StudentAddButton;
        private System.Windows.Forms.MaskedTextBox StudentBirthdateTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LessonAddButton;
        private System.Windows.Forms.TextBox LessonIDTextBox;
        private System.Windows.Forms.TextBox LessonNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CourseAddButton;
        private System.Windows.Forms.TextBox CourseStudentIDTextBox;
        private System.Windows.Forms.TextBox CourseLessonIDTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LessonCreditComboBox;
        private System.Windows.Forms.ComboBox CourseGradeComboBox;
    }
}