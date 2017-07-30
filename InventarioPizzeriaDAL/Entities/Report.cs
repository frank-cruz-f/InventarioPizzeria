using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarioPizzeriaDAL.Entities
{
    [Table("Reports")]
    public class Report
    {
        private int spentDough;
        private int initialDough;
        int remainingDough;
        int burntDough;
        int spentCheese;
        private string date;

        [Key]
        public int ID { get; set; }

        public int SpentDough
        {
            get
            {
                return spentDough;
            }

            set
            {
                spentDough = value;
            }
        }

        public int InitialDough
        {
            get
            {
                return initialDough;
            }

            set
            {
                initialDough = value;
            }
        }

        public int RemainingDough
        {
            get
            {
                return remainingDough;
            }

            set
            {
                remainingDough = value;
            }
        }

        public int BurntDough
        {
            get
            {
                return burntDough;
            }

            set
            {
                burntDough = value;
            }
        }

        public int SpentCheese
        {
            get
            {
                return spentCheese;
            }

            set
            {
                spentCheese = value;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public Report()
        {

        }

        public Report(int spentDough, int initialDough, int remainingDough, int burntDough, int spentCheese)
        {
            this.spentDough = spentDough;
            this.initialDough = initialDough;
            this.remainingDough = remainingDough;
            this.burntDough = burntDough;
            this.spentCheese = spentCheese;
        }
    }
}
