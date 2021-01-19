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
    public partial class FormMain : Form
    {
        int tk;
        string ten;
        int loainv;
        Model1 qlcf;
        public FormMain()
        {
            qlcf = new Model1();
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            HienThiDangNhap();
            TrangThaiMenu(false);

        }

        private void TrangThaiMenu(bool v)
        {
            menuDangXuat.Visible = v;
            menuQuanly.Visible = v;
            menuTaiKhoan.Visible = v;
            MenuDangNhap.Visible = !v;
        }

        private void HienThiDangNhap()
        {
            Form frm = this.MdiChildren.OfType<Đăngnhap2>().FirstOrDefault();
            if (frm == null)
            {

                Đăngnhap2 dn = new Đăngnhap2();
                
                dn.MdiParent = this;
                dn.StartPosition = FormStartPosition.CenterScreen;
                
                dn.hienThimenu += HienThiChuongTrinh;
                dn.Show();
            }
        }

        private void HienThiChuongTrinh(int x,string ten,int loai)
        {
            TrangThaiMenu(true);
            tk = x;
            this.ten = ten;
            loainv = loai;
        }

        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Đăng Xuất ", "thong bao", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {

            }
            else
            {
                foreach (var item in this.MdiChildren)

                {
                    Form frmm = this.MdiChildren.FirstOrDefault();
                    if (frmm != null)
                    {
                        frmm.Close();

                    }
                }
                TrangThaiMenu(false);
                HienThiDangNhap();
            }

        }

        private void MenuDangNhap_Click(object sender, EventArgs e)
        {
            
            HienThiDangNhap();
        }

        private void menuQuanly_Click(object sender, EventArgs e)
        {
            Form frm = this.MdiChildren.OfType<QuanLy>().FirstOrDefault();
            Form frmm = this.MdiChildren.OfType<QlTaiKhoan>().FirstOrDefault();
            if (frmm != null)
            {
                frmm.Close();

            }
            if (frm != null )
            {
                
            }
            else
            {
                if (loainv == 1)
                {
                    QuanLy ql = new QuanLy(tk, ten);

                    ql.MdiParent = this;
                    ql.StartPosition = FormStartPosition.CenterScreen;
                    ql.Show();
                }
                else
                {
                    QuanLy2 ql = new QuanLy2(tk, ten);
                    ql.MdiParent = this;
                    ql.StartPosition = FormStartPosition.CenterScreen;
                    ql.Show();
                }
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien nv = qlcf.NhanViens.SingleOrDefault(c => c.MaNV == tk);
            string dn = nv.TaiKhoan.ĐăngNhập;
             
            Form frm = this.MdiChildren.OfType<QlTaiKhoan>().FirstOrDefault();
            foreach (var item in this.MdiChildren)

            {
                Form frmm = this.MdiChildren.FirstOrDefault();
                if (frmm != null)
                {
                    frmm.Close();

                }
            }
            
            if (frm !=null)
            {
                
            }
           
            else
            {
                QlTaiKhoan tk = new QlTaiKhoan(dn);
                tk.MdiParent = this;
                tk.StartPosition = FormStartPosition.CenterScreen;
                tk.Show();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ban co muon thoat", "thong bao", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
