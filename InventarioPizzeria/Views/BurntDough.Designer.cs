namespace InventarioPizzeria.Views
{
    partial class BurntDough
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DoughGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burnedGramsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burntDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCell = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCell = new System.Windows.Forms.DataGridViewImageColumn();
            this.burntDoughBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioPizzeriaDataSet1 = new InventarioPizzeria.InventarioPizzeriaDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioPizzeriaDataSet = new InventarioPizzeria.InventarioPizzeriaDataSet();
            this.productTableAdapter = new InventarioPizzeria.InventarioPizzeriaDataSetTableAdapters.ProductTableAdapter();
            this.addBtn = new System.Windows.Forms.Button();
            this.cookTbx = new System.Windows.Forms.TextBox();
            this.gramsTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.burntDoughTableAdapter = new InventarioPizzeria.InventarioPizzeriaDataSet1TableAdapters.BurntDoughTableAdapter();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DoughGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burntDoughBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPizzeriaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPizzeriaDataSet)).BeginInit();
            this.detailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoughGridView
            // 
            this.DoughGridView.AllowUserToAddRows = false;
            this.DoughGridView.AllowUserToDeleteRows = false;
            this.DoughGridView.AllowUserToResizeRows = false;
            this.DoughGridView.AutoGenerateColumns = false;
            this.DoughGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poet", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoughGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DoughGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoughGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.burnedGramsDataGridViewTextBoxColumn,
            this.cookNameDataGridViewTextBoxColumn,
            this.burntDateDataGridViewTextBoxColumn,
            this.EditCell,
            this.DeleteCell});
            this.DoughGridView.DataSource = this.burntDoughBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poet", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoughGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.DoughGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DoughGridView.Location = new System.Drawing.Point(49, 93);
            this.DoughGridView.MultiSelect = false;
            this.DoughGridView.Name = "DoughGridView";
            this.DoughGridView.ReadOnly = true;
            this.DoughGridView.RowHeadersVisible = false;
            this.DoughGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DoughGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DoughGridView.ShowCellErrors = false;
            this.DoughGridView.ShowCellToolTips = false;
            this.DoughGridView.ShowEditingIcon = false;
            this.DoughGridView.ShowRowErrors = false;
            this.DoughGridView.Size = new System.Drawing.Size(710, 224);
            this.DoughGridView.TabIndex = 21;
            this.DoughGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoughGridView_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 205;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 205;
            // 
            // burnedGramsDataGridViewTextBoxColumn
            // 
            this.burnedGramsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.burnedGramsDataGridViewTextBoxColumn.DataPropertyName = "BurnedGrams";
            this.burnedGramsDataGridViewTextBoxColumn.HeaderText = "Gramos";
            this.burnedGramsDataGridViewTextBoxColumn.MinimumWidth = 210;
            this.burnedGramsDataGridViewTextBoxColumn.Name = "burnedGramsDataGridViewTextBoxColumn";
            this.burnedGramsDataGridViewTextBoxColumn.ReadOnly = true;
            this.burnedGramsDataGridViewTextBoxColumn.Width = 210;
            // 
            // cookNameDataGridViewTextBoxColumn
            // 
            this.cookNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cookNameDataGridViewTextBoxColumn.DataPropertyName = "cookName";
            this.cookNameDataGridViewTextBoxColumn.HeaderText = "Cocinero";
            this.cookNameDataGridViewTextBoxColumn.MinimumWidth = 190;
            this.cookNameDataGridViewTextBoxColumn.Name = "cookNameDataGridViewTextBoxColumn";
            this.cookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cookNameDataGridViewTextBoxColumn.Width = 190;
            // 
            // burntDateDataGridViewTextBoxColumn
            // 
            this.burntDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.burntDateDataGridViewTextBoxColumn.DataPropertyName = "burntDate";
            this.burntDateDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.burntDateDataGridViewTextBoxColumn.MinimumWidth = 205;
            this.burntDateDataGridViewTextBoxColumn.Name = "burntDateDataGridViewTextBoxColumn";
            this.burntDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.burntDateDataGridViewTextBoxColumn.Width = 205;
            // 
            // EditCell
            // 
            this.EditCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EditCell.HeaderText = "";
            this.EditCell.Image = global::InventarioPizzeria.Resources.edit_interface_sign;
            this.EditCell.MinimumWidth = 50;
            this.EditCell.Name = "EditCell";
            this.EditCell.ReadOnly = true;
            this.EditCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditCell.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditCell.Width = 50;
            // 
            // DeleteCell
            // 
            this.DeleteCell.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteCell.HeaderText = "";
            this.DeleteCell.Image = global::InventarioPizzeria.Resources.trash;
            this.DeleteCell.MinimumWidth = 50;
            this.DeleteCell.Name = "DeleteCell";
            this.DeleteCell.ReadOnly = true;
            this.DeleteCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteCell.Width = 50;
            // 
            // burntDoughBindingSource
            // 
            this.burntDoughBindingSource.DataMember = "BurntDough";
            this.burntDoughBindingSource.DataSource = this.inventarioPizzeriaDataSet1;
            // 
            // inventarioPizzeriaDataSet1
            // 
            this.inventarioPizzeriaDataSet1.DataSetName = "InventarioPizzeriaDataSet1";
            this.inventarioPizzeriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.inventarioPizzeriaDataSet;
            // 
            // inventarioPizzeriaDataSet
            // 
            this.inventarioPizzeriaDataSet.DataSetName = "InventarioPizzeriaDataSet";
            this.inventarioPizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Poet", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(603, 51);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 36);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Agregar Masa";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cookTbx
            // 
            this.cookTbx.Location = new System.Drawing.Point(143, 129);
            this.cookTbx.Name = "cookTbx";
            this.cookTbx.Size = new System.Drawing.Size(142, 20);
            this.cookTbx.TabIndex = 14;
            // 
            // gramsTbx
            // 
            this.gramsTbx.Location = new System.Drawing.Point(143, 64);
            this.gramsTbx.Name = "gramsTbx";
            this.gramsTbx.Size = new System.Drawing.Size(142, 20);
            this.gramsTbx.TabIndex = 12;
            this.gramsTbx.Text = "0";
            this.gramsTbx.TextChanged += new System.EventHandler(this.numericTexbox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cocinero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gramos";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Poet", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(516, 152);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(97, 33);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Poet", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(619, 152);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 33);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Guardar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.datePicker);
            this.detailPanel.Controls.Add(this.cookTbx);
            this.detailPanel.Controls.Add(this.gramsTbx);
            this.detailPanel.Controls.Add(this.label5);
            this.detailPanel.Controls.Add(this.label4);
            this.detailPanel.Controls.Add(this.label3);
            this.detailPanel.Controls.Add(this.cancelBtn);
            this.detailPanel.Controls.Add(this.saveBtn);
            this.detailPanel.Controls.Add(this.label2);
            this.detailPanel.Location = new System.Drawing.Point(50, 349);
            this.detailPanel.Name = "detailPanel";
            this.detailPanel.Size = new System.Drawing.Size(709, 188);
            this.detailPanel.TabIndex = 19;
            this.detailPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Masa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poet", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Masa Quemada";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::InventarioPizzeria.Resources.edit_interface_sign;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::InventarioPizzeria.Resources.trash;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // burntDoughTableAdapter
            // 
            this.burntDoughTableAdapter.ClearBeforeFill = true;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(341, 64);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(99, 20);
            this.datePicker.TabIndex = 15;
            // 
            // BurntDough
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DoughGridView);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.label1);
            this.Name = "BurntDough";
            this.Text = "BurntDough";
            this.Load += new System.EventHandler(this.BurntDough_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoughGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burntDoughBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPizzeriaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioPizzeriaDataSet)).EndInit();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView DoughGridView;
        private System.Windows.Forms.BindingSource productBindingSource;
        private InventarioPizzeriaDataSet inventarioPizzeriaDataSet;
        private InventarioPizzeriaDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox cookTbx;
        private System.Windows.Forms.TextBox gramsTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private InventarioPizzeriaDataSet1 inventarioPizzeriaDataSet1;
        private System.Windows.Forms.BindingSource burntDoughBindingSource;
        private InventarioPizzeriaDataSet1TableAdapters.BurntDoughTableAdapter burntDoughTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn burnedGramsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn burntDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditCell;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCell;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}