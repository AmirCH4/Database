using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class UpdateForm : Form
    {
        DataClasses1DataContext Database;

        string imagePath;
        public UpdateForm(DataClasses1DataContext refDatabase)
        {
            Database = refDatabase;
            InitializeComponent();
        }


        private void StudentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StudentIDTextBox.Text != string.Empty)
                StudentButton.Enabled = true;
            else
                StudentButton.Enabled = false;
        }
        private void LessonIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LessonIDTextBox.Text != string.Empty)
                LessonButton.Enabled = true;
            else
                LessonButton.Enabled = false;
        }
        private void CourseStudentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CourseStudentIDTextBox.Text != string.Empty && CourseLessonIDTextBox.Text != String.Empty)
                CourseButton.Enabled = true;
            else
                CourseButton.Enabled = false;
        }
        private void CourseLessonIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CourseStudentIDTextBox.Text != string.Empty && CourseLessonIDTextBox.Text != String.Empty)
                CourseButton.Enabled = true;
            else
                CourseButton.Enabled = false;
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            if (StudentButton.Text == "Search")
            {
                List<Student> table = Database.SearchStudent(StudentIDTextBox.Text).ToList();
                if (table.Count != 0)
                    try
                    {
                        StudentIDTextBox.Enabled = false;
                        StudentFNameTextBox.Enabled = true;
                        StudentFNameTextBox.Text = table[0].f_name;
                        StudentLNameTextBox.Enabled = true;
                        StudentLNameTextBox.Text = table[0].l_name;
                        StudentBirthdateTextBox.Enabled = true;
                        StudentBirthdateTextBox.Text = table[0].birthdate.ToString();
                        pictureBox1.Enabled = true;
                        BrowseButton.Enabled = true;
                        pictureBox1.Image = Image.FromFile(table[0].image);
                        

                        MessageBox.Show("Student found successfully");
                        StudentButton.Text = "Update";
                    }
                    catch { MessageBox.Show("Something went wrong"); }
                else
                    MessageBox.Show("Student not found");
            }
            else
            {
                try
                {
                    Database.UpdateStudent(StudentIDTextBox.Text, StudentFNameTextBox.Text, StudentLNameTextBox.Text, DateTime.Parse(StudentBirthdateTextBox.Text), imagePath);
                    MessageBox.Show("Student Updated");
                }
                catch { MessageBox.Show("Something went wrong"); }
            }
        }

        private void LessonButton_Click(object sender, EventArgs e)
        {
            if (LessonButton.Text == "Search")
            {
                List<Lesson> table = Database.SearchLesson(LessonIDTextBox.Text).ToList();

                if (table.Count != 0)
                    try
                    {
                        LessonIDTextBox.Enabled = false;
                        LessonNameTextBox.Enabled = true;
                        LessonNameTextBox.Text = table[0].name;
                        LessonCreditComboBox.SelectedIndex = Convert.ToInt32(table[0].credit);
                        LessonCreditComboBox.Enabled = true;

                        MessageBox.Show("Lesson found successfully");
                        LessonButton.Text = "Update";
                    }
                    catch { MessageBox.Show("Something went wrong"); }
                else
                    MessageBox.Show("Lesson not found");
            }
            else
            {
                try
                {
                    Database.UpdateLesson(LessonIDTextBox.Text, LessonNameTextBox.Text, LessonCreditComboBox.SelectedIndex+1);
                    MessageBox.Show("Lesson Updated");
                }
                catch { MessageBox.Show("Something went wrong"); }
            }
        }

        private void CourseButton_Click(object sender, EventArgs e)
        {
            if (CourseButton.Text == "Search")
            {
                List<Course> table = Database.SearchCourse(CourseStudentIDTextBox.Text, CourseLessonIDTextBox.Text).ToList();

                if (table.Count != 0)
                    try
                    {
                        CourseStudentIDTextBox.Enabled = false;
                        CourseLessonIDTextBox.Enabled = false;
                        CourseGradeComboBox.Enabled = true;
                        CourseGradeComboBox.SelectedIndex = Convert.ToInt32(table[0].grade);

                        MessageBox.Show("Course found successfully");
                        CourseButton.Text = "Update";
                    }
                    catch { MessageBox.Show("Something went wrong"); }
                else
                    MessageBox.Show("Course not found");
            }
            else
            {
                try
                {
                    Database.UpdateCourse(CourseStudentIDTextBox.Text, CourseLessonIDTextBox.Text, CourseGradeComboBox.SelectedIndex);
                    MessageBox.Show("Course Updated");
                }
                catch { MessageBox.Show("Something went wrong"); }
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            imagePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
