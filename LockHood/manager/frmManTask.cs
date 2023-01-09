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
using System.Reflection;
using System.Xml.Linq;

namespace LockHood
{
    public partial class frmManTask : Form
    {
        databaseClass objdb = new databaseClass();
        
        string q = "select task.ID, task.Name as task, task.Status as status, task.Date as date, workshop.Name as workshop, department.Name as department from((task INNER JOIN department ON task.Department_ID = department.ID) INNER JOIN workshop ON task.Workshop_ID = workshop.ID)";


        public frmManTask()
        {
            InitializeComponent();

            lblErrorTask.Text = "";
            lblErrorDate.Text = "";
            lblErrorDepart.Text = "";
            lblErrorWork.Text = "";

            lblSucces.Text = "";
            lblUpdsucces.Text = "";
        }

        private void frmManTask_Load(object sender, EventArgs e)
        {
            lblErrorTask.Text = "";
            lblErrorDate.Text = "";
            lblErrorDepart.Text = "";
            lblErrorWork.Text = "";

            lblSucces.Text = "";
            lblUpdsucces.Text = "";

            objdb.createConn();
            objdb.showData(q, dgv_task);
            fillcombo();

        }

        
        public int FindId(String name, String table)
        {
            objdb.createConn();
            int id;
            string query = "SELECT ID from " + table + " WHERE Name  =@name";


            SqlCommand dbCommand = new SqlCommand(query);
            dbCommand.Parameters.AddWithValue("@name", name);

            objdb.executeQuery(dbCommand);

            SqlDataReader dr = dbCommand.ExecuteReader();

            dr.Read();
            id = Convert.ToInt32(dr[0]);

            objdb.closeConn();
            return id;
        }

        public void AddTask()//adding task to task table method
        {
            String name = txtTask.Text;
            DateTime date = dtp_Date.Value;
            String dep_name = cmb_DepName.Text;
            String workshop = cmb_Workshop.Text;

            int dep_id = FindId(dep_name, "department");

            //objdb.createConn();

            ////string query = "SELECT ID from head WHERE Department_ID  = '" + dep_id + "'";

            //objdb.closeConn();

            int workshop_id = FindId(workshop, "workshop");
            try
            {
                objdb.closeConn();

                string query1 = "insert into task (Name, Status, Date, Workshop_ID, Department_ID) values ('" + name + "', 'pending', '" + date + "', '" + workshop_id + "', '" + dep_id + "')";//insert query
                SqlCommand dbCommand1 = new SqlCommand(query1);

                objdb.executeQuery(dbCommand1);

                objdb.closeConn();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cmb_DepName_Leave(object sender, EventArgs e)
        {
            cmb_Workshop.Text = "";
            
            objdb.createConn();
            String name = cmb_DepName.Text;
            string query = "SELECT ID from department WHERE Name  = @cname";

            SqlCommand dbCommand = new SqlCommand(query);
            dbCommand.Parameters.AddWithValue("@cname", name);

            objdb.executeQuery(dbCommand);

            SqlDataReader dr = dbCommand.ExecuteReader();
            dr.Read();
            int dep_id = Convert.ToInt32(dr[0]);
            objdb.closeConn();

            //fill combo sorted
            objdb.createConn();
            string query1 = "select Name from workshop where Department_ID = '" + dep_id + "'";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query1, dt);

            cmb_Workshop.DataSource = dt;
            cmb_Workshop.DisplayMember = "Name";
            cmb_Workshop.ValueMember = "Name";
            objdb.closeConn();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //clear and reload combobox
            clearcombo();
            fillcombo();

            // Empty Error Labels
            lblErrorTask.Text = "";
            lblErrorDate.Text = "";
            lblErrorDepart.Text = "";
            lblErrorWork.Text = "";

            string updateName = updateTask_txtbox.Text;
            DateTime updatedate = dtpUpdDate.Value;
            string updateDepart = cmbUpdDepart.Text;
            string updateWork = cmbupdateWork.Text;

            int dep_id = FindId(updateDepart, "department");
            int workShop_id = FindId(updateWork, "workshop");

            SqlCommand cmd = new SqlCommand("UPDATE task SET Name=@task_name, Date=@task_date, Workshop_ID=@task_work, Department_ID=@task_dep WHERE (ID=@id)");//update query
            cmd.Parameters.AddWithValue("@id", rowtaskID);
            cmd.Parameters.AddWithValue("@task_name", updateName);
            cmd.Parameters.AddWithValue("@task_date", updatedate);
            cmd.Parameters.AddWithValue("@task_work", workShop_id);
            cmd.Parameters.AddWithValue("@task_dep", dep_id);

            updatePanel.Visible = false;
            lblSucces.Text = "✓ The Account has been Updated Successfully";

            objdb.executeQuery(cmd);
            objdb.showData(q, dgv_task);
            emptyText();
        }

        private void clearcombo()
        {
            //clear and reload combobox
            cmbDepart.Items.Clear();
            cmbupdateWork.Items.Clear();
            cmbUpdDepart.Items.Clear();
            cmb_DepName.Items.Clear();
            cmb_Workshop.Items.Clear();

        }
        private void fillcombo()
        {
            objdb.createConn();
            // Fill Items to Department combobox
            string query = "SELECT Name FROM department";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query, dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbDepart.Items.Add(dr["Name"].ToString());
                cmbUpdDepart.Items.Add(dr["Name"].ToString());
                cmb_DepName.Items.Add(dr["Name"].ToString());
            }
            objdb.closeConn();
            objdb.createConn();

            // Fill Items to Department combobox
            string query1 = "SELECT Name FROM workshop";
            DataTable dt1 = new DataTable();

            objdb.readDatathroughAdapter(query1, dt1);

            foreach (DataRow dr1 in dt1.Rows)
            {
                cmb_Workshop.Items.Add(dr1["Name"].ToString());
                cmbupdateWork.Items.Add(dr1["Name"].ToString());
            }
            objdb.closeConn();
        }

