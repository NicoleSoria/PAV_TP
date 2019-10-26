namespace TP_TorneoNatacion.Pantallas
{
    partial class AñadirClub
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
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(419, 173);
            this.txtAltura.Mask = "9999";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(95, 20);
            this.txtAltura.TabIndex = 22;
            this.txtAltura.ValidatingType = typeof(int);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(234, 242);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(130, 58);
            this.btnAñadir.TabIndex = 24;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(44, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 42);
            this.label5.TabIndex = 26;
            this.label5.Text = "Añadir Club";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(125, 171);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(143, 20);
            this.txtCalle.TabIndex = 20;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 19;
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(337, 173);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(62, 20);
            this.numero.TabIndex = 25;
            this.numero.Text = "Altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Calle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre:";
            // 
            // AñadirClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(577, 385);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AñadirClub";
            this.Text = "AñadirClub";
            this.Load += new System.EventHandler(this.AñadirClub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}