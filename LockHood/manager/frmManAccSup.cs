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
using System.Xml.Linq;

namespace LockHood
{
    public partial class frmManAccSup : Form
    {
        databaseClass objdb = new databaseClass();
        string q = "select supervisor.ID, supervisor.Name as Name, supervisor.Email as Email, workshop.Name as Workshop FROM supervisor INNER JOIN workshop ON supervisor.Workshop_ID = workshop.ID";

        public frmManAccSup()
        {
            InitializeComponent();

            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorWork.Text = "";

            lblUpdsucces.Text = "";
            lblSucces.Text = "";
        }

        private void frmManAccSup_Load(object sender, EventArgs e)
        {
            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorWork.Text = "";

            lblUpdsucces.Text = "";
            lblSucces.Text = "";

            objdb.createConn();
            objdb.showData(q, dgv_sup);
            fillcombo();
        }

        string rowsupID;
        string rowsupname;
        string rowsupemail;
        string rowsupwork;

        private void dgv_sup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //clear and reload combobox
            cmbWork.Items.Clear();
            cmbupdateWork.Items.Clear();
            fillcombo();

            //ignore header click
            if (e.RowIndex == -1) return;

            var row = dgv_sup.Rows[e.RowIndex];
            rowsupID = row.Cells[2].Value.ToString();
            rowsupname = row.Cells[3].Value.ToString();
            rowsupemail = row.Cells[4].Value.ToString();
            rowsupwork = row.Cells[5].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to Update " + rowsupID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    updatePanel.Visible = true;
                    updateName_txtbox.Text = rowsupname;
                    updateEmail_txtbox.Text = rowsupemail;
                    cmbupdateWork.Text = rowsupwork;
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete " + rowsupID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM supervisor WHERE id='" + rowsupID + "'");
                    objdb.executeQuery(delete);
                    dgv_sup.Rows.RemoveAt(row.Index);
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

            string updateName = updateName_txtbox.Text;
            string updateEmail = updateEmail_txtbox.Text;

            SqlCommand cmd = new SqlCommand("UPDATE supervisor SET Name=@sup_name, Email=@sup_email WHERE (ID=@id)");//update query
            cmd.Parameters.AddWithValue("@id", rowsupID);
            cmd.Parameters.AddWithValue("@sup_email", updateEmail);
            cmd.Parameters.AddWithValue("@sup_name", updateName);

            lblUpdsucces.Text = "✓ The Account has been Updated Successfully";

            objdb.executeQuery(cmd);
            objdb.showData(q, dgv_sup);
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
            String work = cmbWork.Text;

            int work_id = FindId(work, "workshop");

            objdb.createConn();
            try
            {
                string query = "insert into supervisor (Name, Email, Workshop_ID) values ('" + name + "',  '" + mail + "', '" + work_id + "')";
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
            String work = cmbWork.Text;


            // Empty Error Labels
            lblErrorMail.Text = "";
            lblErrorName.Text = "";
            lblErrorWork.Text = "";


            // Validations
            if (name == "")
            {
                lblErrorName.Text = "This field is required !";
            }
            if (mail == "")
            {
                lblErrorMail.Text = "This field is required !";
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
                objdb.showData(q, dgv_sup);
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
            cmbupdateWork.Text = "";
            updateEmail_txtbox.Text = "";
            updateName_txtbox.Text = "";
        }
    }
}
