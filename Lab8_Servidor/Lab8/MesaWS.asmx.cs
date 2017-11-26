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
    /// Summary description for MesaWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MesaWS : System.Web.Services.WebService {

        private MesaDA mesaDA;
        public MesaWS() {
            mesaDA = new MesaDA();
        }
        [WebMethod]
        public BindingList<Mesa> listarEntradas() {
            BindingList<Mesa> lista = new BindingList<Mesa>();
            lista = mesaDA.listarMesas();
            return lista;
        }
    }
}
