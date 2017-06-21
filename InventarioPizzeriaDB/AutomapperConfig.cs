using AutoMapper;
using InventarioPizzeriaDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioPizzeriaDAL
{
    class AutomapperConfig
    {
        public AutomapperConfig()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Producto, ProductoDTO>();
            });
        }
    }
}
