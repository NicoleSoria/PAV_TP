using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TorneoNatacion.Modelos
{
    public class NadadorModel
    {
        public int id_Nadador { get; set; }
        public string nombre { get; set; }
        public string tipoDoc { get; set; }
        public string dni { get; set; }
        public string club { get; set; }
        public string profesor { get; set; }
    }
}
