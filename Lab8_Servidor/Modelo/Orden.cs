using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo {
    public class Orden {
        int id;
        Mesa mesa;
        DateTime hora_orden;
        Orden_Menu_Detalle detalleOrden;
        double preioTotal;
        
        public Orden() {
            Mesa = new Mesa();
            detalleOrden = new Orden_Menu_Detalle();
        }

        public int Id { get => id; set => id = value; }
        public Mesa Mesa { get => mesa; set => mesa = value; }
        public DateTime Hora_orden { get => hora_orden; set => hora_orden = value; }
        public double PreioTotal { get => preioTotal; set => preioTotal = value; }
        public Orden_Menu_Detalle DetalleOrden { get => detalleOrden; set => detalleOrden = value; }
    }
}
