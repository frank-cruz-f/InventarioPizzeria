using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventarioPizzeriaDAL;
using System.Deployment.Application;
using InventarioPizzeriaDAL.Entities;
using System.Data.Entity.Migrations;
using System.Diagnostics;

namespace InventarioPizzeria
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AutomapperConfig.MapperConfig();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
