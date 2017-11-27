using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Controlador.EntradaWS;
using Controlador.PlatoFondoWS;

namespace WindowsFormsApp12
{
    public partial class frmSeleccionarMenu : Form
    {
        private Controlador.EntradaWS.Entrada entradaSeleccionada;
        private EntradaBL entradaBL;
        private Controlador.PlatoFondoWS.PlatoFondo platoFondoSeleccionado;
        private PlatoFondoBL platoFondoBL;
        public frmSeleccionarMenu()
        {
            InitializeComponent();
            entradaSeleccionada = new Controlador.EntradaWS.Entrada();
            entradaBL = new EntradaBL();
            dgvEntradas.DataSource = entradaBL.devolverEntrada();
            platoFondoSeleccionado = new Controlador.PlatoFondoWS.PlatoFondo();
            platoFondoBL = new PlatoFondoBL();
            dgvPlatosFondo.DataSource = platoFondoBL.devolverPlatosFondo();
            dgvEntradas.AutoGenerateColumns = false;
            dgvPlatosFondo.AutoGenerateColumns = false;
        }

        public Entrada EntradaSeleccionada { get => entradaSeleccionada; set => entradaSeleccionada = value; }
        public PlatoFondo PlatoFondoSeleccionado { get => platoFondoSeleccionado; set => platoFondoSeleccionado = value; }

        private void btnElegirEntrada_Click(object sender, EventArgs e) {
            if (dgvEntradas.CurrentRow == null) return;
            int idx = dgvEntradas.CurrentRow.Index;
            entradaSeleccionada = entradaBL.devolverEntrada().ElementAt(idx);
            txtEntrada.Text = entradaSeleccionada.Nombre;
        }

        private void btnElegirPlatoFondo_Click(object sender, EventArgs e) {
            if (dgvPlatosFondo.CurrentRow == null) return;
            int idx = dgvPlatosFondo.CurrentRow.Index;
            platoFondoSeleccionado = platoFondoBL.devolverPlatosFondo().ElementAt(idx);
            txtPlatoFondo.Text = platoFondoSeleccionado.Nombre;
        }

        private void btnQuitarEntrada_Click(object sender, EventArgs e) {
            txtEntrada.Text = "";
        }

        private void btnQuitarPlatoFondo_Click(object sender, EventArgs e) {
            txtPlatoFondo.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            if (dgvPlatosFondo.CurrentRow == null) return;
            int idx = dgvPlatosFondo.CurrentRow.Index;
            platoFondoSeleccionado = new PlatoFondo();
            platoFondoSeleccionado = platoFondoBL.devolverPlatosFondo().ElementAt(idx);
            txtPlatoFondo.Text = platoFondoSeleccionado.Nombre;
            this.Dispose();
        }
    }
}
