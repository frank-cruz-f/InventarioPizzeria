using AutoMapper;
using InventarioPizzeriaDAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DA
{
    public class UserDA : DataAccess
    {
        public UserDA():
            base()
        {

        }

        public UserDTO login(string username, string password, int shopId)
        {
            var user = context.Users.FirstOrDefault(u => u.Username == username && u.Password == password && shopId == u.ShopId);
            return user != null ? Mapper.Map<UserDTO>(user) : null;
        }
    }
}
