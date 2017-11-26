using AccesoDatos;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Lab8 {
    /// <summary>
    /// Summary description for EntradaWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EntradaWS : System.Web.Services.WebService {

        private EntradaDA entradaDA;
        public EntradaWS() {
            entradaDA = new EntradaDA();
        }
        [WebMethod]
        public BindingList<Entrada> listarEntradas() {
            BindingList<Entrada> lista = new BindingList<Entrada>();
            lista = entradaDA.listarEntradas();
            return lista;
        }
    }
}
