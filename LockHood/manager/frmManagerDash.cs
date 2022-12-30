using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LockHood
{
    public partial class frmManagerDash : Form
    {
        databaseClass objdb = new databaseClass();

        public frmManagerDash()
        {
            InitializeComponent();
        }

        private void frmManagerDash_Load(object sender, EventArgs e)
        {
            objdb.createConn();
            fill_Count();

            FillPieChart();
            FillBarChart();
        }

        public void fill_Count()
        {
            //pull the total Task count
            string query = "SELECT COUNT(*) FROM task WHERE Status ='completed'";
            DataTable dt = new DataTable();
            objdb.readDatathroughAdapter(query, dt);
            lblComplet.Text = dt.Rows[0][0].ToString();

            //pull the total Pending Task count
            string query1 = "SELECT COUNT(*) FROM task WHERE Status ='pending'";
            DataTable dt2 = new DataTable();
            objdb.readDatathroughAdapter(query1, dt2);
            lblPendingTask.Text = dt2.Rows[0][0].ToString();

            //pull the total Pending Task count
            string query3 = "SELECT COUNT(*) FROM supervisor";
            DataTable dt3 = new DataTable();
            objdb.readDatathroughAdapter(query3, dt3);
            lblSupervisor.Text = dt3.Rows[0][0].ToString();

            //pull the total Pending Task count
            string query4 = "SELECT COUNT(*) FROM employee";
            DataTable dt4 = new DataTable();
            objdb.readDatathroughAdapter(query4, dt4);
            lblEmployee.Text = dt4.Rows[0][0].ToString();

        }

        private void FillPieChart()
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

        private void FillBarChart()
        {
            chart2.Titles.Add("Requests");
            Series series = chart2.Series["Series1"];

            objdb.createConn();
            string query = "SELECT Material, Quantity FROM requests";
            SqlCommand dbCommand = new SqlCommand(query);
            objdb.executeQuery(dbCommand);

            SqlDataReader DR = dbCommand.ExecuteReader();
            while (DR.Read())
            {
                series.Points.AddXY(DR["Material"].ToString(), DR["Quantity"]);
            }
            objdb.closeConn();
        }
    }
}
