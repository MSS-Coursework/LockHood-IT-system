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
    public partial class frmHeadRequests : Form
    {
        databaseClass objdb = new databaseClass();
        string q = "SELECT requests.ID, requests.Material as Name, requests.Quantity as Quantity, workshop.Name as Workshop FROM requests INNER JOIN workshop ON requests.Workshop_ID = workshop.ID";

        public frmHeadRequests()
        {
            InitializeComponent();
        }

        private void frmHeadRequests_Load(object sender, EventArgs e)
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

        private void cmbSortWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            string workShop = cmbSortWork.SelectedItem.ToString();

            string q = "SELECT requests.ID, requests.Material as Name, requests.Quantity as Quantity, workshop.Name as Workshop FROM requests INNER JOIN workshop ON requests.Workshop_ID = workshop.ID where workshop.Name='" + workShop + "'";
            objdb.createConn();
            objdb.showData(q, dgv_sub);
        }
    }
}
