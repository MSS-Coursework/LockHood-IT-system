﻿using System;
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
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=LockHood;Integrated Security=True");

        public frmSupHome()
        {
            InitializeComponent();
        }

        private void frmSupHome_Load(object sender, EventArgs e)
        {
            loadadhomeform(new frmHeadDash());

            // Check the connection status & close/Open
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            // Fill the Username Textbox
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Department from Head", con);
            da.Fill(dt);

            lblDepart.Text = dt.Rows[0][0].ToString();
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
            btnWarehouse.ForeColor = Color.White;
            btnInventory.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnTasks.BackColor = Color.CornflowerBlue;
            btnRequest.BackColor = Color.CornflowerBlue;
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

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
            btnWarehouse.ForeColor = Color.White;
            btnInventory.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnRequest.BackColor = Color.CornflowerBlue;
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

            //Current color
            btnTasks.BackColor = Color.White;
            btnTasks.ForeColor = Color.CornflowerBlue;

            //loadadhomeform(new frmSuperDash());
            lblHeading.Text = "Tasks";
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnWarehouse.ForeColor = Color.White;
            btnInventory.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

            //Current color
            btnRequest.BackColor = Color.White;
            btnRequest.ForeColor = Color.CornflowerBlue;

            //loadadhomeform(new frmSuperDash());
            lblHeading.Text = "Requests";
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;
            btnInventory.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnRequest.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

            //Current color
            btnWarehouse.BackColor = Color.White;
            btnWarehouse.ForeColor = Color.CornflowerBlue;

            //loadadhomeform(new frmSuperDash());
            lblHeading.Text = "Warehouse";
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;
            btnWarehouse.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnRequest.BackColor = Color.CornflowerBlue;
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;

            //Current color
            btnInventory.BackColor = Color.White;
            btnInventory.ForeColor = Color.CornflowerBlue;

            //loadadhomeform(new frmSuperDash());
            lblHeading.Text = "Inventory";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnDash.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;
            btnWarehouse.ForeColor = Color.White;
            btnInventory.ForeColor = Color.White;

            //btn Back Color
            btnDash.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnRequest.BackColor = Color.CornflowerBlue;
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;

            //Current color
            btnReports.BackColor = Color.White;
            btnReports.ForeColor = Color.CornflowerBlue;

            //loadadhomeform(new frmSuperDash());
            lblHeading.Text = "Report Generation";
        }
    }
}