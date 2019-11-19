namespace TP_TorneoNatacion.Pantallas.Reportes
{
    partial class GenerarReporteInscriptos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ReporteInscriptos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.conjuntoDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conjuntoDatos = new TP_TorneoNatacion.Pantallas.Reportes.ConjuntoDatos();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new TP_TorneoNatacion.Pantallas.Reportes.ConjuntoDatosTableAdapters.DataTable1TableAdapter();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.conjuntoDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjuntoDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteInscriptos
            // 
            this.ReporteInscriptos.LocalReport.ReportEmbeddedResource = "TP_TorneoNatacion.Pantallas.Reportes.IncriptosInforme.rdlc";
            this.ReporteInscriptos.Location = new System.Drawing.Point(12, 69);
            this.ReporteInscriptos.Name = "ReporteInscriptos";
            this.ReporteInscriptos.ServerReport.BearerToken = null;
            this.ReporteInscriptos.Size = new System.Drawing.Size(396, 369);
            this.ReporteInscriptos.TabIndex = 0;
            // 
            // conjuntoDatosBindingSource
            // 
            this.conjuntoDatosBindingSource.DataSource = this.conjuntoDatos;
            this.conjuntoDatosBindingSource.Position = 0;
            // 
            // conjuntoDatos
            // 
            this.conjuntoDatos.DataSetName = "ConjuntoDatos";
            this.conjuntoDatos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.conjuntoDatos;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(148, 24);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 1;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(12, 24);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(121, 21);
            this.cmbTorneo.TabIndex = 2;
            // 
            // GenerarReporteInscriptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.cmbTorneo);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.ReporteInscriptos);
            this.Name = "GenerarReporteInscriptos";
            this.Text = "GenerarReporteInscriptos";
            this.Load += new System.EventHandler(this.GenerarReporteInscriptos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.conjuntoDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjuntoDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource conjuntoDatosBindingSource;
        private ConjuntoDatos conjuntoDatos;
        private Microsoft.Reporting.WinForms.ReportViewer ReporteInscriptos;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ConjuntoDatosTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cmbTorneo;
    }
}