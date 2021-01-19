namespace QuanLyQuanCoffee.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThucUong")]
    public partial class ThucUong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThucUong()
        {
            CTHoaDons = new HashSet<CTHoaDon>();
        }

        [Key]
        [StringLength(50)]
        public string Manuoc { get; set; }

        [Required]
        [StringLength(50)]
        public string Tennuoc { get; set; }

        public double Đơngia { get; set; }

        [Required]
        [StringLength(50)]
        public string Maloai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; }

        public virtual Loai Loai { get; set; }
    }
}
