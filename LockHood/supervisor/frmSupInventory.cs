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
    public partial class frmSupInventory : Form
        
    {
        databaseClass objdb = new databaseClass();
        string workshopID = "";

        
        public frmSupInventory()
        {
            InitializeComponent();

        }

        private void frmSupInventory_Load(object sender, EventArgs e)
        {
            lblSucces.Text = "";
            lbl_errMat.Text = "";
            lbl_errquantity.Text = "";
            fillcombo();
            LoadTable();

        }

        private void LoadTable()
        {
            string getWorkshopId = "SELECT workshop_id FROM supervisor WHERE Email = '" + login.email + "'";
            var reader = objdb.readDatathroughReader(getWorkshopId);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    workshopID = reader[0].ToString();
                }
            }
            objdb.closeConn();
            string getMaterials = "SELECT NAME as Materials, Quantity  FROM materials WHERE workshop_ID = '" + workshopID + "'";
            objdb.showData(getMaterials, dgv_Mate);
            string reqMaterials = "SELECT ID,  Material as Materials, Quantity  FROM requests WHERE workshop_ID = '" + workshopID + "'";
            objdb.showData(reqMaterials, dgv_Req);
        }

        private void fillcombo()
        {
            // Fill Items to Material combobox
            string query1 = "SELECT Material FROM inventory";
            DataTable dt1 = new DataTable();

            objdb.readDatathroughAdapter(query1, dt1);

            foreach (DataRow dr1 in dt1.Rows)
            {
                cmbMate.Items.Add(dr1["Material"].ToString());
               //  cmbupdateWork.Items.Add(dr1["Name"].ToString());
            }
            objdb.closeConn();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            string material = cmbMate.Text;
            string quantity = txtQuant.Text;
            // Validations
            if (material == "")
            {
                lbl_errMat.Text = "This field is required !";
            }
            if (quantity == "")
            {
                lbl_errquantity.Text = "This field is required !";
            }
            else
            {
                requestMat(material, quantity);
                lblSucces.Text = "✓ The Material Request has been Created Successfully";
                lbl_errquantity.Text = "";
                lbl_errMat.Text = "";

                string reqMaterials = "SELECT ID,  Material as Materials, Quantity  FROM requests WHERE workshop_ID = '" + workshopID + "'";
                objdb.closeConn();
                objdb.showData(reqMaterials, dgv_Req);
            }
        }

        private void requestMat(string material, string quantity)
        {

            string query1 = "insert into requests (Quantity, Material, Workshop_ID) values ('" + quantity + "', '" + material + "', '" + workshopID + "')";//insert query
            SqlCommand dbCommand1 = new SqlCommand(query1);

            objdb.executeQuery(dbCommand1);

        }
        string rowReqID = "";
        private void dgv_Req_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ignore header click
            if (e.RowIndex == -1) return;

            var row = dgv_Req.Rows[e.RowIndex];
             rowReqID = row.Cells[2].Value.ToString();
            string rowMatname = row.Cells[3].Value.ToString();
            string rowMatquan = row.Cells[4].Value.ToString();

            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to Update " + rowReqID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    updatePanel.Visible = true;
                    Txt_matupdate.Text = rowMatname;
                    txtUpdQuan.Text = rowMatquan;
                    Txt_matupdate.Enabled = false;
                   
                }
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Do you want to delete " + rowReqID + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM requests WHERE ID='" + rowReqID + "'");
                    objdb.executeQuery(delete);
                    dgv_Req.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void btnupdateCancel_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
            lblUpdsucces.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                lblUpdsucces.Text = "";

                string quant = txtUpdQuan.Text;

                SqlCommand cmd = new SqlCommand("UPDATE requests SET Quantity=@quant WHERE (ID=@id)");//update query
                cmd.Parameters.AddWithValue("@id", rowReqID);
                cmd.Parameters.AddWithValue("@quant", quant);

                lblUpdsucces.Text = "✓ The Request has been Updated Successfully";

                objdb.executeQuery(cmd);

                string reqMaterials = "SELECT ID,  Material as Materials, Quantity  FROM requests WHERE workshop_ID = '" + workshopID + "'";
                
                objdb.showData(reqMaterials, dgv_Req);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
