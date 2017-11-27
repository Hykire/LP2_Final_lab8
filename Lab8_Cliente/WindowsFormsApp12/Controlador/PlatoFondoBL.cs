using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador {
    public class PlatoFondoBL {
        private PlatoFondoWS.Plato_FondoWSSoapClient acceso;
        public PlatoFondoBL() {
            acceso = new PlatoFondoWS.Plato_FondoWSSoapClient();
        }
        public BindingList<PlatoFondoWS.PlatoFondo> devolverPlatosFondo() {
            BindingList<PlatoFondoWS.PlatoFondo> lista;
            lista = new BindingList<PlatoFondoWS.PlatoFondo>(acceso.listarPlatoFondo());
            return lista;
        }
    }
}
