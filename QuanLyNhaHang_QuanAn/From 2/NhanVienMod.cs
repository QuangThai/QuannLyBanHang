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


namespace QuanLyNhaHang_QuanAn.Models
{   
    // Khai báo biến và hàm thuộc tính
    class NhanVienMod
    {
        protected string    IdNhanVien { get; set; }
        protected string    HoLotNhanVien               { get; set; }
        protected string    TenNhanVien                 { get; set; }
        protected DateTime  NgaySinhNhanVien             { get; set; }
        protected string     GioiTinhNhanVien            { get; set; }
        protected string    DienThoaiNhanVien           { get; set; }
        protected string    EmailNhanVien               { get; set; }
        protected string    DiaChiNhanVien              { get; set; }
        public NhanVienMod(string _IdNhanVien)
        {
            IdNhanVien = _IdNhanVien;
        }
        public NhanVienMod()
        {

        }
        // Hàm khởi tạo (Hàm contructor)
        public NhanVienMod(string _idNhanVien, string _hoNhanVien, string _tenNhanVien, DateTime _ngaysinhNhanVien, string _giotinhNhanVien, string _dienthoaiNhanVien, string _emailNhanVien, string _diachiNhanVien)
        {
            IdNhanVien    = _idNhanVien;
            HoLotNhanVien = _hoNhanVien;
            TenNhanVien = _tenNhanVien;
            NgaySinhNhanVien = _ngaysinhNhanVien;
            GioiTinhNhanVien = _giotinhNhanVien;
            DienThoaiNhanVien = _dienthoaiNhanVien;
            EmailNhanVien = _emailNhanVien;
            DiaChiNhanVien = _diachiNhanVien;

        }
        //Hàm Thêm
        public int InsertNhanVien()
        {
            int i = 0;
            // Các biến truyền vào giống với khai báo trong SQL
            string[] paras = new string[8] { "@IdNhanVien", "@HoLot", "@Ten", "@Ngaysinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { IdNhanVien, HoLotNhanVien, TenNhanVien,NgaySinhNhanVien,GioiTinhNhanVien,DienThoaiNhanVien,EmailNhanVien,DiaChiNhanVien};
            // Gọi đúng tên thủ tục  vừa đặt
            i = Models.connection.Excute_Sql("spInsertNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Hàm Sửa
        public int UpdateNhanVien()
        {
            int i = 0;
            string[] paras = new string[8] { "@IdNhanVien", "@HoLot", "@Ten", "@Ngaysinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { IdNhanVien, HoLotNhanVien, TenNhanVien, NgaySinhNhanVien, GioiTinhNhanVien, DienThoaiNhanVien, EmailNhanVien, DiaChiNhanVien };
            i = Models.connection.Excute_Sql("spUpdateNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        //Hàm Xóa
        public int DeleteNhanVien()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { IdNhanVien };
            i = Models.connection.Excute_Sql("spDeleteNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Khởi tạo hàm Dataset để load chạy NhanVien
        public static DataSet FillDataSetNhanVien()
        {
             return Models.connection.FillDataSet("spgetNhanVien", CommandType.StoredProcedure);            
        }
        //Thủ tục getNhanVien tạo ra
        public DataSet FillDataSet_getNhanVienByIdNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { IdNhanVien };
            ds = Models.connection.FillDataSet("spgetNhanVienByIdNhanVien", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        // Tìm  Nhan viên bằng IDNhanvien
        public DataSet FillDataSet_getSearchNVbyId()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { IdNhanVien };
            ds = Models.connection.FillDataSet("spSearchNVByIdNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        // Tìm Nhan vien theo tên
        public DataSet FillDataSet_FindNVByTen()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@Ten" };
            object[] values = new object[1] { IdNhanVien };
            ds = Models.connection.FillDataSet("spSearchNVByTenNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
