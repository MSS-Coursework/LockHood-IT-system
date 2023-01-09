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
    public partial class frmSupReport : Form
    {
        databaseClass objdb = new databaseClass();

        public frmSupReport()
        {
            InitializeComponent();
        }

        private void btnEmpAll_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT employee.ID, employee.Name, employee.Email, employee.Role, workshop.Name AS Workshop FROM employee INNER JOIN workshop ON workshop.ID = employee.Workshop_ID";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet2", dt);
            ReportViewerSup.LocalReport.ReportPath = @"D:\Lock-Hood\LockHood-IT-system\LockHood\supervisor\Reports\ReportSupEmp.rdlc";
            ReportViewerSup.LocalReport.DataSources.Clear();
            ReportViewerSup.LocalReport.DataSources.Add(rds);
            ReportViewerSup.RefreshReport();
        }

        private void frmSupReport_Load(object sender, EventArgs e)
        {
            objdb.createConn();
            this.ReportViewerSup.RefreshReport();
            fillcombo();
            //fillcombo();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT requests.ID, requests.Material, requests.Quantity from requests";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet2", dt);
            ReportViewerSup.LocalReport.ReportPath = @"D:\Lock-Hood\LockHood-IT-system\LockHood\supervisor\Reports\rptRequest.rdlc";
            ReportViewerSup.LocalReport.DataSources.Clear();
            ReportViewerSup.LocalReport.DataSources.Add(rds);
            ReportViewerSup.RefreshReport();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT materials.ID, materials.Name, materials.Quantity from materials";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet2", dt);
            ReportViewerSup.LocalReport.ReportPath = @"D:\Lock-Hood\LockHood-IT-system\LockHood\supervisor\Reports\rptMaterials.rdlc";
            ReportViewerSup.LocalReport.DataSources.Clear();
            ReportViewerSup.LocalReport.DataSources.Add(rds);
            ReportViewerSup.RefreshReport();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT sub_task.ID, sub_task.Name, sub_task.Status, sub_task.Date, employee.Name as Employee from sub_task INNER JOIN employee ON sub_task.Employee_ID = employee.ID where sub_task.Status = '" + cmbTask.Text + "'";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet2", dt);
            ReportViewerSup.LocalReport.ReportPath = @"D:\Lock-Hood\LockHood-IT-system\LockHood\supervisor\Reports\rptSubTask.rdlc";
            ReportViewerSup.LocalReport.DataSources.Clear();
            ReportViewerSup.LocalReport.DataSources.Add(rds);
            ReportViewerSup.RefreshReport();
        }

        private void btnTaskAll_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            string query = "SELECT sub_task.ID, sub_task.Name, sub_task.Status, sub_task.Date, employee.Name as Employee from sub_task INNER JOIN employee ON sub_task.Employee_ID = employee.ID";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet2", dt);
            ReportViewerSup.LocalReport.ReportPath = @"D:\Lock-Hood\LockHood-IT-system\LockHood\supervisor\Reports\rptSubTask.rdlc";
            ReportViewerSup.LocalReport.DataSources.Clear();
            ReportViewerSup.LocalReport.DataSources.Add(rds);
            ReportViewerSup.RefreshReport();
        }
        private void fillcombo()
        {
            // Fill Items to workshop combobox
            string query = "SELECT Name FROM workshop";
            DataTable dt = new DataTable();

            objdb.readDatathroughAdapter(query, dt);

            foreach (DataRow dr in dt.Rows)
            {
                cmbEmpl.Items.Add(dr["Name"].ToString());
            }

            
        }
        private void btnEmp_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT employee.ID, employee.Name, employee.Email, employee.Role, workshop.Name as Workshop  from employee INNER JOIN workshop ON employee.Workshop_ID = workshop.ID ";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet2", dt);
            ReportViewerSup.LocalReport.ReportPath = @"D:\Lock-Hood\LockHood-IT-system\LockHood\supervisor\Reports\ReportSupEmp.rdlc";
            ReportViewerSup.LocalReport.DataSources.Clear();
            ReportViewerSup.LocalReport.DataSources.Add(rds);
            ReportViewerSup.RefreshReport();
        }

        private void btnEmp_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string query = "SELECT employee.ID, employee.Name, employee.Email, employee.Role, workshop.Name as Workshop  from employee INNER JOIN workshop ON employee.Workshop_ID = workshop.ID where workshop.Name = '" + cmbEmpl.Text + "'";

            objdb.readDatathroughAdapter(query, dt);

            ReportDataSource rds = new ReportDataSource("DataSet2", dt);
            ReportViewerSup.LocalReport.ReportPath = @"D:\Lock-Hood\LockHood-IT-system\LockHood\supervisor\Reports\ReportSupEmp.rdlc";
            ReportViewerSup.LocalReport.DataSources.Clear();
            ReportViewerSup.LocalReport.DataSources.Add(rds);
            ReportViewerSup.RefreshReport();
        }
    }
}
