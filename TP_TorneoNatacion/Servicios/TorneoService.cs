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
    }
}
