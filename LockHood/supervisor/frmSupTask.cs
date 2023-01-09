using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LockHood.supervisor
{
    public partial class frmSupTask : Form
    {
        databaseClass objdb = new databaseClass();
        string q = "SELECT sub_task.ID as ID, sub_task.Name as SubTask,  sub_task.Status as Status, sub_task.Date, employee.Name as Employee FROM sub_task INNER JOIN employee ON employee.ID = sub_task.Employee_ID";

        public frmSupTask()
        {
            InitializeComponent();
        }

        private void frmSupTask_Load(object sender, EventArgs e)
        {
            objdb.createConn();
            objdb.showData(q, dgv_sub);
            fillcombo();
        }

        private void fillcombo()
        {
            // Fill Items to workshop combobox
            string query = "SELECT Name FROM task";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query, dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSortWork.Items.Add(dr["Name"].ToString());
            }
        }

        string subTaskID;

        private void dgv_sub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var row = dgv_sub.Rows[e.RowIndex];
            string subTaskName = row.Cells[2].Value.ToString();
            subTaskID = row.Cells[1].Value.ToString();



            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to Update " + subTaskName + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtUpdSub.Enabled = false;
                    pnlSubTaskUpdate.Visible = true;
                    txtUpdSub.Text = subTaskName;
                }
            }
        }

        private void btnupdateCancel_Click(object sender, EventArgs e)
        {
            pnlSubTaskUpdate.Visible = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = cmbUpdTask.Text;

            SqlCommand cmd = new SqlCommand("UPDATE sub_task SET Status=@status WHERE (ID=@subTaskID)");//update query
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@subTaskID", subTaskID);

            lblSucces.Text = "✓ The Sub Task has been Sent Successfully";

            objdb.executeQuery(cmd);
            objdb.showData(q, dgv_sub);

            pnlSubTaskUpdate.Visible = false;


        }

        private void cmbSortWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            string taskName = cmbSortWork.Text;
            int taskID = FindId(taskName);

            databaseClass objdb = new databaseClass();
            string q = "SELECT sub_task.ID as ID, sub_task.Name as SubTask,  sub_task.Status as Status, sub_task.Date, employee.Name as Employee FROM sub_task INNER JOIN employee ON employee.ID = sub_task.Employee_ID WHERE sub_task.Task_ID='" + taskID + "'";

            objdb.showData(q, dgv_sub);


        }

        public int FindId(string name)
        {
            objdb.createConn();
            int id;
            string query = "SELECT ID from task WHERE Name=@name";


            SqlCommand dbCommand = new SqlCommand(query);
            dbCommand.Parameters.AddWithValue("@name", name);


            objdb.executeQuery(dbCommand);

            SqlDataReader dr = dbCommand.ExecuteReader();

            dr.Read();
            id = Convert.ToInt32(dr[0]);

            objdb.closeConn();
            return id;
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            objdb.showData(q, dgv_sub);
        }
    }
}
