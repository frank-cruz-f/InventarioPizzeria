using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DTO
{
    public class BurntDoughDTO
    {

        public BurntDoughDTO(int BurnedGrams, DateTime burntDate, string cookName)
        {
            this.BurnedGrams = BurnedGrams;
            this.burntDate = burntDate;
            this.cookName = cookName;
        }

        public int ID { get; set; }
        public int BurnedGrams { get; set; }
        public string cookName { get; set; }
        public DateTime burntDate { get; set; }
    }
}
