using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_TorneoNatacion.Modelos;

namespace TP_TorneoNatacion.Servicios
{
    class EspecialidadService
    {
        public EspecialidadModel buscarEspecialidad(string nombre)
        {
            EspecialidadModel listaEspecialidades = new EspecialidadModel();
            var consulta = "SELECT * FROM Especialidades WHERE nombre like @param1 + '%' ";

            var resultado = DBHelper.getDBHelper().ConsultarSQLConParametros(consulta, new object[] { nombre });

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    EspecialidadModel encontraEspecialidad = new EspecialidadModel();

                    encontraEspecialidad.id_Especialidad = Convert.ToInt32(row[0]);
                    encontraEspecialidad.nombre = row[1].ToString();

                    listaEspecialidades = encontraEspecialidad;

                }
            }
            return listaEspecialidades;
        }
    }
}
