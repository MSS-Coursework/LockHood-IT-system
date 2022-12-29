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
    public partial class frmManEmployee : Form
    {
        databaseClass objdb = new databaseClass();
        string q = "select employee.ID, employee.Name as Name, employee.Email as Email, employee.Role as Role, workshop.Name as Workshop FROM employee INNER JOIN workshop ON employee.Workshop_ID = workshop.ID";

        public frmManEmployee()
        {
            InitializeComponent();

            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorWork.Text = "";
            lblErrorRole.Text = "";

            lblUpdsucces.Text = "";
            lblSucces.Text = "";
        }

        private void frmManEmployee_Load(object sender, EventArgs e)
        {
            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorWork.Text = "";
            lblErrorRole.Text = "";

            lblUpdsucces.Text = "";
            lblSucces.Text = "";

            objdb.createConn();
            objdb.showData(q, dgv_emp);
            fillcombo();
        }

        string rowempID;
        string rowempname;
        string rowempemail;
        string rowemprole;
        string rowempwork;

        private void dgv_emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //clear and reload combobox
            cmbWork.Items.Clear();
            cmbupdateWork.Items.Clear();
            fillcombo();

            //ignore header click
            if (e.RowIndex == -1) return;

            var row = dgv_emp.Rows[e.RowIndex];
            rowempID = row.Cells[2].Value.ToString();
            rowempname = row.Cells[3].Value.ToString();
            rowempemail = row.Cells[4].Value.ToString();
            rowemprole = row.Cells[5].Value.ToString();
            rowempwork = row.Cells[6].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to Update " + rowempID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    updatePanel.Visible = true;
                    updateName_txtbox.Text = rowempname;
                    updateEmail_txtbox.Text = rowempemail;
                    txtUpdRole.Text = rowemprole;
                    cmbupdateWork.Text = rowempwork;
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete " + rowempID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM employee WHERE id='" + rowempID + "'");
                    objdb.executeQuery(delete);
                    dgv_emp.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void btnupdateCancel_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;

            //clear and reload combobox
            cmbWork.Items.Clear();
            cmbupdateWork.Items.Clear();
            fillcombo();
            emptyText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //clear and reload combobox
            cmbWork.Items.Clear();
            fillcombo();

            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorWork.Text = "";
            lblErrorRole.Text = "";

            string updateName = updateName_txtbox.Text;
            string updateEmail = updateEmail_txtbox.Text;
            string updateRole = txtUpdRole.Text;

            SqlCommand cmd = new SqlCommand("UPDATE employee SET Name=@emp_name, Email=@emp_email, Role=@emp_role WHERE (ID=@id)");//update query
            cmd.Parameters.AddWithValue("@id", rowempID);
            cmd.Parameters.AddWithValue("@emp_email", updateEmail);
            cmd.Parameters.AddWithValue("@emp_role", updateRole);
            cmd.Parameters.AddWithValue("@emp_name", updateName);

            lblUpdsucces.Text = "✓ The Account has been Updated Successfully";

            objdb.executeQuery(cmd);
            objdb.showData(q, dgv_emp);
            emptyText();
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

        public void createHead()//adding task to task table method
        {
            String name = txtName.Text;
            String mail = txtMail.Text;
            String role = txtRole.Text;
            String work = cmbWork.Text;

            int work_id = FindId(work, "workshop");

            objdb.createConn();
            try
            {
                string query = "insert into employee (Name, Email, Role, Workshop_ID) values ('" + name + "',  '" + mail + "', '"+role+"', '" + work_id + "')";
                SqlCommand dbCommand = new SqlCommand(query);

                objdb.executeQuery(dbCommand);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            objdb.closeConn();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //clear and reload combobox
            cmbWork.Items.Clear();
            cmbupdateWork.Items.Clear();
            fillcombo();

            // Read from values
            String name = txtName.Text;
            String mail = txtMail.Text;
            String role = txtRole.Text;
            String work = cmbWork.Text;


            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorWork.Text = "";
            lblErrorRole.Text = "";


            // Validations
            if (name == "")
            {
                lblErrorName.Text = "This field is required !";
            }
            if (mail == "")
            {
                lblErrorMail.Text = "This field is required !";
            }
            if (role == "")
            {
                lblErrorRole.Text = "This field is required !";
            }
            if (work == "")
            {
                lblErrorWork.Text = "This field is required !";
            }
            else
            {
                createHead();
                lblSucces.Text = "✓ The Account has been Created Successfully";

                emptyText();
                objdb.showData(q, dgv_emp);
            }

        }

        private void fillcombo()
        {
            // Fill Items to Workshop combobox
            string query = "SELECT Name FROM workshop";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query, dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbWork.Items.Add(dr["Name"].ToString());
                cmbupdateWork.Items.Add(dr["Name"].ToString());
            }
        }

        private void emptyText()
        {
            txtName.Text = "";
            txtMail.Text = "";
            cmbWork.Text = "";
            txtRole.Text = "";
            cmbupdateWork.Text = "";
            updateEmail_txtbox.Text = "";
            txtUpdRole.Text = "";
            updateName_txtbox.Text = "";
        }
    }
}
