
namespace QuanLyQuanCoffee
{
    partial class Đăngnhap2
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
            this.bntHuy.Location = new System.Drawing.Point(345, 424);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(112, 36);
            this.bntHuy.TabIndex = 23;
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
            this.bntdangnhap.Location = new System.Drawing.Point(164, 424);
            this.bntdangnhap.Name = "bntdangnhap";
            this.bntdangnhap.Size = new System.Drawing.Size(111, 36);
            this.bntdangnhap.TabIndex = 22;
            this.bntdangnhap.Text = "ĐăngNhập";
            this.bntdangnhap.UseVisualStyleBackColor = true;
            this.bntdangnhap.Click += new System.EventHandler(this.bntdangnhap_Click);
            // 
            // txtMK
            // 
            this.txtMK.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMK.Location = new System.Drawing.Point(220, 300);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(237, 22);
            this.txtMK.TabIndex = 21;
            this.txtMK.UseSystemPasswordChar = true;
            this.txtMK.Validating += new System.ComponentModel.CancelEventHandler(this.txtTK_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mật Khẩu";
            // 
            // txtTK
            // 
            this.txtTK.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtTK.Location = new System.Drawing.Point(220, 239);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(237, 22);
            this.txtTK.TabIndex = 19;
            this.txtTK.Validating += new System.ComponentModel.CancelEventHandler(this.txtTK_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(68, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Quản Lý Quán CaFe";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Đăngnhap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::QuanLyQuanCoffee.Properties.Resources.pngtree_cafe_coffee_bean_western_coffee_lahua_menu_poster_image_135292;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 628);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntdangnhap);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Đăngnhap2";
            this.Text = "Đăngnhap2";
            this.Load += new System.EventHandler(this.Đăngnhap2_Load);
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
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}