using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_TorneoNatacion.Modelos;

namespace TP_TorneoNatacion.Servicios
{
    class ProfesorService
    {

        public List<ProfesorModel> buscarProfesor(string nombre)
        {
            List<ProfesorModel> listaProfesores = new List<ProfesorModel>();
            var consulta = "SELECT * FROM Profesores WHERE nombre like @param1 + '%' ";

            var resultado = DBHelper.getDBHelper().ConsultarSQLConParametros(consulta, new object[] { nombre });

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    ProfesorModel encontradoProfesor = new ProfesorModel();

                    encontradoProfesor.id_Nadador = Convert.ToInt32(row[0]);
                    encontradoProfesor.nombre = row[1].ToString();

                    listaProfesores.Add(encontradoProfesor);
                }
            }

            return listaProfesores;

        }
    }
}
