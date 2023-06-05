using iText.Commons.Utils;
using iText.StyledXmlParser.Jsoup.Select;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Threading.Tasks;
using System.Windows.Forms;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AdminInversiones
{
    internal class ConexionBD
    {
        private MySqlConnection conn1, conn2;
        public ConexionBD()
        {
            conn2 = new MySqlConnection("server=" + "localhost" + "; " +
                                        "port=" + "3306" + "; " +
                                        "user id=" + "root" + "; " +
                                        "password=" + "EpicLULZ1" + "; " +
                                        "database=proyecto_anli_prueba;");

            conn1 = new MySqlConnection("server=" + "201.120.42.39" + "; " +
                                        "port=" + "3306" + "; " +
                                        "user id=" + "root" + "; " +
                                        "password=" + "Conque2" + "; " +
                                        "database=alfa_newlife;");
        }
        public DataTable obtenerSolicitudesDeposito()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "SELECT id_solicitud AS \"ID Solicitud\",usuario.`id_usuario` AS \"No.Socio\",`usuario`.`nombre_usuario` AS \"Nombre Socio\", cantidad_deposito AS \"Cantidad\", fecha_deposito AS \"Fecha Solicitud\", url_foto AS \"Foto URL\"" +
                               "FROM solicitudes_deposito " +
                               "INNER JOIN usuario ON solicitudes_deposito.id_usuario = usuario.id_usuario " +
                               "WHERE `estado_deposito` = 0 " +
                               "ORDER BY id_solicitud ASC;";
                //SE DECLARA LA TABLA DONDE SE VACIAN LOS DATOS QUE REGRESA LA QUERY SQL
                DataTable dataTable = new DataTable();

                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                    MySqlDataReader reader = null;
                    //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
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
        }   //MODIFICADO2
        public DataTable obtenerSolicitudesRetiro()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "SELECT id_solicitud AS \"ID Retiro\", `usuario`.`id_usuario` AS \"No. Socio\",`usuario`.`nombre_usuario` AS \"Nombre Socio\", tr.nombre AS \"Concepto Retiro\", fecha_retiro AS \"Fecha Solicitud\" " +
                                "FROM solicitudes_retiro INNER JOIN  tipo_retiro AS tr ON solicitudes_retiro.tipo_retiro = tr.id " +
                                "INNER JOIN usuario " +
                                "ON solicitudes_retiro.id_usuario = usuario.id_usuario " +
                                "WHERE `estado_retiro` = 0;";
                //SE DECLARA LA TABLA DONDE SE VACIAN LOS DATOS QUE REGRESA LA QUERY SQL
                DataTable dataTable = new DataTable();

                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                    MySqlDataReader reader = null;
                    //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
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
        }  //MODIFICADO2
        public DataTable obtenerSolicitudesRegistro()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "SELECT `id_solicitud` AS 'ID SOLICITUD',`id_usuario` AS 'ID USUARIO',`nombre_usuario` AS 'NOMBRE USUARIO',`fecha_solicitud` AS 'FECHA DE ENVIO DE SOLICITUD'" +
                               "FROM solicitudes_usuario " +
                               "WHERE `estado_solicitud` = 0;";
                //SE DECLARA LA TABLA DONDE SE VACIAN LOS DATOS QUE REGRESA LA QUERY SQL
                DataTable dataTable = new DataTable();

                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                    MySqlDataReader reader = null;
                    //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
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
        }   //MODIFICADO2
        public DataTable obtenerHistorialTasas()
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "SELECT nombre_tasa AS Tasa," +
                                       "cantidad_tasa AS Cantidad," +
                                       "fecha_valida AS 'Fecha' " +
                                       "FROM historial_tasas_interes ORDER BY fecha_valida ASC;";
                //SE DECLARA LA TABLA DONDE SE VACIAN LOS DATOS QUE REGRESA LA QUERY SQL
                DataTable dataTable = new DataTable();

                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                    MySqlDataReader reader = null;
                    //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
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
        }  //MODIFICADO2
        public DataTable obtenerDepositosACalcular()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "SELECT  d.id_usuario AS '# de Socio'," +
                                        "d.id_deposito AS '# de Deposito'," +
                                        "u.nombre_usuario AS 'Nombre Socio'," +
                                        "DATE(d.fecha_aprobacion) AS 'Fecha de Aprobacion'," +
                                        "d.cantidad_deposito AS 'Cantidad de Deposito'," +
                                        "d.tasa_inversion AS 'Tasa de Deposito' " +
                               "FROM depositos AS d " +
                               "INNER JOIN usuario as u ON d.id_usuario = u.id_usuario;";
                //SE DECLARA LA TABLA DONDE SE VACIAN LOS DATOS QUE REGRESA LA QUERY SQL
                DataTable dataTable = new DataTable();

                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                    MySqlDataReader reader = null;
                    //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
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
        }   //POR MODIFICAR, PUEDE QUE NO SEA NECESARIO
        public DataTable obtenerUsuarios()
        {
            //SE DECLARA A QUE BASE DE DATOS SE CONECTARA
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "SELECT id_usuario AS 'No. Socio', " +
                                       "nombre_usuario AS 'Nombre de usuario', " +
                                       "fecha_registro AS 'Fecha de Registro', " +
                                       "cantidad_ahorro + cantidad_inversion AS 'Total', " +
                                       "IF(estatus_usuario = 1,\"ACTIVO\",\"BAJA\") AS 'ESTATUS'" +
                               "from usuario ORDER BY estatus_usuario ASC;;";
                //SE DECLARA LA TABLA DONDE SE VACIAN LOS DATOS QUE REGRESA LA QUERY SQL
                DataTable dataTable = new DataTable();

                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE DECLARA EL LECTOR DE DATOS DE LA BASE DE DATOS SQL
                    MySqlDataReader reader = null;
                    //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
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
        }
        public string obtenerNombre(int id)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = $"SELECT nombre_usuario FROM usuario WHERE id_usuario = {id};";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    //SE EJECUTA EL COMANDO
                    var nombre = cmd.ExecuteScalar().ToString();
                    //SE LLENA LA TABLA PARA PODER MOSTRAR LA INFORMACION AL USUARIO
                    return nombre;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return "";

            }
        }
        public void bajaUsuarios(int idUsuario)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "UPDATE `usuario` " +
                               "SET `estatus_usuario` = 2 " +
                               "WHERE `id_usuario` = " + idUsuario + ";";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();
                    //SE LLENA LA TABLA PARA PODER MOSTRAR LA INFORMACION AL USUARIO

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        public void aceptarSolicitudRegistro(int id)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "UPDATE `solicitudes_usuario` " +
                              "SET `estado_solicitud` = 1 " +
                              "WHERE `id_solicitud` = " + id + ";";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE LE ASIGNA LA INFORMACION QUE REGRESO EL COMANDO SQL
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();
                    //SE LLENA LA TABLA PARA PODER MOSTRAR LA INFORMACION AL USUARIO

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        } //MODIFICADO2
        public double obtenerImpuestos(int id)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT cantidad " +
                                    "FROM impuestos_usuario " +
                                    "INNER JOIN usuario ON impuestos_usuario.id_impuesto = usuario.id_impuesto " +
                                    $"WHERE  id_usuario = {id};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var obj = cmd.ExecuteScalar();
                    //SE OBTIENE EL TOTAL
                    double total = Convert.ToDouble(obj);
                    return total;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "OBTENER IMPUESTOS");
                }
                return 0;
            }//USING  
        }
        public void insertarImpuestosRetiro(int id, double cantidadPagar)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "INSERT INTO `impuestos_intereses`(`id_usuario`,`cantidad_pagar`,`fecha_impuesto`,`estado_pagado`)" +
                                   $"VALUES({id}, {cantidadPagar}, DATE(NOW()), 0);";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "insertarImpuestosUsuarios");
                }
            }//USING  
        }
        public void aceptarSolicitudDeposito(int id, string folio)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "UPDATE `solicitudes_deposito` " +
                               $"SET `estado_deposito` = 1,no_folio = '{folio}'" +
                               "WHERE `id_solicitud` = " + id + ";";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        } //MODIFICADO2
        public void aceptarSolicitudRetiro(int id, double cantidad)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "UPDATE `solicitudes_retiro` " +
                              $"SET cantidad_retiro = {cantidad}, `estado_retiro` = 1 " +
                              $"WHERE `id_solicitud` = {id} ;";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "aceptarSolicitudRetiro");
                }

            }
        } //MODIFICADO2
        public void insertarTasaInteres(double tasa, string tipo, string descripcion)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "INSERT INTO `tasas_interes`(`tasa`,`tipo_tasa`,`descripcion_tasa`)" +
                              $"VALUES({tasa},'{tipo}','{descripcion}');";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }//USING
        } //MODIFICADO2
        public void rechazarSolicitudDeposito(int id)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "UPDATE `solicitudes_deposito` " +
                              "SET `estado_deposito` = 2 " +
                              "WHERE `id_solicitud` = " + id + ";";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }//USING
        } //MODIFICADO2
        public void rechazarSolicitudRetiro(int id)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "UPDATE `solicitudes_retiro` " +
                              "SET `estado_retiro` = 2 " +
                              "WHERE `id_solicitud` = " + id + " ;";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//USING
        } //MODIFICADO2
        public void rechazarSolicitudRegistro(int id)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "UPDATE `solicitudes_usuario` " +
                               "SET `estado_solicitud` = 2  " +
                               $"WHERE `id_solicitud` = {id};";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//USING
        } //MODIFICADO2
        public void actualizarInteresGenerado(int id, double cantidad)
        {
            using (conn1)
            {
                //SE DECLARA EL COMANDO SQL QUE SE DESEA EJECUTAR 
                string query = "UPDATE usuario " +
                              "SET cantidad_ahorro = cantidad_ahorro +" + cantidad +
                              "WHERE id_usuario = " + id + " ;";
                try
                {
                    //SE ABRE LA CONEXION CON LA BASE DE DATOS
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "ACTUALIZAR INTERES");
                }
            }//USING
        }
        public void actualizarTasaCliente(int id, int tasa)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = $"UPDATE usuario SET id_tasas = {tasa} WHERE id_usuario = {id};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }//USING
        } //MODIFICADO2
        public void actualizarEstadoInteres(int id)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = $"UPDATE depositos SET estado_interes = 1 WHERE id_deposito = {id};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ACTUALIZAR ESTADO INTERES");
                }
            }//USING
        }
        public void actualizarTasa(int id, double value)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = $"UPDATE tasas_interes SET tasa = {value} WHERE id_tasas = {id};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ACTUALIZAR TASA INTERES");
                }
            }//USING
        }
        public void actualizarImpuestos(double value)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = $"UPDATE impuestos_usuario SET cantidad = {value} WHERE id_impuesto = 1;";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ACTUALIZAR TASA INTERES");
                }
            }//USING
        }
        public double obtenerTotal(int id)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = $"SELECT cantidad_ahorro + cantidad_inversion FROM usuario WHERE id_usuario = {id};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var obj = cmd.ExecuteScalar();
                    //SE VERIFICA QUE EXISTA EL NOMBRE DE USUARIO (El valor que regresa el query es 0 si no existe, 1 si existe)
                    double total = Convert.ToDouble(obj);
                    return total;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "OBTENER TOTAL");
                }
                return 0;
            }//USING        

        }
        public double calcularTotalImpuestos(string fechaCalcular)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = $"SELECT SUM(cantidad_pagar) FROM impuestos_intereses WHERE MONTH(fecha_impuesto) = MONTH('{fechaCalcular}');";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var obj = cmd.ExecuteScalar();
                    //SE VERIFICA QUE EXISTA EL NOMBRE DE USUARIO (El valor que regresa el query es 0 si no existe, 1 si existe)
                    double total = Convert.ToDouble(obj);
                    return Math.Round(total, 2);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return 0;
            }//USING  
        }
        public void nuevoTotal(int idUsuario)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = $"UPDATE usuario SET cantidad_inversion  = ROUND(cantidad_inversion + cantidad_ahorro,2) WHERE id_usuario = {idUsuario};";
                    string query2 = $"UPDATE usuario SET cantidad_ahorro  = 0 WHERE id_usuario = {idUsuario};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    MySqlCommand cmd2 = new MySqlCommand(query2, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }//USING
        }
        public bool verificarLogin(string username, string password)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = $"SELECT EXISTS(SELECT * from users WHERE NOMBRE = BINARY '{username}' AND `PASSWORD` = BINARY '{password}');";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var obj = cmd.ExecuteScalar();
                    //SE VERIFICA QUE EXISTA EL NOMBRE DE USUARIO (El valor que regresa el query es 0 si no existe, 1 si existe)
                    if (Convert.ToInt32(obj) > 0)
                    {
                        return true;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }//USING        
            return false;
        }
        public void insertarNuevosDepositosTotales(int id, double total)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = "INSERT INTO `solicitudes_deposito`(`id_usuario`,`cantidad_deposito`,`fecha_deposito`,`estado_deposito`)" +
                                   $"VALUES({id},{total},DATE(NOW()),3);";

                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }//USING
        }
        public void borrarDepositosCalculados()
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = "DELETE FROM depositos WHERE cantidad_deposito = 0 OR estado_interes = 1;";

                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }//USING
        }
        public List<Inversiones> obtenerInversiones(List<Inversiones> inversion)
        {

            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT  sd.id_usuario AS 'NoSocio', " +
                                            "d.id_deposito AS 'solicitudInv', " +
                                            "u.nombre_usuario AS 'Socio', " +
                                            "DATE(d.fecha_aprobacion) AS 'Fecha', " +
                                            "d.cantidad_deposito AS 'Cantidad'," +
                                            "d.tasa_inversion AS 'Tasa' " +
                                   "FROM depositos AS d " +
                                   "INNER JOIN solicitudes_deposito AS sd ON d.id_solicitud = sd.id_solicitud " +
                                   "INNER JOIN usuario as u ON sd.id_usuario = u.id_usuario " +
                                   "WHERE d.estado_interes = 0;";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var dataReader = cmd.ExecuteReader();
                    //SE LLENA LA LISTA DE INVERSIONES CON LOS DATOS QUE RETORNA EL QUERY SQL 
                    inversion = llenarLista<Inversiones>(dataReader);
                    return inversion;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "OBTENER INVERSIONES");
                    return null;
                }
            }//USING
        } //MODIFICADO2
        //METODO NECESARIO PARA REPORTE DE UN SOLO USUARIO
        public List<DepositosCalculados> obtenerDataReportes(List<DepositosCalculados> reporte, string fechaIni, string fechaFin, int userID)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT u.nombre_usuario AS 'Nombre', " +
                                            "sd.id_usuario AS 'IdUsuario', " +
                                            "d.id_deposito AS 'IdDeposito', " +
                                            "d.cantidad_deposito AS 'Cantidad'," +
                                            "d.fecha_aprobacion AS 'FechaAprob'," +
                                            "d.tasa_inversion AS 'Tasa' " +
                                          "FROM depositos_calculados AS d " +
                                          "INNER JOIN solicitudes_deposito AS sd ON d.id_solicitud = sd.id_solicitud " +
                                          "INNER JOIN usuario AS u ON sd.id_usuario = u.id_usuario " +
                                          $"WHERE d.fecha_aprobacion >= '{fechaIni}' AND d.fecha_aprobacion <= '{fechaFin}' AND sd.id_usuario = {userID} AND d.tipo_deposito != 3 ORDER BY d.fecha_aprobacion DESC;";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var dataReader = cmd.ExecuteReader();
                    //SE LLENA LA LISTA CON LOS DATOS NECESARIOS PARA GENERAR LOS REPORTES 
                    reporte = llenarLista<DepositosCalculados>(dataReader);
                    return reporte;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }//USING
        }
        //METODO REPORTE GENERAL
        public List<DepositosCalculados> obtenerDataReportes(List<DepositosCalculados> reporte, string fechaIni, string fechaFin)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT u.nombre_usuario AS 'Nombre', " +
                                            "sd.id_usuario AS 'IdUsuario', " +
                                            "d.id_deposito AS 'IdDeposito', " +
                                            "d.cantidad_deposito AS 'Cantidad'," +
                                            "d.fecha_aprobacion AS 'FechaAprob'," +
                                            "d.tasa_inversion AS 'Tasa' " +
                                          "FROM depositos_calculados AS d " +
                                          "INNER JOIN solicitudes_deposito AS sd ON d.id_solicitud = sd.id_solicitud " +
                                          "INNER JOIN usuario AS u ON sd.id_usuario = u.id_usuario " +
                                          $"WHERE d.fecha_aprobacion >= '{fechaIni}' AND d.fecha_aprobacion <= '{fechaFin}' AND d.tipo_deposito != 3 ORDER BY d.fecha_aprobacion DESC;";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var dataReader = cmd.ExecuteReader();
                    //SE LLENA LA LISTA CON LOS DATOS NECESARIOS PARA GENERAR LOS REPORTES 
                    reporte = llenarLista<DepositosCalculados>(dataReader);
                    return reporte;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }//USING
        }
        //METODO NECESARIO PARA REPORTE DE UN SOLO USUARIO
        public List<Depositos> obtenerDataReportes(List<Depositos> reporte, string fechaIni, string fechaFin, int userID)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT u.nombre_usuario AS 'Nombre', " +
                                          "sd.id_usuario AS 'IdUsuario', " +
                                          "d.id_deposito AS 'IdDeposito', " +
                                          "d.cantidad_deposito AS 'Cantidad', " +
                                          "d.fecha_aprobacion AS 'FechaAprob', " +
                                          "d.tasa_inversion AS 'Tasa' " +
                                   "FROM depositos AS d " +
                                   "INNER JOIN solicitudes_deposito AS sd ON d.id_solicitud = sd.id_solicitud " +
                                   "INNER JOIN usuario AS u ON sd.id_usuario = u.id_usuario " +
                                   $"WHERE fecha_aprobacion >= '{fechaIni}' AND fecha_aprobacion <= '{fechaFin}' " +
                                   $"AND sd.id_usuario = {userID} " +
                                   $"AND d.tipo_deposito != 3 ORDER BY d.fecha_aprobacion DESC;";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var dataReader = cmd.ExecuteReader();
                    //SE LLENA LA LISTA CON LOS DATOS NECESARIOS PARA GENERAR LOS REPORTES 
                    reporte = llenarLista<Depositos>(dataReader);
                    return reporte;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }//USING
        }
        //METODO REPORTE GENERAL
        public List<Depositos> obtenerDataReportes(List<Depositos> reporte, string fechaIni, string fechaFin)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT u.nombre_usuario AS 'Nombre', " +
                                          "sd.id_usuario AS 'IdUsuario', " +
                                          "d.id_deposito AS 'IdDeposito', " +
                                          "d.cantidad_deposito AS 'Cantidad', " +
                                          "d.fecha_aprobacion AS 'FechaAprob', " +
                                          "d.tasa_inversion AS 'Tasa' " +
                                   "FROM depositos AS d " +
                                   "INNER JOIN solicitudes_deposito AS sd ON d.id_solicitud = sd.id_solicitud " +
                                   "INNER JOIN usuario AS u ON sd.id_usuario = u.id_usuario " +
                                   $"WHERE fecha_aprobacion >= '{fechaIni}' AND fecha_aprobacion <= '{fechaFin}' " +
                                   $"AND d.tipo_deposito != 3 ORDER BY d.fecha_aprobacion DESC;";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var dataReader = cmd.ExecuteReader();
                    //SE LLENA LA LISTA CON LOS DATOS NECESARIOS PARA GENERAR LOS REPORTES 
                    reporte = llenarLista<Depositos>(dataReader);
                    return reporte;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }//USING
        }
        //METODO NECESARIO PARA REPORTE DE UN SOLO USUARIO
        public List<Retiros> obtenerDataReportes(List<Retiros> reporte, string fechaIni, string fechaFin, int userID)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT u.nombre_usuario AS 'Nombre'," +
                                           "sr.id_usuario AS IdUsuario, " +
                                          "r.id_retiro AS IdRetiro, " +
                                          "r.cantidad_retiro AS Cantidad, " +
                                          "r.fecha_aprobacion AS FechaAprob " +
                                 "FROM retiros AS r " +
                                 "INNER JOIN solicitudes_retiro AS sr ON r.id_solicitud = sr.id_solicitud " +
                                 "INNER JOIN usuario AS u ON sr.id_usuario = u.id_usuario " +
                                 $"WHERE fecha_aprobacion >= '{fechaIni}' AND fecha_aprobacion <= '{fechaFin}' " +
                                 $"AND sr.id_usuario = {userID};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var dataReader = cmd.ExecuteReader();
                    //SE LLENA LA LISTA CON LOS DATOS NECESARIOS PARA GENERAR LOS REPORTES 
                    reporte = llenarLista<Retiros>(dataReader);
                    return reporte;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }//USING
        }
        //METODO REPORTE GENERAL       
        public List<Retiros> obtenerDataReportes(List<Retiros> reporte, string fechaIni, string fechaFin)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT u.nombre_usuario AS 'Nombre'," +
                                           "sr.id_usuario AS IdUsuario, " +
                                          "r.id_retiro AS IdRetiro, " +
                                          "r.cantidad_retiro AS Cantidad, " +
                                          "r.fecha_aprobacion AS FechaAprob " +
                                 "FROM retiros AS r " +
                                 "INNER JOIN solicitudes_retiro AS sr ON r.id_solicitud = sr.id_solicitud " +
                                 "INNER JOIN usuario AS u ON sr.id_usuario = u.id_usuario " +
                                 $"WHERE fecha_aprobacion >= '{fechaIni}' AND fecha_aprobacion <= '{fechaFin}';";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var dataReader = cmd.ExecuteReader();
                    //SE LLENA LA LISTA CON LOS DATOS NECESARIOS PARA GENERAR LOS REPORTES 
                    reporte = llenarLista<Retiros>(dataReader);
                    return reporte;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }//USING
        }
        public List<Impuestos> obtenerTablaImpuestos(List<Impuestos> impuesto, string fechaImpuestos)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT i.id_usuario AS 'Id'," +
                                           "u.nombre_usuario AS 'Nombre'," +
                                           "i.fecha_impuesto AS 'Fecha'," +
                                           "i.cantidad_pagar AS 'Cantidad' " +
                                   "FROM impuestos_intereses AS i " +
                                   "INNER JOIN usuario AS u ON i.id_usuario = u.id_usuario " +
                                   $"WHERE MONTH(fecha_impuesto) = MONTH('{fechaImpuestos}') AND " +
                                   $"YEAR(fecha_impuesto) = YEAR('{fechaImpuestos}')  ORDER BY i.id_usuario ASC;";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var dataReader = cmd.ExecuteReader();
                    //SE LLENA LA LISTA CON LOS DATOS NECESARIOS PARA GENERAR LOS REPORTES 
                    impuesto = llenarLista<Impuestos>(dataReader);
                    return impuesto;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }//USING

        }
        public List<Impuestos> obtenerTablaImpuestos(List<Impuestos> impuesto, int id, string fechaIni,string fechaFin)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR
                    string query = "SELECT i.id_usuario AS 'Id'," +
                                           "u.nombre_usuario AS 'Nombre'," +
                                           "i.fecha_impuesto AS 'Fecha'," +
                                           "i.cantidad_pagar AS 'Cantidad' " +
                                   "FROM impuestos_intereses AS i " +
                                   "INNER JOIN usuario AS u ON i.id_usuario = u.id_usuario " +
                                   $"WHERE fecha_impuesto >= '{fechaIni}' AND fecha_impuesto <= '{fechaFin}' AND i.id_usuario = {id};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    var dataReader = cmd.ExecuteReader();
                    //SE LLENA LA LISTA CON LOS DATOS NECESARIOS PARA GENERAR LOS REPORTES 
                    impuesto = llenarLista<Impuestos>(dataReader);
                    return impuesto;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }//USING

        }

        public ComboBox obtenerTasasInversiones(ComboBox cmbTasas)
        {
            using (conn1)
            {
                try
                {
                    string query = "SELECT `id_tasas`, `tipo_tasa` FROM tasas_interes;";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn1);
                    conn1.Open();
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
                    MessageBox.Show("Error occured!" + ex.Message);
                    return null;
                }
            }
        } //MODIFICADO2
        public ComboBox obtenerNoSocio(ComboBox cmbSocios)
        {
            using (conn1)
            {
                try
                {
                    string query = "SELECT `id_usuario` FROM usuario WHERE estatus_usuario = 1 ORDER BY id_usuario ASC;";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn1);
                    conn1.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "NoUsuario");
                    cmbSocios.DisplayMember = "id_usuario";
                    cmbSocios.ValueMember = "id_usuario";
                    cmbSocios.DataSource = ds.Tables["NoUsuario"];
                    return cmbSocios;
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!" + ex.Message);
                    return null;
                }
            }
        }
        public List<T> llenarLista<T>(IDataReader dataReader)
        {
            List<T> lista = new List<T>();
            while (dataReader.Read())
            {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties())
                {
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(dataReader[prop.Name].ToString(), propType));
                }
                lista.Add(obj);
            }
            return lista;
        }
        internal void borrarImpuestosNulos()
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = "DELETE FROM impuestos_intereses WHERE cantidad_pagar = 0;";

                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }//USING
        }
        internal void eliminarTasa(int id)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = $"DELETE FROM tasas_interes WHERE id_tasas = {id};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString(), "ACTUALIZAR TASA INTERES");
                }
            }//USING
        }

        internal void actualizarDepositos(int idUsuario)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = $"UPDATE depositos AS d " +
                                   $"INNER JOIN solicitudes_deposito AS sd ON d.id_solicitud = sd.id_solicitud " +
                                   $"SET d.estado_interes = 1, d.tipo_deposito = 4 WHERE sd.id_usuario = {idUsuario} AND d.estado_interes = 0;";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }//USING
        }

        internal void generarRetiro(int idUsuario, double total)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = $"INSERT INTO solicitudes_retiro(id_usuario,tipo_retiro,fecha_retiro,cantidad_retiro,estado_retiro) " +
                                   $"VALUES({idUsuario},6,DATE(NOW()),{total},1);";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        internal void actualizarTotal(int idUsuario)
        {
            using (conn1)
            {
                try
                {
                    //QUERY QUE SE VA A EJECUTAR    
                    string query = $"UPDATE usuario SET cantidad_ahorro = 0, cantidad_inversion = 0 WHERE id_usuario = {idUsuario};";
                    //SE PREPARA EL COMANDO SQL CON EL QUERY Y LA CONEXION
                    MySqlCommand cmd = new MySqlCommand(query, conn1);
                    conn1.Open();
                    //SE EJECUTA EL COMANDO
                    cmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }//USING
        }
    }
}
