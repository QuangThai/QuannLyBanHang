namespace QuanLyNhaHang_QuanAn.Views
{
    partial class uctBan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctBan));
            this.grDanhSachBan = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachBan = new System.Windows.Forms.DataGridView();
            this.IdBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVucb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiaib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grThongTinBan = new System.Windows.Forms.GroupBox();
            this.cmbTenKhuVuc = new System.Windows.Forms.ComboBox();
            this.cmbTrangThaiBan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDienGiaiBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.grDanhSachBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
            this.grThongTinBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDanhSachBan
            // 
            this.grDanhSachBan.Controls.Add(this.dgvDanhSachBan);
            this.grDanhSachBan.Location = new System.Drawing.Point(4, 107);
            this.grDanhSachBan.Margin = new System.Windows.Forms.Padding(4);
            this.grDanhSachBan.Name = "grDanhSachBan";
            this.grDanhSachBan.Padding = new System.Windows.Forms.Padding(4);
            this.grDanhSachBan.Size = new System.Drawing.Size(724, 553);
            this.grDanhSachBan.TabIndex = 90;
            this.grDanhSachBan.TabStop = false;
            // 
            // dgvDanhSachBan
            // 
            this.dgvDanhSachBan.AllowUserToAddRows = false;
            this.dgvDanhSachBan.AllowUserToDeleteRows = false;
            this.dgvDanhSachBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBan.BackgroundColor = System.Drawing.Color.Lime;
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBan,
            this.TenKhuVucb,
            this.TenBan,
            this.DienGiaib,
            this.TrangThaib});
            this.dgvDanhSachBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachBan.Location = new System.Drawing.Point(4, 0);
            this.dgvDanhSachBan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            this.dgvDanhSachBan.ReadOnly = true;
            this.dgvDanhSachBan.Size = new System.Drawing.Size(716, 549);
            this.dgvDanhSachBan.TabIndex = 88;
            // 
            // IdBan
            // 
            this.IdBan.DataPropertyName = "IdBan";
            this.IdBan.HeaderText = "Id bàn";
            this.IdBan.Name = "IdBan";
            this.IdBan.ReadOnly = true;
            // 
            // TenKhuVucb
            // 
            this.TenKhuVucb.DataPropertyName = "TenKhuVuc";
            this.TenKhuVucb.HeaderText = "Tên khu vực";
            this.TenKhuVucb.Name = "TenKhuVucb";
            this.TenKhuVucb.ReadOnly = true;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.Name = "TenBan";
            this.TenBan.ReadOnly = true;
            // 
            // DienGiaib
            // 
            this.DienGiaib.DataPropertyName = "DienGiai";
            this.DienGiaib.HeaderText = "Diễn giải";
            this.DienGiaib.Name = "DienGiaib";
            this.DienGiaib.ReadOnly = true;
            // 
            // TrangThaib
            // 
            this.TrangThaib.DataPropertyName = "TrangThai";
            this.TrangThaib.HeaderText = "Trạng thái";
            this.TrangThaib.Name = "TrangThaib";
            this.TrangThaib.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(275, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 87;
            this.label1.Text = "DANH SÁCH BÀN";
            // 
            // grThongTinBan
            // 
            this.grThongTinBan.Controls.Add(this.cmbTenKhuVuc);
            this.grThongTinBan.Controls.Add(this.cmbTrangThaiBan);
            this.grThongTinBan.Controls.Add(this.label10);
            this.grThongTinBan.Controls.Add(this.txtDienGiaiBan);
            this.grThongTinBan.Controls.Add(this.label8);
            this.grThongTinBan.Controls.Add(this.txtTenBan);
            this.grThongTinBan.Controls.Add(this.label2);
            this.grThongTinBan.Controls.Add(this.txtIdBan);
            this.grThongTinBan.Controls.Add(this.label3);
            this.grThongTinBan.Controls.Add(this.label6);
            this.grThongTinBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinBan.Location = new System.Drawing.Point(772, 107);
            this.grThongTinBan.Margin = new System.Windows.Forms.Padding(4);
            this.grThongTinBan.Name = "grThongTinBan";
            this.grThongTinBan.Padding = new System.Windows.Forms.Padding(4);
            this.grThongTinBan.Size = new System.Drawing.Size(500, 277);
            this.grThongTinBan.TabIndex = 99;
            this.grThongTinBan.TabStop = false;
            // 
            // cmbTenKhuVuc
            // 
            this.cmbTenKhuVuc.FormattingEnabled = true;
            this.cmbTenKhuVuc.Location = new System.Drawing.Point(181, 65);
            this.cmbTenKhuVuc.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTenKhuVuc.Name = "cmbTenKhuVuc";
            this.cmbTenKhuVuc.Size = new System.Drawing.Size(144, 27);
            this.cmbTenKhuVuc.TabIndex = 97;
            // 
            // cmbTrangThaiBan
            // 
            this.cmbTrangThaiBan.FormattingEnabled = true;
            this.cmbTrangThaiBan.Location = new System.Drawing.Point(181, 204);
            this.cmbTrangThaiBan.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrangThaiBan.Name = "cmbTrangThaiBan";
            this.cmbTrangThaiBan.Size = new System.Drawing.Size(144, 27);
            this.cmbTrangThaiBan.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(15, 209);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 94;
            this.label10.Text = "Trạng Thái :";
            // 
            // txtDienGiaiBan
            // 
            this.txtDienGiaiBan.Location = new System.Drawing.Point(181, 158);
            this.txtDienGiaiBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienGiaiBan.Name = "txtDienGiaiBan";
            this.txtDienGiaiBan.Size = new System.Drawing.Size(144, 26);
            this.txtDienGiaiBan.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(15, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 95;
            this.label8.Text = "Diễn Giải :";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(181, 107);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(144, 26);
            this.txtTenBan.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên Bàn :";
            // 
            // txtIdBan
            // 
            this.txtIdBan.Enabled = false;
            this.txtIdBan.Location = new System.Drawing.Point(181, 26);
            this.txtIdBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBan.Name = "txtIdBan";
            this.txtIdBan.Size = new System.Drawing.Size(144, 26);
            this.txtIdBan.TabIndex = 93;
            this.txtIdBan.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tên Khu Vực :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 92;
            this.label6.Text = "Id Bàn :";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.Red;
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.ImageKey = "(none)";
            this.btnThemMoi.Location = new System.Drawing.Point(763, 404);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(164, 58);
            this.btnThemMoi.TabIndex = 100;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.Red;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(853, 486);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(153, 55);
            this.btnHuy.TabIndex = 104;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Red;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1092, 404);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(147, 58);
            this.btnLuu.TabIndex = 103;
            this.btnLuu.Text = "Cập nhập";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Red;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(935, 404);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 58);
            this.btnSua.TabIndex = 101;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1042, 484);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(139, 57);
            this.btnXoa.TabIndex = 102;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(923, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 22);
            this.label4.TabIndex = 87;
            this.label4.Text = "THÔNG TIN BÀN";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "21216-200.png");
            this.imageList2.Images.SetKeyName(1, "as.png");
            this.imageList2.Images.SetKeyName(2, "b.png");
            this.imageList2.Images.SetKeyName(3, "BanDangPhucVu.png");
            this.imageList2.Images.SetKeyName(4, "BanTrong.png");
            this.imageList2.Images.SetKeyName(5, "Benjigarner-Softdimension-Picture-Manager.ico");
            this.imageList2.Images.SetKeyName(6, "catering (1).png");
            this.imageList2.Images.SetKeyName(7, "catering.png");
            this.imageList2.Images.SetKeyName(8, "ChamCong.png");
            this.imageList2.Images.SetKeyName(9, "covered-food-tray-on-a-hand-of-hotel-room-service_318-61182.png");
            this.imageList2.Images.SetKeyName(10, "DangKy.png");
            this.imageList2.Images.SetKeyName(11, "DangNhap.png");
            this.imageList2.Images.SetKeyName(12, "DangXuat.png");
            this.imageList2.Images.SetKeyName(13, "DSThucDon.png");
            this.imageList2.Images.SetKeyName(14, "Edit.png");
            this.imageList2.Images.SetKeyName(15, "Exit.ico");
            this.imageList2.Images.SetKeyName(16, "exit.png");
            this.imageList2.Images.SetKeyName(17, "Finance-Cash-Receiving-icon.png");
            this.imageList2.Images.SetKeyName(18, "Food-Waiter-icon.png");
            this.imageList2.Images.SetKeyName(19, "GoiMon.png");
            this.imageList2.Images.SetKeyName(20, "Household-Table-icon.png");
            this.imageList2.Images.SetKeyName(21, "Huy.png");
            this.imageList2.Images.SetKeyName(22, "icon.ico");
            this.imageList2.Images.SetKeyName(23, "KhuVuc.png");
            this.imageList2.Images.SetKeyName(24, "Luu.png");
            this.imageList2.Images.SetKeyName(25, "PhanQuyen.png");
            this.imageList2.Images.SetKeyName(26, "PhucHoi.png");
            this.imageList2.Images.SetKeyName(27, "QLKhachHang.png");
            this.imageList2.Images.SetKeyName(28, "QLLoaiThucDon.png");
            this.imageList2.Images.SetKeyName(29, "QLNhanVien.png");
            this.imageList2.Images.SetKeyName(30, "QlThucDon.png");
            this.imageList2.Images.SetKeyName(31, "QuenMK.png");
            this.imageList2.Images.SetKeyName(32, "round-border-menu-bar-128.png");
            this.imageList2.Images.SetKeyName(33, "sa.png");
            this.imageList2.Images.SetKeyName(34, "SaoLuu.png");
            this.imageList2.Images.SetKeyName(35, "save.png");
            this.imageList2.Images.SetKeyName(36, "Sua.png");
            this.imageList2.Images.SetKeyName(37, "tale.png");
            this.imageList2.Images.SetKeyName(38, "ThanhToan.png");
            this.imageList2.Images.SetKeyName(39, "Them.png");
            this.imageList2.Images.SetKeyName(40, "Thoat.png");
            this.imageList2.Images.SetKeyName(41, "ThongTin.png");
            this.imageList2.Images.SetKeyName(42, "TimKiem.png");
            this.imageList2.Images.SetKeyName(43, "TinhLuong.png");
            this.imageList2.Images.SetKeyName(44, "Very-Basic-Menu-icon.png");
            this.imageList2.Images.SetKeyName(45, "Xoa.png");
            this.imageList2.Images.SetKeyName(46, "za.png");
            this.imageList2.Images.SetKeyName(47, "21216-200.png");
            // 
            // uctBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grThongTinBan);
            this.Controls.Add(this.grDanhSachBan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uctBan";
            this.Size = new System.Drawing.Size(1281, 663);
            this.Load += new System.EventHandler(this.uctBan_Load);
            this.grDanhSachBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            this.grThongTinBan.ResumeLayout(false);
            this.grThongTinBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhSachBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grThongTinBan;
        private System.Windows.Forms.ComboBox cmbTrangThaiBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDienGiaiBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cmbTenKhuVuc;
        private System.Windows.Forms.DataGridView dgvDanhSachBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVucb;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiaib;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}
