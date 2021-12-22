using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ShowForm : Form
    {
        DataClasses1DataContext Database;
        public ShowForm(DataClasses1DataContext refDatabase)
        {
            Database = refDatabase;
            InitializeComponent(); 
        }

        private void StudentShowButton_Click(object sender, EventArgs e)
        {
            List<Student> table = Database.GetStudentTable().ToList();
            Point pt = new Point();

            label1.Location =new Point(5, 30);
            label2.Location = new Point(105, 30);
            label3.Location = new Point(205, 30);
            label4.Location = new Point(305, 30);
            label5.Location = new Point(405, 30);

            for (int i = 0; i < table.Count; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    pt.X = (j * 100) + 5;
                    pt.Y = (i * 30) + 60;
                    Label lbl = new Label();
                    StudentGroupBox.Controls.Add(lbl);
                    if(j!=4)
                        lbl.Location = pt;


                    if (j == 0)
                        lbl.Text = table[i].ID;
                    else if (j == 1)
                        lbl.Text = table[i].f_name;
                    else if (j == 2)
                        lbl.Text = table[i].l_name;
                    else if (j == 3)
                        lbl.Text = table[i].birthdate.ToString();
                    else
                    {
                        Button btn = new Button();
                        btn.Name = "Button_" + i;
                        StudentGroupBox.Controls.Add(btn);
                        btn.Location = pt;
                        btn.Text = "Click";
                        btn.Size = new Size(80, 20);
                        btn.Click += new EventHandler(clickEvent);
                        void clickEvent(Object sender2,EventArgs e2 )
                        {
                            string[] s = new string[2];
                            s = ((Button)sender2).Name.Split('_');
                            int k =Convert.ToInt32( s[1]);
                            
                            pictureBox1.Image=Image.FromFile(table[k].image);
                        }
                    }
                }
            }
        }

        private void LessonShowButton_Click(object sender, EventArgs e)
        {
            List<Lesson> table = Database.GetLessonTable().ToList();
            Point pt = new Point();

            label6.Location = new Point(5, 30);
            label7.Location = new Point(105, 30);
            label8.Location = new Point(205, 30);

            for(int i=0;i<table.Count;i++)
            {
                for(int j=0;j<3;j++)
                {
                    pt.X = (j * 100) + 5;
                    pt.Y = (i * 30) + 60;
                    Label lbl = new Label();
                    LessonGroupBox.Controls.Add(lbl);
                    lbl.Location = pt;

                    if (j == 0)
                        lbl.Text = table[i].ID;
                    else if (j == 1)
                        lbl.Text = table[i].name;
                    else
                        lbl.Text = table[i].credit.ToString();

                }
            }
        }

        private void CourseShowButton_Click(object sender, EventArgs e)
        {
            List<Course> table = Database.GetCourseTable().ToList();
            Point pt = new Point();

            label9.Location = new Point(5, 30);
            label10.Location = new Point(105, 30);
            label11.Location = new Point(205, 30);

            for (int i = 0; i < table.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pt.X = (j * 100) + 5;
                    pt.Y = (i * 30) + 60;
                    Label lbl = new Label();
                    CourseGroupBox.Controls.Add(lbl);
                    lbl.Location = pt;

                    if (j == 0)
                        lbl.Text = table[i].student_ID;
                    else if (j == 1)
                        lbl.Text = table[i].lesson_ID;
                    else
                        lbl.Text = table[i].grade.ToString();

                }
            }
        }
    }
}
