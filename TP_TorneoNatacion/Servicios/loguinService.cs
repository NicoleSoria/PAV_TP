using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TorneoNatacion.Servicios
{
    class loguinService
    {

        public bool iniciarSesion(string usuario, string contraseña)
        {
            Boolean inicioCorrecto = false;
            var consulta = string.Concat(" SELECT * " +
                                         "   FROM Usuarios " +
                                         "  WHERE nombre = @param1 ");
            var resultado = DBHelper.getDBHelper().ConsultarSQLConParametros(consulta, new object[] { usuario });

            
            foreach(DataRow row in resultado.Rows)
            {
                if (row[1].ToString() == contraseña)
                {
                    inicioCorrecto = true;
                } 
                else
                {
                    inicioCorrecto = false;
                }
            }

            return inicioCorrecto;
        }
    }

}
