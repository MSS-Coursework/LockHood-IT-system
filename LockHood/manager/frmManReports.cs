using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
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
    public partial class frmManReports : Form
    {
        databaseClass objdb = new databaseClass();

        public frmManReports()
        {
            InitializeComponent();
        }

        private void frmManReports_Load(object sender, EventArgs e)
        {
            objdb.createConn();
            this.rptviewerMan.RefreshReport();
            fillcombo();
        }

        private void fillcombo()
        {
            // Clear combo
            cmbTask.Items.Clear();
            cmbSupervisor.Items.Clear();
            cmbInventory.Items.Clear();

            // Fill Items to workshop combobox
            string query = "SELECT Name FROM department";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query, dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbInventory.Items.Add(dr["Name"].ToString());
                cmbSupervisor.Items.Add(dr["Name"].ToString());

            }
            // Fill Items to workshop combobox
            string query1 = "SELECT Name FROM workshop";
            DataTable dt1 = new DataTable();

            objdb.readDatathroughAdapter(query1, dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                cmbTask.Items.Add(dr["Name"].ToString());
            }
        }

        private void btnInvent_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT materials.ID, materials.Name, materials.Quantity, workshop.Name AS Workshop, department.Name AS Department FROM((workshop INNER JOIN department ON workshop.Department_ID = department.ID) INNER JOIN materials ON materials.Workshop_ID = workshop.ID) WHERE department.Name = '" + cmbInventory.Text + "'";
            
            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptviewerMan.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\manager\Reports\rptManInventory.rdlc";
            rptviewerMan.LocalReport.DataSources.Clear();
            rptviewerMan.LocalReport.DataSources.Add(rds);
            rptviewerMan.RefreshReport();
        }

        private void btnAllinven_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT materials.ID, materials.Name, materials.Quantity, workshop.Name AS Workshop, department.Name AS Department FROM((workshop INNER JOIN department ON workshop.Department_ID = department.ID) INNER JOIN materials ON materials.Workshop_ID = workshop.ID)";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptviewerMan.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\manager\Reports\rptManInventory.rdlc";
            rptviewerMan.LocalReport.DataSources.Clear();
            rptviewerMan.LocalReport.DataSources.Add(rds);
            rptviewerMan.RefreshReport();
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;

            DataTable dt = new DataTable();
            string query = "SELECT Product, SUM(Sales) AS Sales, SUM(Cost) AS Cost FROM income WHERE Date BETWEEN '" + start+"' AND '"+end+ "'  GROUP BY Product";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptviewerMan.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\manager\Reports\ReportManIncome.rdlc";
            rptviewerMan.LocalReport.DataSources.Clear();
            rptviewerMan.LocalReport.DataSources.Add(rds);
            rptviewerMan.RefreshReport();
        }

        private void btnIncoAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT Product, SUM(Sales) AS Sales, SUM(Cost) AS Cost FROM income GROUP BY Product";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptviewerMan.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\manager\Reports\ReportManIncome.rdlc";
            rptviewerMan.LocalReport.DataSources.Clear();
            rptviewerMan.LocalReport.DataSources.Add(rds);
            rptviewerMan.RefreshReport();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT task.ID, task.Name, task.Status,  task.Date, department.Name AS Department, workshop.Name AS Workshop FROM((workshop INNER JOIN task ON task.Workshop_ID = workshop.ID) INNER JOIN department ON task.Department_ID = department.ID) WHERE workshop.Name = '" + cmbTask.Text + "'";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptviewerMan.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\manager\Reports\rptManTask.rdlc";
            rptviewerMan.LocalReport.DataSources.Clear();
            rptviewerMan.LocalReport.DataSources.Add(rds);
            rptviewerMan.RefreshReport();
        }

        private void btnAllTask_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT task.ID, task.Name, task.Status,  task.Date, department.Name AS Department, workshop.Name AS Workshop FROM((task INNER JOIN department ON task.Department_ID = department.ID) INNER JOIN workshop ON task.Workshop_ID = workshop.ID)";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptviewerMan.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\manager\Reports\rptManTask.rdlc";
            rptviewerMan.LocalReport.DataSources.Clear();
            rptviewerMan.LocalReport.DataSources.Add(rds);
            rptviewerMan.RefreshReport();
        }

        private void btnSuper_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string query = "SELECT supervisor.ID, supervisor.Name, supervisor.Email, workshop.Name AS Workshop, department.Name AS Department FROM((workshop INNER JOIN department ON workshop.Department_ID = department.ID) INNER JOIN supervisor ON supervisor.Workshop_ID = workshop.ID) WHERE department.Name = '" + cmbSupervisor.Text + "'";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptviewerMan.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\manager\Reports\rptManSupervisors.rdlc";
            rptviewerMan.LocalReport.DataSources.Clear();
            rptviewerMan.LocalReport.DataSources.Add(rds);
            rptviewerMan.RefreshReport();
            
        }

        private void btnSuperAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT supervisor.ID, supervisor.Name, supervisor.Email, workshop.Name AS Workshop, department.Name AS Department FROM((workshop INNER JOIN department ON workshop.Department_ID = department.ID) INNER JOIN supervisor ON supervisor.Workshop_ID = workshop.ID)";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            rptviewerMan.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\manager\Reports\rptManSupervisors.rdlc";
            rptviewerMan.LocalReport.DataSources.Clear();
            rptviewerMan.LocalReport.DataSources.Add(rds);
            rptviewerMan.RefreshReport();
        }

        private void Switch(int switchStatement)
        {
            //switch (switchStatement)
            //{
            //    case 1:
            //        Console.WriteLine("1");

            //        break;

            //    case 2:
            //        Console.WriteLine("2");
            //        break;

            //    case 3:
                    
            //        continue;

            //    default:
            //        Console.WriteLine(switchStatement);
            //        break;

            //}
            
        }
    }
}
