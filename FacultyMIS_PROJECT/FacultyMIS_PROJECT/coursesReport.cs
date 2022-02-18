using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace FacultyMIS_PROJECT
{
    public partial class coursesReport : Form
    {
        CoursesCrystalReport CR;
        Start start;

        public coursesReport(Start s)
        {
            InitializeComponent();
            start = s;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, semesterBox.Text);
            crystalReportViewer1.ReportSource = CR;
        }

        private void coursesReport_Load(object sender, EventArgs e)
        {
            CR = new CoursesCrystalReport();

            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                semesterBox.Items.Add(v.Value);
        }

        private void coursesReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            start.Show();
        }
    }
}
