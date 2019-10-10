using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuanLyNhaHang_QuanAn.Views
{
    public partial class uctNhanVien : UserControl 
    {
        public uctNhanVien()
        {
            InitializeComponent();
        }
        public static uctNhanVien uctNV = new uctNhanVien();
        int flag = 0;
        // khai báo hàm hiển thị danh sách sinh viên - để đưa dữ liệu vào dataGridView
        public void HienThiDanhSachNhanVien()
        {
            // Trỏ tới data nhân viên
            dgvDanhSachNV.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            dgvDanhSachNV.Dock = DockStyle.Fill;
            dgvDanhSachNV.RowHeadersVisible = false;
            dgvDanhSachNV.BorderStyle = BorderStyle.Fixed3D;
        }
       
        private void uctNhanVien_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachNhanVien();
            bingding();
        }
        public void nhung(Control ctr)
        {
            pnlDanhSachNV.Controls.Clear();
            pnlDanhSachNV.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlDanhSachNV.Controls.Add(ctr);
            pnlDanhSachNV.Show();
        }
        // Hàm load giới tính cho nhân viên
        void loadcontrol()
        {
            cmbGioiTinhNV.Items.Clear();
            cmbGioiTinhNV.Items.Add("Nam");
            cmbGioiTinhNV.Items.Add("Nữ");
        }
        // Tạo hàm để trỏ tới dữ liệu trên dataGridView
        void bingding()
        {
            // Trỏ tới đúng tham số đã khai báo
            txtIdNhanVien.DataBindings.Clear();
            txtIdNhanVien.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "IdNhanVien");
            txtHolotNV.DataBindings.Clear();
            txtHolotNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "HoLot");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Ten");
            dtpNgaySinhNV.DataBindings.Clear();
            dtpNgaySinhNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Ngaysinh");
            cmbGioiTinhNV.DataBindings.Clear();
            cmbGioiTinhNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "GioiTinh");
            txtDienThoaiNV.DataBindings.Clear();
            txtDienThoaiNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "DienThoai");
            txtEmailNV.DataBindings.Clear();
            txtEmailNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Email");
            txtDiaChiNV.DataBindings.Clear();
            txtDiaChiNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "DiaChi");

        }
        // Hàm xóa dữ liệu ở textbox lúc ta nhấn vào button
        void clearData()
        {
            txtIdNhanVien.Text = Models.connection.ExcuteScalar(String.Format("select IdNhanVien= dbo.fcgetIdNhanVien()"));
            txtHolotNV.Text = "";
            txtTenNV.Text = "";
            txtDienThoaiNV.Text = "";
            txtEmailNV.Text = "";
            txtDiaChiNV.Text = "";
            loadcontrol();
        }
        // Hàm dis-end các button khi load lên
        void dis_end(bool e)
        {
            
            txtHolotNV.Enabled = e;
            txtTenNV.Enabled = e;
            dtpNgaySinhNV.Enabled = e;
            cmbGioiTinhNV.Enabled = e;
            txtDienThoaiNV.Enabled = e;
            txtEmailNV.Enabled = e;
            txtDiaChiNV.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }
        private void txtDienThoaiNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            uctSearchNhanVien uctS = new uctSearchNhanVien();
            nhung(uctS);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlDanhSachNV.Controls.Clear();
            pnlDanhSachNV.BorderStyle = BorderStyle.None;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // khai báo các biến
            string _idNhanVien = "";
            try
            {
                _idNhanVien = txtIdNhanVien.Text;
            }
            catch { }

            string _hoNhanVien = "";
            try
            {
                _hoNhanVien = txtHolotNV.Text;
            }
            catch { }
            string _tenNhanVien = "";
            try
            {
                _tenNhanVien = txtTenNV.Text;
            }
            catch { }

            DateTime _ngaysinhNhanVien = dtpNgaySinhNV.Value;

            try { }
            catch { }
            string _giotinhNhanVien = "";
            try
            {
                _giotinhNhanVien = cmbGioiTinhNV.Text;
            }
            catch { }
            string _dienthoaiNhanVien = "";
            try
            {
                _dienthoaiNhanVien = txtDienThoaiNV.Text;
            }
            catch { }
            string _emailNhanVien = "";
            try
            {
                _emailNhanVien = txtEmailNV.Text;
            }
            catch { }
            string _diachiNhanVien = "";
            try
            {
                _diachiNhanVien = txtDiaChiNV.Text;
            }
            catch { }
            if (flag == 0)
            {
                // Thêm mới

                if (_idNhanVien == "" || _tenNhanVien == "" || _hoNhanVien == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.NhanVienCtrl.InSertNhanVien(_idNhanVien, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _diachiNhanVien);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachNhanVien();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                // Sửa
                int i = 0;
                i = Controllers.NhanVienCtrl.UpdateNhanVien(_idNhanVien, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _diachiNhanVien);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachNhanVien();
                    uctNhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            uctNhanVien_Load(sender, e);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctNhanVien_Load(sender, e);
            dis_end(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // lúc Click sửa mặc định cho flag = 1
            flag = 1;
            dis_end(true);//các nút thêm,sửa,xóa sẽ ẩn đi,chỉ còn nút lưu và hủy
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idNhanVien = "";
            try
            {
                _idNhanVien = txtIdNhanVien.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.DeleteNhanVien(_idNhanVien);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachNhanVien();
                    uctNhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }


    }
}
