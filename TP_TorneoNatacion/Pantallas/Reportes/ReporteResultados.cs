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
using TP_TorneoNatacion.Pantallas.Reportes.ConjuntoDatosResultadosTableAdapters;

namespace TP_TorneoNatacion.Pantallas.Reportes
{
    public partial class ReporteResultados : Form
    {
        DataTableResultados datatable;
        ConjuntoDatosResultados conjuntoDatos;

        public ReporteResultados()
        {
            InitializeComponent();
            datatable = new DataTableResultados();
            conjuntoDatos = new ConjuntoDatosResultados();
            cargarTorneos();
            
        }

        public void cargarTorneos()
        {
            string consulta = "SELECT * FROM Torneo";

            var resultado = DBHelper.getDBHelper().ConsultaSQL(consulta);

            cmbTorneo.DataSource = resultado;
            cmbTorneo.DisplayMember = "fecha";
            cmbTorneo.ValueMember = "fecha";
            cmbTorneo.SelectedIndex = -1;
        }

        private void ReporteResultados_Load(object sender, EventArgs e)
        {
            datatable.Fill(conjuntoDatos.DataTableReult, "15/11/2019");

            this.reportViewer1.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var fechaSeleccionada = cmbTorneo.SelectedValue.ToString();
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("fecha", fechaSeleccionada) });
            
            datatable.Fill(conjuntoDatos.DataTableReult, fechaSeleccionada);

            this.reportViewer1.RefreshReport();

        }
    }
}
