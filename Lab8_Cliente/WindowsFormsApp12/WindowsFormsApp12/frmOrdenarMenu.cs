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
        
        public frmOrdenarMenu()
        {
            InitializeComponent();
            dgvOrdenesMenu.AutoGenerateColumns = false;
            entradaSeleccionada = new Controlador.EntradaWS.Entrada();
            platoFondoSeleccionado = new Controlador.PlatoFondoWS.PlatoFondo();
            lstDetalleOrden = new BindingList<Orden_Menu_Detalle>();
            dgvOrdenesMenu.DataSource = lstDetalleOrden;
            
            //dgvOrdenesMenu.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Texto", HeaderText = "Custom ToString value" });
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSeleccionarMenu frmSeleccionMenu = new frmSeleccionarMenu();
            if (frmSeleccionMenu.ShowDialog() == DialogResult.OK) {
                entradaSeleccionada = frmSeleccionMenu.EntradaSeleccionada;
                platoFondoSeleccionado = frmSeleccionMenu.PlatoFondoSeleccionado;
                MessageBox.Show(platoFondoSeleccionado.Nombre, "Mensaje de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Orden_Menu_Detalle detalle = new Orden_Menu_Detalle();
                detalle.PlatoFondo = new Controlador.DetalleOrdenWS.PlatoFondo();
                detalle.Entrada = new Controlador.DetalleOrdenWS.Entrada();
                if (detalle == null)
                    MessageBox.Show("Error!!", "Mensaje de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if(platoFondoSeleccionado == null)
                    MessageBox.Show("Plato nulo!", "Mensaje de aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                detalle.PlatoFondo.Id = platoFondoSeleccionado.Id;
                detalle.PlatoFondo.Nombre = platoFondoSeleccionado.Nombre;
                detalle.PlatoFondo.Precio = platoFondoSeleccionado.Precio;
                detalle.Entrada.Id = entradaSeleccionada.Id;
                detalle.Entrada.Nombre = entradaSeleccionada.Nombre;
                detalle.Texto = "Entrada: " + detalle.Entrada.Nombre + "\nPlato Fondo: " + detalle.PlatoFondo.Nombre + "\nPrecio: " + detalle.PlatoFondo.Precio; 
                lstDetalleOrden.Add(detalle);
                //dgvOrdenesMenu.DataSource = lstDetalleOrden;

                //dgvOrdenesMenu.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Texto", HeaderText = "Custom ToString value" });
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
