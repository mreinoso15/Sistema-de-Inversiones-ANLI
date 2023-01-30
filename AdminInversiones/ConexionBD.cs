using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminInversiones
{
    internal class ConexionBD
    {
        string server, port, user, password;
        Inversiones inv;
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
                "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";
            
            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "SELECT id_solicitud AS \"ID Deposito\", `usuario`.`id_usuario` AS \"No.Socio\",`usuario`.`nombre_usuario` AS \"Nombre Socio\", cantidad_deposito AS \"Cantidad\", fecha_deposito AS \"Fecha Solicitud\" " +
                "FROM solicitudes_deposito " +
                "INNER JOIN usuario " +
                "ON solicitudes_deposito.id_usuario = usuario.id_usuario " +
                "WHERE `estado_deposito` = 0;";

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
        } //MODIFICADA NUEVA BD
        public DataTable obtenerSolicitudesRetiro()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port +
                "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "SELECT id_solicitud AS \"ID Retiro\", `usuario`.`id_usuario` AS \"No. Socio\",`usuario`.`nombre_usuario` AS \"Nombre Socio\", cantidad_retiro AS \"Cantidad\", fecha_retiro AS \"Fecha Solicitud\" " +
                "FROM solicitudes_retiro " +
                "INNER JOIN usuario " +
                "ON solicitudes_retiro.id_usuario = usuario.id_usuario " +
                "WHERE `estado_retiro` = 0;";

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
        } //MODIFICADA NUEVA BD
        public DataTable obtenerSolicitudesRegistro()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port +
                "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "SELECT `id_solicitud` AS 'ID SOLICITUD',`id_usuario` AS 'ID USUARIO',`nombre_usuario` AS 'NOMBRE USUARIO',`fecha_solicitud` AS 'FECHA DE ENVIO DE SOLICITUD'" +
                "FROM solicitudes_usuario " +
                "WHERE `estado_solicitud` = 0;";

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
        } //MODIFICADA NUEVA BD 
        public DataTable obtenerClientesTasas()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port +
                "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "SELECT u.id_usuario AS 'ID Socio', u.nombre_usuario AS 'Nombre Usuario',ti.tipo_tasa AS 'Tipo Tasa', ti.tasa AS 'Tasa Actual'" +
                              "FROM usuario AS u " +
                              "INNER JOIN tasas_interes AS ti " +
                              "ON u.id_tasas = ti.id_tasas;";

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
        public void aceptarSolicitudRegistro(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE `solicitudes_usuario` " +
                              "SET `estado_solicitud` = 1 " +
                              "WHERE `id_solicitud` = " + id + ";";

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
        } //MODIFICADA NUEVA BD
        public void aceptarSolicitudDeposito(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port +"; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE `solicitudes_deposito` " +
                              "SET `estado_deposito` = 1 " +
                              "WHERE `id_solicitud` = " + id + ";";

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
        } //MODIFICADA NUEVA BD
        public void aceptarSolicitudRetiro(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE `solicitudes_retiro` " +
                              "SET `estado_retiro` = 1 " +
                              "WHERE `id_solicitud` = " + id + " ;";

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
        } //MODIFICADA NUEVA BD
        public void insertarTasaInteres(double tasa,string tipo, string descripcion)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "INSERT INTO `proyecto_anli_prueba`.`tasas_interes`(`tasa`,`tipo_tasa`,`descripcion_tasa`)" +
                              $"VALUES({tasa},'{tipo}','{descripcion}');";

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
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE `solicitudes_deposito` " +
                              "SET `estado_deposito` = 2 " +
                              "WHERE `id_solicitud` = " + id + ";";

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
        } //MODIFICADA NUEVA BD
        public void rechazarSolicitudRetiro(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE `solicitudes_retiro` " +
                              "SET `estado_retiro` = 2 " +
                              "WHERE `id_solicitud` = " + id + " ;";

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
        } //MODIFICADAD NUEVA BD
        public void rechazarSolicitudRegistro(int id)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

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
        } // MODIFICADO NUEVO BD
        public void actualizarCantidadAhorro(int id, double cantidad)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE usuario " +
                              "SET cantidad_ahorro = cantidad_ahorro +"+ cantidad +
                              " WHERE id_usuario = "+id+" ;";

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
        public void actualizarInteresGenerado(int id, double cantidad)
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "UPDATE usuario " +
                              "SET cantidad_inversion = cantidad_inversion +" + cantidad +
                              " WHERE id_usuario = " + id + " ;";

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
        public void actualizarTasaCliente(int id,int tasa)
        {
            using (MySqlConnection conn = new MySqlConnection("server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;"))
            {
                try
                {
                    string query = $"UPDATE usuario SET id_tasas = {tasa} WHERE id_usuario = {id};";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();                    
                    
                }
                catch (MySqlException ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show(ex.ToString());
                    
                }
            }
        }
        public List<Inversiones> obtenerInversiones(List<Inversiones> inversion)
        {
            inv = new Inversiones();
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            string cadConexion = "server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;";

            //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
            string cadQuery = "SELECT  sd.id_usuario AS 'NoSocio', d.id_deposito AS 'solicitudInv', u.nombre_usuario AS 'Socio', DATE(d.fecha_aprobacion) AS 'Fecha', d.cantidad_deposito AS 'Cantidad', d.tasa_inversion AS 'Tasa' " +
                              "FROM depositos AS d " +
                              "INNER JOIN solicitudes_deposito AS sd ON d.id_solicitud = sd.id_solicitud " +
                              "INNER JOIN usuario as u ON sd.id_usuario = u.id_usuario;";

            //SE CREA EL OBJETO DE LA CONEXION CON LA BASE DE DATOS SQL
            MySqlConnection conexion = new MySqlConnection(cadConexion);

            try
            {
                //SE ABRE LA CONEXION CON LA BASE DE DATOS
                conexion.Open();

                //SE CREA EL OBJETO COMANDO SQL CON EL QUERY Y LA CONEXION NECESARIA
                MySqlCommand cmd = new MySqlCommand(cadQuery, conexion);

                //SE EJECUTA EL COMANDO
                var dataReader = cmd.ExecuteReader();

                //SE LLENA LA LISTA DE INVERSIONES CON LOS DATOS QUE RETORNA EL QUERY SQL 
                inversion = inv.llenarLista<Inversiones>(dataReader);

                return inversion;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public ComboBox obtenerTasasInversiones(ComboBox cmbTasas)
        {
            using (MySqlConnection conn = new MySqlConnection("server=" + server + "; port=" + port + "; user id=" + user + "; password=" + password + "; database=proyecto_anli_prueba;"))
            {
                try
                {
                    string query = "SELECT `id_tasas`, `tipo_tasa` FROM `proyecto_anli_prueba`.`tasas_interes`;";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Tasas");
                    cmbTasas.DisplayMember = "tipo_tasa";
                    cmbTasas.ValueMember = "id_tasas";
                    cmbTasas.DataSource = ds.Tables["Tasas"];
                    return cmbTasas;
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                    return null;
                }
            }
        }

    }
}
