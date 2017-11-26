using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos {
    public class PlatoFondoDA {
        public BindingList<PlatoFondo> listarPlatoFondo() {
            BindingList<PlatoFondo> lista = new BindingList<PlatoFondo>();
            String cadena = "server=50.62.209.188;" + "user=fpaz; password=123456; database=LP2;" + "port=3306";
            MySqlConnection conn = new MySqlConnection(cadena);
            conn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM PLATO_FONDO";
            comando.Connection = conn;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                PlatoFondo p = new PlatoFondo();
                p.Id = reader.GetInt32(0);
                p.Nombre = reader.GetString(1);
                p.Precio = reader.GetDouble(2);
                lista.Add(p);
            }
            conn.Close();
            return lista;
        }
    }
}
