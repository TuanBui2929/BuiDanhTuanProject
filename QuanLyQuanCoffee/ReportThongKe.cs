using Microsoft.Reporting.WinForms;
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
    public partial class ReportThongKe : Form
    {
        Model1 qlcf;
        DateTime x;
        DateTime y;
        
        public ReportThongKe(DateTime x,DateTime y)
        {
            this.x = x;
            this.y = y;
            qlcf = new Model1();
            InitializeComponent();
        }

        private void ReportThongKe_Load(object sender, EventArgs e)
        {

            this.reportviewer.RefreshReport();
       
            ReportDoanhThu();


        }
        private void ReportDoanhThu()
        {

            List<HoaDon> list = qlcf.HoaDons.ToList();
            List<ThongKeDoanhThu> ListReportDoanhThu = new List<ThongKeDoanhThu>();
            DateTime from = x.Date;
            DateTime to = y.Date;
            float tong = 0;
           
            foreach (HoaDon item in list)
            {
                if (item.Ngayxuat.Date >= from && item.Ngayxuat.Date <= to)
                {
                    ThongKeDoanhThu tk = new ThongKeDoanhThu();
                    tk.MaHĐ = item.MaHĐ;
                    tk.MaNV = item.NhanVien.TenNV;
                    tk.Ngayxuat = item.Ngayxuat.Date;
                    tk.Maban = item.Maban;
                   
                    float gia =0;
                    foreach (CTHoaDon i in qlcf.CTHoaDons)
                    {
                        if (i.MaHD == item.MaHĐ)
                        {
                            gia += (float)i.soluong * (float)i.ThucUong.Đơngia;
                        }

                    }
                    tk.TongTien = gia;

                    ListReportDoanhThu.Add(tk);
                    foreach (CTHoaDon ct in qlcf.CTHoaDons)
                    {
                        if (ct.MaHD == item.MaHĐ)
                        {
                            tong += (float)ct.soluong * (float)ct.ThucUong.Đơngia;

                        }

                    }

                }

            }

           
            this.reportviewer.LocalReport.ReportPath = "ReportDoanhThu.rdlc";
            var reportdataset = new ReportDataSource("DataDoanhThu", ListReportDoanhThu);     
            this.reportviewer.LocalReport.DataSources.Clear();
            this.reportviewer.LocalReport.DataSources.Add(reportdataset);
            this.reportviewer.SetDisplayMode(DisplayMode.Normal);
            this.reportviewer.ZoomMode = ZoomMode.PageWidth;
            this.reportviewer.RefreshReport();


        }
    }
}
