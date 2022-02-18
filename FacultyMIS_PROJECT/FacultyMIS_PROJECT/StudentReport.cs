using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyMIS_PROJECT
{
    public partial class StudentReport : Form
    {
        Start start;

        public StudentReport(Start s)
        {
            InitializeComponent();
            start = s;
        }

        private void StudentReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            start.Show();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            StudentCrystalReport studentCrystalReport = new StudentCrystalReport();
            crystalReportViewer1.ReportSource = studentCrystalReport;
            crystalReportViewer1.RefreshReport();
        }
    }
}
