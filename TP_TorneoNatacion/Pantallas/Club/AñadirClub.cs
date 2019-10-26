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
    public partial class AñadirClub : Form
    {
        Servicios.ClubService clubService;

        public AñadirClub()
        {
            InitializeComponent();
            clubService = new Servicios.ClubService();
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            var resultado = clubService.saveClub(txtNombre.Text.Trim(), txtCalle.Text.Trim(), txtAltura.Text.Trim());

            if (resultado == true)
            {
                MessageBox.Show("Se dió de alta el nuevo club!", "", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Se produjo un error al dar el alta al nuevo club", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }
        }

        private void AñadirClub_Load(object sender, EventArgs e)
        {

        }
    }
}
