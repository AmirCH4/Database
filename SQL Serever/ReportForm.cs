using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Linq;
namespace FinalProject
{
    public partial class ReportForm : Form
    {
        DataClasses1DataContext Database;
        public ReportForm(DataClasses1DataContext refDatabase)
        {
            Database = refDatabase;
            InitializeComponent();
        }

        private void ReportButton1_Click(object sender, EventArgs e)
        {
            label2.Location = new Point(5, 60);
            label3.Location = new Point(105, 60);
            label4.Location = new Point(205, 60);

            List<Course> table = Database.StudentLessonsReport(Report1IDTextBox.Text).ToList();
            Point pt = new Point();

            int sum = 0;
            for (int i = 0; i < table.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Label lbl = new Label();
                    pt.X = (j * 100) + 5;
                    pt.Y = (i * 30) + 90;
                    groupBox1.Controls.Add(lbl);

                    lbl.Location = pt;
                    if (j == 0)
                        lbl.Text = table[i].student_ID;
                    else if (j == 1)
                        lbl.Text = table[i].lesson_ID;
                    else
                        lbl.Text = table[i].grade.ToString();
                }
                sum += Convert.ToInt32(table[i].grade);
            }

            if (table.Count != 0)
            {
                NameLabelReport1.Text = table[0].Student.f_name + " " + table[0].Student.l_name;
                AvgLabelReport1.Text = (sum / table.Count).ToString();
                pictureBox1.Image = Image.FromFile(table[0].Student.image);
            }
        }

        private void Report1IDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Report1IDTextBox.Text != String.Empty)
                ReportButton1.Enabled = true;
        }

        private void Report2Button_Click(object sender, EventArgs e)
        {
            label6.Location = new Point(5, 60);
            label7.Location = new Point(105, 60);
            label5.Location = new Point(205, 60);
            label21.Location = new Point(305, 60);

            List<Course> table = Database.LessonStudentsReport(Report2LessonIDTextBox.Text).ToList();
            Point pt = new Point();

            for (int i = 0; i < table.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Label lbl = new Label();
                    pt.X = (j * 100) + 5;
                    pt.Y = (i * 30) + 90;
                    groupBox2.Controls.Add(lbl);
                    lbl.Location = pt;

                    if (j == 0)
                        lbl.Text = table[i].lesson_ID;
                    else if (j == 1)
                        lbl.Text = table[i].student_ID;
                    else if (j == 2)
                        lbl.Text = table[i].grade.ToString();
                    else
                        lbl.Text = table[i].Student.f_name + " " + table[i].Student.l_name;
                }
            }
            if (table.Count != 0)
                Report2NameLabel.Text = table[0].Lesson.name;
        }

        private void Report2LessonIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Report2LessonIDTextBox.Text != String.Empty)
                Report2Button.Enabled = true;
        }

        private void Report3Button_Click(object sender, EventArgs e)
        {
            label11.Location = new Point(5,30);
            label9.Location = new Point(105,30);

            ISingleResult<GetAvgResult1> tempTable= Database.GetAvg();
            List<GetAvgResult1> table= tempTable.ToList();

            for (int i = 0; i < table.Count; i++)
            {
                if (i < 3)
                {
                    Label lbl1 = new Label();
                    groupBox3.Controls.Add(lbl1);
                    lbl1.Location = new Point(5, i*30+60);
                    lbl1.Text = table[i].student_ID;

                    Label lbl2 = new Label();
                    groupBox3.Controls.Add(lbl2);
                    lbl2.Location = new Point(105, i*30+60);
                    lbl2.Text = table[i].average.ToString();
                }
                else
                    break;
            }
        }

        private void Report4Button_Click(object sender, EventArgs e)
        {
            label16.Location = new Point(5, 30);
            label17.Location = new Point(105, 30);

            ISingleResult<GetCountRejectedStudentResult> tempTable = Database.GetCountRejectedStudent();
            List<GetCountRejectedStudentResult> table = tempTable.ToList();

            for (int i = 0; i < table.Count; i++)
            {
                if (i < 3)
                {
                    Label lbl1 = new Label();
                    groupBox4.Controls.Add(lbl1);
                    lbl1.Location = new Point(5, i * 30 + 60);
                    lbl1.Text = table[i].lesson_ID;

                    Label lbl2 = new Label();
                    groupBox4.Controls.Add(lbl2);
                    lbl2.Location = new Point(105, i * 30 + 60);
                    lbl2.Text = table[i].rejectedCount.ToString();
                }
                else
                    break;
            }
        }
    }
}
