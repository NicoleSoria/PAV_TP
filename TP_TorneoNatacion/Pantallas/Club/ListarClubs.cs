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
    public partial class ListarClubs : Form
    {
        Servicios.ClubService clubService;
        public ListarClubs()
        {
            InitializeComponent();
            clubService = new Servicios.ClubService();
            getClubs();
        }

        public void getClubs()
        {
            var resultado = clubService.getClubs();

            GrillaClub.DataSource = resultado;
        }

        public void deteleClub()
        {
            DataGridViewRow seleccionado = GrillaClub.CurrentRow;

            var id = Convert.ToInt32(seleccionado.Cells["id_Club"].Value);

            if(seleccionado != null)
            {
                var resultado = clubService.deleteClub(id);

                if(resultado == true)
                {
                    getClubs();
                }
            }

            
        }

        public void editarClub()
        {
            DataGridViewRow seleccionado = GrillaClub.CurrentRow;
            var id = Convert.ToInt32(seleccionado.Cells["id_Club"].Value);

            ClubModel clubEditar = new ClubModel();

            clubEditar.id_Club = id;
            clubEditar.nombre = seleccionado.Cells["Nombre"].Value.ToString();
            clubEditar.calle = seleccionado.Cells["Calle"].Value.ToString();
            clubEditar.numero = seleccionado.Cells["Numero"].Value.ToString();

            if (seleccionado != null)
            {
                EditarClub pantallaEditar = new EditarClub();
                pantallaEditar.cargarDatosEditar(clubEditar);
                pantallaEditar.ShowDialog();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            deteleClub();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            editarClub();
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var resultado = clubService.buscarClub(buscarTXT.Text);

            if(resultado != null)
            {
                GrillaClub.DataSource = resultado;
            }
        }
    }
}
