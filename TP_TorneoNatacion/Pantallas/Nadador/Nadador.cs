using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_TorneoNatacion.Pantallas.Nadador
{
    public partial class Nadador : Form
    {
        public Nadador()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarNadador pantallaListar = new ListarNadador();
            pantallaListar.ShowDialog();
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            AñadirNadador pantallaAñadir = new AñadirNadador();
            pantallaAñadir.ShowDialog();
        }
    }
}
