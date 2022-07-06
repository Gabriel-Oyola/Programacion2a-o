namespace WindFormsProductos2
{
    partial class FormProductos
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
            this.tabC_Productos = new System.Windows.Forms.TabControl();
            this.SelectTab = new System.Windows.Forms.TabPage();
            this.tabP_Movimiento = new System.Windows.Forms.TabPage();
            this.btCargar = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.rdIngreso = new System.Windows.Forms.RadioButton();
            this.rdEgreso = new System.Windows.Forms.RadioButton();
            this.lblStock = new System.Windows.Forms.Label();
            this.tabC_Productos.SuspendLayout();
            this.SelectTab.SuspendLayout();
            this.tabP_Movimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabC_Productos
            // 
            this.tabC_Productos.Controls.Add(this.SelectTab);
            this.tabC_Productos.Controls.Add(this.tabP_Movimiento);
            this.tabC_Productos.Location = new System.Drawing.Point(0, 0);
            this.tabC_Productos.Name = "tabC_Productos";
            this.tabC_Productos.SelectedIndex = 0;
            this.tabC_Productos.Size = new System.Drawing.Size(788, 229);
            this.tabC_Productos.TabIndex = 0;
            // 
            // SelectTab
            // 
            this.SelectTab.Controls.Add(this.btCargar);
            this.SelectTab.Controls.Add(this.txtStock);
            this.SelectTab.Controls.Add(this.txtDesc);
            this.SelectTab.Controls.Add(this.txtCodigo);
            this.SelectTab.Controls.Add(this.label2);
            this.SelectTab.Controls.Add(this.label3);
            this.SelectTab.Controls.Add(this.label1);
            this.SelectTab.Location = new System.Drawing.Point(4, 22);
            this.SelectTab.Name = "SelectTab";
            this.SelectTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTab.Size = new System.Drawing.Size(780, 203);
            this.SelectTab.TabIndex = 0;
            this.SelectTab.Text = "Carga de productos";
            this.SelectTab.UseVisualStyleBackColor = true;
            // 
            // tabP_Movimiento
            // 
            this.tabP_Movimiento.Controls.Add(this.lblStock);
            this.tabP_Movimiento.Controls.Add(this.rdEgreso);
            this.tabP_Movimiento.Controls.Add(this.rdIngreso);
            this.tabP_Movimiento.Controls.Add(this.BtAceptar);
            this.tabP_Movimiento.Controls.Add(this.txtCantidad);
            this.tabP_Movimiento.Controls.Add(this.lblCantidad);
            this.tabP_Movimiento.Controls.Add(this.lblDesc);
            this.tabP_Movimiento.Controls.Add(this.lblCodigo);
            this.tabP_Movimiento.Location = new System.Drawing.Point(4, 22);
            this.tabP_Movimiento.Name = "tabP_Movimiento";
            this.tabP_Movimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Movimiento.Size = new System.Drawing.Size(780, 203);
            this.tabP_Movimiento.TabIndex = 1;
            this.tabP_Movimiento.Text = "Movimiento de productos";
            this.tabP_Movimiento.UseVisualStyleBackColor = true;
            // 
            // btCargar
            // 
            this.btCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargar.Location = new System.Drawing.Point(213, 114);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(126, 28);
            this.btCargar.TabIndex = 14;
            this.btCargar.Text = "Cargar";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(84, 116);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(123, 26);
            this.txtStock.TabIndex = 13;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(113, 73);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(255, 26);
            this.txtDesc.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(84, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(255, 26);
            this.txtCodigo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo";
            // 
            // BtAceptar
            // 
            this.BtAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAceptar.Location = new System.Drawing.Point(353, 117);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(126, 28);
            this.BtAceptar.TabIndex = 19;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(97, 154);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 26);
            this.txtCantidad.TabIndex = 18;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(18, 157);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(18, 76);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(92, 20);
            this.lblDesc.TabIndex = 17;
            this.lblDesc.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(18, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Codigo";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(4, 235);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(784, 233);
            this.dgvProductos.TabIndex = 20;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // rdIngreso
            // 
            this.rdIngreso.AutoSize = true;
            this.rdIngreso.Location = new System.Drawing.Point(246, 105);
            this.rdIngreso.Name = "rdIngreso";
            this.rdIngreso.Size = new System.Drawing.Size(60, 17);
            this.rdIngreso.TabIndex = 20;
            this.rdIngreso.TabStop = true;
            this.rdIngreso.Text = "Ingreso";
            this.rdIngreso.UseVisualStyleBackColor = true;
            // 
            // rdEgreso
            // 
            this.rdEgreso.AutoSize = true;
            this.rdEgreso.Location = new System.Drawing.Point(246, 128);
            this.rdEgreso.Name = "rdEgreso";
            this.rdEgreso.Size = new System.Drawing.Size(58, 17);
            this.rdEgreso.TabIndex = 21;
            this.rdEgreso.TabStop = true;
            this.rdEgreso.Text = "Egreso";
            this.rdEgreso.UseVisualStyleBackColor = true;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(18, 121);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(50, 20);
            this.lblStock.TabIndex = 22;
            this.lblStock.Text = "Stock";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.tabC_Productos);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.tabC_Productos.ResumeLayout(false);
            this.SelectTab.ResumeLayout(false);
            this.SelectTab.PerformLayout();
            this.tabP_Movimiento.ResumeLayout(false);
            this.tabP_Movimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabC_Productos;
        private System.Windows.Forms.TabPage SelectTab;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabP_Movimiento;
        private System.Windows.Forms.RadioButton rdEgreso;
        private System.Windows.Forms.RadioButton rdIngreso;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblStock;
    }
}