        private void emptyText()
        {
            txtTask.Text = "";
            updateTask_txtbox.Text = "";
            cmbDepart.Text = "";
            cmbupdateWork.Text = "";
            cmbUpdDepart.Text = "";
            cmb_Workshop.Text = "";
        }

        string rowtaskID;
        string rowtaskname;
        string rowtaskstatus;
        string rowtaskdate;
        string rowtaskwork;
        string rowtaskdepart;

        private void dgv_task_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //clear and reload combobox
            clearcombo();
            fillcombo();

            //ignore header click
            if (e.RowIndex == -1) return;

            var row = dgv_task.Rows[e.RowIndex];
            rowtaskID = row.Cells[2].Value.ToString();
            rowtaskname = row.Cells[3].Value.ToString();
            rowtaskstatus = row.Cells[4].Value.ToString();
            rowtaskdate = row.Cells[5].Value.ToString();
            rowtaskwork = row.Cells[6].Value.ToString();
            rowtaskdepart = row.Cells[7].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to Update " + rowtaskname + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    updatePanel.Visible = true;
                    updateTask_txtbox.Text = rowtaskname;
                    dtpUpdDate.Text = rowtaskdate;
                    cmbupdateWork.Text = rowtaskwork;
                    cmbUpdDepart.Text = rowtaskdepart;
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete " + rowtaskID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM task WHERE id='" + rowtaskID + "'");
                    objdb.executeQuery(delete);
                    dgv_task.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //clear and reload combobox
            //clearcombo();
            //fillcombo();

            // Read from values
            String name = txtTask.Text;
            DateTime date = dtp_Date.Value;
            String dep_name = cmb_DepName.Text;
            String workshop = cmb_Workshop.Text;


            // Empty Error Labels
            lblErrorTask.Text = "";
            lblErrorDate.Text = "";
            lblErrorDepart.Text = "";
            lblErrorWork.Text = "";


            // Validations
            if (name == "")
            {
                lblErrorTask.Text = "This field is required !";
            }           
            if (workshop == "")
            {
                lblErrorWork.Text = "This field is required !";
            }
            if (dep_name == "")
            {
                lblErrorDepart.Text = "This field is required !";
            }
            else
            {
                AddTask();
                lblSucces.Text = "✓ The Account has been Created Successfully";

                emptyText();
                objdb.showData(q, dgv_task);
            }
        }

        private void cmbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string department = cmbDepart.Text;
            string q = "select task.ID, task.Name as task, task.Status as status, task.Date as date, workshop.Name as workshop, department.Name as department from((task INNER JOIN department ON task.Department_ID = department.ID) INNER JOIN workshop ON task.Workshop_ID = workshop.ID) where department.Name= '" + department + "'";
            objdb.createConn();
            objdb.showData(q, dgv_task);
        }
    }
} 
