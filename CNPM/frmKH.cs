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
    public partial class frmKH : Form
    {
        public frmKH()
        {
            InitializeComponent();
        }
        CSDL.MCSquanlyquanan db;
        string thaotac;
        private void frmKH_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            
            try
            {
                db = new CSDL.MCSquanlyquanan();
                dgvKH.DataSource = db.KhachHangs.OrderByDescending(k=>k.TenKH).ToList();
                dgvKH.Refresh();
                dgvKH.Columns[0].HeaderText = "MaKH";
                dgvKH.Columns[1].HeaderText = "TenKH";
                dgvKH.Columns[2].HeaderText = "DiaChiKH";
                dgvKH.Columns[3].HeaderText = "SDTKH";
                if (dgvKH.Rows.Count>0)
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
            cbxKH.Enabled = false;
            txtTENKH.Enabled = false;
            txtDC.Enabled = false;
            txtSDT.Enabled = false;

        }
        public void txt_reset()
        {
            cbxKH.ResetText();
            txtTENKH.ResetText();
            txtDC.ResetText();
            txtSDT.ResetText();

        }
        public void txt_true()
        {
            cbxKH.Enabled = true;
            txtTENKH.Enabled = true;
            txtDC.Enabled = true;
            txtSDT.Enabled = true;
        }
        public void txt_databd_refes()
        {
            cbxKH.DataBindings.Clear();
            txtTENKH.DataBindings.Clear();
            txtDC.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
        }
        public void txt_databd_add()
        {
            cbxKH.DataBindings.Add("text", dgvKH.DataSource, "MaKH");
            txtTENKH.DataBindings.Add("text", dgvKH.DataSource, "TenKH");
            txtDC.DataBindings.Add("text", dgvKH.DataSource, "DiaChiKH");
            txtSDT.DataBindings.Add("text", dgvKH.DataSource, "SDTKH");

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
                cbxKH.Enabled = false;
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
                CSDL.KhachHang ngd;
                if (thaotac == "Thêm")
                {
                    ngd = new CSDL.KhachHang();
                    db.Entry(ngd).State = System.Data.Entity.EntityState.Added;
                    ngd.MaKH = cbxKH.Text;
                }
                else
                {
                    ngd = db.KhachHangs.Where(s => s.MaKH == cbxKH.Text).FirstOrDefault();
                    db.Entry(ngd).State = System.Data.Entity.EntityState.Modified;
                    cbxKH.Enabled = false;
                }
                ngd.TenKH = txtTENKH.Text;
                ngd.DiaChiKH = txtDC.Text;
                ngd.SDTKH = txtSDT.Text;
                db.SaveChanges();
                dgvKH.DataSource = db.KhachHangs.ToList();
                dgvKH.Refresh();
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
            if (MessageBox.Show("Ban có thực sự muốn xóa NGƯỜI DÙNG này?", "Khẳng định xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CSDL.KhachHang nguoidung = db.KhachHangs.Where(s => s.MaKH == cbxKH.Text).FirstOrDefault();
                db.Entry(nguoidung).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                dgvKH.DataSource = db.KhachHangs.ToList();
                dgvKH.Refresh();
                txt_databd_refes();
                txt_databd_add();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            thaotac = "Sửa";
        }

        private void cbxKH_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_databd_add();
        }
    }
}
