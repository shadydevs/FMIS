using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace FacultyMIS_PROJECT
{
	public partial class CoursesForm : Form
	{
		OracleDataAdapter adapter;
		OracleCommandBuilder builder;
		DataSet dataSet;

		Start start;

		public CoursesForm(Start s)
		{
			InitializeComponent();
			start = s;
		}


		private void courseId_CheckedChanged(object sender, EventArgs e)
		{
			if (!courseId.Checked)
			{
				courses.DataSource = null;
				cidBox.Text = "";
				cidBox.Enabled = false;
				return;
			}
			cidBox.Enabled = true;
		}

		private void semOffered_CheckedChanged(object sender, EventArgs e)
		{
			fall.Enabled = semOffered.Checked;
			spring.Enabled = semOffered.Checked;
			fall.Checked = semOffered.Checked;
			spring.Checked = semOffered.Checked;
		}

		private void fall_CheckedChanged(object sender, EventArgs e)
		{
			string constr = "Data source=orcl;User Id=scott; Password=tiger;";
			string cmdstr = "";

			if (fall.Checked && spring.Checked)
				cmdstr = "SELECT * FROM courses ";
			else if (fall.Checked)
				cmdstr = "SELECT * FROM courses WHERE semester_offered='Fall'";
			else if (spring.Checked)
				cmdstr = "SELECT * FROM courses WHERE semester_offered='Spring'";
			else
			{
				courses.DataSource = null;
				return;
			}


			adapter = new OracleDataAdapter(cmdstr, constr);
			dataSet = new DataSet();

			adapter.Fill(dataSet);
			courses.DataSource = dataSet.Tables[0];
		}

		private void spring_CheckedChanged(object sender, EventArgs e)
		{
			string constr = "Data source=orcl;User Id=scott; Password=tiger;";
			string cmdstr = "";

			if (fall.Checked && spring.Checked)
				cmdstr = "SELECT * FROM courses ";
			else if (fall.Checked)
				cmdstr = "SELECT * FROM courses WHERE semester_offered='Fall'";
			else if (spring.Checked)
				cmdstr = "SELECT * FROM courses WHERE semester_offered='Spring'";
			else
			{
				courses.DataSource = null;
				return;
			}

			adapter = new OracleDataAdapter(cmdstr, constr);
			dataSet = new DataSet();

			adapter.Fill(dataSet);
			courses.DataSource = dataSet.Tables[0];
		}

		private void courseName_CheckedChanged(object sender, EventArgs e)
		{
			if (!courseName.Checked)
			{
				courses.DataSource = null;
				cNameBox.Text = "";
				cNameBox.Enabled = false;
				return;
			}
			cNameBox.Enabled = true;
		}

		private void lecName_CheckedChanged(object sender, EventArgs e)
		{
			if (!lecName.Checked)
			{
				courses.DataSource = null;
				lecNameBox.Text = "";
				lecNameBox.Enabled = false;
				return;
			}
			lecNameBox.Enabled = true;

		}

		private void numOfCredits_CheckedChanged(object sender, EventArgs e)
		{
			if (!numOfCredits.Checked)
			{
				courses.DataSource = null;
				numOfCreditsBox.Text = "";
				numOfCreditsBox.Enabled = false;
				return;
			}
			numOfCreditsBox.Enabled = true;
		}


		private void cidBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string constr = "Data source=orcl;User Id=scott; Password=tiger;";
			string cmdstr = "SELECT * FROM courses WHERE course_id='" + cidBox.Text.ToString() + "'";
			adapter = new OracleDataAdapter(cmdstr, constr);
			dataSet = new DataSet();

			adapter.Fill(dataSet);
			courses.DataSource = dataSet.Tables[0];
		}

		private void cNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string constr = "Data source=orcl;User Id=scott; Password=tiger;";
			string cmdstr = "SELECT * FROM courses WHERE course_name='" + cNameBox.Text.ToString() + "'";
			adapter = new OracleDataAdapter(cmdstr, constr);
			dataSet = new DataSet();

			adapter.Fill(dataSet);
			courses.DataSource = dataSet.Tables[0];
		}

		private void numOfCreditsBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string constr = "Data source=orcl;User Id=scott; Password=tiger;";
			string cmdstr = "SELECT * FROM courses WHERE no_of_credits='" + numOfCreditsBox.Text.ToString() + "'";
			adapter = new OracleDataAdapter(cmdstr, constr);
			dataSet = new DataSet();

			adapter.Fill(dataSet);
			courses.DataSource = dataSet.Tables[0];
		}

		private void lecNameBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string constr = "Data source=orcl;User Id=scott; Password=tiger;";
			string cmdstr = "SELECT * FROM courses WHERE lecturer_name='" + lecNameBox.Text.ToString() + "'";
			adapter = new OracleDataAdapter(cmdstr, constr);
			dataSet = new DataSet();

			adapter.Fill(dataSet);
			courses.DataSource = dataSet.Tables[0];
		}

		private void save_Click(object sender, EventArgs e)
		{
			OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

			adapter.Update(dataSet.Tables[0]);

			updateList();

			MessageBox.Show("Changes saved.");
		}

		private void CoursesForm_Load(object sender, EventArgs e)
		{
			updateList();
		}

		private void updateList()
		{
			//empty old lists
			cidBox.Items.Clear();
			cNameBox.Items.Clear();
			lecNameBox.Items.Clear();

			//fill new list
			string constr = "Data source=orcl;User Id=scott; Password=tiger;";
			string comboBoxCmd = "SELECT course_id FROM courses";

			adapter = new OracleDataAdapter(comboBoxCmd, constr);
			dataSet = new DataSet();

			adapter.Fill(dataSet);

			DataTableReader dr = dataSet.CreateDataReader();

			while (dr.Read())
			{
				cidBox.Items.Add(dr[0]);
			}

			comboBoxCmd = "SELECT lecturer_name FROM courses";

			adapter = new OracleDataAdapter(comboBoxCmd, constr);
			dataSet = new DataSet();

			adapter.Fill(dataSet);

			dr = dataSet.CreateDataReader();

			while (dr.Read())
			{
				lecNameBox.Items.Add(dr[0]);
			}

			comboBoxCmd = "SELECT course_name FROM courses";

			adapter = new OracleDataAdapter(comboBoxCmd, constr);
			dataSet = new DataSet();

			adapter.Fill(dataSet);

			dr = dataSet.CreateDataReader();

			while (dr.Read())
			{
				cNameBox.Items.Add(dr[0]);
			}

		}

		private void CoursesForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			start.Show();
		}
	}

}
