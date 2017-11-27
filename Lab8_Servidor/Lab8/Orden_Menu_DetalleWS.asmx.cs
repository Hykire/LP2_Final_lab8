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
    /// Summary description for Orden_Menu_DetalleWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Orden_Menu_DetalleWS : System.Web.Services.WebService {

        private OrdenMenuDetalleDA detalleDA;
        public Orden_Menu_DetalleWS() {
            detalleDA = new OrdenMenuDetalleDA();
        }
        [WebMethod]
        public BindingList<Orden_Menu_Detalle> listarDetallePedidos() {
            BindingList<Orden_Menu_Detalle> lista = new BindingList<Orden_Menu_Detalle>();
            lista = detalleDA.listarDetalleDeOrden();
            return lista;
        }
    }
}
