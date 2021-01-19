
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
    public partial class QuanLy : Form
    {
        Model1 qlcf;
        List<ThucUong> listthucuong;
        List<NhanVien> listnhanvien;
        List<TaiKhoan> listtaikhoan;
        List<ThucUong> listthemmon;
        List<CaLam> listcalam;

        int flag = 0;
        int manv;

        public QuanLy(int x,string ten)
        {
            InitializeComponent();
            qlcf = new Model1();
            listthucuong = qlcf.ThucUongs.ToList();
            listnhanvien = qlcf.NhanViens.ToList();
            listtaikhoan = qlcf.TaiKhoans.ToList();
            listcalam = qlcf.CaLams.ToList();

            NhanVien nv = qlcf.NhanViens.FirstOrDefault(c => c.MaNV == x);
            txtnhanvien.Text = ten; ;
            manv = x;


        }
        public QuanLy()
        {
            InitializeComponent();
            qlcf = new Model1();
            listthucuong = qlcf.ThucUongs.ToList();
            listnhanvien = qlcf.NhanViens.ToList();
            listtaikhoan = qlcf.TaiKhoans.ToList();
            listcalam = qlcf.CaLams.ToList();

           

        }



        private void QuanLy_Load(object sender, EventArgs e)
        {
        // ham set Tên Bàn
            int index = 1;
            listthemmon = new List<ThucUong>();
            foreach (Button item in tblayerBan.Controls)
            {
                item.Text = index.ToString();
                item.Name = index.ToString();
                index++;
                item.Click += Item_click;

            }
         // tab Quan Ly Thuc Uong
            updatedatagrid(listthucuong);
          
            datacombox();
         // tab Quan Ly Nhan Vien
            updategridnhanvien(listnhanvien,listtaikhoan);
         // slection full dong datagridview
            dataGridnhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridThucUong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridmenuBH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridhoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTKdoanhthu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCaLam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            NhanVienCaLam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTKNv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetGridViewStyle(dataGridnhanvien);
            SetGridViewStyle(dataGridThucUong);
            SetGridViewStyle(datagridmenuBH);
            SetGridViewStyle(datagridhoadon);
            SetGridViewStyle(dataGridTKdoanhthu);
            SetGridViewStyle(dataGridCaLam);
            SetGridViewStyle(NhanVienCaLam);
            SetGridViewStyle(dataGridViewTKNv);

            // tab Bán Hàng
            updatedatagridmenu(listthucuong);
            // tab quan Ly ca Lam
            updatedatatgridcalam(qlcf.CaLams.ToList());
            updatedatatgridLuongcalam(qlcf.CtCaLams.ToList());
            updatecombobox();
            //Thong ke NV
            dataComboboxTkThang();
            dateTimeThang.Format = DateTimePickerFormat.Custom;
            dateTimeThang.CustomFormat = "M-yyyy";



           // this.reportViewer1.RefreshReport();
        }

        public void SetGridViewStyle(DataGridView dgview)
        {
            //dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239,
           249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
           // dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            //dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
            dgview.MultiSelect = false;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        /// <summary>
        /// BÁN HÀNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void updatedatagridmenu(List<ThucUong> list)
        {

            DataTable table = new DataTable();
            
            table.Columns.Add("ma thuc Uong");
            table.Columns.Add("ten nuoc");
            table.Columns.Add("don gia");
            table.Columns.Add(" loai");
           

            for (int i = 0; i < list.Count(); i++)
            {
                ThucUong thucuong = list[i];
                table.Rows.Add(new string[] { thucuong.Manuoc,thucuong.Tennuoc,
                thucuong.Đơngia.ToString(),thucuong.Loai.Tenloai});

                
            }
           datagridmenuBH.DataSource = table;

        }
        private void updatedatagridhoadon(List<ThucUong> list)
        {

            DataTable table = new DataTable();

            table.Columns.Add("ma thuc Uong");
            table.Columns.Add("ten nuoc");
            table.Columns.Add("don gia");
            table.Columns.Add(" loai");


            for (int i = 0; i < list.Count(); i++)
            {
                ThucUong thucuong = list[i];
                table.Rows.Add(new string[] { thucuong.Manuoc,thucuong.Tennuoc,
                thucuong.Đơngia.ToString(),thucuong.Maloai});


            }
            datagridhoadon.DataSource = table;

        }

        private void updatedatagridhoadon(List<CTHoaDon> list)
        {

            DataTable table = new DataTable();

            table.Columns.Add("Ma Hoá Đơn");
            table.Columns.Add("Tên Nước");
            table.Columns.Add("So Luong");
            foreach (CTHoaDon item in list)
            {
                table.Rows.Add(new string[] { item.MaHD.ToString(), item.ThucUong.Tennuoc, item.soluong.ToString() });

            }
            datagridhoadon.DataSource = table;

        }

        private void Item_click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
           
            if (bnt.BackColor == Color.Pink)
            {
                if (flag == 0)
                {
                    bnt.BackColor = Color.Yellow;
                    
                   flag = 1;
                }
                else
                {
                    MessageBox.Show("ban hay chon mon");
                }
               
            }
            else if(bnt.BackColor == Color.Blue)
            {

                List<CTHoaDon> list = new List<CTHoaDon>();

                var results = from hd in qlcf.HoaDons.ToList()
                               where hd.Maban == Int32.Parse(bnt.Name)
                               select hd;



                var ite = results.OrderByDescending(i => i.MaHĐ).FirstOrDefault();
              
                foreach (var item in qlcf.CTHoaDons)
                {
                    if (item.MaHD == ite.MaHĐ)
                    {
                        list.Add(item);
                    }
               }
                updatedatagridhoadon(list);

            }
            else
            {
                bnt.BackColor = Color.Pink;
                flag = 0;
            }
        }


      
        private void bntThemmon_Click(object sender, EventArgs e)
        {
            int chon =0;
            foreach (Button item in tblayerBan.Controls)
            {
                if (item.BackColor==Color.Yellow)
                {
                    chon = 1;
                }

            }
            if (chon == 1) {
                ThucUong tc = new ThucUong();
                tc.Manuoc = datagridmenuBH.SelectedRows[0].Cells[0].Value.ToString();
                tc.Tennuoc = datagridmenuBH.SelectedRows[0].Cells[1].Value.ToString();
                tc.Đơngia = float.Parse(datagridmenuBH.SelectedRows[0].Cells[2].Value.ToString());
                tc.Maloai = datagridmenuBH.SelectedRows[0].Cells[3].Value.ToString();
                listthemmon.Add(tc);

                updatedatagridhoadon(listthemmon);
            }
            else
            {
                MessageBox.Show("hay cho ban");
            }

        }



        private void bntHoanThanh_Click(object sender, EventArgs e)
        {
        
            if (datagridhoadon.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Moi Chon Ban ");

            }


            else
            {
                foreach (Button item in tblayerBan.Controls)
                {
                    if (item.BackColor == Color.Yellow)
                    {   //


                        NhanVien no = qlcf.NhanViens.SingleOrDefault(c => c.MaNV == manv);
                        HoaDon hd = new HoaDon();
                        hd.Maban = Int32.Parse(item.Text);
                        hd.Ngayxuat = DateTime.Today.Date;
                        hd.MaNV = no.MaNV;
                        qlcf.HoaDons.Add(hd);
                        qlcf.SaveChanges();
                        //

                        var results = from st in listthemmon
                                      group st by st.Manuoc;

                        foreach (var st in results)
                        {
                            int soluong = st.Count();
                            CTHoaDon cthd = new CTHoaDon();
                            cthd.MaHD = hd.MaHĐ;
                            cthd.Manuoc = st.Key;
                            cthd.soluong = soluong;
                            qlcf.CTHoaDons.Add(cthd);
                            qlcf.SaveChanges();

                        }

                        item.BackColor = Color.Blue;
                        flag = 0;

                    }

                }
                listthemmon.Clear();

                List<CTHoaDon> list = new List<CTHoaDon>();

                var ite = qlcf.HoaDons.OrderByDescending(i => i.MaHĐ).FirstOrDefault();

                foreach (var item in qlcf.CTHoaDons)
                {
                    if (item.MaHD == ite.MaHĐ)
                    {
                        list.Add(item);
                    }
                }
                updatedatagridhoadon(list);

            }

        }

        private void bntThanhToan_Click(object sender, EventArgs e)
        {
            List<CTHoaDon> list = new List<CTHoaDon>();

            if (datagridhoadon.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Moi Chon Ban ");

            }
            else
            {
                string hoadon = datagridhoadon.SelectedRows[0].Cells[0].Value.ToString();
                int x = Int32.Parse(hoadon);
                HoaDon no = qlcf.HoaDons.FirstOrDefault(c => c.MaHĐ == x);
                foreach (Button item in tblayerBan.Controls)
                {
                    if (item.Text == no.Maban.ToString())
                    {
                        item.BackColor = Color.Pink;

                    }

                }
                Hoá_Đơn hd = new Hoá_Đơn(hoadon);
                hd.ShowDialog();
            }

            updatedatagridhoadon(list);


        }

        private void bntBoChon_Click(object sender, EventArgs e)
        {
            //string x = datagridhoadon.SelectedRows[0].Cells[0].Value.ToString();
            ThucUong tc = listthemmon.FirstOrDefault(c => c.Manuoc == datagridhoadon.SelectedRows[0].Cells[0].Value.ToString());
            if (tc != null)
            {
                listthemmon.Remove(tc);
            }
            else
            {
                MessageBox.Show("moi chon mon");
            }
            updatedatagridhoadon(listthemmon);

        }


        /// <summary>
        ///  QUẢN LÝ THỨC UỐNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

        private void datacombox()
        {
            cbloainuoc.DataSource = qlcf.Loais.ToList();
            this.cbloainuoc.DisplayMember = "Tenloai";
            this.cbloainuoc.ValueMember = "Maloai";
        }

        private void updatedatagrid(List<ThucUong> list)
        {
           
            DataTable table = new DataTable();
            table.Columns.Add("Stt");
            table.Columns.Add("ma thuc Uong");
            table.Columns.Add("ten nuoc");
            table.Columns.Add("don gia"); 
            table.Columns.Add(" loai");
            int stt=0;

            for (int i = 0; i < list.Count(); i++,stt++)
            {
                ThucUong thucuong = list[i];
                table.Rows.Add(new string[] {stt.ToString(), thucuong.Manuoc,thucuong.Tennuoc,
                  thucuong.Đơngia.ToString(),thucuong.Loai.Tenloai});
            }
            dataGridThucUong.DataSource = table;

        }

      

      
        private void dataGridThucUong_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridThucUong.SelectedRows.Count > 0)
            {
                txtmanc.Text = dataGridThucUong.SelectedRows[0].Cells[1].Value.ToString();
                txttennc.Text = dataGridThucUong.SelectedRows[0].Cells[2].Value.ToString();
                txtdongia.Text = dataGridThucUong.SelectedRows[0].Cells[3].Value.ToString();
                cbloainuoc.SelectedIndex = cbloainuoc.FindStringExact(dataGridThucUong.SelectedRows[0].Cells[4].Value.ToString());
            }
        }


        private void bntThemnc_Click_1(object sender, EventArgs e)
        {

            ThucUong nuoc = new ThucUong();
            ThucUong no = qlcf.ThucUongs.FirstOrDefault(c => c.Manuoc == txtmanc.Text);
            {
                if (no != null)
                {
                    no.Tennuoc = txttennc.Text;
                    no.Đơngia = float.Parse(txtdongia.Text);
                    no.Maloai = cbloainuoc.SelectedValue.ToString();

                }
                else
                {
                    nuoc.Manuoc = txtmanc.Text;
                    nuoc.Tennuoc = txttennc.Text;
                    nuoc.Đơngia = float.Parse(txtdongia.Text);
                    nuoc.Maloai = cbloainuoc.SelectedValue.ToString();
                    qlcf.ThucUongs.Add(nuoc);
                }
            }

            qlcf.SaveChanges();
            QuanLy_Load(sender, e);
            updatedatagrid(qlcf.ThucUongs.ToList());

        }

        private void bntxoanc_Click_1(object sender, EventArgs e)
        {
            ThucUong no = qlcf.ThucUongs.SingleOrDefault(c => c.Manuoc == txtmanc.Text);
            
                if (no == null)
                {
                    MessageBox.Show("MA nuoc khong ton tai");
                }
                else
                {
                        if( qlcf.CTHoaDons.Any(C => C.Manuoc == no.Manuoc))
                        {
                            MessageBox.Show("K thể Xoá Vì trong Tồn tại trong hoá đơn bán hàng");

                        }
                        else
                        {
                                qlcf.ThucUongs.Remove(no);
                                qlcf.SaveChanges();
                                txtmanc.Text = "";
                                txttennc.Text = "";
                                txtdongia.Text = "";
                                cbloainuoc.Text = "";
                        }
                
                    
                   
                 }
            

           
            updatedatagrid(qlcf.ThucUongs.ToList());

        }

        /// <summary>
        /// QUANG lY NHAN VIEN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void updategridnhanvien(List<NhanVien> list, List<TaiKhoan> nolist)
        {

            DataTable table = new DataTable();
            table.Columns.Add("Stt");//0
            table.Columns.Add("Ma nv");//1
            table.Columns.Add("Họ Và Tên");//2
            table.Columns.Add("Địa Chỉ");//3
            table.Columns.Add("Ngày Sinh");//4
            table.Columns.Add("Giới Tính");//5
            table.Columns.Add("Chức Vụ");//6
            table.Columns.Add("Đăng Nhập");//7
            table.Columns.Add("Mật Khẩu");//8
            int stt = 0;

            for (int i = 0; i < list.Count(); i++, stt++)
            {
                NhanVien nhanvien = list[i];
                TaiKhoan taikhoan = nolist[i];
                table.Rows.Add(new string[] {stt.ToString(), nhanvien.MaNV.ToString(),nhanvien.TenNV,nhanvien.DiaChi,
                  nhanvien.Ngaysinh,nhanvien.GiơiTinh,nhanvien.ChucVu ,taikhoan.ĐăngNhập,taikhoan.MậtKhau});
            }
            dataGridnhanvien.DataSource = table;

        }

      

        private void dataGridnhanvien_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridnhanvien.SelectedRows.Count > 0)
            {

                txtmanv.Text = dataGridnhanvien.SelectedRows[0].Cells[1].Value.ToString();
                txttennv.Text = dataGridnhanvien.SelectedRows[0].Cells[2].Value.ToString();
                txtdiachi.Text = dataGridnhanvien.SelectedRows[0].Cells[3].Value.ToString();
                txtngaysinh.Text = dataGridnhanvien.SelectedRows[0].Cells[4].Value.ToString();
                txtdangnhap.Text = dataGridnhanvien.SelectedRows[0].Cells[7].Value.ToString();
                txtmatkhau.Text = dataGridnhanvien.SelectedRows[0].Cells[8].Value.ToString();
                if (dataGridnhanvien.SelectedRows[0].Cells[5].Value.ToString() == "Nam")
                {
                    Nam.Checked = true;

                }
                else
                {
                    Nữ.Checked = true;
                }
                if (dataGridnhanvien.SelectedRows[0].Cells[6].Value.ToString() == "Nhân Viên")
                {
                    rdoNV.Checked = true;

                }
                else
                {
                    rdoQuanLy.Checked = true;
                }
            }

        }
        private void bntThemNV_Click_1(object sender, EventArgs e)
        {

            NhanVien nhanvien = new NhanVien();
            TaiKhoan tk = new TaiKhoan();
            if (txtmanv.Text=="") { 
                   
                        nhanvien.TenNV = txttennv.Text;
                        nhanvien.Ngaysinh = txtngaysinh.Text;
                        nhanvien.DiaChi = txtdiachi.Text;

                        if (Nam.Checked) {

                            nhanvien.GiơiTinh = "Nam";
                        }
                        else
                        {
                            nhanvien.GiơiTinh = "Nữ";
                        }
                        if (rdoQuanLy.Checked)
                        {

                            nhanvien.ChucVu = "Quản Lý"; ;
                        }
                        else
                        {
                            nhanvien.ChucVu = "Nhân Viên";
                        }


                        qlcf.NhanViens.Add(nhanvien);
                        qlcf.SaveChanges();
                        tk.Matk = nhanvien.MaNV;
                        tk.ĐăngNhập = txtdangnhap.Text;
                        tk.MậtKhau = txtmatkhau.Text;
                        qlcf.TaiKhoans.Add(tk);

                  
            }
            else
            {
                int ma = Int32.Parse(txtmanv.Text);
                NhanVien no = qlcf.NhanViens.SingleOrDefault(c => c.MaNV ==ma );
                TaiKhoan notk = qlcf.TaiKhoans.SingleOrDefault(c => c.Matk == ma);

                if (no != null)
                {
                    no.TenNV = txttennv.Text;
                    no.Ngaysinh = txtngaysinh.Text;
                    no.DiaChi = txtdiachi.Text;
                    notk.ĐăngNhập = txtdangnhap.Text;
                    notk.MậtKhau = txtmatkhau.Text;

                    if (Nam.Checked)
                    {

                        no.GiơiTinh = "Nam";
                    }
                    else
                    {
                        no.GiơiTinh = "Nữ";
                    }
                    if (rdoQuanLy.Checked)
                    {

                        no.ChucVu = "Quản Lý"; ;
                    }
                    else
                    {
                       no.ChucVu = "Nhân Viên";
                    }

                }

            }
            qlcf.SaveChanges();
            QuanLy_Load(sender, e);
            updategridnhanvien(qlcf.NhanViens.ToList(), qlcf.TaiKhoans.ToList());
            

        }

        private void bntxoanv_Click_1(object sender, EventArgs e)
        {
            int ma = Int32.Parse(txtmanv.Text);
            NhanVien nonv = qlcf.NhanViens.SingleOrDefault(c => c.MaNV == ma);
            TaiKhoan notk = qlcf.TaiKhoans.SingleOrDefault(c => c.Matk == ma);
            if (nonv == null)
            {
                MessageBox.Show("MA nuoc khong ton tai");
            }
            else
            {
                qlcf.NhanViens.Remove(nonv);
                qlcf.TaiKhoans.Remove(notk);
                qlcf.SaveChanges();
            }
            QuanLy_Load(sender, e);
            updategridnhanvien(qlcf.NhanViens.ToList(), qlcf.TaiKhoans.ToList());
        }
    
        /// <summary>
        /// Thống ke doanh thu bán hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntThongkedoanhthu_Click(object sender, EventArgs e)
        {
            List<HoaDon> listdoanhthu = new List<HoaDon>();
            DateTime from = txtfrom.Value.Date;
            DateTime to = txtTo.Value.Date;
            float tong = 0;
            foreach (HoaDon item in qlcf.HoaDons)
            {
                if(item.Ngayxuat.Date>=from && item.Ngayxuat.Date<=to  )
                {
                    listdoanhthu.Add(item);
                    foreach (CTHoaDon ct in qlcf.CTHoaDons)
                    {
                        if (ct.MaHD==item.MaHĐ)
                        {
                            tong += (float)ct.soluong * (float)ct.ThucUong.Đơngia;

                        }

                    }

                }    

            }
            txtDoanhThu.Text = tong.ToString();
          //  dataGridTKdoanhthu.DataSource = listdoanhthu;
          updatedatatgridThongkeDoanhThu(listdoanhthu);

        }
      
        private void bntReportDoanhThu(object sender, EventArgs e)
        {
            DateTime from = txtfrom.Value.Date;
            DateTime to = txtTo.Value.Date;
            ReportThongKe frm= new ReportThongKe(from,to);
             frm.MdiParent = this.ParentForm;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void updatedatatgridThongkeDoanhThu(List<HoaDon> list )
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ma Hoa Don");
            table.Columns.Add("Ngay Xuat ");
            table.Columns.Add("Nhan Vien");
            table.Columns.Add("Ban");
            foreach (HoaDon item in list)
            {
                table.Rows.Add( new string[] {item.MaHĐ.ToString(),item.Ngayxuat.ToString("yyyy-MM-dd"),item.NhanVien.TenNV,item.Maban.ToString() });


            }
            dataGridTKdoanhthu.DataSource = table;


        }

        private void dataGridTKdoanhthu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string mahoadon = dataGridTKdoanhthu.SelectedRows[0].Cells[0].Value.ToString();
            int x = Int32.Parse(mahoadon);
            Hoá_Đơn hd = new Hoá_Đơn(mahoadon);
            hd.ShowDialog();

        }


        /// <summary>
        /// Thong Ke Luong Thang Cua Nhan Vien
        /// 
        /// 
        /// </summary>
        private void dataComboboxTkThang()
        {
            cmbTknv.DataSource = qlcf.NhanViens.ToList();
                this.cmbTknv.DisplayMember = "TenNV";
                this.cmbTknv.ValueMember = "MaNV";
           


        }
      
      

        private void updateGridviweThongKeNhanVien(List<CtCaLam> list)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ngay");
            table.Columns.Add("Ten Ca");
            table.Columns.Add("Ten Nv");

            foreach (CtCaLam item in list)
            {
                table.Rows.Add(new string[] { item.Ngay.ToString("yyyy - MM - dd"), item.Maca.ToString(), item.NhanVien.TenNV });


            }
           dataGridViewTKNv.DataSource = table;



        }

        private void bntXemTkNV_Click_1(object sender, EventArgs e)
        {

            List<CtCaLam> list = new List<CtCaLam>();
            DateTime date = DateTime.Now;
            //int month = date.Month;
            DateTime month = dateTimeThang.Value;
            float tong = 0;
            int ma = Int32.Parse(cmbTknv.SelectedValue.ToString());

            var result = from c in qlcf.CtCaLams
                         where c.Manv == ma && c.Ngay.Month == month.Month
                         select c;
            foreach (CtCaLam item in result)
            {
                list.Add(item);
                tong += (float)item.CaLam.Sotien;
            }

            txtTong.Text = tong.ToString();
            updateGridviweThongKeNhanVien(list);

        }

        /// <summary>
        /// Quan Ly Ca Lam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntThemCa_Click(object sender, EventArgs e)
        {

   
            if (txtmaca.Text == "")
            {
                CaLam ca = new CaLam();
                string a = txtgiokt.Text;
                ca.Tenca = txtTenCa.Text;
                ca.GiơBD = DateTime.Parse(txtgiobd.Text).TimeOfDay;
                ca.GiơKT = DateTime.Parse(txtgiokt.Text).TimeOfDay;
                ca.Sotien = float.Parse(txtSotien.Text);
                qlcf.CaLams.Add(ca);
            }
            else
            {
                int ma = Int32.Parse(txtmaca.Text);
                CaLam ca1 = qlcf.CaLams.FirstOrDefault(c => c.Maca == ma);
               // ca1.Maca = Int32.Parse(txtmaca.Text);
                ca1.Tenca = txtTenCa.Text;
                ca1.GiơBD = DateTime.Parse(txtgiobd.Text).TimeOfDay;
                ca1.GiơKT = DateTime.Parse(txtgiokt.Text).TimeOfDay;
                ca1.Sotien = float.Parse(txtSotien.Text);

            }
            qlcf.SaveChanges();
            QuanLy_Load(sender, e);
            updatedatatgridcalam(qlcf.CaLams.ToList());
            

        }

        private void updatedatatgridcalam(List<CaLam> list)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ma Ca");
            table.Columns.Add("Ten Ca");
            table.Columns.Add("Giờ Bắt Đầu");
            table.Columns.Add("Giờ Kết thúc");
            table.Columns.Add("Số Tiền");
            foreach (CaLam item in list)
            {
                table.Rows.Add(new string[] { item.Maca.ToString(),item.Tenca.ToString(), item.GiơBD.ToString(), item.GiơKT.ToString(), item.Sotien.ToString() });


            }
            dataGridCaLam.DataSource = table;


        }
        private void dataGridCaLam_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridCaLam.SelectedRows.Count > 0) {
                txtmaca.Text = dataGridCaLam.SelectedRows[0].Cells[0].Value.ToString();
                txtTenCa.Text = dataGridCaLam.SelectedRows[0].Cells[1].Value.ToString();
                txtgiobd.Text = dataGridCaLam.SelectedRows[0].Cells[2].Value.ToString();
                txtgiokt.Text = dataGridCaLam.SelectedRows[0].Cells[3].Value.ToString();
                txtSotien.Text = dataGridCaLam.SelectedRows[0].Cells[4].Value.ToString();

            }
        }

        private void bntdeleteCa_Click(object sender, EventArgs e)
        {
            if (txtmaca.Text != "")
            {
                int ma = Int32.Parse(txtmaca.Text);
                CaLam ca1 = qlcf.CaLams.FirstOrDefault(c => c.Maca == ma);
                if (ca1 != null)
                {
                    qlcf.CaLams.Remove(ca1);
                    qlcf.SaveChanges();
                    updatedatatgridcalam(qlcf.CaLams.ToList());
                }
                txtmaca.Text = "";
                txtTenCa.Text = "";
                txtgiobd.Text = "";
                txtgiokt.Text ="";
                txtSotien.Text = "";

                QuanLy_Load(sender, e);
            }

        }

        private void updatecombobox()
        {
            DateTime x = DateTime.Now;
            txtNgay.Text = x.Date.ToString("yyyy - MM - dd");
            cmbNhanVien.DataSource = qlcf.NhanViens.ToList();
            this.cmbNhanVien.DisplayMember = "TenNV";
            this.cmbNhanVien.ValueMember = "MaNV";
            cmbCa.DataSource = qlcf.CaLams.ToList();
            this.cmbCa.DisplayMember = "Tenca";
            this.cmbCa.ValueMember = "Maca";

        }
      


        private void bntThemCanv_Click(object sender, EventArgs e)
        {
            int manv = Int32.Parse(cmbNhanVien.SelectedValue.ToString());
           int maca=  Int32.Parse(cmbCa.SelectedValue.ToString());
            DateTime date = DateTime.ParseExact(txtNgay.Text, "yyyy - MM - dd", null);
            CtCaLam ct1 = qlcf.CtCaLams.FirstOrDefault(c => c.Manv == manv && c.Ngay == date && c.Maca== maca );

            if (ct1 == null)
            {

                CtCaLam ct = new CtCaLam();
                ct.Maca = maca ;
                ct.Manv =manv;
                ct.Ngay = DateTime.Now.Date;
                qlcf.CtCaLams.Add(ct);
            }
            else
            {
                MessageBox.Show("Da Cham Cong");
            }
            qlcf.SaveChanges();
            updatedatatgridLuongcalam(qlcf.CtCaLams.ToList());
            QuanLy_Load(sender, e);




        }

        private void updatedatatgridLuongcalam(List<CtCaLam> list)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Ngay");
            table.Columns.Add("Ten Ca");
            table.Columns.Add("Ten Nv");
           
            foreach (CtCaLam item in list)
            {
                table.Rows.Add(new string[] { item.Ngay.ToString("yyyy - MM - dd"), item.CaLam.Tenca.ToString(), item.NhanVien.TenNV  });


            }
            NhanVienCaLam.DataSource = table;


        }

        private void bntXoacanv_Click(object sender, EventArgs e)
        {
            int manv = Int32.Parse(cmbNhanVien.SelectedValue.ToString());
            int maca = Int32.Parse(cmbCa.SelectedValue.ToString());

            DateTime date = DateTime.ParseExact(txtNgay.Text, "yyyy - MM - dd", null);
            CtCaLam ct1 = qlcf.CtCaLams.FirstOrDefault(c => c.Manv == manv && c.Ngay == date && c.Maca == maca);
               if(ct1!=null) 
            {
                qlcf.CtCaLams.Remove(ct1);


            }
            else
            {
                MessageBox.Show("khong tim thay");
            }
            qlcf.SaveChanges();
            QuanLy_Load(sender, e);
            updatedatatgridLuongcalam(qlcf.CtCaLams.ToList());
        }

        private void NhanVienCaLam_SelectionChanged(object sender, EventArgs e)
        {
            if (NhanVienCaLam.SelectedRows.Count > 0)
            {
                cmbNhanVien.SelectedIndex = cmbNhanVien.FindStringExact(NhanVienCaLam.SelectedRows[0].Cells[2].Value.ToString());
                txtNgay.Text =NhanVienCaLam.SelectedRows[0].Cells[0].Value.ToString();
                cmbCa.SelectedIndex = cmbCa.FindStringExact(NhanVienCaLam.SelectedRows[0].Cells[1].Value.ToString());
            }
        }

        
    }
}
