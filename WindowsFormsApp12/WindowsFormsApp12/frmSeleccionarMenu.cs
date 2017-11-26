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

namespace WindowsFormsApp12
{
    public partial class frmSeleccionarMenu : Form
    {
        private EntradaBL logica;

        public frmSeleccionarMenu()
        {
            InitializeComponent();
            logica = new EntradaBL();
            //dgvEntradas.AutoGenerateColumns = false;
            dgvEntradas.DataSource = logica.devolverEntradas();
            dgvPlatosFondo.AutoGenerateColumns = false;
        }

    }
}
