
namespace CNPM
{
    partial class frmMA
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGIA = new System.Windows.Forms.TextBox();
            this.txtTENMA = new System.Windows.Forms.TextBox();
            this.txtMAMA = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTENMA = new System.Windows.Forms.Label();
            this.lblMAMA = new System.Windows.Forms.Label();
            this.dgvMA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel1.Controls.Add(this.btnSua);
            this.splitContainer1.Panel1.Controls.Add(this.btnThem);
            this.splitContainer1.Panel1.Controls.Add(this.txtGIA);
            this.splitContainer1.Panel1.Controls.Add(this.txtTENMA);
            this.splitContainer1.Panel1.Controls.Add(this.txtMAMA);
            this.splitContainer1.Panel1.Controls.Add(this.lblGia);
            this.splitContainer1.Panel1.Controls.Add(this.lblTENMA);
            this.splitContainer1.Panel1.Controls.Add(this.lblMAMA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMA);
            this.splitContainer1.Size = new System.Drawing.Size(882, 362);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(153, 219);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(33, 219);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(153, 163);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 163);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGIA
            // 
            this.txtGIA.Location = new System.Drawing.Point(105, 103);
            this.txtGIA.Name = "txtGIA";
            this.txtGIA.Size = new System.Drawing.Size(160, 20);
            this.txtGIA.TabIndex = 32;
            // 
            // txtTENMA
            // 
            this.txtTENMA.Location = new System.Drawing.Point(105, 70);
            this.txtTENMA.Name = "txtTENMA";
            this.txtTENMA.Size = new System.Drawing.Size(160, 20);
            this.txtTENMA.TabIndex = 31;
            // 
            // txtMAMA
            // 
            this.txtMAMA.Location = new System.Drawing.Point(105, 29);
            this.txtMAMA.Name = "txtMAMA";
            this.txtMAMA.Size = new System.Drawing.Size(100, 20);
            this.txtMAMA.TabIndex = 30;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(30, 104);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(26, 15);
            this.lblGia.TabIndex = 28;
            this.lblGia.Text = "GIA";
            // 
            // lblTENMA
            // 
            this.lblTENMA.AutoSize = true;
            this.lblTENMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTENMA.Location = new System.Drawing.Point(30, 71);
            this.lblTENMA.Name = "lblTENMA";
            this.lblTENMA.Size = new System.Drawing.Size(49, 15);
            this.lblTENMA.TabIndex = 27;
            this.lblTENMA.Text = "TENMA";
            // 
            // lblMAMA
            // 
            this.lblMAMA.AutoSize = true;
            this.lblMAMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAMA.Location = new System.Drawing.Point(30, 30);
            this.lblMAMA.Name = "lblMAMA";
            this.lblMAMA.Size = new System.Drawing.Size(43, 15);
            this.lblMAMA.TabIndex = 26;
            this.lblMAMA.Text = "MAMA";
            // 
            // dgvMA
            // 
            this.dgvMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMA.Location = new System.Drawing.Point(0, 0);
            this.dgvMA.Name = "dgvMA";
            this.dgvMA.Size = new System.Drawing.Size(584, 362);
            this.dgvMA.TabIndex = 0;
            // 
            // frmMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 362);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMA";
            this.Text = "frmMA";
            this.Load += new System.EventHandler(this.frmMA_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGIA;
        private System.Windows.Forms.TextBox txtTENMA;
        private System.Windows.Forms.TextBox txtMAMA;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTENMA;
        private System.Windows.Forms.Label lblMAMA;
        private System.Windows.Forms.DataGridView dgvMA;
    }
}