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
        public frmOrdenarMenu()
        {
            InitializeComponent();
            dgvOrdenesMenu.AutoGenerateColumns = false;
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmSeleccionarMenu frmSeleccionMenu = new frmSeleccionarMenu();
            if (frmSeleccionMenu.ShowDialog() == DialogResult.OK)
            {

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
