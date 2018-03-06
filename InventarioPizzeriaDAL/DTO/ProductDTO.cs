using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DTO
{
    public class ProductDTO
    {
        public string ProductName { get; set; }
        public string Code { get; set; }
        public int CheeseGrams { get; set; }
        public int DoughGrams { get; set; }
        public int ID { get; set; }

        public ProductDTO(string name, string code, int cheeseGrams, int doughGrams)
        {
            this.ProductName = name;
            this.Code = code;
            this.CheeseGrams = cheeseGrams;
            this.DoughGrams = doughGrams;
        }

        public ProductDTO()
        {

        }
    }
}
