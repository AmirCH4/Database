using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        DataClasses1DataContext Database = new DataClasses1DataContext();
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(Database);
            addForm.ShowDialog();
            addForm.Dispose();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm(Database);
            updateForm.ShowDialog();
            updateForm.Dispose();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(Database);
            deleteForm.ShowDialog();
            deleteForm.Dispose();
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(Database);
            reportForm.ShowDialog();
            reportForm.Dispose();
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            ShowForm showForm = new ShowForm(Database);
            showForm.ShowDialog();
            showForm.Dispose();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBoxForm aboutForm = new AboutBoxForm();
            aboutForm.ShowDialog();
            aboutForm.Dispose();
        }
    }
}
