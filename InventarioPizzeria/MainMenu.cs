using InventarioPizzeria.Views;
using InventarioPizzeriaDAL.DA;
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
        private ShopDA shopDA;
        public MainMenu()
        {
            shopDA = new ShopDA();
            InitializeComponent();
            sucursal.Text = "Sucursal: " + shopDA.getShopNameById(Global.CurrentShop);
            if(Global.CurrentUserLevel != UserType.Admin)
            {
                loadReportBtn.Visible = false;
                configurarIngredientesToolStripMenuItem.Visible = false;
            }
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
        }
    }
}
