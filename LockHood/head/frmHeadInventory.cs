using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LockHood
{

    public partial class frmHeadInventory : Form
    {
        databaseClass objdb = new databaseClass();
        string q = "SELECT materials.ID, materials.Name as Name, materials.Quantity as Quantity, workshop.Name as Workshop FROM materials INNER JOIN workshop ON materials.Workshop_ID = workshop.ID";

        public frmHeadInventory()
        {
            InitializeComponent();
        }

        private void frmHeadInventory_Load(object sender, EventArgs e)
        {
            objdb.createConn();
            objdb.showData(q, dgv_sub);
            fillcombo();
        }

        private void fillcombo()
        {
            // Fill Items to Department combobox
            string query = "SELECT Name FROM workshop";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query, dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSortWork.Items.Add(dr["Name"].ToString());
            }
        }

        private void cmbMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbMat.SelectedIndex == 0)
            {
               // string q = "SELECT materials.ID, materials.Name as Name, materials.Quantity as Quantity, workshop.Name as Workshop FROM materials INNER JOIN workshop ON materials.Workshop_ID = workshop.ID";
                objdb.createConn();
                objdb.showData(q, dgv_sub);
            }

            if (cmbMat.SelectedIndex == 1)
            {
                string q = "SELECT materials.ID, materials.Name as Name, materials.Quantity as Quantity, workshop.Name as Workshop FROM materials INNER JOIN workshop ON materials.Workshop_ID = workshop.ID where materials.Quantity<20";
                objdb.createConn();
                objdb.showData(q, dgv_sub);
            }

            if (cmbMat.SelectedIndex == 2)
            {
                string q = "SELECT materials.ID, materials.Name as Name, materials.Quantity as Quantity, workshop.Name as Workshop FROM materials INNER JOIN workshop ON materials.Workshop_ID = workshop.ID where materials.Quantity>20";
                objdb.createConn();
                objdb.showData(q, dgv_sub);
            }
        }

        private void cmbSortWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            string workShop = cmbSortWork.SelectedItem.ToString();

            string q = "SELECT materials.ID, materials.Name as Name, materials.Quantity as Quantity, workshop.Name as Workshop FROM materials INNER JOIN workshop ON materials.Workshop_ID = workshop.ID where workshop.Name='"+workShop+"'";
            objdb.createConn();
            objdb.showData(q, dgv_sub);
        }
    }
}
