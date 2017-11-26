using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo {
    public class Mesa {
        int id;
        int capacidad;

        public Mesa() {

        }
        public int Id { get => id; set => id = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
    }
}
