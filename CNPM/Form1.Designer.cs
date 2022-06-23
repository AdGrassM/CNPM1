
namespace CNPM
{
    partial class frm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolKH = new System.Windows.Forms.ToolStripMenuItem();
            this.toolNV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolHD = new System.Windows.Forms.ToolStripMenuItem();
            this.toolout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(112, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wellcome to Bao Ngon";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu,
            this.toolLogin,
            this.toolLogout,
            this.toolout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolMenu
            // 
            this.toolMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolKH,
            this.toolNV,
            this.toolMA,
            this.toolHD});
            this.toolMenu.Name = "toolMenu";
            this.toolMenu.Size = new System.Drawing.Size(50, 20);
            this.toolMenu.Text = "Menu";
            // 
            // toolLogin
            // 
            this.toolLogin.Name = "toolLogin";
            this.toolLogin.Size = new System.Drawing.Size(49, 20);
            this.toolLogin.Text = "Login";
            this.toolLogin.Click += new System.EventHandler(this.toolLogin_Click);
            // 
            // toolLogout
            // 
            this.toolLogout.Name = "toolLogout";
            this.toolLogout.Size = new System.Drawing.Size(57, 20);
            this.toolLogout.Text = "Logout";
            this.toolLogout.Click += new System.EventHandler(this.toolLogout_Click);
            // 
            // toolKH
            // 
            this.toolKH.Name = "toolKH";
            this.toolKH.Size = new System.Drawing.Size(180, 22);
            this.toolKH.Text = "QLKH";
            this.toolKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // toolNV
            // 
            this.toolNV.Name = "toolNV";
            this.toolNV.Size = new System.Drawing.Size(180, 22);
            this.toolNV.Text = "QLNV";
            this.toolNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // toolMA
            // 
            this.toolMA.Name = "toolMA";
            this.toolMA.Size = new System.Drawing.Size(180, 22);
            this.toolMA.Text = "QLMA";
            this.toolMA.Click += new System.EventHandler(this.btnMA_Click);
            // 
            // toolHD
            // 
            this.toolHD.Name = "toolHD";
            this.toolHD.Size = new System.Drawing.Size(180, 22);
            this.toolHD.Text = "QLHD";
            this.toolHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // toolout
            // 
            this.toolout.Name = "toolout";
            this.toolout.Size = new System.Drawing.Size(39, 20);
            this.toolout.Text = "Out";
            this.toolout.Click += new System.EventHandler(this.toolout_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::CNPM.Properties.Resources.bannerdoan;
            this.ClientSize = new System.Drawing.Size(805, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm1";
            this.Text = "QL Bao Ngon";
            this.Load += new System.EventHandler(this.frm1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolMenu;
        private System.Windows.Forms.ToolStripMenuItem toolKH;
        private System.Windows.Forms.ToolStripMenuItem toolNV;
        private System.Windows.Forms.ToolStripMenuItem toolMA;
        private System.Windows.Forms.ToolStripMenuItem toolHD;
        private System.Windows.Forms.ToolStripMenuItem toolLogin;
        private System.Windows.Forms.ToolStripMenuItem toolLogout;
        private System.Windows.Forms.ToolStripMenuItem toolout;
    }
}

