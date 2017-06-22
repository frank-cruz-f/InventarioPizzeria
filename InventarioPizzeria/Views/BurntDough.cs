using InventarioPizzeriaDAL.DA;
using InventarioPizzeriaDAL.DTO;
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
    public partial class BurntDough : Form
    {
        private int editingID;
        private bool editMode;
        private BurntDoughDA dataAccess;

        public BurntDough()
        {
            InitializeComponent();
            dataAccess = new BurntDoughDA();
        }

        private void BurntDough_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'localInvPizzDBDataSet1.BurntDough' table. You can move, or remove it, as needed.
            this.burntDoughTableAdapter.Fill(this.localInvPizzDBDataSet1.BurntDough);
        }

        private void DoughGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    var boundItem = (DataRowView)senderGrid.Rows[e.RowIndex].DataBoundItem;
                    var doughId = boundItem.Row.Field<int>("ID");
                    if (e.ColumnIndex == 4)
                    {
                        populateEditBurntDough(doughId);
                    }
                    else if (e.ColumnIndex == 5)
                    {
                        deleteBurntDough(doughId);
                    }
                }
                catch (Exception)
                {

                }

            }
        }

        private void deleteBurntDough(int doughId)
        {
            dataAccess.deleteDough(doughId);
            reloadGridView();
        }

        private void populateEditBurntDough(int doughId)
        {
            editMode = true;
            editingID = doughId;
            var dough = dataAccess.getDough(doughId);
            gramsTbx.Text = dough.BurnedGrams.ToString();
            cookTbx.Text = dough.cookName;
            datePicker.Text = dough.burntDate.ToString();
            detailPanel.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool result;
            BurntDoughDTO dough = new BurntDoughDTO(int.Parse(gramsTbx.Text), DateTime.Parse(datePicker.Text), cookTbx.Text);
            if (editMode)
            {
                dough.ID = editingID;
            }

            result = dataAccess.saveDough(dough);

            if (result)
            {
                clearAndHideForm();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearAndHideForm();
        }

        private void clearAndHideForm()
        {
            gramsTbx.Clear();
            cookTbx.Clear();
            editingID = 0;
            editMode = false;
            detailPanel.Hide();

            reloadGridView();
        }

        private void reloadGridView()
        {
            this.burntDoughTableAdapter.Fill(this.localInvPizzDBDataSet1.BurntDough);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            detailPanel.Show();
        }

        private void numericTexbox_TextChanged(object sender, EventArgs e)
        {
            TextBox senderButton = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(senderButton.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor usar solo numeros");
                senderButton.Text = senderButton.Text.Remove(senderButton.Text.Length - 1);
            }
        }
    }
}
