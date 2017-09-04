using InventarioPizzeriaDAL.DTO;
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

namespace InventarioPizzeria.Views
{
    public partial class ConfigCuts : Form
    {
        public ConfigCuts()
        {
            InitializeComponent();
        }

        private void ConfigCuts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localInvPizzDBDataSet1.Doughs' table. You can move, or remove it, as needed.
            this.doughsTableAdapter.Fill(this.localInvPizzDBDataSet1.Doughs);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DoughDTO dough = new DoughDTO(int.Parse(gramsTbx.Text), DateTime.Parse(dateTbx.Text), cookTbx.Text, DoughOperation.Split);

        }
    }
}
