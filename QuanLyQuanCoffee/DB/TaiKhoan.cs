namespace QuanLyQuanCoffee.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Matk { get; set; }

        [Required]
        [StringLength(50)]
        public string ĐăngNhập { get; set; }

        [Required]
        [StringLength(50)]
        public string MậtKhau { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
