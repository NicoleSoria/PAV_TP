using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_TorneoNatacion.Modelos
{
    class InscripcionModel
    {
        public DateTime fecha { get; set; }
        public int nadador { get; set; }
        public int torneo { get; set; }
        public List<EspecialidadModel> especialidad { get; set; }

        
    }
}
