namespace WindowsFormsApp12
{
    partial class frmSeleccionarMenu
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
            this.gbEntradas = new System.Windows.Forms.GroupBox();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.NOMBRE_ENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtPlatoFondo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPlatosFondo = new System.Windows.Forms.DataGridView();
            this.NOMBRE_PLATO_FONDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnElegirEntrada = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbEntradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.gbSeleccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatosFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEntradas
            // 
            this.gbEntradas.Controls.Add(this.dgvEntradas);
            this.gbEntradas.Location = new System.Drawing.Point(551, 15);
            this.gbEntradas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEntradas.Name = "gbEntradas";
            this.gbEntradas.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEntradas.Size = new System.Drawing.Size(463, 193);
            this.gbEntradas.TabIndex = 1;
            this.gbEntradas.TabStop = false;
            this.gbEntradas.Text = "Entradas";
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.AllowUserToAddRows = false;
            this.dgvEntradas.AllowUserToDeleteRows = false;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE_ENTRADA});
            this.dgvEntradas.Location = new System.Drawing.Point(20, 23);
            this.dgvEntradas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.Size = new System.Drawing.Size(435, 159);
            this.dgvEntradas.TabIndex = 2;
            // 
            // NOMBRE_ENTRADA
            // 
            this.NOMBRE_ENTRADA.DataPropertyName = "Nombre";
            this.NOMBRE_ENTRADA.HeaderText = "NOMBRE";
            this.NOMBRE_ENTRADA.Name = "NOMBRE_ENTRADA";
            this.NOMBRE_ENTRADA.ReadOnly = true;
            this.NOMBRE_ENTRADA.Width = 250;
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.button4);
            this.gbSeleccion.Controls.Add(this.txtPlatoFondo);
            this.gbSeleccion.Controls.Add(this.label2);
            this.gbSeleccion.Controls.Add(this.button2);
            this.gbSeleccion.Controls.Add(this.txtEntrada);
            this.gbSeleccion.Controls.Add(this.label1);
            this.gbSeleccion.Controls.Add(this.pictureBox1);
            this.gbSeleccion.Controls.Add(this.button3);
            this.gbSeleccion.Location = new System.Drawing.Point(16, 15);
            this.gbSeleccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSeleccion.Size = new System.Drawing.Size(449, 412);
            this.gbSeleccion.TabIndex = 2;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Selección";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(372, 314);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtPlatoFondo
            // 
            this.txtPlatoFondo.Location = new System.Drawing.Point(27, 316);
            this.txtPlatoFondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlatoFondo.Name = "txtPlatoFondo";
            this.txtPlatoFondo.Size = new System.Drawing.Size(336, 22);
            this.txtPlatoFondo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Plato de Fondo:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(372, 233);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(27, 235);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(336, 22);
            this.txtEntrada.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entrada:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp12.Properties.Resources._977694414_gif;
            this.pictureBox1.Location = new System.Drawing.Point(89, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 366);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "ACEPTAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPlatosFondo);
            this.groupBox1.Location = new System.Drawing.Point(551, 233);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(463, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Platos de Fondo";
            // 
            // dgvPlatosFondo
            // 
            this.dgvPlatosFondo.AllowUserToAddRows = false;
            this.dgvPlatosFondo.AllowUserToDeleteRows = false;
            this.dgvPlatosFondo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlatosFondo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE_PLATO_FONDO});
            this.dgvPlatosFondo.Location = new System.Drawing.Point(20, 23);
            this.dgvPlatosFondo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPlatosFondo.Name = "dgvPlatosFondo";
            this.dgvPlatosFondo.ReadOnly = true;
            this.dgvPlatosFondo.Size = new System.Drawing.Size(435, 164);
            this.dgvPlatosFondo.TabIndex = 3;
            // 
            // NOMBRE_PLATO_FONDO
            // 
            this.NOMBRE_PLATO_FONDO.DataPropertyName = "Nombre";
            this.NOMBRE_PLATO_FONDO.HeaderText = "NOMBRE";
            this.NOMBRE_PLATO_FONDO.Name = "NOMBRE_PLATO_FONDO";
            this.NOMBRE_PLATO_FONDO.ReadOnly = true;
            this.NOMBRE_PLATO_FONDO.Width = 250;
            // 
            // btnElegirEntrada
            // 
            this.btnElegirEntrada.Location = new System.Drawing.Point(473, 75);
            this.btnElegirEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnElegirEntrada.Name = "btnElegirEntrada";
            this.btnElegirEntrada.Size = new System.Drawing.Size(64, 28);
            this.btnElegirEntrada.TabIndex = 1;
            this.btnElegirEntrada.Text = "<<";
            this.btnElegirEntrada.UseVisualStyleBackColor = true;
            this.btnElegirEntrada.Click += new System.EventHandler(this.btnElegirEntrada_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 294);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSeleccionarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnElegirEntrada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSeleccion);
            this.Controls.Add(this.gbEntradas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSeleccionarMenu";
            this.Text = "Seleccionar Menú";
            this.gbEntradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
            this.gbSeleccion.ResumeLayout(false);
            this.gbSeleccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlatosFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEntradas;
        private System.Windows.Forms.GroupBox gbSeleccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnElegirEntrada;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvPlatosFondo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_ENTRADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_PLATO_FONDO;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtPlatoFondo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label1;
    }
}