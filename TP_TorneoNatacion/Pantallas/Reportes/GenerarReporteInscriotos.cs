using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_TorneoNatacion.Pantallas.Reportes
{
    public partial class GenerarReporteInscriotos : Form
    {
        public GenerarReporteInscriotos()
        {
            InitializeComponent();
            cargarTorneos();
        }

        public void cargarTorneos()
        {
            string consulta = "SELECT * FROM Torneo WHERE Torneo.fecha > getdate()";

            var resultado = DBHelper.getDBHelper().ConsultaSQL(consulta);

            cmbTorneo.DataSource = resultado;
            cmbTorneo.DisplayMember = "fecha";
            cmbTorneo.ValueMember = "fecha";
            cmbTorneo.SelectedIndex = -1;
        }

        private void GenerarReporteInscriotos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ConjuntoDatos.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.ConjuntoDatos.DataTable1, "2019/11/15");
            
            this.reportViewer1.RefreshReport();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            var fechaSeleccionada = cmbTorneo.SelectedValue.ToString();

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("fecha", fechaSeleccionada) });

            this.DataTable1TableAdapter.Fill(this.ConjuntoDatos.DataTable1, fechaSeleccionada);

            this.reportViewer1.RefreshReport();
        }
    }
}
