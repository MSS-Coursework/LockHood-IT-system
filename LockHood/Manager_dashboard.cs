using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LockHood
{
    public partial class Manager_dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7S8GDR;Initial Catalog=LockHood;Integrated Security=True");//sql con
        public Manager_dashboard()
        {
            InitializeComponent();
        }
        private void DisplayData()//display data on data grid view
        {
            int id = 1;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select task.name as task, task.date as date, department_head.name as department, workshop.name as workshop from ((task INNER JOIN department_head ON task.head_id = department_head.id) INNER JOIN workshop ON task.workshop_id = workshop.id) WHERE task.head_id = '"+id+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 200;//adjusting column sizes of tables
            dataGridView1.Columns[1].Width = 135;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            con.Close();
        }
        private void FillPieChart()//fill pie chart by c charp corner
        {
            pieChart1.Titles.Add("status");
            pieChart1.Series["Series1"].Points.AddXY("accept", 30);
            pieChart1.Series["Series1"].Points.AddXY("pending", 20);
            pieChart1.Series["Series1"].Points.AddXY("progress", 50);
        }

        public void DepartmentCount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(id) from department", con);
            //cmd.Parameters.AddWithValue("@cname", name);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            lbl_Departments.Text = (dr[0]).ToString();
            con.Close();
        }

        public void ManagerCount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(id) from general_managers", con);
            //cmd.Parameters.AddWithValue("@cname", name);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            lbl_Managers.Text = (dr[0]).ToString();
            con.Close();
        }
        private void FillBarChart()// fill the bar chart by c charp corner
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT m.name as name, COUNT(d.id) AS count FROM general_manager m LEFT JOIN department d ON m.id = d.manager_id GROUP BY m.name", con);
            adapt.Fill(ds);
            barChart1.DataSource = ds;

            barChart1.Series["Department_count"].XValueMember = "name";
            barChart1.Series["Department_count"].YValueMembers = "count";
            barChart1.Titles.Add("Count chart");
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
            FillPieChart();
            FillBarChart();
            DepartmentCount();

        }
    }
}
