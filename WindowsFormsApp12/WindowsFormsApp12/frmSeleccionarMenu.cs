using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador.PlatoFondoWS;
using Controlador.EntradaWS;

namespace WindowsFormsApp12
{
    public partial class frmSeleccionarMenu : Form
    {
        private Controlador.PlatoFondoWS.PlatoFondo platoSeleccionado;
        private Controlador.EntradaWS.Entrada entradaSeleccionada;
        private BindingList<Controlador.EntradaWS.Entrada> listaEntradas;
        private BindingList<Controlador.PlatoFondoWS.PlatoFondo> listaPlatos;
        private EntradaBL logica;
        private PlatoFondoBL logicaPlato;

        public frmSeleccionarMenu(){
            InitializeComponent();
            logica = new EntradaBL();
            logicaPlato = new PlatoFondoBL();
            dgvEntradas.AutoGenerateColumns = false;
            listaEntradas = logica.devolverEntradas();
            dgvEntradas.DataSource = listaEntradas;
            dgvPlatosFondo.AutoGenerateColumns = false;
            listaPlatos = logicaPlato.devolverPlatos();
            dgvPlatosFondo.DataSource = listaPlatos;
            entradaSeleccionada = null;
            platoSeleccionado = null;
        }

        public PlatoFondo PlatoSeleccionado { get => platoSeleccionado; set => platoSeleccionado = value; }
        public Entrada EntradaSeleccionada { get => entradaSeleccionada; set => entradaSeleccionada = value; }

        private void btnElegirEntrada_Click(object sender, EventArgs e)
        {
            if (dgvEntradas.CurrentRow == null) return;
            int idx = dgvEntradas.CurrentRow.Index;
            entradaSeleccionada = listaEntradas.ElementAt(idx);
            txtEntrada.Text = entradaSeleccionada.Nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvPlatosFondo.CurrentRow == null) return;
            int idx = dgvPlatosFondo.CurrentRow.Index;
            platoSeleccionado = listaPlatos.ElementAt(idx);
            txtPlatoFondo.Text = platoSeleccionado.Nombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = "";
            entradaSeleccionada = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPlatoFondo.Text = "";
            platoSeleccionado = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
