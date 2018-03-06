using AutoMapper;
using InventarioPizzeriaDAL.DTO;
using InventarioPizzeriaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DA
{
    public class ShopDA : DataAccess
    {
        public ShopDA():
            base()
        {

        }

        public List<ShopDTO> getShops()
        {
            return Mapper.Map<List<Shop>, List<ShopDTO>>(context.Shops.ToList());
        }
    }
}
