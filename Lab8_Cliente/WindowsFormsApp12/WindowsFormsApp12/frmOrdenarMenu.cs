using Controlador.DetalleOrdenWS;
using Controlador.EntradaWS;
using Controlador.PlatoFondoWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class frmOrdenarMenu : Form
    {
        private Controlador.EntradaWS.Entrada entradaSeleccionada;
        private Controlador.PlatoFondoWS.PlatoFondo platoFondoSeleccionado;
        private BindingList<Orden_Menu_Detalle> lstDetalleOrden;
        private Orden_Menu_Detalle detalle;
        public frmOrdenarMenu()
        {
            InitializeComponent();
            //dgvOrdenesMenu.AutoGenerateColumns = false;
            entradaSeleccionada = new Controlador.EntradaWS.Entrada();
            platoFondoSeleccionado = new Controlador.PlatoFondoWS.PlatoFondo();
            lstDetalleOrden = new BindingList<Orden_Menu_Detalle>();
            dgvOrdenesMenu.DataSource = lstDetalleOrden;
            detalle = new Orden_Menu_Detalle();
            dgvOrdenesMenu.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Texto", HeaderText = "Custom ToString value" });
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSeleccionarMenu frmSeleccionMenu = new frmSeleccionarMenu();
            if (frmSeleccionMenu.ShowDialog() == DialogResult.OK) {
                entradaSeleccionada = frmSeleccionMenu.EntradaSeleccionada;
                platoFondoSeleccionado = frmSeleccionMenu.PlatoFondoSeleccionado;
                
                detalle.PlatoFondo.Id = platoFondoSeleccionado.Id;
                detalle.PlatoFondo.Nombre = platoFondoSeleccionado.Nombre;
                detalle.PlatoFondo.Precio = platoFondoSeleccionado.Precio;
                detalle.Entrada.Id = entradaSeleccionada.Id;
                detalle.Entrada.Nombre = entradaSeleccionada.Nombre;
                detalle.Texto = "Holi";
                MessageBox.Show(detalle.Texto, "Mensaje de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Console.Out.WriteLine(detalle);
                lstDetalleOrden.Add(detalle);
                dgvOrdenesMenu.DataSource = lstDetalleOrden;

                dgvOrdenesMenu.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Texto", HeaderText = "Custom ToString value" });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaPedidos frmBusqPedidos = new frmBusquedaPedidos();
            if (frmBusqPedidos.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
