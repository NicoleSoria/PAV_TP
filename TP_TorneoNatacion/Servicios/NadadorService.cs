using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_TorneoNatacion.Modelos;

namespace TP_TorneoNatacion.Servicios
{
    class NadadorService
    {
        DataTable listaNadadores = new DataTable();


        public bool saveNadador(string nombre,int tipoDoc, string dni, int club, int profesor)
        {
            string consulta = "INSERT INTO Nadadores (nombre, id_tipoDoc, dni, id_club, id_Profesor) VALUES (@param1, @param2, @param3, @param4, @param5); ";

            var result = DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] { nombre, tipoDoc, dni, club, profesor });

            if (result != 0)
            {
                return true;
            }

            return false;
        }


        public DataTable getNadadores()
        {
            var consulta = " SELECT Nadadores.id_Nadador, Nadadores.nombre Nadador, TipoDocumentos.id_tipoDoc Tipo, Nadadores.dni Documento, Clubs.nombre Club, Profesores.nombre Profesor " +
                             " FROM Nadadores, TipoDocumentos, Clubs, Profesores " +
                              " WHERE " +
                            " Nadadores.id_Club = Clubs.id_Club AND " +
                            " Nadadores.id_Profesor = Profesores.id_Profesor AND " +
                            " Nadadores.id_tipoDoc = TipoDocumentos.id_tipoDoc ";

            listaNadadores = DBHelper.getDBHelper().ConsultaSQL(consulta);

            return listaNadadores;
        }

        public bool deleteNadador(int id)
        {

            var consulta = " DELETE FROM Nadadores WHERE id_Nadador = @param1";

            var resultado = DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] { id });

            if (resultado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool editarNadador(int id, string nombre, int tipoDoc ,string dni, int club, int profesor)
        {

            var consulta = string.Concat("UPDATE Nadadores SET " +
                                          " nombre = @param1, " +
                                          " id_tipoDoc = @param2, " +
                                          " dni = @param3, " +
                                          " id_Club = @param4, " +
                                          " id_Profesor = @param5" +
                                          " WHERE id_Nadador = @param6 ");

            var resultado = DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] { nombre, tipoDoc, dni, club, profesor, id });

            if (resultado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<NadadorModel> buscarNadador(string nombre)
        {
            List<NadadorModel> listaNadadores = new List<NadadorModel>();
            var consulta = "SELECT * FROM Nadadores WHERE nombre like @param1 + '%' ";

            var resultado = DBHelper.getDBHelper().ConsultarSQLConParametros(consulta, new object[] { nombre });

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow row in resultado.Rows)
                {
                    NadadorModel encontradoClub = new NadadorModel();

                    encontradoClub.id_Nadador = Convert.ToInt32(row[0]);
                    encontradoClub.nombre = row[1].ToString();
                    encontradoClub.dni = row[2].ToString();
                    encontradoClub.club = row[3].ToString();

                    listaNadadores.Add(encontradoClub);

                }
            }
            return listaNadadores;
        }

        public bool guardarNadadorXEspecialidad(int idNadador, int idEspecialidad)
        {
            var consulta = " INSERT INTO NadadorXEspecialidad (id_Nadador, id_Especialidad) VALUES (@param1, @param2); ";

            var resultado = DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] { idNadador, idEspecialidad });

            if( resultado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable buscarNadadorXEspecialidad(int id_Nadador)
        {
            var consulta = " SELECT Especialidades.nombre Especialidad" +
                             " FROM Especialidades, NadadorXEspecialidad" +
                             " WHERE NadadorXEspecialidad.id_Nadador = @param1 AND " +
                             "Especialidades.id_Especialidad = NadadorXEspecialidad.id_Especialidad ";

            var resultado = DBHelper.getDBHelper().ConsultarSQLConParametros(consulta, new object[] { id_Nadador });

            return resultado;

        }
    }
}
