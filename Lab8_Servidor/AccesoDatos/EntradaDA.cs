using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos {

    public class EntradaDA {
        public EntradaDA() {

        }
        public BindingList<Entrada> listarEntradas() {
            BindingList<Entrada> lista = new BindingList<Entrada>();
            String cadena = "server=50.62.209.188;" + "user=fpaz; password=123456; database=LP2;" + "port=3306";
            MySqlConnection conn = new MySqlConnection(cadena);
            conn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "SELECT * FROM ENTRADA";
            comando.Connection = conn;
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read()) {
                Entrada e = new Entrada();
                e.Id = reader.GetInt32(0);
                e.Nombre = reader.GetString(1);
                lista.Add(e);
            }
            conn.Close();
            return lista;
        }
    }
}
