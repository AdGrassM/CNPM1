namespace CNPM.CSDL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        [StringLength(50)]
        public string NgayLHD { get; set; }

        [StringLength(10)]
        public string MaMA { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(100)]
        public string TongTien { get; set; }

        [StringLength(10)]
        public string MaKH { get; set; }
    }
}
