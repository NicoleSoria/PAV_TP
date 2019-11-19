using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TorneoNatacion
{
    class DBHelper
    {
        private string string_conexion;
        private static DBHelper instance = new DBHelper();
        SqlConnection connection;
        SqlTransaction transaction;

        public DBHelper()
        {
            connection = new SqlConnection();
            string_conexion = "Data Source=DESKTOP-TV45VP8;Initial Catalog=TorneoNatacion;Integrated Security=True";
            connection.ConnectionString = string_conexion;
        }

        public static DBHelper getDBHelper()
        {
            if (instance == null)
                instance = new DBHelper();
            return instance;
        }

        public void BegingTransaction()
        {
            if(connection.State == ConnectionState.Open)
            {
                transaction = connection.BeginTransaction();
            }
        }

        public void commit()
        {
            if(transaction != null){
                transaction.Commit();
            }
        }

        public void Rollback()
        {
            if(transaction != null)
            {
                transaction.Rollback();
            }
        }

        public void Open()
        {
            if(connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if(connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }


        public int ejecutarSQLParametros(string strSql, Object [] prs)
        {
            string n_param;

            int afectadas = 0;
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction t = null;

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                //comienzo de transaccion...
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandText = strSql;
                cmd.Transaction = t;
                //afectadas = cmd.ExecuteNonQuery();

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                //IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN
                for (int i = 0; i < prs.Length; i++)
                {
                    if (prs[i] != null)
                    {
                        n_param = "param" + Convert.ToString(i + 1);
                        cmd.Parameters.AddWithValue(n_param, prs[i]);
                    }
                }
                   

                afectadas = cmd.ExecuteNonQuery();
               
                //Commit de transacción...
                t.Commit();
            }
            catch (Exception ex)
            {
                if (t != null)
                {
                    t.Rollback();
                    afectadas = 0;
                }
                throw ex;
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return afectadas;
        }

        // Resumen:
        //     Se utiliza para sentencias SQL del tipo “Select”. Recibe por valor una sentencia sql como string
        // Devuelve:
        //      un objeto de tipo DataTable con el resultado de la consulta
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.

        public DataTable ConsultaSQL(string strSql)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }

        // Resumen:
        //      Se utiliza para sentencias SQL del tipo “Select” con parámetros recibidos desde la interfaz
        //      La función recibe por valor una sentencia sql como string y un arreglo de objetos como parámetros
        // Devuelve:
        //      un objeto de tipo DataTable con el resultado de la consulta
        // Excepciones:
        //      System.Data.SqlClient.SqlException:
        //          El error de conexión se produce:
        //              a) durante la apertura de la conexión
        //              b) durante la ejecución del comando.

        public DataTable ConsultarSQLConParametros(string sqlStr, Object[] prs)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            string n_param;
            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sqlStr;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                //IMPORTANTE: cada parametro deberá llamarse: param1, param2,.., paramN
                for (int i = 0; i < prs.Length; i++)
                    if (prs[i] != null)
                    {
                        n_param = "param" + Convert.ToString(i + 1);
                        cmd.Parameters.AddWithValue(n_param, prs[i]);
                    }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                CloseConnection(cnn);
            }
        }

        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
                cnn.Dispose();
            }

        }

        public DataTable GenerarReporte(string fecha)
        {
            string strSql = "SELECT Nadadores.nombre AS Nadador, Clubs.nombre AS Club, Profesores.nombre AS Profesor, Especialidades.nombre AS Especialidad " +
                            "FROM Clubs INNER JOIN" +
                         " Nadadores ON Clubs.id_Club = Nadadores.id_Club INNER JOIN " +
                         " Inscripto ON Nadadores.id_Nadador = Inscripto.id_Nadador INNER JOIN " +
                         " NadadorXEspecialidad ON Nadadores.id_Nadador = NadadorXEspecialidad.id_Nadador INNER JOIN " +
                         " Especialidades ON NadadorXEspecialidad.id_Especialidad = Especialidades.id_Especialidad INNER JOIN " +
                         " Profesores ON Nadadores.id_Profesor = Profesores.id_Profesor INNER JOIN " +
                         " Torneo ON Inscripto.id_Torneo = Torneo.id_Torneo" +
                         " WHERE Torneo.fecha = @fecha" +
                         " ORDER BY Nombre Nadador ";



            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = string_conexion;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;
                cmd.Parameters.AddWithValue("@fecha", fecha);
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            finally
            {
                this.CloseConnection(cnn);
            }
        }
    }
}
