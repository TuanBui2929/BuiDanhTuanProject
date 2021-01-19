using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanCoffee.DB;

namespace QuanLyQuanCoffee
{
    
    public partial class Hoá_Đơn : Form
    {
        Model1 qlcf;
        public Hoá_Đơn()
        {
            InitializeComponent();
        }
        public Hoá_Đơn(string Mahd)
        {
            qlcf = new Model1();
            InitializeComponent();
            txtmahd.Text = Mahd;
            
        }

        private void Hoá_Đơn_Load(object sender, EventArgs e)
        {
            int x = Int32.Parse(txtmahd.Text);
            HoaDon no = qlcf.HoaDons.FirstOrDefault(c => c.MaHĐ == x);

            txtngay.Text = no.Ngayxuat.ToString();
            txtnv.Text = no.NhanVien.TenNV;
            txtban.Text = no.Maban.ToString();


            var results = from c in qlcf.CTHoaDons
                          where c.MaHD == x
                          select c;

            float tong = 0;
            foreach (CTHoaDon item in results)
            {
               tong = tong+ (float) item.soluong * (float)item.ThucUong.Đơngia;


            }
            txtTien.Text = tong.ToString();

        }
    }
}
