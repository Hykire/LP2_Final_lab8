using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo {
    public class Orden_Menu_Detalle {
        private int id;
        private int idOrden;
        private Entrada entrada;
        private PlatoFondo platoFondo;
        private string texto;
        public Orden_Menu_Detalle() {
            entrada = new Entrada();
            platoFondo = new PlatoFondo();
        }
        public int Id { get => id; set => id = value; }
        public Entrada Entrada { get => entrada; set => entrada = value; }
        public PlatoFondo PlatoFondo { get => platoFondo; set => platoFondo = value; }
        public int IdOrden { get => idOrden; set => idOrden = value; }
        public string Texto { get => "Entrada: " + entrada.Nombre + " \n Plato Fondo: " + platoFondo.Nombre + " \n Precio: " + platoFondo.Precio + ""; set => texto = value; }

        public override string ToString() {
            return "Entrada: " + entrada.Nombre + " \n Plato Fondo: " + platoFondo.Nombre + " \n Precio: " + platoFondo.Precio + "";
        }
    }
}
