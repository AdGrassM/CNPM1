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
    public partial class fremLogin : Form
    {
        public fremLogin()
        {
            InitializeComponent();
        }
        string tk = "ttk", pass = "1";
        
        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fremLogin_Load(object sender, EventArgs e)
        {
            txtTK.Text = tk;
            txtPass.Text = pass;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int i = 1;
            for (; i<=3;i++)
            {
                if (txtTK.Text == tk && txtPass.Text == pass)
                {
                    this.Close();
                    frm1 n = new frm1();
                    n.Enabled = true;
                }
                else
                {

                }
            }
            if (i == 4)
                this.Close();
        }
    }
}
