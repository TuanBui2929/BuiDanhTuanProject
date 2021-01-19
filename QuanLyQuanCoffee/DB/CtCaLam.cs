namespace QuanLyQuanCoffee.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CtCaLam")]
    public partial class CtCaLam
    {
        public int Id { get; set; }

        public int Manv { get; set; }

        public int Maca { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngay { get; set; }

        public virtual CaLam CaLam { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
