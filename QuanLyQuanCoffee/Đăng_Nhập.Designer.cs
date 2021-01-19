
namespace QuanLyQuanCoffee
{
    partial class Đăng_Nhập
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
            this.bntHuy = new System.Windows.Forms.Button();
            this.bntdangnhap = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntHuy
            // 
            this.bntHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bntHuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bntHuy.FlatAppearance.BorderSize = 2;
            this.bntHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bntHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHuy.Location = new System.Drawing.Point(389, 341);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(112, 36);
            this.bntHuy.TabIndex = 15;
            this.bntHuy.Text = "Huỷ";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // bntdangnhap
            // 
            this.bntdangnhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bntdangnhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bntdangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntdangnhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdangnhap.Location = new System.Drawing.Point(224, 341);
            this.bntdangnhap.Name = "bntdangnhap";
            this.bntdangnhap.Size = new System.Drawing.Size(111, 36);
            this.bntdangnhap.TabIndex = 14;
            this.bntdangnhap.Text = "ĐăngNhập";
            this.bntdangnhap.UseVisualStyleBackColor = true;
        //    this.bntdangnhap.Click += new System.EventHandler(this.bntdangnhap_Click);
            // 
            // txtMK
            // 
            this.txtMK.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMK.Location = new System.Drawing.Point(280, 266);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(237, 22);
            this.txtMK.TabIndex = 13;
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.Validating += new System.ComponentModel.CancelEventHandler(this.Even_kiemtranhap);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtTK
            // 
            this.txtTK.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtTK.Location = new System.Drawing.Point(280, 195);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(237, 22);
            this.txtTK.TabIndex = 11;
            this.txtTK.Validating += new System.ComponentModel.CancelEventHandler(this.Even_kiemtranhap);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tài Khoản";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar1.Enabled = false;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.progressBar1.Location = new System.Drawing.Point(63, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(634, 32);
            this.progressBar1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tuấn Ca get high";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Đăng_Nhập
            // 
            this.AcceptButton = this.bntdangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CancelButton = this.bntHuy;
            this.ClientSize = new System.Drawing.Size(756, 404);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntdangnhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Name = "Đăng_Nhập";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Đăng_Nhập_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.Button bntdangnhap;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

