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
    public partial class uctGoiMon : UserControl
    {
        public uctGoiMon()
        {
            InitializeComponent();
        }
        
        public static uctGoiMon uctGM = new uctGoiMon();
        // Hiển thị danh sách bàn ăn
        public DataTable getBan()
        {
            DataTable dt = new DataTable();
            dt = Models.BanMod.FillDataSetDanhSachBan_GoiMon().Tables[0];
            return dt;

        }
        // Bàn khách đã gọi
        public DataTable getBanDaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSetDanhSachBan_GoiMon().Tables[0];
            dgvGoiMon.DataSource = dt;
            return dt;

        }
        // Bàn khách chưa gọi
        public DataTable getBanChuaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSetDanhSachBan_ChuaGoiMon().Tables[0];
            dgvGoiMon.DataSource = dt;
            return dt;
        }
        //Hàm Gọi món
        private void uctGoiMon_Load(object sender, EventArgs e)
        {
            uctDanhSachTD uctDSTD = new uctDanhSachTD();
            nhung(uctDSTD);
            ShowListView();
            dgvGoiMon.Dock = DockStyle.Fill;
            dgvGoiMon.RowHeadersVisible = false;
            dgvGoiMon.BorderStyle = BorderStyle.Fixed3D;
            lblTongTien.Text = "";
        }
        // Hàm hiển thị Showlist
        public void ShowListView()
        {
            lvDanhSachBan.Items.Clear();
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 1;//hình ảnh chèn bàn có người trong ImageIndex
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
            DataTable dt2 = new DataTable();
            dt2 = getBanChuaGoi();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt2.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt2.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt2.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 0;//hình ảnh chèn bàn chưa có người trong ImageIndex
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);

            }
        }
        // Hiển thị bàn có người ngồi--tạo để dataaTable để lưu dữ liệu
        public void BanCoNguoi()
        {
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            dgvGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 1;//hình ảnh chèn bàn có người trong ImageIndex
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);

            }
        }
        // Hiển thị bàn chưa có người ngồi-- tạo để dataTable để lưu dữ liệu
        public void BanChuaCoNguoi()
        {
            DataTable dt = new DataTable();
            dt = getBanChuaGoi();
            dgvGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.SubItems.Add(dt.Rows[i]["Id Bàn"].ToString());
                lvDanhSachBan.Items.Add(item);
                item.ImageIndex = 0;//hình ảnh chèn bàn chưa có người trong ImageIndex
            }
        }
        // Thêm bàn mới
        public void ThemBanMoi()
        {
            uctBan uctban = new uctBan();
            uctban.Show();
            
        }
        private void thêmBànMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemBanMoi();
        }
        // Hiển thị bàn chưa có người
        private void hiểnThịBànChưaCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanChuaCoNguoi();
        }
        // Hiển thị bàn có người
        private void hiểnThịBànCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanCoNguoi();
        }

        private void hiểnThịTấtCảBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctGoiMon_Load(sender, e);
        }
        // Hiển thị tất cả các bàn (gồm có người và không người)
        private void lvDanhSachBan_Click(object sender, EventArgs e)
        {
            string _IdBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
            dgvGoiMon.DataSource = Controllers.GoiMonCtrl.FillDataSet_getGoiMonByIdBan(_IdBan).Tables[0];
            string _tenBan = lvDanhSachBan.SelectedItems[0].SubItems[0].Text;// Items tên bàn,subItem Id bàn
            label1.Text = _tenBan.ToString();// dùng để truyền tên bàn
            label1.Hide();
            tinhtien();
        }
        // Hàm tính tiền
        public void tinhtien()
        {
           
            try
            {
                int tien = dgvGoiMon.Rows.Count;
                decimal thanhtien = 0;
                for (int i = 0; i < tien; i++)
                {
                    thanhtien += decimal.Parse(dgvGoiMon.Rows[i].Cells["Thành Tiền"].Value.ToString());
                }
                lblTongTien.Text = thanhtien.ToString("#,###") + " VND";
                lblTongTien.ForeColor = SystemColors.HotTrack;
            }
            catch 
            {
                //MessageBox.Show("Bạn chưa chọn bàn thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ok = new DialogResult();
                ok = MessageBox.Show("Bạn có muốn tính tiền " + label1.Text + " Không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               
                if (ok == DialogResult.Yes)
                {
                    MessageBox.Show("TỔNG SỐ TIỀN THANH TOÁN CỦA " +" [ "+ label1.Text + " ] "+ " LÀ " +lblTongTien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tinhtien();
                    // tính tiền những món đã gọi
                    uctMonDaGoi uctMDG = new uctMonDaGoi();
                    nhung(uctMDG);
                    string _IdBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
                    dgvGoiMon.DataSource = Controllers.GoiMonCtrl.DeleteGoiMon(_IdBan);
                    uctGoiMon_Load(sender, e);
                }
                else
                {
                    return;
                }
            }
            catch { MessageBox.Show("Bạn chưa chọn bàn thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            uctGoiMon_Load(sender, e);
        }

        public void nhung(Control ctr)
        {
            pnlGoiMon.Controls.Clear();
            pnlGoiMon.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(ctr);
            pnlGoiMon.Show();
        }
        public void nhungFrom(Form frm)
        {
          
            pnlGoiMon.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(frm);
            pnlGoiMon.Show();
        }
        private void lvDanhSachBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDanhSachBan.SelectedItems.Count==0)
            {
                return;
            }
            else
            {
                
            }
        }

        private void btnGoimon_Click(object sender, EventArgs e)
        {
            uctMonDaGoi uctMDG = new uctMonDaGoi();
            uctGoiMon_Load(sender, e); 
            nhung(uctMDG);   
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            uctDanhSachTD uctDSTD = new uctDanhSachTD();
            nhung(uctDSTD);
            uctGoiMon_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmThanhToan _frmThanhToan = new frmThanhToan();
            nhungFrom(_frmThanhToan);
           
        }


    }
}
