using System;
using System.Windows.Forms;
using InventarioPizzeriaDAL.DA;
using InventarioPizzeriaDAL.DTO;
using System.Data;
using System.ComponentModel;

namespace InventarioPizzeria.Views
{
    public partial class ConfigIngred : Form
    {
        private ProductDA dataAccess;
        private bool editMode = false;
        private int editingID = 0;

        public ConfigIngred()
        {
            InitializeComponent();
            ProductoGridView.AutoGenerateColumns = false;
            dataAccess = new ProductDA();
        }

        private void ConfigIngred_Load(object sender, EventArgs e)
        {
            var productos = new BindingList<ProductDTO>(dataAccess.getProducts());
            ProductoGridView.DataSource = productos;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearAndHideForm();
        }

        private void clearAndHideForm()
        {
            nameTbx.Clear();
            codeTbx.Clear();
            doughGramsTbx.Clear();
            cheeseGramsTbx.Clear();
            editingID = 0;
            editMode = false;
            detailPanel.Hide();

            reloadGridView();
        }

        private void reloadGridView()
        {
            var productos = new BindingList<ProductDTO>(dataAccess.getProducts());
            ProductoGridView.DataSource = productos;
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            detailPanel.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool result;
            ProductDTO product = new ProductDTO(nameTbx.Text, codeTbx.Text, int.Parse(cheeseGramsTbx.Text), int.Parse(doughGramsTbx.Text));
            if (editMode)
            {
                product.ID = editingID;
            }

            result = dataAccess.saveProduct(product);

            if (result)
            {
                clearAndHideForm();
            }
        }

        private void ProductoGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    var boundItem = (ProductDTO)senderGrid.Rows[e.RowIndex].DataBoundItem;
                    var productId = boundItem.ID;
                    if(e.ColumnIndex == 5)
                    {
                        populateEditProduct(productId);
                    }
                    else if(e.ColumnIndex == 6)
                    {
                        deleteProduct(productId);
                    }
                }
                catch (Exception)
                {
                    
                }
                
            }
        }

        private void populateEditProduct(int productId)
        {
            editMode = true;
            editingID = productId;
            var product = dataAccess.getProduct(productId);
            nameTbx.Text = product.ProductName;
            codeTbx.Text = product.Code;
            cheeseGramsTbx.Text = product.CheeseGrams.ToString();
            doughGramsTbx.Text = product.DoughGrams.ToString();
            detailPanel.Show();
        }

        private void deleteProduct(int productId)
        {
            dataAccess.deleteProduct(productId);
            reloadGridView();
        }
    }
}
