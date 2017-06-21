using InventarioPizzeriaDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL.DA
{
    public class DataAccess
    {
        public InvPizzeriaModel context;

        public DataAccess()
        {
            context = new InvPizzeriaModel();
        }
    }
}
