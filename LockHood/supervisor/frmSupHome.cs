using LockHood.supervisor;
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
    public partial class frmSupHome : Form
    {
        databaseClass objdb = new databaseClass();

        public frmSupHome()
        {
            InitializeComponent();
        }

        private void frmSupHome_Load(object sender, EventArgs e)
        {
            loadadhomeform(new frmSuperDash());

            //Current color
            btnDash.BackColor = Color.White;
            btnDash.ForeColor = Color.CornflowerBlue;


            objdb.createConn();

            //// Fill the Username Textbox
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select Department from Head", con);
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
            btnRequest.ForeColor = Color.White;                 
            btnEmployee.ForeColor = Color.White;
            btnReport.ForeColor = Color.White;

            //btn Back Color
            btnTasks.BackColor = Color.CornflowerBlue;
            btnRequest.BackColor = Color.CornflowerBlue;
            btnEmployee.BackColor = Color.CornflowerBlue;
            btnReport.BackColor = Color.CornflowerBlue;

            //Current color
            btnDash.BackColor = Color.White;
            btnDash.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmSuperDash());
            lblHeading.Text = "Dashboard";
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;                   
            btnEmployee.ForeColor = Color.White;
            btnReport.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnRequest.BackColor = Color.CornflowerBlue;
            btnEmployee.BackColor = Color.CornflowerBlue;
            btnReport.BackColor = Color.CornflowerBlue;

            //Current color
            btnTasks.BackColor = Color.White;
            btnTasks.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmSupTask());
            lblHeading.Text = "Tasks";
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;               
            btnEmployee.ForeColor = Color.White;
            btnReport.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnEmployee.BackColor = Color.CornflowerBlue;
            btnReport.BackColor = Color.CornflowerBlue;

            //Current color
            btnRequest.BackColor = Color.White;
            btnRequest.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmSupInventory());
            lblHeading.Text = "Requests";
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;
            btnEmployee.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnRequest.BackColor = Color.CornflowerBlue;
            btnEmployee.BackColor = Color.CornflowerBlue;

            //Current color
            btnReport.BackColor = Color.White;
            btnReport.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmSupReport());
            lblHeading.Text = "Report Generation";
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;
            btnReport.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnRequest.BackColor = Color.CornflowerBlue;
            btnReport.BackColor = Color.CornflowerBlue;

            //Current color
            btnEmployee.BackColor = Color.White;
            btnEmployee.ForeColor = Color.CornflowerBlue;

            //loadadhomeform(new frmSuperDash());
            lblHeading.Text = "Employee";
        }
    }
}
