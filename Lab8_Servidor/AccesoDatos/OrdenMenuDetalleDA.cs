using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos {
    public class OrdenMenuDetalleDA {
        public BindingList<Orden_Menu_Detalle> listarDetalleDeOrden() {
            BindingList<Orden_Menu_Detalle> lista = new BindingList<Orden_Menu_Detalle>();
            String cadena = "server=50.62.209.188;" + "user=fpaz; password=123456; database=LP2;" + "port=3306";
            MySqlConnection conn = new MySqlConnection(cadena);
            conn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM ORDEN_MENU_DETALLE";
            comando.Connection = conn;
            
            MySqlDataReader reader = comando.ExecuteReader();

            EntradaDA entradaDA = new EntradaDA();
            BindingList<Entrada> lstEntradas = new BindingList<Entrada>();
            lstEntradas = entradaDA.listarEntradas();

            PlatoFondoDA platoFondoDA = new PlatoFondoDA();
            BindingList<PlatoFondo> lstPlatosFondo = new BindingList<PlatoFondo>();
            lstPlatosFondo = platoFondoDA.listarPlatoFondo();

            while (reader.Read()) {
                Orden_Menu_Detalle detalle = new Orden_Menu_Detalle();
                detalle.Id = reader.GetInt32(0);
                detalle.IdOrden = reader.GetInt32(1);
                for(int i = 0; i < lstEntradas.Count(); i++) {
                    if(lstEntradas.ElementAt(i).Id == reader.GetInt32(2)) {
                        detalle.Entrada = lstEntradas.ElementAt(i);
                        break;
                    }
                }
                for (int i = 0; i < lstPlatosFondo.Count(); i++) {
                    if (lstPlatosFondo.ElementAt(i).Id == reader.GetInt32(3)) {
                        detalle.PlatoFondo = lstPlatosFondo.ElementAt(i);
                        break;
                    }
                }
                lista.Add(detalle);
            }
            conn.Close();
            return lista;
        }
        public bool registrarDetallePedido(Orden_Menu_Detalle detalle) {
            String cadena = "server=50.62.209.188;" + "user=fpaz; password=123456; database=LP2;" + "port=3306";
            MySqlConnection conn = new MySqlConnection(cadena);
            conn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "INSERT INTO ORDEN_MENU_DETALLE(ID_ORDEN_MENU_DETALLE,FID_ORDEN,FID_ENTRADA,FID_PLATO_FONDO) VALUES ('NULL','" + detalle.IdOrden + "','" + detalle.Entrada.Id + "','" + detalle.PlatoFondo.Id + "')";
            comando.Connection = conn;
            comando.ExecuteNonQuery();
            return true;
        }
    }
}
