﻿using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab8 {
    /// <summary>
    /// Summary description for Plato_FondoWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Plato_FondoWS : System.Web.Services.WebService {

        private PlatoFondoDA platoFondoDA;
        public Plato_FondoWS() {
            platoFondoDA = new PlatoFondoDA();
        }
        [WebMethod]
        public BindingList<PlatoFondo> listarPlatoFondo() {
            BindingList<PlatoFondo> lista = new BindingList<PlatoFondo>();
            lista = platoFondoDA.listarPlatoFondo();
            return lista;
        }
    }
}
