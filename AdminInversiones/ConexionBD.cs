using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInversiones
{
    internal class ConexionBD
    {
        string server, port, user, password, datos;
        public ConexionBD()
        {
            server = "localhost";
            port = "3306";
            user = "root";
            password = "EpicLULZ1";
            datos = "";
        }

        public void conectar()
        {
            string cadConexion = "server=" + server + "; port=" + port + 
                "; user id=" + user +"; password=" + password+"; database=proyecto_anli;";

            MySqlConnection conexion = new MySqlConnection(cadConexion);

            try
            {
                conexion.Open();
                MySqlDataReader reader = null;
                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES",conexion);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }
                MessageBox.Show(datos);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
