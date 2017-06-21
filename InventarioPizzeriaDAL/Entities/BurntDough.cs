using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioPizzeriaDAL.Entities
{
    [Table("BurntDough")]
    public class BurntDough
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int BurnedGrams { get; set; }

        [Required]
        public string cookName { get; set; }

        [Required]
        public DateTime burntDate { get; set; }

        internal BurntDough copyValues(BurntDough dough)
        {
            this.BurnedGrams = dough.BurnedGrams;
            this.cookName = dough.cookName;
            this.burntDate = dough.burntDate;
            return this;
        }
    }
}
