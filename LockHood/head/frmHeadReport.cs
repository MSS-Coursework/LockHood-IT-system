using Microsoft.Reporting.WinForms;
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
    public partial class frmHeadReport : Form
    {
        databaseClass objdb = new databaseClass();

        public frmHeadReport()
        {
            InitializeComponent();
        }

        private void frmHeadReport_Load(object sender, EventArgs e)
        {
            objdb.createConn();
            this.rptViewerHead.RefreshReport();
            fillcombo();
        }

        private void fillcombo()
        {
            //empty combo
            cmbSubTask.Items.Clear();
            cmbEmployee.Items.Clear();
            cmbTask.Items.Clear();

            // Fill Items to workshop combobox
            string query = "SELECT Name FROM Task";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query, dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbSubTask.Items.Add(dr["Name"].ToString());
            }

            // Fill Items to workshop combobox
            string query1 = "SELECT Name FROM workshop";
            DataTable dt1 = new DataTable();

            objdb.readDatathroughAdapter(query1, dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                cmbEmployee.Items.Add(dr["Name"].ToString());
                cmbTask.Items.Add(dr["Name"].ToString());
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT employee.ID, employee.Name, employee.Email, employee.Role, workshop.Name AS Workshop FROM workshop INNER JOIN employee ON workshop.ID = employee.Workshop_ID WHERE workshop.Name ='"+cmbEmployee.Text+"'";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet3", dt);
            rptViewerHead.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\head\Reports\rptEmployee.rdlc";
            rptViewerHead.LocalReport.DataSources.Clear();
            rptViewerHead.LocalReport.DataSources.Add(rds);
            rptViewerHead.RefreshReport();
        }

        private void btnEmployeeAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT employee.ID, employee.Name, employee.Email, employee.Role, workshop.Name AS Workshop FROM employee INNER JOIN workshop ON workshop.ID = employee.Workshop_ID";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet3", dt);
            rptViewerHead.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\head\Reports\rptEmployee.rdlc";
            rptViewerHead.LocalReport.DataSources.Clear();
            rptViewerHead.LocalReport.DataSources.Add(rds);
            rptViewerHead.RefreshReport();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM inventory ORDER BY Quantity DESC";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet3", dt);
            rptViewerHead.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\head\Reports\rptInventory.rdlc";
            rptViewerHead.LocalReport.DataSources.Clear();
            rptViewerHead.LocalReport.DataSources.Add(rds);
            rptViewerHead.RefreshReport();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT task.ID, task.Name, task.Status, task.Date, department.Name AS Department, workshop.Name AS Workshop FROM((department INNER JOIN workshop ON workshop.Department_ID = department.ID) INNER JOIN task ON task.Workshop_ID = workshop.ID) WHERE workshop.Name = '" + cmbTask.Text + "'";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet3", dt);
            rptViewerHead.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\head\Reports\rptTask.rdlc";
            rptViewerHead.LocalReport.DataSources.Clear();
            rptViewerHead.LocalReport.DataSources.Add(rds);
            rptViewerHead.RefreshReport();
        }

        private void btnTaskAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT task.ID, task.Name, task.Status, task.Date, department.Name AS Department, workshop.Name AS Workshop FROM((department INNER JOIN workshop ON workshop.Department_ID = department.ID) INNER JOIN task ON task.Workshop_ID = workshop.ID)";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet3", dt);
            rptViewerHead.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\head\Reports\rptTask.rdlc";
            rptViewerHead.LocalReport.DataSources.Clear();
            rptViewerHead.LocalReport.DataSources.Add(rds);
            rptViewerHead.RefreshReport();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT sub_task.ID, sub_task.Name, sub_task.Status, sub_task.Date, task.Name AS Task, workshop.Name AS Workshop FROM((task INNER JOIN sub_task ON sub_task.Task_ID = task.ID) INNER JOIN workshop ON task.Workshop_ID = workshop.ID) WHERE task.Name = '" + cmbSubTask.Text + "'";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet3", dt);
            rptViewerHead.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\head\Reports\rptSubTask.rdlc";
            rptViewerHead.LocalReport.DataSources.Clear();
            rptViewerHead.LocalReport.DataSources.Add(rds);
            rptViewerHead.RefreshReport();
        }

        private void btnSubAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT sub_task.ID, sub_task.Name, sub_task.Status, sub_task.Date, task.Name AS Task, workshop.Name AS Workshop FROM((task INNER JOIN sub_task ON sub_task.Task_ID = task.ID) INNER JOIN workshop ON task.Workshop_ID = workshop.ID)";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet3", dt);
            rptViewerHead.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\head\Reports\rptSubTask.rdlc";
            rptViewerHead.LocalReport.DataSources.Clear();
            rptViewerHead.LocalReport.DataSources.Add(rds);
            rptViewerHead.RefreshReport();
        }
    }
}
