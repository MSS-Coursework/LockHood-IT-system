using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LockHood
{
    public partial class frmHeadDash : Form
    {
        public frmHeadDash()
        {
            InitializeComponent();
        }

        private void frmHeadDash_Load(object sender, EventArgs e)
        {
           
            FillBarChart();
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
