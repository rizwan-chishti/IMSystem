namespace IMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        public int? Cat_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int? Mod_ID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Model Model { get; set; }
    }
}
