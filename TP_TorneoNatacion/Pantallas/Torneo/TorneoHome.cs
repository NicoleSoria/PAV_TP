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
using TP_TorneoNatacion.Pantallas.Reportes;
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
            cargarInscriptos();
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

            for( var i = 0; i < (grillaEspecSeleccionadas.Rows.Count - 1); i++)
            {
                EspecialidadModel encontrada = new EspecialidadModel();

                encontrada = especialidadService.buscarEspecialidad(grillaEspecSeleccionadas.Rows[i].Cells[0].Value.ToString());

                nuevaInscripcion.especialidad.Add(encontrada);
            }

            var resultado = torneoService.guardarInscripcion(nuevaInscripcion);

            if(resultado == true)
            {
                MessageBox.Show("Incripcion realizada con exito", "", MessageBoxButtons.OK);
                cargarInscriptos();

            }
        }


        public void cargarInscriptos()
        {
            var resultado = torneoService.obtenerParticipantes();

            grillaParticipantes.DataSource = resultado;
        }

        public void registrarResultados()
        {
            DataGridViewRow seleccionado = grillaParticipantes.CurrentRow;
            int id_Nadador = 0;
            int id_Torneo = 0;
            int posicion;
            decimal tiempo;


            if (txtPosicion.Text.Length == 0)
            {
                posicion = (int)seleccionado.Cells["posicion"].Value;
            }
            else
            {
                posicion = Convert.ToInt32(txtPosicion.Text);
            }

            if (txtTiempo.Text.Length == 0)
            {
                tiempo = (int)seleccionado.Cells["tiempo"].Value;
            }
            else
            {
                tiempo = Convert.ToDecimal(txtTiempo.Text);
            }


            List<NadadorModel> nadadorEncontrado = nadadorService.buscarNadador(seleccionado.Cells["Nombre"].Value.ToString());

            foreach(NadadorModel nadador in nadadorEncontrado)
            {
                id_Nadador = nadador.id_Nadador;
            }

            List<TorneoModel> resultadoToreno = torneoService.buscarTorneo(Convert.ToDateTime(seleccionado.Cells["Fecha"].Value));

            foreach (TorneoModel torneo in resultadoToreno)
            {
                id_Torneo = torneo.id_Torneo;
            }

            var resultadoSaveResultado = torneoService.registrarResultado(id_Torneo, id_Nadador, posicion, tiempo);

            if (resultadoSaveResultado)
            {
                MessageBox.Show("Guardado con exito", "", MessageBoxButtons.OK);
                cargarInscriptos();
                txtPosicion.Clear();
                txtTiempo.Clear();
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

        private void BtnRegResultado_Click(object sender, EventArgs e)
        {
            registrarResultados();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var reporteInscriptos = new GenerarReporteInscriptos();

            reporteInscriptos.Show();
        }
    }
}
