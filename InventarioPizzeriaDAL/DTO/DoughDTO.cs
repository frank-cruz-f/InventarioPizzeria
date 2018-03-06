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

        public DoughDTO(int grams, DateTime date, string cookName, DoughOperation operation, int shopId, string name = "")
        {
            this.Grams = grams;
            this.Date = date;
            this.CookName = cookName;
            this.Operation = operation;
            this.Name = name;
            this.ShopId = shopId;
        }

        public int ID { get; set; }
        public int Grams { get; set; }
        public string CookName { get; set; }
        public DateTime Date { get; set; }
        public DoughOperation Operation { get; set; }
        public string Name { get; set; }
        public int ShopId { get; set; }
    }
}
