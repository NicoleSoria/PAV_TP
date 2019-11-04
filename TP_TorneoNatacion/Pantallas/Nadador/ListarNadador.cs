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

namespace TP_TorneoNatacion.Pantallas.Nadador
{
    public partial class ListarNadador : Form
    {
        Servicios.NadadorService nadadorService;

        public ListarNadador()
        {
            InitializeComponent();
            nadadorService = new Servicios.NadadorService();
            getNadador();
        }

        public void getNadador()
        {
            var resultado = nadadorService.getNadadores();

            GrillaNadadores.DataSource = resultado;
        }

        public void deleteNadador()
        {
            DataGridViewRow seleccionado = GrillaNadadores.CurrentRow;

            var id = Convert.ToInt32(seleccionado.Cells["id_Nadador"].Value);

            if (seleccionado != null)
            {
                var resultado = nadadorService.deleteNadador(id);

                if (resultado == true)
                {
                    getNadador();
                }
            }

        }

        public void editarNadador()
        {
            DataGridViewRow seleccionado = GrillaNadadores.CurrentRow;
            var id = Convert.ToInt32(seleccionado.Cells["id_Nadador"].Value);

            NadadorModel nadadorEditar = new NadadorModel();

            nadadorEditar.id_Nadador = id;
            nadadorEditar.nombre = seleccionado.Cells["Nadador"].Value.ToString();
            nadadorEditar.tipoDoc = seleccionado.Cells["Tipo"].Value.ToString();
            nadadorEditar.dni = seleccionado.Cells["Documento"].Value.ToString();
            nadadorEditar.club = seleccionado.Cells["Club"].Value.ToString();
            nadadorEditar.profesor = seleccionado.Cells["Profesor"].Value.ToString();

            if (seleccionado != null)
            {
                EditarNadador pantallaEditar = new EditarNadador();
                pantallaEditar.cargarDatosEditar(nadadorEditar);
                pantallaEditar.ShowDialog();
                this.Close();
            }
        }

        //public void verEspecialidadNad()
        //{
        //    DataGridViewRow seleccionado = GrillaNadadores.CurrentRow;
        //    var id = Convert.ToInt32(seleccionado.Cells["id_Nadador"].Value);
        //    var nombreNadador = seleccionado.Cells["Nadador"].Value.ToString();

        //    if(seleccionado != null)
        //    {
        //        Especialidad pantallaEspecialidad = new Especialidad();
        //        pantallaEspecialidad.getNadador(id, nombreNadador);
        //        pantallaEspecialidad.ShowDialog();
        //    }
        //}

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            editarNadador();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            deleteNadador();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var resultado = nadadorService.buscarNadador(buscarTXT.Text);

            if(resultado != null)
            {
                GrillaNadadores.DataSource = resultado;
            }
        }

        //private void BtnEspecialidad_Click(object sender, EventArgs e)
        //{
        //    verEspecialidadNad();
        //}
    }
}
