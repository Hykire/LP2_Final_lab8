﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador {
    public class EntradaBL {
        private EntradaWS.EntradaWSSoapClient acceso;
        public EntradaBL() {
            acceso = new EntradaWS.EntradaWSSoapClient();
        }
        public BindingList<EntradaWS.Entrada> devolverEntrada() {
            BindingList<EntradaWS.Entrada> lista;
            lista = new BindingList<EntradaWS.Entrada>(acceso.listarEntradas());
            return lista;
        }
    }
}
