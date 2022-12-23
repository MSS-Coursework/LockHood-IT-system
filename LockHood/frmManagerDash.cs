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
    public partial class frmManagerDash : Form
    {
        public frmManagerDash()
        {
            InitializeComponent();
        }

        private void frmManagerDash_Load(object sender, EventArgs e)
        {
            FillPieChart();
            FillBarChart();
        }

        private void FillPieChart()//fill pie chart by c charp corner
        {
            chart2.Titles.Add("status");
            chart2.Series["Series1"].Points.AddXY("accept", 30);
            chart2.Series["Series1"].Points.AddXY("pending", 20);
            chart2.Series["Series1"].Points.AddXY("progress", 50);
        }
        private void FillBarChart()//fill pie chart by c charp corner
        {
            chart1.Titles.Add("Progress");
            chart1.Series["Series1"].Points.AddXY("Engineering", 30);
            chart1.Series["Series1"].Points.AddXY("Design", 20);
            chart1.Series["Series1"].Points.AddXY("R & D", 50);
            chart1.Series["Series1"].Points.AddXY("Purchasing", 80);
            chart1.Series["Series1"].Points.AddXY("IT", 80);
        }
    }
}
