namespace TP_TorneoNatacion.Pantallas.Nadador
{
    partial class Especialidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.GrillaEspecialidad = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNadador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEspecialidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Nombre:";
            // 
            // GrillaEspecialidad
            // 
            this.GrillaEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEspecialidad.Location = new System.Drawing.Point(37, 87);
            this.GrillaEspecialidad.Name = "GrillaEspecialidad";
            this.GrillaEspecialidad.Size = new System.Drawing.Size(263, 267);
            this.GrillaEspecialidad.TabIndex = 72;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(323, 376);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 73;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // txtNadador
            // 
            this.txtNadador.AcceptsReturn = true;
            this.txtNadador.Location = new System.Drawing.Point(125, 40);
            this.txtNadador.Name = "txtNadador";
            this.txtNadador.Size = new System.Drawing.Size(100, 20);
            this.txtNadador.TabIndex = 71;
            // 
            // Especialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(428, 428);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.GrillaEspecialidad);
            this.Controls.Add(this.txtNadador);
            this.Controls.Add(this.label1);
            this.Name = "Especialidad";
            this.Text = "Especialidad";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEspecialidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrillaEspecialidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNadador;
    }
}