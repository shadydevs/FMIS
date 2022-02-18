using System;
using System.Windows.Forms;

namespace FacultyMIS_PROJECT
{
    public partial class Start : Form
    {
        private const string UNAME = "admin";
        private const string PWORD = "admin";

        public Start()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (username.Text == UNAME && password.Text == PWORD)
            {
                sReport.Visible = true;
                cReport.Visible = true;
                courses.Visible = true;
                students.Visible = true;
                username.Visible = false;
                password.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                error.Visible = false;
                login.Visible = false;
                return;
            }

            error.Visible = true;
        }

        private void students_Click(object sender, EventArgs e)
        {

            StudentsForm sform = new StudentsForm(this);
            sform.Show();
            this.Hide();
        }

        private void courses_Click(object sender, EventArgs e)
        {
            CoursesForm cform = new CoursesForm(this);
            cform.Show();
            this.Hide();
        }

        private void cReport_Click(object sender, EventArgs e)
        {
            coursesReport CR = new coursesReport(this);
            CR.Show();
            this.Hide();
        }

        private void sReport_Click(object sender, EventArgs e)
        {
            StudentReport SR = new StudentReport(this);
            SR.Show();
            this.Hide();
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                login_Click(sender, e);
            }
        }

    }
}
