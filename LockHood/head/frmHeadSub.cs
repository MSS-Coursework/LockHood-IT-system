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

namespace LockHood.head
{
    public partial class frmHeadSub : Form
    {
        databaseClass objdb = new databaseClass();
        string q = "SELECT task.ID, task.Name as Task, task.Status as Status, task.Date, workshop.Name as Workshop FROM task INNER JOIN workshop ON task.Workshop_ID = workshop.ID";
        string q2 = "SELECT sub_task.Task_ID as TaskID, sub_task.Name as SubTask, sub_task.Date, workshop.Name as Workshop, employee.Name as Employee, sub_task.Status as Status FROM ((sub_task INNER JOIN workshop ON sub_task.Workshop_ID = workshop.ID))  INNER JOIN employee ON employee.ID = sub_task.Employee_ID";


        public frmHeadSub()
        {
            InitializeComponent();
        }

        private void frmHeadSub_Load(object sender, EventArgs e)
        {
            objdb.createConn();
            objdb.showData(q2, dgv_sub);
            objdb.showData(q, dgv_task);
            fillcombo();
            emptyText();
            clearLabel();
        }

        private void fillcombo()
        {

            // Fill Items to workshop combobox
            string query = "SELECT Name FROM workshop";
            DataTable dt = new DataTable();



            objdb.readDatathroughAdapter(query, dt);



            foreach (DataRow dr in dt.Rows)
            {
                cmbSortWork.Items.Add(dr["Name"].ToString());
            }




            // Fill Items to task combobox



            string query3 = "SELECT Name FROM task";
            DataTable dt3 = new DataTable();



            objdb.readDatathroughAdapter(query3, dt3);



            foreach (DataRow dr in dt3.Rows)
            {
                cmbTask.Items.Add(dr["Name"].ToString());



            }
        }

        private void emptyText()
        {
            txtSub.Text = "";
            txtUpdSub.Text = "";
        }

        private void clearLabel()
        {
            lblErrorDate.Text = "";
            lblErrorEmp.Text = "";
            lblErrorSub.Text = "";
            lblErrorTask.Text = "";
            lblSucces.Text = "";
        }

        private void cmbSortWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            string workShop = cmbSortWork.SelectedItem.ToString();



            string q = "SELECT task.ID, task.Name as Task, task.Status as Status, task.Date, workshop.Name as Workshop FROM task INNER JOIN workshop ON task.Workshop_ID = workshop.ID where workshop.Name='" + workShop + "'";
            string q2 = "SELECT sub_task.Task_ID as TaskID, sub_task.Name as SubTask, sub_task.Date, workshop.Name as Workshop, employee.Name as Employee, sub_task.Status as Status FROM ((sub_task INNER JOIN workshop ON sub_task.Workshop_ID = workshop.ID))  INNER JOIN employee ON employee.ID = sub_task.Employee_ID where workshop.Name='" + workShop + "'";




            objdb.createConn();
            objdb.showData(q2, dgv_sub);
            objdb.showData(q, dgv_task);


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            addSubTask();
        }

