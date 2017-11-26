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
            this.gbSeleccion = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPlatosFondo = new System.Windows.Forms.DataGridView();
            this.btnElegirEntrada = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NOMBRE_ENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_PLATO_FONDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.gbEntradas.Location = new System.Drawing.Point(413, 12);
            this.gbEntradas.Name = "gbEntradas";
            this.gbEntradas.Size = new System.Drawing.Size(347, 157);
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
            this.dgvEntradas.Location = new System.Drawing.Point(15, 19);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.Size = new System.Drawing.Size(326, 129);
            this.dgvEntradas.TabIndex = 2;
            // 
            // gbSeleccion
            // 
            this.gbSeleccion.Controls.Add(this.button4);
            this.gbSeleccion.Controls.Add(this.textBox2);
            this.gbSeleccion.Controls.Add(this.label2);
            this.gbSeleccion.Controls.Add(this.button2);
            this.gbSeleccion.Controls.Add(this.textBox1);
            this.gbSeleccion.Controls.Add(this.label1);
            this.gbSeleccion.Controls.Add(this.pictureBox1);
            this.gbSeleccion.Controls.Add(this.button3);
            this.gbSeleccion.Location = new System.Drawing.Point(12, 12);
            this.gbSeleccion.Name = "gbSeleccion";
            this.gbSeleccion.Size = new System.Drawing.Size(337, 335);
            this.gbSeleccion.TabIndex = 2;
            this.gbSeleccion.TabStop = false;
            this.gbSeleccion.Text = "Selección";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp12.Properties.Resources._977694414_gif;
            this.pictureBox1.Location = new System.Drawing.Point(67, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "ACEPTAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPlatosFondo);
            this.groupBox1.Location = new System.Drawing.Point(413, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 158);
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
            this.dgvPlatosFondo.Location = new System.Drawing.Point(15, 19);
            this.dgvPlatosFondo.Name = "dgvPlatosFondo";
            this.dgvPlatosFondo.ReadOnly = true;
            this.dgvPlatosFondo.Size = new System.Drawing.Size(326, 133);
            this.dgvPlatosFondo.TabIndex = 3;
            // 
            // btnElegirEntrada
            // 
            this.btnElegirEntrada.Location = new System.Drawing.Point(355, 61);
            this.btnElegirEntrada.Name = "btnElegirEntrada";
            this.btnElegirEntrada.Size = new System.Drawing.Size(48, 23);
            this.btnElegirEntrada.TabIndex = 1;
            this.btnElegirEntrada.Text = "<<";
            this.btnElegirEntrada.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NOMBRE_ENTRADA
            // 
            this.NOMBRE_ENTRADA.DataPropertyName = "Nombre";
            this.NOMBRE_ENTRADA.HeaderText = "NOMBRE";
            this.NOMBRE_ENTRADA.Name = "NOMBRE_ENTRADA";
            this.NOMBRE_ENTRADA.ReadOnly = true;
            this.NOMBRE_ENTRADA.Width = 250;
            // 
            // NOMBRE_PLATO_FONDO
            // 
            this.NOMBRE_PLATO_FONDO.DataPropertyName = "Nombre";
            this.NOMBRE_PLATO_FONDO.HeaderText = "NOMBRE";
            this.NOMBRE_PLATO_FONDO.Name = "NOMBRE_PLATO_FONDO";
            this.NOMBRE_PLATO_FONDO.ReadOnly = true;
            this.NOMBRE_PLATO_FONDO.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entrada:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(279, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Plato de Fondo:";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(279, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 20);
            this.textBox2.TabIndex = 8;
            // 
            // frmSeleccionarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnElegirEntrada);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSeleccion);
            this.Controls.Add(this.gbEntradas);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}