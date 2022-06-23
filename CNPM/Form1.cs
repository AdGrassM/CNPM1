using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            frmKH kh = new frmKH();
            kh.Show();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            frmNV nv = new frmNV();
            nv.Show();
        }

        private void btnMA_Click(object sender, EventArgs e)
        {
            frmMA ma = new frmMA();
            ma.Show();
        }

        private void frm1_Load(object sender, EventArgs e)
        {

            toolMenu.Enabled = false;
            toolLogout.Enabled = false; 
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            frmHD hd = new frmHD();
            hd.Show();
        }

        private void toolLogin_Click(object sender, EventArgs e)
        {
            this.Enabled=false;
            fremLogin login = new fremLogin();
            login.Show();
            toolMenu.Enabled = true;
            toolLogin.Enabled = false;
            toolLogout.Enabled = true;
            this.Enabled = true;
        }

        private void toolLogout_Click(object sender, EventArgs e)
        {
            fremLogin m = new fremLogin();
            m.Show();
            toolLogout.Enabled = false;
            toolLogin.Enabled = true;
            toolMenu.Enabled = false;
        }

        private void toolout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
