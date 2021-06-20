namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [StringLength(50)]
        public string Description { get; set; }

        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
