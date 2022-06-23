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
    public partial class frmMA : Form
    {
        public frmMA()
        {
            InitializeComponent();
        }
        CSDL.MCSquanlyquanan db;
        string thaotac;
        private void frmMA_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            try
            {
                db = new CSDL.MCSquanlyquanan();
                dgvMA.DataSource = db.MonAns.OrderByDescending(m=>m.MaMA).ToList();
                dgvMA.Refresh();
                dgvMA.Columns[0].HeaderText = "MaMA";
                dgvMA.Columns[1].HeaderText = "TenMA";
                dgvMA.Columns[2].HeaderText = "Gia";
                if (dgvMA.Rows.Count > 0)
                {
                    txt_databd_add();
                    txt_fase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void txt_fase()
        {
            txtMAMA.Enabled = false;
            txtTENMA.Enabled = false;
            txtGIA.Enabled = false;
        }
        public void txt_reset()
        {
            txtMAMA.ResetText();
            txtTENMA.ResetText();
            txtGIA.ResetText();
        }
        public void txt_true()
        {
            txtMAMA.Enabled = true;
            txtTENMA.Enabled = true;
            txtGIA.Enabled = true;
        }
        public void txt_databd_refes()
        {
            txtMAMA.DataBindings.Clear();
            txtTENMA.DataBindings.Clear();
            txtGIA.DataBindings.Clear();
        }
        public void txt_databd_add()
        {
            txtMAMA.DataBindings.Add("text", dgvMA.DataSource, "MaMA");
            txtTENMA.DataBindings.Add("text", dgvMA.DataSource, "TenMA");
            txtGIA.DataBindings.Add("text", dgvMA.DataSource, "Gia");
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text == "Thêm")
            {
                thaotac = "Thêm";
                txt_reset();
                txt_true();
            }
            else
            {
                thaotac = "Sửa";
                txt_true();
                txtMAMA.Enabled = false;
            }

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txt_databd_refes();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                CSDL.MonAn ngd;
                if (thaotac == "Thêm")
                {
                    ngd = new CSDL.MonAn();
                    db.Entry(ngd).State = System.Data.Entity.EntityState.Added;
                    ngd.MaMA = txtMAMA.Text;
                }
                else
                {
                    ngd = db.MonAns.Where(s => s.MaMA == txtMAMA.Text).FirstOrDefault();
                    db.Entry(ngd).State = System.Data.Entity.EntityState.Modified;
                    txtMAMA.Enabled = false;
                }
                ngd.TenMA = txtTENMA.Text;
                ngd.Gia = txtGIA.Text;
                db.SaveChanges();
                dgvMA.DataSource = db.MonAns.ToList();
                dgvMA.Refresh();
                txt_databd_add();
                txt_fase();
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban có thực sự muốn xóa MÓN Ăn này?", "Khẳng định xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CSDL.MonAn nguoidung = db.MonAns.Where(s => s.MaMA == txtMAMA.Text).FirstOrDefault();
                db.Entry(nguoidung).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                dgvMA.DataSource = db.MonAns.ToList();
                dgvMA.Refresh();
                txt_databd_refes();
                txt_databd_add();
            }
        }
    }
}
