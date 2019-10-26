using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_TorneoNatacion.Pantallas
{
    public partial class Loguin : Form
    {
        Servicios.loguinService loguinService;

        public Loguin()
        {
            InitializeComponent();
            loguinService = new Servicios.loguinService();
        }

        public void iniciarSesion()
        {
            var resultado = loguinService.iniciarSesion(txtUsuario.Text, txtContraseña.Text);

            if(resultado == true)
            {
                MessageBox.Show("Inicio de sesion con exito", "Bienvenido", MessageBoxButtons.OK);
                Home home = new Home();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            if(txtUsuario.Text == null)
            {
                MessageBox.Show("Debe ingresar usuario", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if(txtContraseña.Text == null)
            {
                MessageBox.Show("Debe ingresar contraseña", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            iniciarSesion();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
