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
    public partial class Đăngnhap2 : Form
    {
        Model1 model;

        int loai;
        public delegate void HienThimenu(int ma,string ten,int loai);
        public   event HienThimenu hienThimenu;
        
        public Đăngnhap2()
        {
            model = new Model1();
            InitializeComponent();
        }



        private bool KiemtraDangNhap()
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            if (model.TaiKhoans.Any(c => c.ĐăngNhập == tk && c.MậtKhau == mk))
            {
                NhanVien nv = model.NhanViens.FirstOrDefault(c => c.TaiKhoan.ĐăngNhập == tk && c.TaiKhoan.MậtKhau == mk);
                if (nv.ChucVu=="Quản Lý")
                {
                    loai = 1;

                }
                else
                {
                    loai = 2;
                }
                return true;

            }
            return false;
        }
        private void bntdangnhap_Click(object sender, EventArgs e)
        {
            string tk1 = txtTK.Text;
            TaiKhoan no = model.TaiKhoans.FirstOrDefault(c => c.ĐăngNhập == tk1);
            if (KiemtraDangNhap())
            {                
                hienThimenu(no.Matk,no.NhanVien.TenNV,loai);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai Tai Khoan Hoac Mat Khau");
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private bool KiemTraNhap(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                errorProvider1.SetError(textbox, "moi nhap du lieu");
                return false;
            }
            else
            {
                errorProvider1.SetError(textbox, "");
                return true;
            }
        }

        private void txtTK_Validating(object sender, CancelEventArgs e)
        {
            TextBox texbox = (TextBox)sender;

            KiemTraNhap(texbox);
        }

        private void Đăngnhap2_Load(object sender, EventArgs e)
        {

        }
    }
}
