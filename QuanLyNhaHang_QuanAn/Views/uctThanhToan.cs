using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaHang_QuanAn.Controllers;
namespace QuanLyNhaHang_QuanAn.Views
{
    public partial class uctThanhToan : UserControl
    {
        public uctThanhToan()
        {
            InitializeComponent();
        }
       

        private void uctThanhToan_Load(object sender, EventArgs e)
        {

        }

        public string _idBan { get; set; }
    }
}
