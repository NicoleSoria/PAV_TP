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
using TP_TorneoNatacion.Servicios;

namespace TP_TorneoNatacion.Pantallas.Reportes
{
    public partial class GenerarReporteInscriptos : Form
    {
        TorneoService torneoService;

        public GenerarReporteInscriptos()
        {
            InitializeComponent();
            torneoService = new TorneoService();
            cargarTorneos();

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

        private void GenerarReporteInscriptos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'conjuntoDatos.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.conjuntoDatos.DataTable1);

            this.ReporteInscriptos.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if (cmbTorneo == null)
            {
                ReporteInscriptos.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("fecha", cmbTorneo.SelectedText)});
                //DATASOURCE
                ReporteInscriptos.LocalReport.DataSources.Clear();
                ReporteInscriptos.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", DBHelper.getDBHelper().GenerarReporte(cmbTorneo.SelectedText)));
                ReporteInscriptos.RefreshReport();
            }

        }
    }
}
