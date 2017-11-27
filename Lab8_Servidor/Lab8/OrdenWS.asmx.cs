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
    /// Summary description for OrdenWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrdenWS : System.Web.Services.WebService {

        private OrdenDA ordenDA;
        public OrdenWS() {
            ordenDA = new OrdenDA();
        }
        [WebMethod]
        public BindingList<Orden> listarDetallePedidos() {
            BindingList<Orden> lista = new BindingList<Orden>();
            lista = ordenDA.listarOrdenes();
            return lista;
        }
        [WebMethod]
        public bool registrarOrden(Orden o) {
            return ordenDA.registrarOrden(o);
        }
    }
}
