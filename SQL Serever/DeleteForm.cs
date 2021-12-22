using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class DeleteForm : Form
    {
        DataClasses1DataContext Database;
        public DeleteForm(DataClasses1DataContext refDatabase)
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
                        StudentFNameTextBox.Text = table[0].f_name;
                        StudentLNameTextBox.Text = table[0].l_name;
                        StudentBirthdateTextBox.Text = table[0].birthdate.ToString();
                        pictureBox1.Image = Image.FromFile(table[0].image);

                        StudentButton.Text = "Delete";
                        MessageBox.Show("Student found successfully");
                    }
                    catch { MessageBox.Show("Something went wrong"); }
                else
                    MessageBox.Show("Student not found");
            }
            else
            {
                try
                {
                    Database.DeleteStudent(StudentIDTextBox.Text);
                    MessageBox.Show("Student Deleted");
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
                        LessonNameTextBox.Text = table[0].name;
                        LessonCreditComboBox.SelectedIndex = Convert.ToInt32(table[0].credit);

                        MessageBox.Show("Lesson found successfully");
                        LessonButton.Text = "Delete";
                    }
                    catch { MessageBox.Show("Something went wrong"); }
                else
                    MessageBox.Show("Lesson not found");
            }
            else
            {
                try
                {
                    Database.DeleteLesson(LessonIDTextBox.Text);
                    MessageBox.Show("Lesson Deleted");
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
                        CourseGradeComboBox.SelectedIndex = Convert.ToInt32(table[0].grade);

                        MessageBox.Show("Course found successfully");
                        CourseButton.Text = "Delete";
                    }
                    catch { MessageBox.Show("Something went wrong"); }
                else
                    MessageBox.Show("Course not found");
            }
            else
            {
                try
                {
                    Database.DeleteCourse(CourseStudentIDTextBox.Text, CourseLessonIDTextBox.Text);
                    MessageBox.Show("Student Deleted");
                }
                catch { MessageBox.Show("Something went wrong"); }
            }
        }
    }
}
