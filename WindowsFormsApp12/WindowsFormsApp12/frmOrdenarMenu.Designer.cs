namespace WindowsFormsApp12
{
    partial class frmOrdenarMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenarMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.cboMesa = new System.Windows.Forms.ComboBox();
            this.dgvOrdenesMenu = new System.Windows.Forms.DataGridView();
            this.MENUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnRegistrarPedido = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblNumPersonas = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesMenu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesa:";
            // 
            // cboMesa
            // 
            this.cboMesa.FormattingEnabled = true;
            this.cboMesa.Location = new System.Drawing.Point(62, 31);
            this.cboMesa.Name = "cboMesa";
            this.cboMesa.Size = new System.Drawing.Size(246, 21);
            this.cboMesa.TabIndex = 1;
            // 
            // dgvOrdenesMenu
            // 
            this.dgvOrdenesMenu.AllowUserToAddRows = false;
            this.dgvOrdenesMenu.AllowUserToDeleteRows = false;
            this.dgvOrdenesMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrdenesMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenesMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MENUS});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrdenesMenu.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrdenesMenu.Location = new System.Drawing.Point(23, 88);
            this.dgvOrdenesMenu.Name = "dgvOrdenesMenu";
            this.dgvOrdenesMenu.ReadOnly = true;
            this.dgvOrdenesMenu.Size = new System.Drawing.Size(451, 187);
            this.dgvOrdenesMenu.TabIndex = 2;
            // 
            // MENUS
            // 
            this.MENUS.HeaderText = "MENUS";
            this.MENUS.Name = "MENUS";
            this.MENUS.ReadOnly = true;
            this.MENUS.Width = 350;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnRegistrarPedido,
            this.btnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(489, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "&Nuevo";
            // 
            // btnRegistrarPedido
            // 
            this.btnRegistrarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPedido.Image")));
            this.btnRegistrarPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistrarPedido.Name = "btnRegistrarPedido";
            this.btnRegistrarPedido.Size = new System.Drawing.Size(113, 22);
            this.btnRegistrarPedido.Text = "&Registrar Pedido";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(386, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Menú";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(386, 57);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar Menú";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(20, 62);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(61, 13);
            this.lblCapacidad.TabIndex = 6;
            this.lblCapacidad.Text = "Capacidad:";
            // 
            // lblNumPersonas
            // 
            this.lblNumPersonas.AutoSize = true;
            this.lblNumPersonas.Location = new System.Drawing.Point(87, 62);
            this.lblNumPersonas.Name = "lblNumPersonas";
            this.lblNumPersonas.Size = new System.Drawing.Size(10, 13);
            this.lblNumPersonas.TabIndex = 7;
            this.lblNumPersonas.Text = "-";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(402, 282);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(72, 20);
            this.txtPrecioTotal.TabIndex = 8;
            this.txtPrecioTotal.Text = "00.00";
            this.txtPrecioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TOTAL:";
            // 
            // frmOrdenarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 314);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.lblNumPersonas);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvOrdenesMenu);
            this.Controls.Add(this.cboMesa);
            this.Controls.Add(this.label1);
            this.Name = "frmOrdenarMenu";
            this.Text = "Registro de Órdenes de Menus";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenesMenu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMesa;
        private System.Windows.Forms.DataGridView dgvOrdenesMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnRegistrarPedido;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblNumPersonas;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MENUS;
    }
}

