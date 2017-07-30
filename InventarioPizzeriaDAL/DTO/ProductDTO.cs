using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DTO
{
    public class ProductDTO
    {
        public string ProductName;
        public string Code;
        public int CheeseGrams;
        public int DoughGrams;
        public int ID;

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
