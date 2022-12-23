﻿using System;
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
    public partial class Task_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J7S8GDR;Initial Catalog=LockHood;Integrated Security=True");//sql con
        

        public Task_Manager()
        {
            InitializeComponent();
            lbl_ErrorTask.Text = "";
            lbl_ErrorDate.Text = "";
            lbl_ErrorHead.Text = "";
            lbl_ErrorWorkshop.Text = "";
            
        }
        public int FindId(SqlConnection con, String name, String table)
        {

            con.Open();
            int id;


            SqlCommand cmd = new SqlCommand("SELECT id from "+table+" WHERE name  = @cname", con);
            cmd.Parameters.AddWithValue("@cname", name);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            id = Convert.ToInt32(dr[0]);
            con.Close();
            
            return id;
        }
        
        private void DisplayData()//display data on data grid view
        {
            int id = 1;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select task.name as task, task.date as date, task.status as status, department_head.name as department, workshop.name as workshop from ((task INNER JOIN department_head ON task.head_id = department_head.id) INNER JOIN workshop ON task.workshop_id = workshop.id) WHERE task.head_id = '" + id + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 100;//adjusting column sizes of tables
            dataGridView1.Columns[1].Width = 135;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            con.Close();
        }
        public void AddTask()//adding task to task table method
        {
            String name = txt_Name.Text;
            DateTime date = dtp_Date.Value;
            String dep_name = cmb_HeadName.Text;
            String workshop = cmb_Workshop.Text;
            int dep_id = FindId(con, dep_name, "department");
            con.Open();
            int head_id;
            SqlCommand cmd1 = new SqlCommand("SELECT id from department_head WHERE department_id  = @cname", con);
            cmd1.Parameters.AddWithValue("@cname", dep_id);

            SqlDataReader dr = cmd1.ExecuteReader();

            dr.Read();
            head_id = Convert.ToInt32(dr[0]);
            con.Close();


            int workshop_id = FindId(con, workshop, "workshop");
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into task (name, status, date, head_id, workshop_id, department_id) values ('" + name + "', 'pending', '" + date + "', '" + head_id + "', '" + workshop_id + "', '" + dep_id + "')";//insert query
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void validation()//checking checkbox if they are empty method
        {
            lbl_ErrorTask.Text = "";
            lbl_ErrorDate.Text = "";
            lbl_ErrorHead.Text = "";
            lbl_ErrorWorkshop.Text = "";
            if (txt_Name.Text == "")
            {
                lbl_ErrorTask.Text = "Required";
            }
            if (cmb_HeadName.Text == "")
            {
                lbl_ErrorHead.Text = "Required";
            }
            if (cmb_Workshop.Text == "")
            {
                lbl_ErrorWorkshop.Text = "Required";
            }

        }

        public void FillSearchBar()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select name from task", con);//fill name in the combo box
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_Search.DataSource = dt;
            cmb_Search.DisplayMember = "name";
            cmb_Search.ValueMember = "name";
            con.Close();
        }
        private void Task_Manager_Load(object sender, EventArgs e)
        {
            
            DisplayData();
            FillHead();
            FillSearchBar();

        }

        public void Search()
        {
            
            try
            {
                con.Open();
                String name = cmb_Search.Text;
                SqlCommand cmd = new SqlCommand("select task.date,  department.name as depname, workshop.name as workname from ((task INNER JOIN workshop ON workshop.id = task.workshop_id) INNER JOIN department ON department.id = task.department_id) where task.name = @name", con);
                cmd.Parameters.AddWithValue("@name", name);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt_Name.Text = cmb_Search.Text;
                    dtp_Date.Value =  Convert.ToDateTime(dr[0].ToString());
                    cmb_HeadName.Text = dr[1].ToString();
                    cmb_Workshop.Text = dr[2].ToString();
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            validation();
            if(lbl_ErrorTask.Text == "" && lbl_ErrorDate.Text == "" && lbl_ErrorHead.Text == "" && lbl_ErrorWorkshop.Text == "")
            {
                AddTask();
                MessageBox.Show("Task has been added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);//fill boxes error
                DisplayData();
                Refresh();
            }
            else
            {
                MessageBox.Show("Please fil all the form inputs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);//fill boxes error
            }
        }
        public void refresh()//method to clear text boxes
        {
            txt_Name.Clear();
            dtp_Date.Text = "";
            cmb_HeadName.Text = "";
            cmb_Workshop.Text = "";
        }
        public void update()
        {

            String name = txt_Name.Text;
            DateTime date = dtp_Date.Value;
            String dep_name = cmb_HeadName.Text;
            String workshop = cmb_Workshop.Text;
            int dep_id = FindId(con, dep_name, "department");
            int workshop_id = FindId(con, workshop, "workshop");

            con.Open();


            int head_id;
            SqlCommand cmd2 = new SqlCommand("SELECT id from department_head WHERE department_id  = @dep_id", con);
            cmd2.Parameters.AddWithValue("@dep_id", dep_id);
            SqlDataReader dr = cmd2.ExecuteReader();

            dr.Read();
            head_id = Convert.ToInt32(dr[0]);
            con.Close();


            try
            {
                con.Open();//connection open
                SqlCommand cmd = new SqlCommand("UPDATE task SET date=@date, head_id=@head_id, workshop_id=@workshop_id, department_id=@department_id WHERE (name=@name )", con);//update query
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@head_id", head_id);
                cmd.Parameters.AddWithValue("@workshop_id", workshop_id);
                cmd.Parameters.AddWithValue("@department_id", dep_id);//to remove the time in the value
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Details of the task has been updated", "Lock Hood", MessageBoxButtons.OK, MessageBoxIcon.Information);//pop up message box
                
                con.Close();//connection close
                DisplayData();//shows the updated data
                refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillHead()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select name from department where manager_id = '"+1+"'", con);//fill name in the combo box
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_HeadName.DataSource = dt;
            cmb_HeadName.DisplayMember = "name";
            cmb_HeadName.ValueMember = "name";
            con.Close();
        }
        
        private void cmb_HeadName_Leave(object sender, EventArgs e)
        {
            cmb_Workshop.Text = "";
            con.Open();
            String name = cmb_HeadName.Text;
            


            SqlCommand cmd = new SqlCommand("SELECT id from department WHERE name  = @cname", con);
            cmd.Parameters.AddWithValue("@cname", name);

            SqlDataReader dr = cmd.ExecuteReader();

            dr.Read();
            int dep_id = Convert.ToInt32(dr[0]);
            con.Close();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select name from workshop where department_id = '" + dep_id + "'", con);//fill name in the combo box
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmb_Workshop.DataSource = dt;
            cmb_Workshop.DisplayMember = "name";
            cmb_Workshop.ValueMember = "name";
            con.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            update();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
