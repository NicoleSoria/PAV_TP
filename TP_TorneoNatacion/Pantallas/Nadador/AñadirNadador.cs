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
    public partial class AñadirNadador : Form
    {
        Servicios.NadadorService nadadorService;
        Servicios.ClubService clubService;
        Servicios.ProfesorService profesorService;

        public AñadirNadador()
        {
            InitializeComponent();
            nadadorService = new Servicios.NadadorService();
            clubService = new Servicios.ClubService();
            profesorService = new Servicios.ProfesorService();
            cargarTiposDoc();
            cargarClubs();
            cargarProfesores();
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

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            var id_Club = buscarClub();
            var id_Profesor = buscarProfesor();

            var resultado = nadadorService.saveNadador(txtNombre.Text.Trim(), (int)comboTipoDoc.SelectedValue, txtDoc.Text.Trim(), id_Club, id_Profesor);

            if (resultado == true)
            {
                MessageBox.Show("Se registro exitosamente el nuevo nadador!", "", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error al registrar el nuevo nadador!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public int buscarClub()
        {
            var resultado = clubService.buscarClub(comboClubs.SelectedText);
            var id_club = 0;

            if(resultado != null)
            {
                foreach( ClubModel club in resultado)
                {
                    id_club = club.id_Club;
                }
            }
            return id_club;
        }

        public int buscarProfesor()
        {
            var resultado = profesorService.buscarProfesor(comboProfesores.SelectedText);
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
    }
}
