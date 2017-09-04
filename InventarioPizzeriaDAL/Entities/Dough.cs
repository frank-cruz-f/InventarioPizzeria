using InventarioPizzeriaDAL.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioPizzeriaDAL.Entities
{
    [Table("Doughs")]
    public class Dough
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int Grams { get; set; }

        [Required]
        public string CookName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public DoughOperation Operation { get; set; }

        public string Name { get; set; }

        internal Dough copyValues(Dough dough)
        {
            this.Grams = dough.Grams;
            this.CookName = dough.CookName;
            this.Date = dough.Date;
            this.Name = dough.Name;
            return this;
        }
    }
}
