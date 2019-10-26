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
    
    public partial class EditarNadador : Form
    {
        Servicios.NadadorService nadadorService;
        Servicios.ClubService clubService;
        Servicios.ProfesorService profesorService;

        public EditarNadador()
        {
            InitializeComponent();
            nadadorService = new Servicios.NadadorService();
            clubService = new Servicios.ClubService();
            profesorService = new Servicios.ProfesorService();
            cargarTiposDoc();
            cargarProfesores();
            cargarClubs();

        }

        public void cargarTiposDoc()
        {
            comboTipoDoc.DataSource = DBHelper.getDBHelper().ConsultaSQL("SELECT * FROM TipoDocumentos");
            comboTipoDoc.DisplayMember = "nombre";
            comboTipoDoc.ValueMember = "id_tipoDoc";
            comboTipoDoc.SelectedIndex = -1;
        }

        public void cargarClubs()
        {
            comboClubs.DataSource = DBHelper.getDBHelper().ConsultaSQL("SELECT * FROM Clubs");
            comboClubs.DisplayMember = "nombre";
            comboClubs.ValueMember = "id_Club";
            comboClubs.SelectedIndex = -1;
        }

        public void cargarProfesores()
        {
            comboProfesores.DataSource = DBHelper.getDBHelper().ConsultaSQL("SELECT * FROM Profesores");
            comboProfesores.DisplayMember = "nombre";
            comboProfesores.ValueMember = "id_Profesor";
            comboProfesores.SelectedIndex = -1;
        }

        public void editarNadador()
        {
            var id_Nadador = int.Parse(txt_id.Text);
            var id_Club = buscarClub();
            var id_Profesor = buscarClub();

            var resultado = nadadorService.editarNadador(id_Nadador, txtNombre.Text, (int)comboTipoDoc.SelectedValue ,txtDoc.Text , id_Club, id_Profesor);

            if (resultado == true)
            {
                MessageBox.Show("Nadador editado con exito", "", MessageBoxButtons.OK);
                ListarNadador pantallaListar = new ListarNadador();
                pantallaListar.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al editar nadador", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void cargarDatosEditar(NadadorModel nadador)
        {
            txtNombre.Text = nadador.nombre;
            comboTipoDoc.SelectedValue = nadador.tipoDoc;
            txtDoc.Text = nadador.dni;
            comboClubs.SelectedText = nadador.club;
            txt_id.Text = nadador.id_Nadador.ToString();
            comboProfesores.SelectedText = nadador.profesor.ToString();

        }

        public int buscarClub()
        {
            var resultado = clubService.buscarClub(comboClubs.SelectedValue.ToString());
            var id_club = 0;

            if (resultado != null)
            {
                foreach (ClubModel club in resultado)
                {
                    id_club = club.id_Club;
                }
            }
            return id_club;
        }

        public int buscarProfesor()
        {
            var resultado = profesorService.buscarProfesor(comboProfesores.SelectedValue.ToString());
            var id_Profesor = 0;

            if (resultado != null)
            {
                foreach (ProfesorModel profesor in resultado)
                {
                    id_Profesor = profesor.id_Nadador;
                }
            }
            return id_Profesor;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            editarNadador();
        }
    }
}
