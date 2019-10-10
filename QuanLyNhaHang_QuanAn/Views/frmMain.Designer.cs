namespace QuanLyNhaHang_QuanAn.Views
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.TabHienThi = new System.Windows.Forms.TabControl();
            this.ctxtmenuTabHienThi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemDongTrang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDongTrangAll = new System.Windows.Forms.ToolStripMenuItem();
            this.khuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lựaChọnKhuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngKhuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thứcUốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmenuTabBan = new System.Windows.Forms.MenuStrip();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gọiMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtmenuTabHienThi.SuspendLayout();
            this.ctxtmenuTabBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabHienThi
            // 
            this.TabHienThi.ContextMenuStrip = this.ctxtmenuTabHienThi;
            this.TabHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabHienThi.Location = new System.Drawing.Point(0, 28);
            this.TabHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.TabHienThi.Name = "TabHienThi";
            this.TabHienThi.SelectedIndex = 0;
            this.TabHienThi.Size = new System.Drawing.Size(1371, 885);
            this.TabHienThi.TabIndex = 1;
            // 
            // ctxtmenuTabHienThi
            // 
            this.ctxtmenuTabHienThi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtmenuTabHienThi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDongTrang,
            this.menuItemDongTrangAll});
            this.ctxtmenuTabHienThi.Name = "ctxtmenuTabHienThi";
            this.ctxtmenuTabHienThi.Size = new System.Drawing.Size(208, 52);
            // 
            // menuItemDongTrang
            // 
            this.menuItemDongTrang.Name = "menuItemDongTrang";
            this.menuItemDongTrang.Size = new System.Drawing.Size(207, 24);
            this.menuItemDongTrang.Text = "Đóng trang hiện tại";
            this.menuItemDongTrang.Click += new System.EventHandler(this.menuItemDongTrang_Click);
            // 
            // menuItemDongTrangAll
            // 
            this.menuItemDongTrangAll.Name = "menuItemDongTrangAll";
            this.menuItemDongTrangAll.Size = new System.Drawing.Size(207, 24);
            this.menuItemDongTrangAll.Text = "Đóng tất cả";
            this.menuItemDongTrangAll.Click += new System.EventHandler(this.menuItemDongTrangAll_Click);
            // 
            // khuVựcToolStripMenuItem
            // 
            this.khuVựcToolStripMenuItem.BackColor = System.Drawing.Color.Magenta;
            this.khuVựcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lựaChọnKhuVựcToolStripMenuItem,
            this.hệThốngKhuVựcToolStripMenuItem});
            this.khuVựcToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.khuVựcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khuVựcToolStripMenuItem.Image")));
            this.khuVựcToolStripMenuItem.Name = "khuVựcToolStripMenuItem";
            this.khuVựcToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.khuVựcToolStripMenuItem.Text = "Khu vực";
            // 
            // lựaChọnKhuVựcToolStripMenuItem
            // 
            this.lựaChọnKhuVựcToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.lựaChọnKhuVựcToolStripMenuItem.Image = global::QuanLyNhaHang_QuanAn.Properties.Resources.BanTrong;
            this.lựaChọnKhuVựcToolStripMenuItem.Name = "lựaChọnKhuVựcToolStripMenuItem";
            this.lựaChọnKhuVựcToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.lựaChọnKhuVựcToolStripMenuItem.Text = "Bàn khu vực";
            this.lựaChọnKhuVựcToolStripMenuItem.Click += new System.EventHandler(this.lựaChọnKhuVựcToolStripMenuItem_Click);
            // 
            // hệThốngKhuVựcToolStripMenuItem
            // 
            this.hệThốngKhuVựcToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.hệThốngKhuVựcToolStripMenuItem.Image = global::QuanLyNhaHang_QuanAn.Properties.Resources.KhuVuc;
            this.hệThốngKhuVựcToolStripMenuItem.Name = "hệThốngKhuVựcToolStripMenuItem";
            this.hệThốngKhuVựcToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.hệThốngKhuVựcToolStripMenuItem.Text = "Hệ thống khu vực";
            this.hệThốngKhuVựcToolStripMenuItem.Click += new System.EventHandler(this.hệThốngKhuVựcToolStripMenuItem_Click);
            // 
            // khoHàngToolStripMenuItem
            // 
            this.khoHàngToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.khoHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mónĂnToolStripMenuItem,
            this.thứcUốngToolStripMenuItem});
            this.khoHàngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.khoHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("khoHàngToolStripMenuItem.Image")));
            this.khoHàngToolStripMenuItem.Name = "khoHàngToolStripMenuItem";
            this.khoHàngToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.khoHàngToolStripMenuItem.Text = "Thực đơn";
            // 
            // mónĂnToolStripMenuItem
            // 
            this.mónĂnToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mónĂnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mónĂnToolStripMenuItem.Image")));
            this.mónĂnToolStripMenuItem.Name = "mónĂnToolStripMenuItem";
            this.mónĂnToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.mónĂnToolStripMenuItem.Text = "Loại thực đơn";
            this.mónĂnToolStripMenuItem.Click += new System.EventHandler(this.mónĂnToolStripMenuItem_Click);
            // 
            // thứcUốngToolStripMenuItem
            // 
            this.thứcUốngToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.thứcUốngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thứcUốngToolStripMenuItem.Image")));
            this.thứcUốngToolStripMenuItem.Name = "thứcUốngToolStripMenuItem";
            this.thứcUốngToolStripMenuItem.Size = new System.Drawing.Size(175, 26);
            this.thứcUốngToolStripMenuItem.Text = "Thực đơn";
            this.thứcUốngToolStripMenuItem.Click += new System.EventHandler(this.thứcUốngToolStripMenuItem_Click);
            // 
            // ctxtmenuTabBan
            // 
            this.ctxtmenuTabBan.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxtmenuTabBan.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem,
            this.khuVựcToolStripMenuItem,
            this.khoHàngToolStripMenuItem,
            this.gọiMónToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.ctxtmenuTabBan.Location = new System.Drawing.Point(0, 0);
            this.ctxtmenuTabBan.Name = "ctxtmenuTabBan";
            this.ctxtmenuTabBan.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.ctxtmenuTabBan.Size = new System.Drawing.Size(1371, 28);
            this.ctxtmenuTabBan.TabIndex = 0;
            this.ctxtmenuTabBan.Text = "menuStrip1";
            this.ctxtmenuTabBan.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxtmenuTabBan_ItemClicked);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNhânViênToolStripMenuItem1,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.phânQuyềnSửDụngToolStripMenuItem});
            this.quảnLýNhânViênToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.quảnLýNhânViênToolStripMenuItem.Image = global::QuanLyNhaHang_QuanAn.Properties.Resources.Office_Girl_icon;
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý ";
            // 
            // quảnLýNhânViênToolStripMenuItem1
            // 
            this.quảnLýNhânViênToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime;
            this.quảnLýNhânViênToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNhânViênToolStripMenuItem1.Image")));
            this.quảnLýNhânViênToolStripMenuItem1.Name = "quảnLýNhânViênToolStripMenuItem1";
            this.quảnLýNhânViênToolStripMenuItem1.Size = new System.Drawing.Size(213, 26);
            this.quảnLýNhânViênToolStripMenuItem1.Text = "Quản lý nhân viên";
            this.quảnLýNhânViênToolStripMenuItem1.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem1_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.quảnLýKháchHàngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýKháchHàngToolStripMenuItem.Image")));
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản lý khách hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // phânQuyềnSửDụngToolStripMenuItem
            // 
            this.phânQuyềnSửDụngToolStripMenuItem.Name = "phânQuyềnSửDụngToolStripMenuItem";
            this.phânQuyềnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            // 
            // gọiMónToolStripMenuItem
            // 
            this.gọiMónToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gọiMónToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.gọiMónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gọiMónToolStripMenuItem.Image")));
            this.gọiMónToolStripMenuItem.Name = "gọiMónToolStripMenuItem";
            this.gọiMónToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.gọiMónToolStripMenuItem.Text = "Gọi món";
            this.gọiMónToolStripMenuItem.Click += new System.EventHandler(this.gọiMónToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.thoátToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.thoátToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thoátToolStripMenuItem.Image")));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 913);
            this.Controls.Add(this.TabHienThi);
            this.Controls.Add(this.ctxtmenuTabBan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ctxtmenuTabBan;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quán Ăn Nhậu FA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.ctxtmenuTabHienThi.ResumeLayout(false);
            this.ctxtmenuTabBan.ResumeLayout(false);
            this.ctxtmenuTabBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabHienThi;
        private System.Windows.Forms.ContextMenuStrip ctxtmenuTabHienThi;
        private System.Windows.Forms.ToolStripMenuItem menuItemDongTrang;
        private System.Windows.Forms.ToolStripMenuItem menuItemDongTrangAll;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lựaChọnKhuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hệThốngKhuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thứcUốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gọiMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ctxtmenuTabBan;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnSửDụngToolStripMenuItem;
    }
}