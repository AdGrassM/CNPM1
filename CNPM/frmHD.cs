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
    public partial class frmHD : Form
    {
        public frmHD()
        {
            InitializeComponent();
        }
        CSDL.MCSquanlyquanan db;
        string thaotac;
        private void frmHD_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            cbxMHD.Enabled = true;
            try
            {
                db = new CSDL.MCSquanlyquanan();
                dgvHD.DataSource = db.HoaDons.OrderByDescending(h => h.NgayLHD).Take(2).ToList();
                dgvHD.Refresh();
                dgvHD.Columns[0].HeaderText = "MaHD";
                dgvHD.Columns[1].HeaderText = "NgayLHD";
                dgvHD.Columns[2].HeaderText = "MaMA";
                dgvHD.Columns[3].HeaderText = "MaNV";
                dgvHD.Columns[4].HeaderText = "TongTien";
                dgvHD.Columns[5].HeaderText = "MaKH";
                if (dgvHD.Rows.Count > 0)
                {
                    txt_databd_add();
                    txtNLap.Enabled = false;
                    txtMAMA.Enabled = false;
                    txtMANV.Enabled = false;
                    txtTT.Enabled = false;
                    txtKH.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void txt_fase()
        {
            cbxMHD.Enabled = false;
            txtNLap.Enabled = false;
            txtMAMA.Enabled = false;
            txtMANV.Enabled = false;
            txtTT.Enabled = false;
            txtKH.Enabled = false;
        }
        public void txt_reset()
        {
            cbxMHD.ResetText();
            txtNLap.ResetText();
            txtMAMA.ResetText();
            txtMANV.ResetText();
            txtTT.ResetText();
            txtKH.ResetText();
        }
        public void txt_true()
        {
            cbxMHD.Enabled = true;
            txtNLap.Enabled = true;
            txtMAMA.Enabled = true;
            txtMANV.Enabled = true;
            txtTT.Enabled = true;
            txtKH.Enabled = true;
        }
        public void txt_databd_refes()
        {
            cbxMHD.DataBindings.Clear();
            txtNLap.DataBindings.Clear();
            txtMAMA.DataBindings.Clear();
            txtMANV.DataBindings.Clear();
            txtTT.DataBindings.Clear();
            txtKH.DataBindings.Clear();
        }
        public void txt_databd_add()
        {
            cbxMHD.DataBindings.Add("text", dgvHD.DataSource, "MaHD");
            txtNLap.DataBindings.Add("text", dgvHD.DataSource, "NgayLHD");
            txtMAMA.DataBindings.Add("text", dgvHD.DataSource, "MaMA");
            txtMANV.DataBindings.Add("text", dgvHD.DataSource, "MaNV");
            txtTT.DataBindings.Add("text", dgvHD.DataSource, "TongTien");
            txtKH.DataBindings.Add("text", dgvHD.DataSource, "MaKH");
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
                cbxMHD.Enabled = false;
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
                CSDL.HoaDon ngd;
                if (thaotac == "Thêm")
                {
                    ngd = new CSDL.HoaDon();
                    db.Entry(ngd).State = System.Data.Entity.EntityState.Added;
                    ngd.MaHD = cbxMHD.Text;
                }
                else
                {
                    ngd = db.HoaDons.Where(s => s.MaHD == cbxMHD.Text).FirstOrDefault();
                    db.Entry(ngd).State = System.Data.Entity.EntityState.Modified;
                }
                ngd.NgayLHD = txtNLap.Text;
                ngd.MaNV = txtMANV.Text;
                ngd.MaMA = txtMAMA.Text;
                ngd.TongTien = txtTT.Text;
                ngd.MaKH = txtKH.Text;
                db.SaveChanges();
                dgvHD.DataSource = db.HoaDons.ToList();
                dgvHD.Refresh();
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
            if (MessageBox.Show("Ban có thực sự muốn xóa HÓA ĐƠN này?", "Khẳng định xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CSDL.HoaDon nguoidung = db.HoaDons.Where(s => s.MaHD == cbxMHD.Text).FirstOrDefault();
                db.Entry(nguoidung).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                dgvHD.DataSource = db.HoaDons.ToList();
                dgvHD.Refresh();
                txt_databd_refes();
                txt_databd_add();
            }
        }
    }
}
