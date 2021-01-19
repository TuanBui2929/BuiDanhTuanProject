using QuanLyQuanCoffee.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCoffee
{
    public partial class QlTaiKhoan : Form
    {

        Model1 qlcf;
        string dn;
        public QlTaiKhoan()
        {
            qlcf = new Model1();
            InitializeComponent();
        }


        public QlTaiKhoan(string x)
        {
            dn = x;
            qlcf = new Model1();
            InitializeComponent();
        }


        private bool KiemTraMk()
        {
            string tk = txtnhaptk.Text;
            string mk = txtNhaplaimk.Text;

            if (qlcf.TaiKhoans.Any(c => c.ĐăngNhập == tk && c.MậtKhau == mk) && txtnhaptk.Text==dn)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Nhập Sai Tài Khoản ( SAI 5 LẦN => PAY ACC)");
            }
            return false;


        }

      

        private void bntSaVe_Click(object sender, EventArgs e)
        {
            string tk = txtnhaptk.Text;
            string mk = txtNhaplaimk.Text;
            if (KiemTraMk())
            {
                TaiKhoan tkk = qlcf.TaiKhoans.SingleOrDefault(c => c.ĐăngNhập ==tk && c.MậtKhau == mk);
                if (tkk != null)
                {
                    tkk.MậtKhau = txtmkmoi.Text;
                }
                qlcf.SaveChanges();
                MessageBox.Show("Đã Thay Đổi Thành Công");
            }
            txtNhaplaimk.Text = "";
            txtmkmoi.Text = "";
            txtnhaptk.Text = "";
        }
    }
}
