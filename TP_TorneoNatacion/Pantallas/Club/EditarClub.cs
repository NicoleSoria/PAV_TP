using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_TorneoNatacion.Modelos;

namespace TP_TorneoNatacion.Pantallas
{
    public partial class EditarClub : Form
    {
        Servicios.ClubService serviceClub;

        public EditarClub()
        {
            InitializeComponent();
            serviceClub = new Servicios.ClubService();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            editarClub();
        }

        public void editarClub()
        {
            var id_Club = int.Parse(txt_id.Text);

            var resultado = serviceClub.editarClub(id_Club, txtNombre.Text, txtCalle.Text, txtAltura.Text);

            if(resultado == true)
            {
                MessageBox.Show("Club editado correctamente", "", MessageBoxButtons.OK);
                ListarClubs pantallaListar = new ListarClubs();
                pantallaListar.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al editar club", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void cargarDatosEditar(ClubModel club)
        {
            txtNombre.Text = club.nombre;
            txtAltura.Text = club.numero;
            txtCalle.Text = club.calle;
            txt_id.Text = club.id_Club.ToString();

        }
    }
}
