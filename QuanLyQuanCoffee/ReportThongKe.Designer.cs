namespace QuanLyQuanCoffee
{
    partial class ReportThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportviewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ThongKeDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportviewer
            // 
            this.reportviewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataDoanhThu";
            reportDataSource1.Value = this.ThongKeDoanhThuBindingSource;
            this.reportviewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportviewer.LocalReport.ReportEmbeddedResource = "QuanLyQuanCoffee.ReportDoanhThu.rdlc";
            this.reportviewer.Location = new System.Drawing.Point(12, 12);
            this.reportviewer.Name = "reportviewer";
            this.reportviewer.Size = new System.Drawing.Size(1162, 653);
            this.reportviewer.TabIndex = 0;
            // 
            // ThongKeDoanhThuBindingSource
            // 
            this.ThongKeDoanhThuBindingSource.DataSource = typeof(QuanLyQuanCoffee.ThongKeDoanhThu);
            // 
            // ReportThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 677);
            this.Controls.Add(this.reportviewer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeDoanhThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportviewer;
        private System.Windows.Forms.BindingSource ThongKeDoanhThuBindingSource;
    }
}