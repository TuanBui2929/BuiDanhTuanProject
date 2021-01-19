namespace QuanLyQuanCoffee.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaLam")]
    public partial class CaLam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaLam()
        {
            CtCaLams = new HashSet<CtCaLam>();
        }

        [Key]
        public int Maca { get; set; }

        [Required]
        [StringLength(50)]
        public string Tenca { get; set; }

        public TimeSpan GiơBD { get; set; }

        public TimeSpan GiơKT { get; set; }

        public double Sotien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CtCaLam> CtCaLams { get; set; }
    }
}
