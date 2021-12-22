using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
namespace FinalProject
{
    public partial class AddForm : Form
    {
        DataClasses1DataContext Database;
        string imagePath = String.Empty;
        public AddForm(DataClasses1DataContext refDatabase)
        {
            Database = refDatabase;
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imagePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(imagePath);
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            if (imagePath != String.Empty)
                try
                {
                    Database.InsertStudent(StudentIDTextBox.Text, StudentFNameTextBox.Text, StudentLNameTextBox.Text, DateTime.Parse(StudentBirthdateTextBox.Text), imagePath);
                    MessageBox.Show("Student added successfully.");
                }
                catch (SqlException error) { if (error.Number == 2627) MessageBox.Show("Student Exist"); }
            else
                MessageBox.Show("You should add a picture");
        }
        private void LessonAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Database.InsertLesson(LessonIDTextBox.Text, LessonNameTextBox.Text, LessonCreditComboBox.SelectedIndex + 1);
                MessageBox.Show("Lesson added successfully.");
            }
            catch (SqlException error) { if (error.Number == 2627) MessageBox.Show("Lesson Exist"); }
        }
        private void CourseAddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Database.InsertCourse(CourseStudentIDTextBox.Text, CourseLessonIDTextBox.Text, CourseGradeComboBox.SelectedIndex);
                MessageBox.Show("Course added successfully.");
            }
            catch (SqlException error) { if (error.Number == 2627) MessageBox.Show("There is a grade for this student in this lesson"); }
        }


        private void StudentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (StudentIDTextBox.Text != String.Empty)
                StudentAddButton.Enabled = true;
            else
                StudentAddButton.Enabled = false;
        }
        private void LessonIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LessonIDTextBox.Text != String.Empty)
                LessonAddButton.Enabled = true;
            else
                LessonAddButton.Enabled = false;
        }
        private void CourseStudentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CourseLessonIDTextBox.Text != String.Empty && CourseStudentIDTextBox.Text != String.Empty)
                CourseAddButton.Enabled = true;
            else
                CourseAddButton.Enabled = false;
        }
        private void CourseLessonIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CourseLessonIDTextBox.Text != String.Empty && CourseStudentIDTextBox.Text != String.Empty)
                CourseAddButton.Enabled = true;
            else
                CourseAddButton.Enabled = false;
        }
    }
}
