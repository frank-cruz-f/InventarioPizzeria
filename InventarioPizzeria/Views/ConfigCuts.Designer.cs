namespace InventarioPizzeria.Views
{
    partial class ConfigCuts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductoGridView = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.gramsTbx = new System.Windows.Forms.TextBox();
            this.nameTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.localInvPizzDBDataSet = new InventarioPizzeria.LocalInvPizzDBDataSet();
            this.localInvPizzDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localInvPizzDBDataSet1 = new InventarioPizzeria.LocalInvPizzDBDataSet1();
            this.doughsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doughsTableAdapter = new InventarioPizzeria.LocalInvPizzDBDataSet1TableAdapters.DoughsTableAdapter();
            this.cookTbx = new System.Windows.Forms.TextBox();
            this.dateTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gramsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCell = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCell = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoGridView)).BeginInit();
            this.detailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localInvPizzDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localInvPizzDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localInvPizzDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doughsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductoGridView
            // 
            this.ProductoGridView.AllowUserToAddRows = false;
            this.ProductoGridView.AllowUserToDeleteRows = false;
            this.ProductoGridView.AllowUserToResizeRows = false;
            this.ProductoGridView.AutoGenerateColumns = false;
            this.ProductoGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poet", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductoGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.gramsDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.cookNameDataGridViewTextBoxColumn,
            this.operationDataGridViewTextBoxColumn,
            this.EditCell,
            this.DeleteCell});
            this.ProductoGridView.DataSource = this.doughsBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poet", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductoGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductoGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductoGridView.Location = new System.Drawing.Point(49, 93);
            this.ProductoGridView.MultiSelect = false;
            this.ProductoGridView.Name = "ProductoGridView";
            this.ProductoGridView.ReadOnly = true;
            this.ProductoGridView.RowHeadersVisible = false;
            this.ProductoGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ProductoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ProductoGridView.ShowCellErrors = false;
            this.ProductoGridView.ShowCellToolTips = false;
            this.ProductoGridView.ShowEditingIcon = false;
            this.ProductoGridView.ShowRowErrors = false;
            this.ProductoGridView.Size = new System.Drawing.Size(710, 224);
            this.ProductoGridView.TabIndex = 21;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Poet", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(603, 51);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(156, 36);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Agregar Corte";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // detailPanel
            // 
            this.detailPanel.Controls.Add(this.cookTbx);
            this.detailPanel.Controls.Add(this.dateTbx);
            this.detailPanel.Controls.Add(this.label4);
            this.detailPanel.Controls.Add(this.label6);
            this.detailPanel.Controls.Add(this.gramsTbx);
            this.detailPanel.Controls.Add(this.nameTbx);
            this.detailPanel.Controls.Add(this.label5);
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
            // gramsTbx
            // 
            this.gramsTbx.Location = new System.Drawing.Point(361, 68);
            this.gramsTbx.Name = "gramsTbx";
            this.gramsTbx.Size = new System.Drawing.Size(142, 20);
            this.gramsTbx.TabIndex = 13;
            // 
            // nameTbx
            // 
            this.nameTbx.Location = new System.Drawing.Point(163, 68);
            this.nameTbx.Name = "nameTbx";
            this.nameTbx.Size = new System.Drawing.Size(142, 20);
            this.nameTbx.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gramos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Corte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poet", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cortes";
            // 
            // localInvPizzDBDataSet
            // 
            this.localInvPizzDBDataSet.DataSetName = "LocalInvPizzDBDataSet";
            this.localInvPizzDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localInvPizzDBDataSetBindingSource
            // 
            this.localInvPizzDBDataSetBindingSource.DataSource = this.localInvPizzDBDataSet;
            this.localInvPizzDBDataSetBindingSource.Position = 0;
            // 
            // localInvPizzDBDataSet1
            // 
            this.localInvPizzDBDataSet1.DataSetName = "LocalInvPizzDBDataSet1";
            this.localInvPizzDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doughsBindingSource
            // 
            this.doughsBindingSource.DataMember = "Doughs";
            this.doughsBindingSource.DataSource = this.localInvPizzDBDataSet1;
            // 
            // doughsTableAdapter
            // 
            this.doughsTableAdapter.ClearBeforeFill = true;
            // 
            // cookTbx
            // 
            this.cookTbx.Location = new System.Drawing.Point(361, 127);
            this.cookTbx.Name = "cookTbx";
            this.cookTbx.Size = new System.Drawing.Size(142, 20);
            this.cookTbx.TabIndex = 17;
            // 
            // dateTbx
            // 
            this.dateTbx.Location = new System.Drawing.Point(163, 127);
            this.dateTbx.Name = "dateTbx";
            this.dateTbx.Size = new System.Drawing.Size(142, 20);
            this.dateTbx.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cocinero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // gramsDataGridViewTextBoxColumn
            // 
            this.gramsDataGridViewTextBoxColumn.DataPropertyName = "Grams";
            this.gramsDataGridViewTextBoxColumn.HeaderText = "Gramos";
            this.gramsDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.gramsDataGridViewTextBoxColumn.Name = "gramsDataGridViewTextBoxColumn";
            this.gramsDataGridViewTextBoxColumn.ReadOnly = true;
            this.gramsDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // cookNameDataGridViewTextBoxColumn
            // 
            this.cookNameDataGridViewTextBoxColumn.DataPropertyName = "CookName";
            this.cookNameDataGridViewTextBoxColumn.HeaderText = "Cocinero";
            this.cookNameDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.cookNameDataGridViewTextBoxColumn.Name = "cookNameDataGridViewTextBoxColumn";
            this.cookNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cookNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // operationDataGridViewTextBoxColumn
            // 
            this.operationDataGridViewTextBoxColumn.DataPropertyName = "Operation";
            this.operationDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.operationDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.operationDataGridViewTextBoxColumn.Name = "operationDataGridViewTextBoxColumn";
            this.operationDataGridViewTextBoxColumn.ReadOnly = true;
            this.operationDataGridViewTextBoxColumn.Visible = false;
            this.operationDataGridViewTextBoxColumn.Width = 150;
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
            // ConfigCuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ProductoGridView);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.label1);
            this.Name = "ConfigCuts";
            this.Text = "ConfigCuts";
            this.Load += new System.EventHandler(this.ConfigCuts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoGridView)).EndInit();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localInvPizzDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localInvPizzDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localInvPizzDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doughsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductoGridView;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Panel detailPanel;
        private System.Windows.Forms.TextBox gramsTbx;
        private System.Windows.Forms.TextBox nameTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource localInvPizzDBDataSetBindingSource;
        private LocalInvPizzDBDataSet localInvPizzDBDataSet;
        private LocalInvPizzDBDataSet1 localInvPizzDBDataSet1;
        private System.Windows.Forms.BindingSource doughsBindingSource;
        private LocalInvPizzDBDataSet1TableAdapters.DoughsTableAdapter doughsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gramsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn EditCell;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCell;
        private System.Windows.Forms.TextBox cookTbx;
        private System.Windows.Forms.TextBox dateTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}