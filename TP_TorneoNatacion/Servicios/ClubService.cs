using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_TorneoNatacion.Modelos;

namespace TP_TorneoNatacion.Servicios
{
    public class ClubService
    {
        DataTable listaClubs = new DataTable();


        public bool saveClub(string nombre, string calle, string numero)
        {
            string consulta = "INSERT INTO Clubs (nombre, calle, numero) VALUES (@param1, @param2, @param3); ";

            var result = DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] { nombre, calle, numero });

            if(result != 0)
            {
                return true;
            }

            return false;
        }

   
        public DataTable getClubs()
        {
            var consulta = "SELECT * FROM Clubs";

            listaClubs = DBHelper.getDBHelper().ConsultaSQL(consulta);

            return listaClubs;
        }
        
        public bool deleteClub(int id)  
        {

            var consulta = " DELETE FROM Clubs WHERE id_Club = @param1";

            var resultado = DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] { id });

            if(resultado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool editarClub(int id, string nombre, string calle, string numero)
        {

            var consulta = string.Concat("UPDATE Clubs SET " +
                                          " nombre = @param1, " +
                                          " calle = @param2, " +
                                          " numero = @param3 " +
                                          " WHERE id_Club = @param4 ");

            var resultado = DBHelper.getDBHelper().ejecutarSQLParametros(consulta, new object[] { nombre, calle, numero, id });

            if(resultado != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ClubModel> buscarClub(string nombre)
        {
            List<ClubModel> listaClubs = new List<ClubModel>();
            var consulta = "SELECT * FROM Clubs WHERE nombre like @param1 + '%' ";

            var resultado = DBHelper.getDBHelper().ConsultarSQLConParametros(consulta, new object[] { nombre });

            if(resultado.Rows.Count > 0)
            {
                foreach(DataRow row in resultado.Rows)
                {
                    ClubModel encontradoClub = new ClubModel();

                    encontradoClub.id_Club = Convert.ToInt32(row[0]);
                    encontradoClub.nombre = row[1].ToString();
                    encontradoClub.calle = row[2].ToString();
                    encontradoClub.numero = row[3].ToString();

                    listaClubs.Add(encontradoClub);

                }

            }

            return listaClubs;

        }
    }
}
