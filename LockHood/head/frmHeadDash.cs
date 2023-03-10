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
using System.Windows.Forms.DataVisualization.Charting;

namespace LockHood
{
    public partial class frmHeadDash : Form
    {
        databaseClass objdb = new databaseClass();

        public frmHeadDash()
        {
            InitializeComponent();
        }

        private void frmHeadDash_Load(object sender, EventArgs e)
        {
            objdb.createConn();
            fill_Count();
            FillChart();
        }

        public void fill_Count()
        {
            //pull the total Task count
            string query = "SELECT COUNT(*) FROM task WHERE Status ='completed'";
            DataTable dt = new DataTable();
            objdb.readDatathroughAdapter(query, dt);
            lblComplete.Text = dt.Rows[0][0].ToString();

            //pull the total Pending Task count
            string query1 = "SELECT COUNT(*) FROM task WHERE Status ='pending'";
            DataTable dt2 = new DataTable();
            objdb.readDatathroughAdapter(query1, dt2);
            lblPending.Text = dt2.Rows[0][0].ToString();

            //pull the total Pending Task count
            string query3 = "SELECT COUNT(*) FROM workshop";
            DataTable dt3 = new DataTable();
            objdb.readDatathroughAdapter(query3, dt3);
            lblWorkshop.Text = dt3.Rows[0][0].ToString();

            //pull the total Pending Task count
            string query4 = "SELECT COUNT(*) FROM materials";
            DataTable dt4 = new DataTable();
            objdb.readDatathroughAdapter(query4, dt4);
            lblInventory.Text = dt4.Rows[0][0].ToString();

        }

        private void FillChart()
        {
            chart1.Titles.Add("Materials");
            Series series = chart1.Series["Series1"];

            objdb.createConn();
            string query = "SELECT Name, Quantity FROM materials";
            SqlCommand dbCommand = new SqlCommand(query);
            objdb.executeQuery(dbCommand);

            SqlDataReader DR = dbCommand.ExecuteReader();
            while (DR.Read())
            {
                series.Points.AddXY(DR["Name"].ToString(), DR["Quantity"]);
            }
            objdb.closeConn();
        }
    }
}