        private void addSubTask()
        {
            String subTask = txtSub.Text;
            DateTime date = dtpDate.Value;
            String employee = cmbEmp.Text;
            string dateString = date.ToString("dd-MM-yyyy");



            string taskName = cmbTask.Text;



            int task_id = FindId(taskName, "ID", "task");
            int dep_id = FindId(taskName, "Department_ID", "task");
            int work_id = FindId(taskName, "Workshop_ID", "task");
            int emp_id = FindId(employee, "ID", "employee");




            try
            {
                objdb.createConn();



                string query1 = "insert into sub_task (Name, Status, Date, Task_ID, Workshop_ID, Department_ID, Employee_ID) values ('" + subTask + "', 'pending', '" + date + "', '" + task_id + "', '" + work_id + "', '" + dep_id + "', '" + emp_id + "')";
                SqlCommand dbCommand1 = new SqlCommand(query1);



                objdb.executeQuery(dbCommand1);



                objdb.showData(q2, dgv_sub);
                objdb.showData(q, dgv_task);



                objdb.closeConn();
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillEmpCombo();

        }

        private void fillEmpCombo()
        {
            cmbEmp.Items.Clear();
            string taskName = cmbTask.Text;



            int work_id = FindId(taskName, "Workshop_ID", "task");



            // Fill Items to workshop combobox
            string query = "SELECT Name FROM employee where Workshop_ID = '" + work_id + "'";
            DataTable dt = new DataTable();



            objdb.readDatathroughAdapter(query, dt);



            foreach (DataRow dr in dt.Rows)
            {
                cmbEmp.Items.Add(dr["Name"].ToString());
            }
        }


        public int FindId(String name, String col, String table)
        {
            objdb.createConn();
            int id;
            string query = "SELECT " + col + " from " + table + " WHERE Name  =@name";




            SqlCommand dbCommand = new SqlCommand(query);
            dbCommand.Parameters.AddWithValue("@name", name);



            objdb.executeQuery(dbCommand);



            SqlDataReader dr = dbCommand.ExecuteReader();



            dr.Read();
            id = Convert.ToInt32(dr[0]);



            objdb.closeConn();
            return id;
        }

        string rowheadID;
        private void dgv_task_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //ignore header click
            if (e.RowIndex == -1) return;



            var row = dgv_task.Rows[e.RowIndex];
            rowheadID = row.Cells[2].Value.ToString();



            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to change the status to Complete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("UPDATE task SET Status = 'completed' WHERE id='" + rowheadID + "'");
                    objdb.executeQuery(delete);
                    dgv_task.Rows.RemoveAt(row.Index);
                    objdb.showData(q, dgv_task);



                }
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to Change the status to Pending?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("UPDATE task SET Status = 'pending' WHERE id='" + rowheadID + "'");
                    objdb.executeQuery(delete);
                    dgv_task.Rows.RemoveAt(row.Index);
                    objdb.showData(q, dgv_task);



                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateSubTask = txtUpdSub.Text;
            DateTime updatedate = dtpUpdDate.Value;
            string updateEmp = cmbUpdEmp.Text;
            int emp_id = FindId(updateEmp, "ID", "employee");
            int sub_id = FindId(rowsubtask, "ID", "sub_task");





            SqlCommand cmd = new SqlCommand("UPDATE sub_task SET Name=@task_name, Date=@task_date, Employee_ID=@emp_work WHERE ID=@id");
            cmd.Parameters.AddWithValue("@id", sub_id);
            cmd.Parameters.AddWithValue("@task_name", updateSubTask);
            cmd.Parameters.AddWithValue("@task_date", updatedate);
            cmd.Parameters.AddWithValue("@emp_work", emp_id);



            updatePanel.Visible = false;
            lblSucces.Text = "✓ The Sub-Task has been Updated Successfully";



            objdb.executeQuery(cmd);
            objdb.showData(q2, dgv_sub);
            emptyText();
        }

        private void btnupdateCancel_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
        }

        string rowtaskID;
        string rowsubtask;
        string rowdate;
        string rowemployee;
        string rowWorkshop;


        private void dgv_sub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;



            var row = dgv_sub.Rows[e.RowIndex];
            rowtaskID = row.Cells[2].Value.ToString();
            rowsubtask = row.Cells[3].Value.ToString();
            rowdate = row.Cells[4].Value.ToString();
            rowWorkshop = row.Cells[5].Value.ToString();
            rowemployee = row.Cells[6].Value.ToString();



            int sub_id = FindId(rowsubtask, "ID", "sub_task");




            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to Update " + rowsubtask + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    updatePanel.Visible = true;
                    dtpDate.Text = rowdate;
                    txtUpdSub.Text = rowsubtask;
                    cmbUpdEmp.Text = rowemployee;
                    fillUpdateEmpCombo();
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete " + rowsubtask + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM sub_task WHERE ID='" + sub_id + "'");
                    objdb.executeQuery(delete);
                    dgv_sub.Rows.RemoveAt(row.Index);
                }
            }
        }

       

        private void picRefresh_Click(object sender, EventArgs e)
        {
            objdb.showData(q2, dgv_sub);
            objdb.showData(q, dgv_task);
        }

        private void fillUpdateEmpCombo()
        {
            cmbUpdEmp.Items.Clear();
            string taskName = cmbTask.Text;



            int work_id = FindId(rowWorkshop, "ID", "workshop");



            // Fill Items to workshop combobox
            string query = "SELECT Name FROM employee where Workshop_ID = '" + work_id + "'";
            DataTable dt = new DataTable();



            objdb.readDatathroughAdapter(query, dt);



            foreach (DataRow dr in dt.Rows)
            {
                cmbUpdEmp.Items.Add(dr["Name"].ToString());
            }
        }
    }
}
