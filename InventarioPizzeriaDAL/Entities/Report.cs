using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioPizzeriaDAL.Entities
{
    [Table("Reports")]
    public class Report
    {
        public int SpentDough { get; set; }
        public int InitialDough { get; set; }
        public int RemainingDough { get; set; }
        public int BurntDough { get; set; }
        public int SpentCheese { get; set; }
        public string Date { get; set; }
        public int ShopId { get; set; }
        [ForeignKey("ShopId")]
        public virtual Shop Shop { get; set; }
        public bool IsCallCenterReport { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime FinalDate { get; set; }

        [Key]
        public int ID { get; set; }
        

        public Report()
        {

        }
    }
}
