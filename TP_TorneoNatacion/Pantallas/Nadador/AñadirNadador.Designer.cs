namespace TP_TorneoNatacion.Pantallas.Nadador
{
    partial class AñadirNadador
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
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClub = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(267, 271);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(130, 58);
            this.btnAñadir.TabIndex = 32;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(37, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 42);
            this.label5.TabIndex = 34;
            this.label5.Text = "Añadir Nadador";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(171, 202);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(143, 20);
            this.txtDoc.TabIndex = 28;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(171, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(143, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(419, 118);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(45, 20);
            this.numero.TabIndex = 33;
            this.numero.Text = "Club";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "N° documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre y Apellido";
            // 
            // txtClub
            // 
            this.txtClub.Location = new System.Drawing.Point(474, 120);
            this.txtClub.Name = "txtClub";
            this.txtClub.Size = new System.Drawing.Size(123, 20);
            this.txtClub.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tipo Documento";
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(172, 158);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.comboTipoDoc.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Profesor";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(474, 160);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(123, 20);
            this.txtProfesor.TabIndex = 39;
            // 
            // AñadirNadador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(629, 359);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTipoDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClub);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AñadirNadador";
            this.Text = "AñadirNadador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClub;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfesor;
    }
}