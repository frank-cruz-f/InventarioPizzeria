using InventarioPizzeria.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioPizzeria
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void configurarIngredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigIngred configIngred = new ConfigIngred();
            configIngred.ShowDialog();
        }

        private void burntDoughBtn_Click(object sender, EventArgs e)
        {
            BurntDough burntDough = new BurntDough();
            burntDough.ShowDialog();
        }
    }
}
