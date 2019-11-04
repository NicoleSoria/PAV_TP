namespace TP_TorneoNatacion
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnTorneo = new System.Windows.Forms.Button();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.btnProfesores = new System.Windows.Forms.Button();
            this.btnNadador = new System.Windows.Forms.Button();
            this.btnClub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Torneo Natacion";
            // 
            // btnTorneo
            // 
            this.btnTorneo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTorneo.Location = new System.Drawing.Point(175, 224);
            this.btnTorneo.Name = "btnTorneo";
            this.btnTorneo.Size = new System.Drawing.Size(175, 81);
            this.btnTorneo.TabIndex = 10;
            this.btnTorneo.Text = "Torneos";
            this.btnTorneo.UseVisualStyleBackColor = true;
            this.btnTorneo.Click += new System.EventHandler(this.BtnTorneo_Click);
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialidad.Location = new System.Drawing.Point(301, 163);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(161, 36);
            this.btnEspecialidad.TabIndex = 9;
            this.btnEspecialidad.Text = "Especialidad";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.Location = new System.Drawing.Point(88, 163);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Size = new System.Drawing.Size(161, 36);
            this.btnProfesores.TabIndex = 7;
            this.btnProfesores.Text = "Profesores";
            this.btnProfesores.UseVisualStyleBackColor = true;
            // 
            // btnNadador
            // 
            this.btnNadador.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNadador.Location = new System.Drawing.Point(301, 104);
            this.btnNadador.Name = "btnNadador";
            this.btnNadador.Size = new System.Drawing.Size(161, 36);
            this.btnNadador.TabIndex = 8;
            this.btnNadador.Text = "Nadadores";
            this.btnNadador.UseVisualStyleBackColor = true;
            this.btnNadador.Click += new System.EventHandler(this.BtnNadador_Click);
            // 
            // btnClub
            // 
            this.btnClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClub.Location = new System.Drawing.Point(88, 104);
            this.btnClub.Name = "btnClub";
            this.btnClub.Size = new System.Drawing.Size(161, 36);
            this.btnClub.TabIndex = 6;
            this.btnClub.Text = "Clubes";
            this.btnClub.UseVisualStyleBackColor = true;
            this.btnClub.Click += new System.EventHandler(this.BtnClub_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 351);
            this.Controls.Add(this.btnTorneo);
            this.Controls.Add(this.btnEspecialidad);
            this.Controls.Add(this.btnProfesores);
            this.Controls.Add(this.btnNadador);
            this.Controls.Add(this.btnClub);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Torneo Natacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTorneo;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Button btnProfesores;
        private System.Windows.Forms.Button btnNadador;
        private System.Windows.Forms.Button btnClub;
    }
}

