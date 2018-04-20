namespace InventarioPizzeria.Views
{
    partial class DoughView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DoughGridView = new System.Windows.Forms.DataGridView();
            this.Grams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditCell = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCell = new System.Windows.Forms.DataGridViewImageColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.cookTbx = new System.Windows.Forms.TextBox();
            this.gramsTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.detailPanel = new System.Windows.Forms.Panel();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.filtroDtpFrom = new System.Windows.Forms.DateTimePicker();
            this.filtroLbl = new System.Windows.Forms.Label();
            this.hastaLbl = new System.Windows.Forms.Label();
            this.filtroDtpTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DoughGridView)).BeginInit();
            this.detailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoughGridView
            // 
            this.DoughGridView.AllowUserToAddRows = false;
            this.DoughGridView.AllowUserToDeleteRows = false;
            this.DoughGridView.AllowUserToResizeColumns = false;
            this.DoughGridView.AllowUserToResizeRows = false;
            this.DoughGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoughGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DoughGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoughGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Grams,
            this.Date,
            this.CookName,
            this.ID,
            this.Operation,
            this.EditCell,
            this.DeleteCell});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoughGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.DoughGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DoughGridView.Location = new System.Drawing.Point(49, 103);
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
            this.DoughGridView.Size = new System.Drawing.Size(710, 214);
            this.DoughGridView.TabIndex = 21;
            this.DoughGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoughGridView_CellContentClick);
            // 
            // Grams
            // 
            this.Grams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Grams.DataPropertyName = "Grams";
            this.Grams.HeaderText = "Gramos";
            this.Grams.MinimumWidth = 205;
            this.Grams.Name = "Grams";
            this.Grams.ReadOnly = true;
            this.Grams.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Grams.Width = 205;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Fecha";
            this.Date.MinimumWidth = 200;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Date.Width = 200;
            // 
            // CookName
            // 
            this.CookName.DataPropertyName = "CookName";
            this.CookName.HeaderText = "Cocinero";
            this.CookName.MinimumWidth = 200;
            this.CookName.Name = "CookName";
            this.CookName.ReadOnly = true;
            this.CookName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CookName.Width = 200;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 20;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Visible = false;
            this.ID.Width = 20;
            // 
            // Operation
            // 
            this.Operation.DataPropertyName = "Operation";
            this.Operation.HeaderText = "Operation";
            this.Operation.MinimumWidth = 20;
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Operation.Visible = false;
            this.Operation.Width = 20;
            // 
            // EditCell
            // 
            this.EditCell.HeaderText = "";
            this.EditCell.Image = global::InventarioPizzeria.Resources.edit_interface_sign;
            this.EditCell.MinimumWidth = 50;
            this.EditCell.Name = "EditCell";
            this.EditCell.ReadOnly = true;
            this.EditCell.Width = 50;
            // 
            // DeleteCell
            // 
            this.DeleteCell.HeaderText = "";
            this.DeleteCell.Image = global::InventarioPizzeria.Resources.trash;
            this.DeleteCell.MinimumWidth = 50;
            this.DeleteCell.Name = "DeleteCell";
            this.DeleteCell.ReadOnly = true;
            this.DeleteCell.Width = 50;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(603, 61);
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cocinero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gramos";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // datePicker
            // 
            this.datePicker.CustomFormat = "";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(341, 64);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(142, 20);
            this.datePicker.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Masa";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(43, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 31);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Masa Quemada";
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
            // filtroDtpFrom
            // 
            this.filtroDtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filtroDtpFrom.Location = new System.Drawing.Point(115, 51);
            this.filtroDtpFrom.Name = "filtroDtpFrom";
            this.filtroDtpFrom.Size = new System.Drawing.Size(101, 20);
            this.filtroDtpFrom.TabIndex = 22;
            this.filtroDtpFrom.ValueChanged += new System.EventHandler(this.filtroDtpFrom_ValueChanged);
            // 
            // filtroLbl
            // 
            this.filtroLbl.AutoSize = true;
            this.filtroLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtroLbl.Location = new System.Drawing.Point(49, 51);
            this.filtroLbl.Name = "filtroLbl";
            this.filtroLbl.Size = new System.Drawing.Size(60, 20);
            this.filtroLbl.TabIndex = 23;
            this.filtroLbl.Text = "Desde:";
            // 
            // hastaLbl
            // 
            this.hastaLbl.AutoSize = true;
            this.hastaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastaLbl.Location = new System.Drawing.Point(53, 77);
            this.hastaLbl.Name = "hastaLbl";
            this.hastaLbl.Size = new System.Drawing.Size(56, 20);
            this.hastaLbl.TabIndex = 24;
            this.hastaLbl.Text = "Hasta:";
            this.hastaLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // filtroDtpTo
            // 
            this.filtroDtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.filtroDtpTo.Location = new System.Drawing.Point(115, 77);
            this.filtroDtpTo.Name = "filtroDtpTo";
            this.filtroDtpTo.Size = new System.Drawing.Size(101, 20);
            this.filtroDtpTo.TabIndex = 25;
            this.filtroDtpTo.ValueChanged += new System.EventHandler(this.filtroDtpFrom_ValueChanged);
            // 
            // DoughView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 482);
            this.Controls.Add(this.filtroDtpTo);
            this.Controls.Add(this.hastaLbl);
            this.Controls.Add(this.filtroLbl);
            this.Controls.Add(this.filtroDtpFrom);
            this.Controls.Add(this.DoughGridView);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.detailPanel);
            this.Controls.Add(this.lblTitle);
            this.Name = "DoughView";
            this.Text = "BurntDough";
            this.Load += new System.EventHandler(this.BurntDough_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoughGridView)).EndInit();
            this.detailPanel.ResumeLayout(false);
            this.detailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DataGridView DoughGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grams;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operation;
        private System.Windows.Forms.DataGridViewImageColumn EditCell;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCell;
        private System.Windows.Forms.DateTimePicker filtroDtpFrom;
        private System.Windows.Forms.Label filtroLbl;
        private System.Windows.Forms.Label hastaLbl;
        private System.Windows.Forms.DateTimePicker filtroDtpTo;
    }
}