
namespace CNPM
{
    partial class frmNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.lblCV = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNS = new System.Windows.Forms.TextBox();
            this.txtTENNV = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNS = new System.Windows.Forms.Label();
            this.lblTENNV = new System.Windows.Forms.Label();
            this.lblMANV = new System.Windows.Forms.Label();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtCV);
            this.splitContainer1.Panel1.Controls.Add(this.lblCV);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.txtSDT);
            this.splitContainer1.Panel1.Controls.Add(this.txtNS);
            this.splitContainer1.Panel1.Controls.Add(this.txtTENNV);
            this.splitContainer1.Panel1.Controls.Add(this.txtMANV);
            this.splitContainer1.Panel1.Controls.Add(this.lblSDT);
            this.splitContainer1.Panel1.Controls.Add(this.lblNS);
            this.splitContainer1.Panel1.Controls.Add(this.lblTENNV);
            this.splitContainer1.Panel1.Controls.Add(this.lblMANV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvNV);
            this.splitContainer1.Size = new System.Drawing.Size(969, 360);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(110, 176);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(160, 20);
            this.txtCV.TabIndex = 25;
            // 
            // lblCV
            // 
            this.lblCV.AutoSize = true;
            this.lblCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCV.Location = new System.Drawing.Point(35, 177);
            this.lblCV.Name = "lblCV";
            this.lblCV.Size = new System.Drawing.Size(22, 15);
            this.lblCV.TabIndex = 24;
            this.lblCV.Text = "CV";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(158, 309);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(38, 309);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(158, 253);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(38, 253);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(110, 138);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(160, 20);
            this.txtSDT.TabIndex = 19;
            // 
            // txtNS
            // 
            this.txtNS.Location = new System.Drawing.Point(110, 101);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(160, 20);
            this.txtNS.TabIndex = 18;
            // 
            // txtTENNV
            // 
            this.txtTENNV.Location = new System.Drawing.Point(110, 68);
            this.txtTENNV.Name = "txtTENNV";
            this.txtTENNV.Size = new System.Drawing.Size(160, 20);
            this.txtTENNV.TabIndex = 17;
            // 
            // txtMANV
            // 
            this.txtMANV.Location = new System.Drawing.Point(110, 27);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 16;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(35, 139);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(31, 15);
            this.lblSDT.TabIndex = 15;
            this.lblSDT.Text = "SDT";
            // 
            // lblNS
            // 
            this.lblNS.AutoSize = true;
            this.lblNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNS.Location = new System.Drawing.Point(35, 102);
            this.lblNS.Name = "lblNS";
            this.lblNS.Size = new System.Drawing.Size(63, 15);
            this.lblNS.TabIndex = 14;
            this.lblNS.Text = "NAMSINH";
            // 
            // lblTENNV
            // 
            this.lblTENNV.AutoSize = true;
            this.lblTENNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTENNV.Location = new System.Drawing.Point(35, 69);
            this.lblTENNV.Name = "lblTENNV";
            this.lblTENNV.Size = new System.Drawing.Size(47, 15);
            this.lblTENNV.TabIndex = 13;
            this.lblTENNV.Text = "TENNV";
            // 
            // lblMANV
            // 
            this.lblMANV.AutoSize = true;
            this.lblMANV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMANV.Location = new System.Drawing.Point(35, 28);
            this.lblMANV.Name = "lblMANV";
            this.lblMANV.Size = new System.Drawing.Size(41, 15);
            this.lblMANV.TabIndex = 12;
            this.lblMANV.Text = "MANV";
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNV.Location = new System.Drawing.Point(0, 0);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(642, 360);
            this.dgvNV.TabIndex = 0;
            // 
            // frmNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 360);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmNV";
            this.Text = "frmNV";
            this.Load += new System.EventHandler(this.frmNV_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNS;
        private System.Windows.Forms.TextBox txtTENNV;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNS;
        private System.Windows.Forms.Label lblTENNV;
        private System.Windows.Forms.Label lblMANV;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.Label lblCV;
        private System.Windows.Forms.DataGridView dgvNV;
    }
}