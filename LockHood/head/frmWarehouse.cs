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
    public partial class frmWarehouse : Form
    {
        databaseClass objdb = new databaseClass();
        string q = "SELECT ID as MID, Material as Materials, Quantity as MQuantity from inventory";
        string q2 = "SELECT ID as ID, Material as Materials, Quantity as Quantity from requests";

        public frmWarehouse()
        {
            InitializeComponent();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            dgv_Req.AutoGenerateColumns = false;
            objdb.createConn();
            objdb.showData(q, dgv_Req);
            objdb.showData(q2, dgvIntReq);
            cleaErrlbl();
            fillcombo();
        }

        private void fillcombo()
        {
            // Fill Items to workshop combobox
            string query = "SELECT Name FROM workshop";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query, dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbWorkshop.Items.Add(dr["Name"].ToString());
            }
        }


            private void cleaErrlbl()
        {
            lblErrorName.Text = "";
            lblErrQuan.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            String material = txtMaterial.Text;
            String quantity = txtQuant.Text;


            cleaErrlbl();

            // Validations
            if (material == "")
            {
                lblErrorName.Text = "This field is required !";
            }
            if (quantity == "")
            {
                lblErrQuan.Text = "This field is required !";
            }
            else
            {
                AddMaterial();
                lblSucces.Text = "✓ The Account has been Created Successfully";
                objdb.showData(q, dgv_Req);
            }

        }

        public void AddMaterial()//adding task to task table method
        {
            String quantity = txtQuant.Text;
            String material = txtMaterial.Text;

            try
            {
                objdb.closeConn();

                string query1 = "insert into inventory (Material, Quantity) values ('" + material + "', '" + quantity + "')";
                SqlCommand dbCommand1 = new SqlCommand(query1);

                objdb.executeQuery(dbCommand1);

                objdb.closeConn();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        string material;
        string quantity;
        string id;

        private void dgv_Req_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var row = dgv_Req.Rows[e.RowIndex];
            id = row.Cells[0].Value.ToString();
            material = row.Cells[1].Value.ToString();
            quantity = row.Cells[2].Value.ToString();


            if (e.ColumnIndex == 3)
            {
                if (MessageBox.Show("Do you want to Update " + material + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    updatePanel.Visible = true;
                    txtUpdMat.Text = material;
                    txtUpdQuan.Text = quantity.ToString();
                }
            }
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Do you want to delete " + material + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand delete = new SqlCommand("DELETE FROM inventory WHERE ID='" + id + "'");
                    objdb.executeQuery(delete);
                    dgv_Req.Rows.RemoveAt(row.Index);
                }
            }
        
        }

        private void cmbWorkshop_SelectedIndexChanged(object sender, EventArgs e)
        {
            string workShop = cmbWorkshop.Text;
            string q2 = "SELECT requests.Material as Materials, requests.Quantity as Quantity from requests inner join workshop on requests.Workshop_ID = workshop.ID where workshop.Name='" + workShop + "'";

            objdb.createConn();
            objdb.showData(q2, dgvIntReq);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //clear and reload combobox
            fillcombo();


            string updateMat = txtUpdMat.Text;
            string updateQuan = txtUpdQuan.Text;

            SqlCommand cmd = new SqlCommand("UPDATE inventory SET Material=@updateMat, Quantity=@updateQuan WHERE (ID=@id)");//update query
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@updateMat", updateMat);
            cmd.Parameters.AddWithValue("@updateQuan", updateQuan);

            lblUpdsucces.Text = "✓ The Material has been Updated Successfully";

            objdb.executeQuery(cmd);
            objdb.showData(q, dgv_Req);

        }

        private void btnupdateCancel_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //clear and reload combobox
            fillcombo();

            int reqID = int.Parse(requestID);

            //get names in textbox
            string updateQuan = txtAddReqQuan.Text;
            string updName = txtAddMate.Text;

            //get material ID from mat table
            int materialID = FindId(updName, "ID", "materials", "Name");
            string matID = materialID.ToString();

            //get exisiting quantity from inventory and materials in workshop
            int currentWorkshopMatQuantity = FindQuan(matID, "Quantity", "materials");
            int currentInventoryMatQuantity = FindId(updName, "Quantity", "inventory", "Material");


            //calcualte total inventory with the requested quantity and existing workshop quantity
            int updatedMatQuantity = int.Parse(updateQuan) + currentWorkshopMatQuantity;


            //reduce mat in inventoery
            int updatedMatQuantityInInventoery = currentInventoryMatQuantity - int.Parse(updateQuan);


            SqlCommand cmd = new SqlCommand("UPDATE materials SET Quantity=@updatedMatQuantity WHERE (ID=@materialID)");//update query
            cmd.Parameters.AddWithValue("@materialID", materialID);
            cmd.Parameters.AddWithValue("@updatedMatQuantity", updatedMatQuantity);


            SqlCommand cmdUpInv = new SqlCommand("UPDATE inventory SET Quantity=@updatedMatQuantityInInventoery WHERE (Material=@updName)");//update query
            cmdUpInv.Parameters.AddWithValue("@updName", updName);
            cmdUpInv.Parameters.AddWithValue("@updatedMatQuantityInInventoery", updatedMatQuantityInInventoery);

            SqlCommand cmdDel = new SqlCommand("Delete from requests WHERE (ID=@reqID)");//update query
            cmdDel.Parameters.AddWithValue("@reqID", reqID);


            lblSucces.Text = "✓ The Material has been Sent Successfully";

            objdb.executeQuery(cmd);
            objdb.executeQuery(cmdDel);
            objdb.executeQuery(cmdUpInv);


            pnlReqUpdate.Visible = false;
            objdb.showData(q2, dgvIntReq);
            
            objdb.closeConn();
            
            objdb.showData(q, dgv_Req);

        }


        //int currentInventoryMatQuantity = FindId(updName, "Quantity", "inventory");

        public int FindId(String name, String col, String table, string whereOp)
        {
            objdb.createConn();
            int id;
            string query = "SELECT " + col + " from " + table + " WHERE " + whereOp + " =@name";


            SqlCommand dbCommand = new SqlCommand(query);
            dbCommand.Parameters.AddWithValue("@name", name);


            objdb.executeQuery(dbCommand);

            SqlDataReader dr = dbCommand.ExecuteReader();

            dr.Read();
            id = Convert.ToInt32(dr[0]);

            objdb.closeConn();
            return id;
        }

        public int FindQuan(String ID, String col, String table)
        {
            objdb.createConn();
            int quantity;
            string query = "SELECT " + col + " from " + table + " WHERE ID  =@ID";


            SqlCommand dbCommand = new SqlCommand(query);
            dbCommand.Parameters.AddWithValue("@ID", ID);

            objdb.executeQuery(dbCommand);

            SqlDataReader dr = dbCommand.ExecuteReader();

            dr.Read();
            quantity = Convert.ToInt32(dr[0]);

            objdb.closeConn();
            return quantity;
        }



        private void btnUpdReqCancel_Click(object sender, EventArgs e)
        {
            pnlReqUpdate.Visible = false;
        }

        string requestID;
        private void dgvIntReq_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var row = dgvIntReq.Rows[e.RowIndex];
            requestID = row.Cells[1].Value.ToString();
            material = row.Cells[2].Value.ToString();
            quantity = row.Cells[3].Value.ToString();


            if (e.ColumnIndex == 0)
            {
                if (MessageBox.Show("Do you want to Send " + material + " from Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    txtAddMate.Enabled = false;
                    pnlReqUpdate.Visible = true;
                    txtAddMate.Text = material;
                    txtAddReqQuan.Text = quantity.ToString();
                }
            }
        }
    }
}
