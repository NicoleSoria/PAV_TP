using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_TorneoNatacion.Pantallas;
using TP_TorneoNatacion.Pantallas.Nadador;
using TP_TorneoNatacion.Pantallas.Torneo;

namespace TP_TorneoNatacion
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnClub_Click(object sender, EventArgs e)
        {
            Club club = new Club();

            club.ShowDialog();
        }

        private void BtnNadador_Click(object sender, EventArgs e)
        {
            Nadador nadador = new Nadador();
            nadador.ShowDialog();
        }

        private void BtnTorneo_Click(object sender, EventArgs e)
        {
            TorneoHome torneo = new TorneoHome();
            torneo.ShowDialog();
        }
    }
}
