using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_TorneoNatacion.Pantallas
{
    public partial class Club : Form
    {
        public Club()
        {
            InitializeComponent();
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            AñadirClub nuevoClub = new AñadirClub();
            nuevoClub.ShowDialog();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarClubs listadoClub = new ListarClubs();
            listadoClub.ShowDialog();
        }
    }
}
