namespace TP_TorneoNatacion.Pantallas.Nadador
{
    partial class Nadador
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
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(58, 81);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(138, 128);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar nadadores";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(245, 81);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(144, 128);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir nuevo nadador";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // Nadador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(460, 278);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnListar);
            this.Name = "Nadador";
            this.Text = "Nadador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAñadir;
    }
}