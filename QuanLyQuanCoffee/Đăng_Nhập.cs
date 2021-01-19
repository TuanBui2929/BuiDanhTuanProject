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
    public partial class Đăng_Nhập : Form
    {
        public Đăng_Nhập()
        {
            InitializeComponent();
        }

        //private void bntdangnhap_Click(object sender, EventArgs e)
        //{

        //    QuanLy ql = new QuanLy();
        //    this.Hide();
        //    ql.ShowDialog();
        //    this.Show();
          
        //}

        private void bntHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ban co muon thoat", "thong bao", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Đăng_Nhập_Load(object sender, EventArgs e)
        {
            txtTK.Text = "admin";
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

        private void Even_kiemtranhap(object sender, CancelEventArgs e)
        {
            TextBox texbox = (TextBox)sender;

            KiemTraNhap(texbox);
        }
    }
}
