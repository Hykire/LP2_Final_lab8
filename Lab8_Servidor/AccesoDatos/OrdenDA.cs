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
                o.Hora_orden = reader.GetDateTime(2);
                o.PreioTotal = reader.GetDouble(3);
                lista.Add(o);
            }
            conn.Close();
            return lista;
        }
    }
}
