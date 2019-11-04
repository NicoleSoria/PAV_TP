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
using TP_TorneoNatacion.Servicios;

namespace TP_TorneoNatacion.Pantallas.Torneo
{
    public partial class TorneoHome : Form
    {
        NadadorService nadadorService;
        TorneoService torneoService;
        EspecialidadService especialidadService;

        public TorneoHome()
        {
            InitializeComponent();
            nadadorService = new NadadorService();
            torneoService = new TorneoService();
            especialidadService = new EspecialidadService();

            cargarTorneos();
            cargarEspecialidades();
        }

        public void cargarTorneos()
        {
            string consulta = "SELECT * FROM Torneo";

            var resultado = DBHelper.getDBHelper().ConsultaSQL(consulta);

            cmbTorneo.DataSource = resultado;
            cmbTorneo.DisplayMember = "fecha";
            cmbTorneo.ValueMember = "id_Torneo";
            cmbTorneo.SelectedIndex = -1;
        }

        public void cargarEspecialidades()
        {
            string consulta = "SELECT * FROM Especialidades";

            var resultado = DBHelper.getDBHelper().ConsultaSQL(consulta);

            List<string> especialidades = new List<string>();

            foreach(DataRow fila in resultado.Rows)
            {
                especialidades.Add(fila["nombre"].ToString()) ;
            }

            foreach(string especialidad in especialidades)
            {
                var filaNueva = grillaEspecialidades.Rows.Add();
                grillaEspecialidades.Rows[filaNueva].Cells[0].Value = especialidad;
            }

        }

        public void buscarNadador()
        {
            var resultado = nadadorService.buscarNadador(txtNadador.Text);

            if(resultado != null)
            {
                grillaNadador.DataSource = resultado;
            }
        }

        public void agregarEspecialidad()
        {
            DataGridViewRow seleccionada = grillaEspecialidades.CurrentRow;

            if(seleccionada != null)
            {
                grillaEspecialidades.Rows.Remove(seleccionada);
                grillaEspecSeleccionadas.Rows.Add(seleccionada);
            }
        }

        public void quitarEspecialidad()
        {
            DataGridViewRow seleccionada = grillaEspecSeleccionadas.CurrentRow;

            if(seleccionada != null)
            {
                grillaEspecSeleccionadas.Rows.Remove(seleccionada);
                grillaEspecialidades.Rows.Add(seleccionada);
            }
        }

        public void guardarIncripcion()
        {
            var nuevaInscripcion = new InscripcionModel();

            DataGridViewRow seleccionadoNadador = grillaNadador.CurrentRow;

            nuevaInscripcion.fecha = DateTime.Now;
            nuevaInscripcion.torneo = (int)cmbTorneo.SelectedValue;
            nuevaInscripcion.nadador = Convert.ToInt32(seleccionadoNadador.Cells["id_Nadador"].Value);

            nuevaInscripcion.especialidad = new List<EspecialidadModel>();

            foreach (DataGridViewRow fila in grillaEspecSeleccionadas.Rows)
            {
                EspecialidadModel especialidad = new EspecialidadModel();

                EspecialidadModel encontrada = new EspecialidadModel();
                encontrada = especialidadService.buscarEspecialidad(fila.Cells[0].Value.ToString());

                especialidad.id_Especialidad = encontrada.id_Especialidad;
                especialidad.nombre = encontrada.nombre;

                nuevaInscripcion.especialidad.Add(especialidad);
            }

            var resultado = torneoService.guardarInscripcion(nuevaInscripcion);

            if(resultado == true)
            {
                MessageBox.Show("Incripcion realizada con exito", "", MessageBoxButtons.OK);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            buscarNadador();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            quitarEspecialidad();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            agregarEspecialidad();
        }

        private void BtnInscribir_Click(object sender, EventArgs e)
        {
            guardarIncripcion();
        }
    }
}
