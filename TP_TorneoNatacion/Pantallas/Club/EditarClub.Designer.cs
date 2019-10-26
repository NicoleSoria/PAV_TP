namespace TP_TorneoNatacion.Pantallas
{
    partial class EditarClub
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(234, 127);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(68, 20);
            this.txt_id.TabIndex = 38;
            this.txt_id.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(225, 299);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 35);
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(67, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 42);
            this.label5.TabIndex = 46;
            this.label5.Text = "Editar Club";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(154, 228);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(148, 20);
            this.txtCalle.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(154, 178);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 39;
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(376, 226);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(62, 20);
            this.numero.TabIndex = 45;
            this.numero.Text = "Altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Calle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre:";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(458, 226);
            this.txtAltura.Mask = "9999";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 41;
            this.txtAltura.ValidatingType = typeof(int);
            // 
            // EditarClub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarClub";
            this.Text = "EditarClub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtAltura;
    }
}