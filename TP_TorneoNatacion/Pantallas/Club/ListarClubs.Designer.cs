namespace TP_TorneoNatacion.Pantallas
{
    partial class ListarClubs
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
            this.label5 = new System.Windows.Forms.Label();
            this.GrillaClub = new System.Windows.Forms.DataGridView();
            this.buscarTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClub)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(48, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 42);
            this.label5.TabIndex = 55;
            this.label5.Text = "Listado de Clubes";
            // 
            // GrillaClub
            // 
            this.GrillaClub.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.GrillaClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaClub.Location = new System.Drawing.Point(78, 103);
            this.GrillaClub.Name = "GrillaClub";
            this.GrillaClub.RowHeadersVisible = false;
            this.GrillaClub.RowHeadersWidth = 110;
            this.GrillaClub.Size = new System.Drawing.Size(629, 260);
            this.GrillaClub.TabIndex = 61;
            // 
            // buscarTXT
            // 
            this.buscarTXT.Location = new System.Drawing.Point(543, 62);
            this.buscarTXT.Name = "buscarTXT";
            this.buscarTXT.Size = new System.Drawing.Size(117, 20);
            this.buscarTXT.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nombre:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(677, 379);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_Eliminar.TabIndex = 64;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(585, 379);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 65;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(677, 58);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 66;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ListarClubs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.GrillaClub);
            this.Controls.Add(this.buscarTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "ListarClubs";
            this.Text = "ListarClubs";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView GrillaClub;
        private System.Windows.Forms.TextBox buscarTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBuscar;
    }
}