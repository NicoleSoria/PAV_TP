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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grillaEspecSeleccionadas = new System.Windows.Forms.DataGridView();
            this.grillaEspecialidades = new System.Windows.Forms.DataGridView();
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
            this.Agregar_Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEspecSeleccionadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEspecialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNadador)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 504);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
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
            this.btnQuitar.Location = new System.Drawing.Point(320, 305);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(51, 24);
            this.btnQuitar.TabIndex = 36;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(320, 264);
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
            this.grillaEspecSeleccionadas.Location = new System.Drawing.Point(419, 247);
            this.grillaEspecSeleccionadas.Name = "grillaEspecSeleccionadas";
            this.grillaEspecSeleccionadas.Size = new System.Drawing.Size(237, 114);
            this.grillaEspecSeleccionadas.TabIndex = 34;
            // 
            // grillaEspecialidades
            // 
            this.grillaEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar_Especialidad});
            this.grillaEspecialidades.Location = new System.Drawing.Point(35, 247);
            this.grillaEspecialidades.Name = "grillaEspecialidades";
            this.grillaEspecialidades.Size = new System.Drawing.Size(243, 114);
            this.grillaEspecialidades.TabIndex = 33;
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
            this.cmbTorneo.Location = new System.Drawing.Point(114, 167);
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
            this.grillaNadador.Size = new System.Drawing.Size(630, 61);
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
            this.label3.Location = new System.Drawing.Point(73, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Especialidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 167);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Agregar_Especialidad
            // 
            this.Agregar_Especialidad.HeaderText = "Especialidad";
            this.Agregar_Especialidad.Name = "Agregar_Especialidad";
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // TorneoHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 575);
            this.Controls.Add(this.tabControl1);
            this.Name = "TorneoHome";
            this.Text = "TorneoHome";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEspecSeleccionadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEspecialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNadador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
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
    }
}