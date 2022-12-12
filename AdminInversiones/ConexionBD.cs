using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInversiones
{
    internal class ConexionBD
    {
        string server, port, user, password;
        public ConexionBD()
        {
            server = "localhost";
            port = "3306";
            user = "root";
            password = "EpicLULZ1";
        }
        public DataTable obtenerSolicitudesDeposito()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port +
                "; user id=" + user + "; password=" + password + "; database=proyecto_anli;";
            
            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "SELECT `depositos`.`idDepositos` AS \"ID Deposito\", `usuarios`.`idUsuarios` AS \"No.Socio\",`usuarios`.`Nombre` AS \"Nombre Socio\",Cantidad AS \"Cantidad\", Fecha  AS \"Fecha Solicitud\" " +
                              "FROM depositos " +
                              "INNER JOIN usuarios " +
                              "ON depositos.idUsuarios = usuarios.idUsuarios " +
                              "WHERE `Estado` = 0;";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            //SE DECLARA LA TABLA DONDE SE VACIAN LOS DATOS QUE REGRESA LA QUERY SQL
            DataTable dataTable = new DataTable();

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();
                //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                MySqlDataReader reader = null;
                //SE EJECUTA EL COMANDO SQL CON LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);
                //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                reader = cmd.ExecuteReader();
                //SE LLENA LA TABLA PARA PODER MOSTRAR LA INFORMACION AL USUARIO
                dataTable.Load(reader);
                return dataTable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable obtenerSolicitudesRetiro()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port +
                "; user id=" + user + "; password=" + password + "; database=proyecto_anli;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "SELECT `retiros`.`idRetiros` AS \"ID Retiro\", `usuarios`.`idUsuarios` AS \"No. Socio\",`usuarios`.`Nombre` AS \"Nombre Socio\", Cantidad AS \"Cantidad\", Fecha AS \"Fecha Solicitud\" " +
                "FROM retiros " +
                "INNER JOIN usuarios " +
                "ON retiros.idUsuarios = usuarios.idUsuarios " +
                "WHERE `Estado` = 0;";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            //SE DECLARA LA TABLA DONDE SE VACIAN LOS DATOS QUE REGRESA LA QUERY SQL
            DataTable dataTable = new DataTable();

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();
                //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                MySqlDataReader reader = null;
                //SE EJECUTA EL COMANDO SQL CON LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);
                //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                reader = cmd.ExecuteReader();
                //SE LLENA LA TABLA PARA PODER MOSTRAR LA INFORMACION AL USUARIO
                dataTable.Load(reader);
                return dataTable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public DataTable obtenerSolicitudesRegistro()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port +
                "; user id=" + user + "; password=" + password + "; database=proyecto_anli;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "SELECT `idsolicitud_usuarios` AS \"ID SOLICITUD\", `idUsuarios` AS \"ID USUARIO\", `nombreUsuario` AS \"NOMBRE USUARIO\", `fechaSolicitud` AS \"FECHA DE ENVIO DE SOLICITUD\" " +
                "FROM solicitud_usuarios " +
                "WHERE `estadoSolicitud` = 0;";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            //SE DECLARA LA TABLA DONDE SE VACIAN LOS DATOS QUE REGRESA LA QUERY SQL
            DataTable dataTable = new DataTable();

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();
                //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                MySqlDataReader reader = null;
                //SE EJECUTA EL COMANDO SQL CON LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);
                //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                reader = cmd.ExecuteReader();
                //SE LLENA LA TABLA PARA PODER MOSTRAR LA INFORMACION AL USUARIO
                dataTable.Load(reader);
                return dataTable;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public void aceptarSolicitudDeposito(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port +"; user id=" + user + "; password=" + password + "; database=proyecto_anli;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE depositos " +
                              "SET estado = 1 " +
                              "WHERE idDepositos = "+id+";";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();
                
                //SE CREA EL OBJETO COMANDO SQL CON EL QUERY Y LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);
                
                //SE EJECUTA EL COMANDO
                cmd.ExecuteNonQuery();
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void aceptarSolicitudRegistro(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE `solicitud_usuarios` " +
                              "SET `estadoSolicitud` = 1 " +
                              "WHERE `idsolicitud_usuarios` = "+id+";";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();

                //SE CREA EL OBJETO COMANDO SQL CON EL QUERY Y LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);

                //SE EJECUTA EL COMANDO
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void rechazarSolicitudDeposito(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE depositos " +
                              "SET estado = 2 " +
                              "WHERE idDepositos = " + id + ";";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();

                //SE CREA EL OBJETO COMANDO SQL CON EL QUERY Y LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);

                //SE EJECUTA EL COMANDO
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void aceptarSolicitudRetiro(int id, string motivo)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE retiros " +
                              "SET estado = 1 , Tipo = \""+ motivo +"\" "+
                              "WHERE idRetiros = "+ id +" ;";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();

                //SE CREA EL OBJETO COMANDO SQL CON EL QUERY Y LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);

                //SE EJECUTA EL COMANDO
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void rechazarSolicitudRetiro(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE retiros " +
                              "SET estado = 2 " +
                              "WHERE idRetiros = "+id+";";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();

                //SE CREA EL OBJETO COMANDO SQL CON EL QUERY Y LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);

                //SE EJECUTA EL COMANDO
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void rechazarSolicitudRegistro(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE `solicitud_usuarios` " +
                              "SET `estadoSolicitud` = 2 " +
                              "WHERE `idsolicitud_usuarios` = " + id + ";";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();

                //SE CREA EL OBJETO COMANDO SQL CON EL QUERY Y LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);

                //SE EJECUTA EL COMANDO
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public MySqlDataReader popularComboSocios()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port +
                "; user id=" + user + "; password=" + password + "; database=proyecto_anli;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "SELECT * FROM USUARIOS;";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();
                //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                MySqlDataReader reader = null;
                //SE EJECUTA EL COMANDO SQL CON LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);
                //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                reader = cmd.ExecuteReader();
                
               return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;    
        }

    }
}
