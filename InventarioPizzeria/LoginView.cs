using InventarioPizzeriaDAL.DA;
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
    public partial class LoginView : Form
    {
        UserDA userDa;
        ShopDA shopDa;
        public LoginView()
        {
            InitializeComponent();
            userDa = new UserDA();
            shopDa = new ShopDA();
            var shops = shopDa.getShops();
            shopCbx.DataSource = shops;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = userDa.login(userTbx.Text, passTbx.Text);
            if(user != null)
            {
                Global.CurrentUserLevel = user.UserType;
                Global.CurrentShop = (int)shopCbx.SelectedValue;
                var menu = new MainMenu();
                menu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El usuario y/o la contraseña son incorrectos");
            }
        }

        private void LoginView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.ActiveControl == null || this.ActiveControl.Text != "Entrar")
            {
                Application.Exit();
            }
        }
    }
}
