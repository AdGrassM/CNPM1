namespace CNPM.CSDL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonAn")]
    public partial class MonAn
    {
        [Key]
        [StringLength(10)]
        public string MaMA { get; set; }

        [StringLength(50)]
        public string TenMA { get; set; }

        [StringLength(100)]
        public string Gia { get; set; }
    }
}
