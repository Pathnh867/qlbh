using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            Text = "Quản trị - " + Utility.Username;
        }

        private void orderToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            fManageCustomer f = new fManageCustomer();

            
            f.MdiParent = this;

            
            f.Show();
        }
    }
}