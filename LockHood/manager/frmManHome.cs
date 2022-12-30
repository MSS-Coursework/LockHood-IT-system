using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockHood
{
    public partial class frmManHome : Form
    {
        databaseClass objdb = new databaseClass();

        public frmManHome()
        {
            InitializeComponent();
        }

        private void frmManHome_Load(object sender, EventArgs e)
        {
            loadadhomeform(new frmManagerDash());
            //Current color
            btnDash.BackColor = Color.White;
            btnDash.ForeColor = Color.CornflowerBlue;

            objdb.createConn();

            //// Fill the Username Textbox
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select Factory from manager", con);
            //da.Fill(dt);

            //lblDepart.Text = dt.Rows[0][0].ToString();
        }
        public void loadadhomeform(object Form)
        {
            if (this.pnlBody.Controls.Count > 0)
                this.pnlBody.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlBody.Controls.Add(f);
            this.pnlBody.Tag = f;
            f.Show();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnTasks.ForeColor = Color.White;
            btnHeads.ForeColor = Color.White;
            btnSupervisors.ForeColor = Color.White;
            btnEmployee.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnTasks.BackColor = Color.CornflowerBlue;
            btnHeads.BackColor = Color.CornflowerBlue;
            btnSupervisors.BackColor = Color.CornflowerBlue;
            btnEmployee.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

            //Current color
            btnDash.BackColor = Color.White;
            btnDash.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmManagerDash());
            lblHeading.Text = "Dashboard";
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnHeads.ForeColor = Color.White;
            btnSupervisors.ForeColor = Color.White;
            btnEmployee.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnHeads.BackColor = Color.CornflowerBlue;
            btnSupervisors.BackColor = Color.CornflowerBlue;
            btnEmployee.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

            //Current color
            btnTasks.BackColor = Color.White;
            btnTasks.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmManTask());
            lblHeading.Text = "Tasks";
        }

        private void btnHeads_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnSupervisors.ForeColor = Color.White;
            btnEmployee.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnSupervisors.BackColor = Color.CornflowerBlue;
            btnEmployee.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

            //Current color
            btnHeads.BackColor = Color.White;
            btnHeads.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmManAccHead());
            lblHeading.Text = " Department Heads";
        }

        private void btnSupervisors_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnHeads.ForeColor = Color.White;
            btnEmployee.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnHeads.BackColor = Color.CornflowerBlue;
            btnEmployee.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

            //Current color
            btnSupervisors.BackColor = Color.White;
            btnSupervisors.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmManAccSup());
            lblHeading.Text = "Supervisors";
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnHeads.ForeColor = Color.White;
            btnSupervisors.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnHeads.BackColor = Color.CornflowerBlue;
            btnSupervisors.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

            //Current color
            btnEmployee.BackColor = Color.White;
            btnEmployee.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmManEmployee());
            lblHeading.Text = "Employees";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnHeads.ForeColor = Color.White;
            btnSupervisors.ForeColor = Color.White;
            btnEmployee.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnHeads.BackColor = Color.CornflowerBlue;
            btnSupervisors.BackColor = Color.CornflowerBlue;
            btnEmployee.BackColor = Color.CornflowerBlue;

            //Current color
            btnReports.BackColor = Color.White;
            btnReports.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmManReports());
            lblHeading.Text = "Generate Reports";
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }
    }
}
