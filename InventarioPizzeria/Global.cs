using InventarioPizzeriaDAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeria
{
    public static class Global
    {
        private static UserType currentUserLevel;
        private static int currentShop;

        public static UserType CurrentUserLevel { get => currentUserLevel; set => currentUserLevel = value; }
        public static int CurrentShop { get => currentShop; set => currentShop = value; }
    }
}
