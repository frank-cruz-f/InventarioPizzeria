using InventarioPizzeriaDAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DTO
{
    public class UserDTO
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public int ShopId { get; set; }
        public ShopDTO Shop { get; set; }
    }
}
