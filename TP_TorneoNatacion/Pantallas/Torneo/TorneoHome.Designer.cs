namespace TP_TorneoNatacion.Pantallas.Torneo
{
    partial class TorneoHome
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
            this.TorneoTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grillaEspecSeleccionadas = new System.Windows.Forms.DataGridView();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grillaEspecialidades = new System.Windows.Forms.DataGridView();
            this.Agregar_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.cmbTorneo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNadador = new System.Windows.Forms.TextBox();
            this.grillaNadador = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Resultado = new System.Windows.Forms.GroupBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.btnRegResultado = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grillaParticipantes = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TorneoTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEspecSeleccionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNadador)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaParticipantes)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TorneoTab
            // 
            this.TorneoTab.Controls.Add(this.tabPage1);
            this.TorneoTab.Controls.Add(this.tabPage2);
            this.TorneoTab.Controls.Add(this.tabPage3);
            this.TorneoTab.Location = new System.Drawing.Point(12, 12);
            this.TorneoTab.Name = "TorneoTab";
            this.TorneoTab.SelectedIndex = 0;
            this.TorneoTab.Size = new System.Drawing.Size(803, 504);
            this.TorneoTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inscripción";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.grillaEspecSeleccionadas);
            this.groupBox1.Controls.Add(this.grillaEspecialidades);
            this.groupBox1.Controls.Add(this.btnInscribir);
            this.groupBox1.Controls.Add(this.cmbTorneo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtNadador);
            this.groupBox1.Controls.Add(this.grillaNadador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 443);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulario de Incripcion";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(320, 339);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(51, 24);
            this.btnQuitar.TabIndex = 36;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(320, 298);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 24);
            this.btnAgregar.TabIndex = 35;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // grillaEspecSeleccionadas
            // 
            this.grillaEspecSeleccionadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEspecSeleccionadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Especialidad});
            this.grillaEspecSeleccionadas.Location = new System.Drawing.Point(419, 281);
            this.grillaEspecSeleccionadas.Name = "grillaEspecSeleccionadas";
            this.grillaEspecSeleccionadas.Size = new System.Drawing.Size(237, 114);
            this.grillaEspecSeleccionadas.TabIndex = 34;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // grillaEspecialidades
            // 
            this.grillaEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar_Especialidad});
            this.grillaEspecialidades.Location = new System.Drawing.Point(35, 281);
            this.grillaEspecialidades.Name = "grillaEspecialidades";
            this.grillaEspecialidades.Size = new System.Drawing.Size(243, 114);
            this.grillaEspecialidades.TabIndex = 33;
            // 
            // Agregar_Especialidad
            // 
            this.Agregar_Especialidad.HeaderText = "Especialidad";
            this.Agregar_Especialidad.Name = "Agregar_Especialidad";
            // 
            // btnInscribir
            // 
            this.btnInscribir.Location = new System.Drawing.Point(677, 397);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(88, 40);
            this.btnInscribir.TabIndex = 32;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.BtnInscribir_Click);
            // 
            // cmbTorneo
            // 
            this.cmbTorneo.FormattingEnabled = true;
            this.cmbTorneo.Location = new System.Drawing.Point(114, 208);
            this.cmbTorneo.Name = "cmbTorneo";
            this.cmbTorneo.Size = new System.Drawing.Size(121, 21);
            this.cmbTorneo.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(219, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtNadador
            // 
            this.txtNadador.Location = new System.Drawing.Point(113, 46);
            this.txtNadador.Name = "txtNadador";
            this.txtNadador.Size = new System.Drawing.Size(100, 20);
            this.txtNadador.TabIndex = 28;
            // 
            // grillaNadador
            // 
            this.grillaNadador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaNadador.Location = new System.Drawing.Point(35, 89);
            this.grillaNadador.Name = "grillaNadador";
            this.grillaNadador.Size = new System.Drawing.Size(630, 90);
            this.grillaNadador.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nadador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Torneo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nro. Inscripcion";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Resultado);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.grillaParticipantes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Torneo - resultados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Resultado
            // 
            this.Resultado.Controls.Add(this.txtTiempo);
            this.Resultado.Controls.Add(this.txtPosicion);
            this.Resultado.Controls.Add(this.btnRegResultado);
            this.Resultado.Controls.Add(this.label6);
            this.Resultado.Controls.Add(this.label7);
            this.Resultado.Location = new System.Drawing.Point(557, 98);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(232, 278);
            this.Resultado.TabIndex = 38;
            this.Resultado.TabStop = false;
            this.Resultado.Text = "Resultado";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(99, 59);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 35;
            // 
            // txtPosicion
            // 
            this.txtPosicion.Location = new System.Drawing.Point(99, 114);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(100, 20);
            this.txtPosicion.TabIndex = 37;
            // 
            // btnRegResultado
            // 
            this.btnRegResultado.Location = new System.Drawing.Point(60, 179);
            this.btnRegResultado.Name = "btnRegResultado";
            this.btnRegResultado.Size = new System.Drawing.Size(139, 49);
            this.btnRegResultado.TabIndex = 2;
            this.btnRegResultado.Text = "Registrar Resultado";
            this.btnRegResultado.UseVisualStyleBackColor = true;
            this.btnRegResultado.Click += new System.EventHandler(this.BtnRegResultado_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Posicion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tiempo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(187, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(403, 42);
            this.label5.TabIndex = 27;
            this.label5.Text = "Torneo - participantes";
            // 
            // grillaParticipantes
            // 
            this.grillaParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaParticipantes.Location = new System.Drawing.Point(6, 86);
            this.grillaParticipantes.Name = "grillaParticipantes";
            this.grillaParticipantes.Size = new System.Drawing.Size(531, 368);
            this.grillaParticipantes.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reportes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(387, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 228);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reporte resultados";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(119, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 70);
            this.button2.TabIndex = 0;
            this.button2.Text = "Generar Reporte";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(49, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte inscriptos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(57, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(50, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 42);
            this.label8.TabIndex = 28;
            this.label8.Text = "Inscriptos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(31, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(339, 42);
            this.label9.TabIndex = 29;
            this.label9.Text = "Resultados torneo";
            // 
            // TorneoHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(825, 575);
            this.Controls.Add(this.TorneoTab);
            this.Name = "TorneoHome";
            this.Text = "TorneoHome";
            this.TorneoTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEspecSeleccionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNadador)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Resultado.ResumeLayout(false);
            this.Resultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaParticipantes)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TorneoTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grillaEspecialidades;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.ComboBox cmbTorneo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNadador;
        private System.Windows.Forms.DataGridView grillaNadador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grillaEspecSeleccionadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agregar_Especialidad;
        private System.Windows.Forms.Button btnRegResultado;
        private System.Windows.Forms.DataGridView grillaParticipantes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Resultado;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}