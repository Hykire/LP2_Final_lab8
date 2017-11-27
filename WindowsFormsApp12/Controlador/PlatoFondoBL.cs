using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class PlatoFondoBL
    {
        private PlatoFondoWS.Plato_FondoWSSoapClient acceso;

        public PlatoFondoBL() {
            acceso = new PlatoFondoWS.Plato_FondoWSSoapClient();
        }

        public BindingList<PlatoFondoWS.PlatoFondo> devolverPlatos() {
            BindingList<PlatoFondoWS.PlatoFondo> lista = new BindingList<PlatoFondoWS.PlatoFondo>(acceso.listarEntradas());
            return lista;
        }

    }
}
