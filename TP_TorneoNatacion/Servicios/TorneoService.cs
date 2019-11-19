using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_TorneoNatacion.Modelos;

namespace TP_TorneoNatacion.Servicios
{
    class TorneoService
    {

        public List<TorneoModel> buscarTorneo(DateTime fecha)
        {
            List<TorneoModel> listaTorneo = new List<TorneoModel>();
            var consulta = "SELECT * FROM Torneo WHERE fecha = @param1";

            var resultado = DBHelper.getDBHelper().ConsultarSQLConParametros(consulta, new object[] { fecha });

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    TorneoModel encontradoTorneo = new TorneoModel();

                    encontradoTorneo.id_Torneo = Convert.ToInt32(row[0]);
                    encontradoTorneo.fecha = Convert.ToDateTime(row[1]);

                    listaTorneo.Add(encontradoTorneo);

                }
            }
            return listaTorneo;
        }

        public bool guardarInscripcion(InscripcionModel inscripcion)
        {

            DBHelper dbHelper = new DBHelper();

            try
            {
                dbHelper.Open();

                dbHelper.BegingTransaction();

                guardarNadadorXEspecialidad(inscripcion);

                string consulta = "INSERT INTO Inscripto (fecha, id_Torneo, id_Nadador)" +
                                    "  VALUES (@param1, @param2, @param3)";

                var resultado = DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] {
                                                                                    inscripcion.fecha,
                                                                                    inscripcion.torneo,
                                                                                    inscripcion.nadador });
                if(resultado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                dbHelper.Rollback();
                return false;
            }
            finally
            {
                dbHelper.Close();
            }
           
        }


        public void guardarNadadorXEspecialidad(InscripcionModel inscripcion)
        {

            foreach(var especialidad in inscripcion.especialidad)
            {
                string consulta = "INSERT INTO NadadorXEspecialidad (id_Especialidad, id_Nadador) " +
                                    " VALUES (@param1, @param2)";

                DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] { especialidad.id_Especialidad,
                                                                                      inscripcion.nadador });

            }

        }

        public DataTable obtenerParticipantes()
        {
            string consulta = "SELECT t.fecha Fecha, n.Nombre Nombre, e.Nombre Especialidad, i.posicion, i.tiempo" +
                              " FROM Torneo as t, Inscripto as i, Nadadores as n, Especialidades as e, NadadorXEspecialidad as en " +
                              " WHERE t.id_Torneo = i.id_Torneo AND n.id_Nadador = i.id_Nadador " +
                              "  AND en.id_Nadador = n.id_Nadador AND e.id_Especialidad = en.id_Especialidad";

            var resultado = DBHelper.getDBHelper().ConsultaSQL(consulta);

            return resultado;
        }

        public bool registrarResultado(int id_Torneo, int id_Nadador, int posicion, decimal tiempo)
        {
            DBHelper dbHelper = new DBHelper();

            try
            {
                dbHelper.Open();

                dbHelper.BegingTransaction();

                string consulta = " UPDATE Inscripto SET " +
                               " posicion = @param1 ," +
                               " tiempo = @param2 " +
                               " WHERE id_Torneo = @param3 AND id_Nadador = @param4 ";

                var resultado = DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] { posicion, tiempo, id_Torneo, id_Nadador });

                if (resultado != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                dbHelper.Rollback();
                return false;
            }
            finally
            {
                dbHelper.Close();
            }

        }
    }
}
