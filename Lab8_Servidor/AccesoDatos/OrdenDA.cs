using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos {
    public class OrdenDA {
        public BindingList<Orden> listarOrdenes() {
            BindingList<Orden> lista = new BindingList<Orden>();
            String cadena = "server=50.62.209.188;" + "user=fpaz; password=123456; database=LP2;" + "port=3306";
            MySqlConnection conn = new MySqlConnection(cadena);
            conn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM ORDEN";
            comando.Connection = conn;

            MesaDA mesaDA = new MesaDA();
            BindingList<Mesa> lstMesas = new BindingList<Mesa>();
            lstMesas = mesaDA.listarMesas();

            OrdenMenuDetalleDA detalleDA = new OrdenMenuDetalleDA();
            BindingList<Orden_Menu_Detalle> lstDetalle = new BindingList<Orden_Menu_Detalle>();
            lstDetalle = detalleDA.listarDetalleDeOrden();

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                Orden o = new Orden();
                o.Id = reader.GetInt32(0);
                int idMesa = reader.GetInt32(1);
                for(int i = 0; i < lstMesas.Count(); i++) {
                    if (lstMesas.ElementAt(i).Id == o.Id) {
                        o.Mesa = lstMesas.ElementAt(i);
                        break;
                    }
                }
                for (int i = 0; i < lstDetalle.Count(); i++) {
                    if (lstDetalle.ElementAt(i).IdOrden == o.Id) {
                        o.DetalleOrden.Add(lstDetalle.ElementAt(i));
                    }
                }
                o.Hora_orden = reader.GetDateTime(2);
                o.PreioTotal = reader.GetDouble(3);
                lista.Add(o);
            }
            conn.Close();
            return lista;
        }
    }
}
