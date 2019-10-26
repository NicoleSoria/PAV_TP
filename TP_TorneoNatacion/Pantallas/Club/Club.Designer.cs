namespace TP_TorneoNatacion.Pantallas
{
    partial class Club
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
            this.btnListar.Location = new System.Drawing.Point(101, 63);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(161, 137);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar clubs";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(327, 63);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(162, 137);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Añadir club";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // Club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(583, 300);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnListar);
            this.Name = "Club";
            this.Text = "Club";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAñadir;
    }
}