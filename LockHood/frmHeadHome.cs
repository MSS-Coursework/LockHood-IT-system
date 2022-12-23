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
    public partial class frmHeadHome : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-N7LQHOM;Initial Catalog=LockHood;Integrated Security=True");

        public frmHeadHome()
        {
            InitializeComponent();
        }

        private void frmHeadHome_Load(object sender, EventArgs e)
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
            btnRequest.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;
            btnWarehouse.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnInventory.ForeColor = Color.White;

            //btn Back Color
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;   
            btnReports.BackColor = Color.CornflowerBlue;       
            btnRequest.BackColor = Color.CornflowerBlue;

            //Current color
            btnDash.BackColor = Color.White;
            btnDash.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmHeadDash());
            lblHeading.Text = "Dashboard";
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnInventory.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;
            btnWarehouse.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnDash.ForeColor = Color.White;

            //btn Back Color
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;
            btnDash.BackColor = Color.CornflowerBlue;

            btnRequest.BackColor = Color.White;
            btnRequest.ForeColor = Color.CornflowerBlue;

            lblHeading.Text = "Inventory Requests";
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnInventory.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;
            btnTasks.ForeColor = Color.White;
            btnDash.ForeColor = Color.White;

            //btn Back Color
            btnRequest.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;
            btnDash.BackColor = Color.CornflowerBlue;

            btnWarehouse.BackColor = Color.White;
            btnWarehouse.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmWarehouse());
            lblHeading.Text = "Warehouse";

        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnInventory.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;
            btnWarehouse.ForeColor = Color.White;
            btnDash.ForeColor = Color.White;

            //btn Back Color
            btnRequest.BackColor = Color.CornflowerBlue;
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;
            btnDash.BackColor = Color.CornflowerBlue;

            btnTasks.BackColor = Color.White;
            btnTasks.ForeColor = Color.CornflowerBlue;

            lblHeading.Text = "Tasks";
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnTasks.ForeColor = Color.White;
            btnReports.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;
            btnWarehouse.ForeColor = Color.White;
            btnDash.ForeColor = Color.White;

            //btn Back Color
            btnRequest.BackColor = Color.CornflowerBlue;
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnReports.BackColor = Color.CornflowerBlue;
            btnDash.BackColor = Color.CornflowerBlue;

            btnInventory.BackColor = Color.White;
            btnInventory.ForeColor = Color.CornflowerBlue;

            loadadhomeform(new frmHeadInventory());
            lblHeading.Text = "Inventory";
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            //btn Font Color
            btnTasks.ForeColor = Color.White;
            btnInventory.ForeColor = Color.White;
            btnRequest.ForeColor = Color.White;
            btnWarehouse.ForeColor = Color.White;
            btnDash.ForeColor = Color.White;

            //btn Back Color
            btnRequest.BackColor = Color.CornflowerBlue;
            btnWarehouse.BackColor = Color.CornflowerBlue;
            btnTasks.BackColor = Color.CornflowerBlue;
            btnInventory.BackColor = Color.CornflowerBlue;
            btnDash.BackColor = Color.CornflowerBlue;

            btnReports.BackColor = Color.White;
            btnReports.ForeColor = Color.CornflowerBlue;

            lblHeading.Text = "Generate Reports";
        }
    }
}
