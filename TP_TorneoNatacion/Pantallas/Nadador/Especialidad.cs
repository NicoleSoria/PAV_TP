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
    public partial class Especialidad : Form
    {
        Servicios.NadadorService nadadorService;

        public Especialidad()
        {
            InitializeComponent();
            nadadorService = new Servicios.NadadorService();
            txtNadador.Enabled = true;

        }

        public void getNadador(int id_Nadador, string nombre)
        {
           var resultado = nadadorService.buscarNadadorXEspecialidad(id_Nadador);

            GrillaEspecialidad.DataSource = resultado;
            txtNadador.Text = nombre;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
