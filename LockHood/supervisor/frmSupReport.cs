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
            ReportViewerSup.LocalReport.ReportPath = @"E:\Lock-Hood\LockHood-IT-system\LockHood\supervisor\Reports\ReportSupEmp.rdlc";
            ReportViewerSup.LocalReport.DataSources.Clear();
            ReportViewerSup.LocalReport.DataSources.Add(rds);
            ReportViewerSup.RefreshReport();
        }

        private void frmSupReport_Load(object sender, EventArgs e)
        {
            objdb.createConn();
            this.ReportViewerSup.RefreshReport();
            //fillcombo();
        }
    }
}
