namespace InventarioPizzeriaDAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public int DoughGrams { get; set; }

        public int CheeseGrams { get; set; }

        internal Product copyValues(Product product)
        {
            this.Name = product.Name;
            this.Code = product.Code;
            this.DoughGrams = product.DoughGrams;
            this.CheeseGrams = product.CheeseGrams;

            return this;
        }
    }
}
