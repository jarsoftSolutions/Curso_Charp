namespace Presentacion.Mantenimientos
{
    partial class FrmPersona
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.CoboColor = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(160, 36);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(338, 27);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(160, 69);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(338, 27);
            this.TxtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Apellido:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(160, 102);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(96, 27);
            this.txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color Pelo";
            // 
            // CboEstadoCivil
            // 
            this.CboEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstadoCivil.FormattingEnabled = true;
            this.CboEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Peliando",
            "Union Libre"});
            this.CboEstadoCivil.Location = new System.Drawing.Point(159, 135);
            this.CboEstadoCivil.Name = "CboEstadoCivil";
            this.CboEstadoCivil.Size = new System.Drawing.Size(205, 28);
            this.CboEstadoCivil.TabIndex = 7;
            // 
            // CoboColor
            // 
            this.CoboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoboColor.FormattingEnabled = true;
            this.CoboColor.Items.AddRange(new object[] {
            "Negro",
            "Castano",
            "Rojo"});
            this.CoboColor.Location = new System.Drawing.Point(160, 168);
            this.CoboColor.Name = "CoboColor";
            this.CoboColor.Size = new System.Drawing.Size(205, 28);
            this.CoboColor.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(160, 236);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 39);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(279, 236);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(135, 39);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 318);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.CoboColor);
            this.Controls.Add(this.CboEstadoCivil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmPersona";
            this.Text = "Mantemiento de Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CboEstadoCivil;
        private System.Windows.Forms.ComboBox CoboColor;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
    }
}