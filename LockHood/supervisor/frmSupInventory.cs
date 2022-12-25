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
    public partial class frmSupInventory : Form
        
    {
        public frmSupInventory()
        {
            InitializeComponent();
            cmbInventory.ItemHeight = 50;
        }

        private void frmSupInventory_Load(object sender, EventArgs e)
        {
            
        }
    }
}
