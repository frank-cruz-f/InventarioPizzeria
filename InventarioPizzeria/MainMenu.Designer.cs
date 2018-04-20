namespace InventarioPizzeria
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarIngredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadReportBtn = new System.Windows.Forms.Button();
            this.burntDoughBtn = new System.Windows.Forms.Button();
            this.doughCutBtn = new System.Windows.Forms.Button();
            this.initialDough = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sucursal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarIngredientesToolStripMenuItem,
            this.toolStripMenuItem1});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // configurarIngredientesToolStripMenuItem
            // 
            this.configurarIngredientesToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configurarIngredientesToolStripMenuItem.Name = "configurarIngredientesToolStripMenuItem";
            this.configurarIngredientesToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.configurarIngredientesToolStripMenuItem.Text = "Configurar Ingredientes";
            this.configurarIngredientesToolStripMenuItem.Click += new System.EventHandler(this.configurarIngredientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(308, 30);
            this.toolStripMenuItem1.Text = "Salir";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // loadReportBtn
            // 
            this.loadReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadReportBtn.Location = new System.Drawing.Point(316, 188);
            this.loadReportBtn.Name = "loadReportBtn";
            this.loadReportBtn.Size = new System.Drawing.Size(144, 81);
            this.loadReportBtn.TabIndex = 1;
            this.loadReportBtn.Text = "Cargar Reporte";
            this.loadReportBtn.UseVisualStyleBackColor = true;
            this.loadReportBtn.Click += new System.EventHandler(this.loadReportBtn_Click);
            // 
            // burntDoughBtn
            // 
            this.burntDoughBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burntDoughBtn.Location = new System.Drawing.Point(414, 329);
            this.burntDoughBtn.Name = "burntDoughBtn";
            this.burntDoughBtn.Size = new System.Drawing.Size(144, 81);
            this.burntDoughBtn.TabIndex = 3;
            this.burntDoughBtn.Text = "Masa Quemada";
            this.burntDoughBtn.UseVisualStyleBackColor = true;
            this.burntDoughBtn.Click += new System.EventHandler(this.burntDoughBtn_Click);
            // 
            // doughCutBtn
            // 
            this.doughCutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doughCutBtn.Location = new System.Drawing.Point(224, 329);
            this.doughCutBtn.Name = "doughCutBtn";
            this.doughCutBtn.Size = new System.Drawing.Size(144, 81);
            this.doughCutBtn.TabIndex = 4;
            this.doughCutBtn.Text = "Corte de Masa";
            this.doughCutBtn.UseVisualStyleBackColor = true;
            this.doughCutBtn.Click += new System.EventHandler(this.doughCutBtn_Click);
            // 
            // initialDough
            // 
            this.initialDough.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initialDough.Location = new System.Drawing.Point(34, 329);
            this.initialDough.Name = "initialDough";
            this.initialDough.Size = new System.Drawing.Size(144, 81);
            this.initialDough.TabIndex = 5;
            this.initialDough.Text = "Masa Inicial";
            this.initialDough.UseVisualStyleBackColor = true;
            this.initialDough.Click += new System.EventHandler(this.initialDough_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(604, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 81);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sobrante de Masa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sucursal
            // 
            this.sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sucursal.Location = new System.Drawing.Point(178, 90);
            this.sucursal.Name = "sucursal";
            this.sucursal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sucursal.Size = new System.Drawing.Size(422, 51);
            this.sucursal.TabIndex = 7;
            this.sucursal.Text = "Sucursal";
            this.sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.sucursal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.initialDough);
            this.Controls.Add(this.doughCutBtn);
            this.Controls.Add(this.burntDoughBtn);
            this.Controls.Add(this.loadReportBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarIngredientesToolStripMenuItem;
        private System.Windows.Forms.Button loadReportBtn;
        private System.Windows.Forms.Button burntDoughBtn;
        private System.Windows.Forms.Button doughCutBtn;
        private System.Windows.Forms.Button initialDough;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label sucursal;
    }
}

