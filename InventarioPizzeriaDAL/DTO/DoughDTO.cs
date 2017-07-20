using InventarioPizzeriaDAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DTO
{
    public class DoughDTO
    {
        public DoughDTO()
        {

        }

        public DoughDTO(int BurnedGrams, DateTime burntDate, string cookName, DoughOperation operation)
        {
            this.Grams = BurnedGrams;
            this.Date = burntDate;
            this.CookName = cookName;
            this.Operation = operation;
        }

        public int ID { get; set; }
        public int Grams { get; set; }
        public string CookName { get; set; }
        public DateTime Date { get; set; }
        public DoughOperation Operation { get; set; }
    }
}
