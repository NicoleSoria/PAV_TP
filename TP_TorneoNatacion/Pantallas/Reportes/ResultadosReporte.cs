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
    public partial class ResultadosReporte : Form
    {
        public ResultadosReporte()
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

        private void ResultadosReporte_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fechaSeleccionada = cmbTorneo.SelectedValue.ToString();

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("fecha", fechaSeleccionada) });

            this.dataTableAdapter.Fill(this.dataTableResultados, fechaSeleccionada);
            this.reportViewer1.RefreshReport();

        }
    }
}
