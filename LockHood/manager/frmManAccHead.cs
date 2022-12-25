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
    public partial class frmManAccHead : Form
    {
        databaseClass objdb = new databaseClass();
        string q = "select head.ID, head.Name as Name, head.Email as Email, department.Name as Department FROM head INNER JOIN department ON head.Department_ID = department.ID";

        public frmManAccHead()
        {
            InitializeComponent();
        }

        private void frmManAccHead_Load(object sender, EventArgs e)
        {


            objdb.showData(q, dgv_head);

        }
        string rowheadID;
        string rowheadname;
        string rowheademail;
        string rowheaddep;
        private void dgv_head_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ignore header click
            if (e.RowIndex == -1) return;

            var row = dgv_head.Rows[e.RowIndex];
            rowheadID = row.Cells[2].Value.ToString();
            rowheadname = row.Cells[3].Value.ToString();
            rowheademail = row.Cells[4].Value.ToString();
            rowheaddep = row.Cells[5].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                if(MessageBox.Show("Do you want to Update " + rowheadID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    updatePanel.Visible = true;
                    updateName_txtbox.Text = rowheadname;
                    updateEmail_txtbox.Text = rowheademail;
                    updateDep_txtbox.Text = rowheaddep;
                    



                }
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete " + rowheadID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM head WHERE id='" + rowheadID + "'");
                    objdb.executeQuery(delete);
                   dgv_head.Rows.RemoveAt(row.Index);
                }
            }
            }

        private void btnupdateCancel_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updateName = updateName_txtbox.Text;
            string updateEmail = updateEmail_txtbox.Text;
            SqlCommand cmd = new SqlCommand("UPDATE head SET Name=@head_name, Email=@head_email WHERE (ID=@id)");//update query
            cmd.Parameters.AddWithValue("@id", rowheadID);
            cmd.Parameters.AddWithValue("@head_email", updateEmail);
            cmd.Parameters.AddWithValue("@head_name", updateName);
            objdb.executeQuery(cmd);
            objdb.showData(q, dgv_head);
        }
    }
}
