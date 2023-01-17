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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LockHood
{
    public partial class frmManAccHead : Form
    {
        databaseClass objdb = new databaseClass();
        string q = "SELECT head.ID, head.Name as Name, head.Email as Email, department.Name as Department FROM head INNER JOIN department ON head.Department_ID = department.ID";


        public frmManAccHead()
        {
            InitializeComponent();

            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorDepart.Text = "";

            lblUpdsucces.Text = "";
            lblSucces.Text = "";
            lblErrPass.Text = "";

        }

        private void frmManAccHead_Load(object sender, EventArgs e)
        {

            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorDepart.Text = "";
            lblErrPass.Text = "";


            lblUpdsucces.Text = "";
            lblSucces.Text = "";

            objdb.createConn();
            objdb.showData(q, dgv_head);          
            fillcombo();
        }

        string rowheadID;
        string rowheadname;
        string rowheademail;
        string rowheaddep;

        private void dgv_head_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //clear and reload combobox
            cmbDepartment.Items.Clear();
            fillcombo();

            //ignore header click
            if (e.RowIndex == -1) return;

            var row = dgv_head.Rows[e.RowIndex];
            rowheadID = row.Cells[2].Value.ToString();
            rowheadname = row.Cells[3].Value.ToString();
            rowheademail = row.Cells[4].Value.ToString();
            rowheaddep = row.Cells[5].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to Update " + rowheadID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    updatePanel.Visible = true;
                    updateName_txtbox.Text = rowheadname;
                    updateEmail_txtbox.Text = rowheademail;
                    cmbupdateDep.Text = rowheaddep;
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete " + rowheadID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM head WHERE id='" + rowheadID + "'");
                    objdb.executeQuery(delete);

                    SqlCommand delete2 = new SqlCommand("DELETE FROM login WHERE Email='" + rowheademail + "'");
                    objdb.executeQuery(delete2);

                    dgv_head.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void btnupdateCancel_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;

            //clear and reload combobox
            cmbDepartment.Items.Clear();
            fillcombo();
            emptyText();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //clear and reload combobox
            cmbDepartment.Items.Clear();
            fillcombo();

            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorDepart.Text = "";
            lblErrPass.Text = "";


            string updateName = updateName_txtbox.Text;
            string updateEmail = updateEmail_txtbox.Text;

            SqlCommand cmd = new SqlCommand("UPDATE head SET Name=@head_name, Email=@head_email WHERE (ID=@id)");//update query
            cmd.Parameters.AddWithValue("@id", rowheadID);
            cmd.Parameters.AddWithValue("@head_email", updateEmail);
            cmd.Parameters.AddWithValue("@head_name", updateName);

            updatePanel.Visible=false;
            lblSucces.Text = "✓ The Account has been Updated Successfully";
            
            objdb.executeQuery(cmd);
            objdb.showData(q, dgv_head);
            emptyText();

            
        }

        public int FindId( String name, String table)
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
            String Depart = cmbDepartment.Text;
            string password = txtPass.Text;


            int dep_id = FindId( Depart, "department");

            objdb.createConn();
            try
            {
                string query = "insert into head (Name, Email,Department_ID) values ('" + name + "',  '" + mail + "', '" + dep_id + "')";
                SqlCommand dbCommand = new SqlCommand(query);

                objdb.executeQuery(dbCommand);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            objdb.closeConn();

            objdb.createConn();
            try
            {
                string query2 = "insert into login (Email, Password, UserType) values ('" + mail + "',  '" + password + "', 'head')";
                SqlCommand dbCommand2 = new SqlCommand(query2);

                objdb.executeQuery(dbCommand2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //clear and reload combobox
            cmbDepartment.Items.Clear();
            fillcombo();

            // Read from values
            String name = txtName.Text;
            String mail = txtMail.Text;
            String depart = cmbDepartment.Text;
            string password = txtPass.Text;



            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorDepart.Text = "";
            lblErrPass.Text = "";



            // Validations
            if (name == "")
            {
                lblErrorName.Text = "This field is required !";
            }
            if (mail == "")
            {
                lblErrorMail.Text = "This field is required !";
            }
            if (depart == "")
            {
                lblErrorDepart.Text = "This field is required !";
            }

            else
            {
                createHead();
                lblSucces.Text = "✓ The Account has been Created Successfully";

                emptyText();
                objdb.showData(q, dgv_head);
            }

        }

        private void fillcombo()
        {
            // Fill Items to Department combobox
            string query = "SELECT Name FROM department";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query, dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbDepartment.Items.Add(dr["Name"].ToString());
                cmbupdateDep.Items.Add(dr["Name"].ToString());
            }
        }

        private void emptyText()
        {
            txtName.Text = "";
            txtMail.Text = "";
            cmbDepartment.Text = "";
            cmbupdateDep.Text = "";
            updateEmail_txtbox.Text = "";
            updateName_txtbox.Text = "";
        }
    }
}
