using InventarioPizzeria.Views;
using InventarioPizzeriaDAL.Enums;
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
            DoughView burntDough = new DoughView(DoughOperation.Burnt);
            burntDough.ShowDialog();
        }

        private void initialDough_Click(object sender, EventArgs e)
        {
            DoughView initialDough = new DoughView(DoughOperation.Initial);
            initialDough.ShowDialog();
        }

        private void doughCutBtn_Click(object sender, EventArgs e)
        {
            DoughView cut = new DoughView(DoughOperation.Split);
            cut.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoughView remaining = new DoughView(DoughOperation.Remaining);
            remaining.ShowDialog();
        }

        private void loadReportBtn_Click(object sender, EventArgs e)
        {
            ReportView report = new ReportView();
            report.ShowDialog();
        }
    }
}
