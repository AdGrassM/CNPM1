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
    public partial class frmNV : Form
    {
        public frmNV()
        {
            InitializeComponent();
        }
        CSDL.MCSquanlyquanan db;
        string thaotac;
        private void frmNV_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            try
            {
                db = new CSDL.MCSquanlyquanan();
                dgvNV.DataSource = db.NhanViens.OrderBy(n=>n.HoTen).ToList();
                dgvNV.Refresh();
                dgvNV.Columns[0].HeaderText = "MaNV";
                dgvNV.Columns[1].HeaderText = "HoTen";
                dgvNV.Columns[2].HeaderText = "NgaySinh";
                dgvNV.Columns[3].HeaderText = "SoDT";
                dgvNV.Columns[4].HeaderText = "ChucVu";
                if (dgvNV.Rows.Count > 0)
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
            txtMANV.Enabled = false;
            txtTENNV.Enabled = false;
            txtNS.Enabled = false;
            txtSDT.Enabled = false;
            txtCV.Enabled = false;
        }
        public void txt_reset()
        {
            txtMANV.ResetText();
            txtTENNV.ResetText();
            txtNS.ResetText();
            txtSDT.ResetText();
            txtCV.ResetText();
        }
        public void txt_true()
        {
            txtMANV.Enabled = true;
            txtTENNV.Enabled = true;
            txtNS.Enabled = true;
            txtSDT.Enabled = true;
            txtCV.Enabled = true;
        }
        public void txt_databd_refes()
        {
            txtMANV.DataBindings.Clear();
            txtTENNV.DataBindings.Clear();
            txtNS.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtCV.DataBindings.Clear();
        }
        public void txt_databd_add()
        {
            txtMANV.DataBindings.Add("text", dgvNV.DataSource, "MaNV");
            txtTENNV.DataBindings.Add("text", dgvNV.DataSource, "HoTen");
            txtNS.DataBindings.Add("text", dgvNV.DataSource, "NgaySinh");
            txtSDT.DataBindings.Add("text", dgvNV.DataSource, "SoDT");
            txtCV.DataBindings.Add("text", dgvNV.DataSource, "ChucVu");
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
                txtMANV.Enabled = false;
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
                CSDL.NhanVien ngd;
                if (thaotac == "Thêm")
                {
                    ngd = new CSDL.NhanVien();
                    db.Entry(ngd).State = System.Data.Entity.EntityState.Added;
                    ngd.MaNV = txtMANV.Text;
                }
                else
                {
                    ngd = db.NhanViens.Where(s => s.MaNV == txtMANV.Text).FirstOrDefault();
                    db.Entry(ngd).State = System.Data.Entity.EntityState.Modified;
                    txtMANV.Enabled = false;
                }
                ngd.HoTen = txtTENNV.Text;
                ngd.NgaySinh = txtNS.Text;
                ngd.SoDT = txtSDT.Text;
                ngd.ChucVu = txtCV.Text;
                db.SaveChanges();
                dgvNV.DataSource = db.NhanViens.ToList();
                dgvNV.Refresh();
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
            if (MessageBox.Show("Ban có thực sự muốn xóa NHÂN VIÊN này?", "Khẳng định xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CSDL.NhanVien nguoidung = db.NhanViens.Where(s => s.MaNV == txtMANV.Text).FirstOrDefault();
                db.Entry(nguoidung).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                dgvNV.DataSource = db.NhanViens.ToList();
                dgvNV.Refresh();
                txt_databd_refes();
                txt_databd_add();
            }
        }

    }
}
