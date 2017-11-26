using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos {
    public class MesaDA {
        public BindingList<Mesa> listarMesas() {
            BindingList<Mesa> lista = new BindingList<Mesa>();
            String cadena = "server=50.62.209.188;" + "user=fpaz; password=123456; database=LP2;" + "port=3306";
            MySqlConnection conn = new MySqlConnection(cadena);
            conn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM MESA";
            comando.Connection = conn;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                Mesa m = new Mesa();
                m.Id = reader.GetInt32(0);
                m.Capacidad = reader.GetInt32(1);
                lista.Add(m);
            }
            conn.Close();
            return lista;
        }
    }
}
