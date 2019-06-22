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
            this.components = new System.ComponentModel.Container();
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
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ControlErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DtListado = new System.Windows.Forms.DataGridView();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ControlErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(160, 30);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(338, 27);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.Location = new System.Drawing.Point(160, 63);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(338, 27);
            this.TxtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Apellido:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(160, 123);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(96, 27);
            this.txtEdad.TabIndex = 5;
            this.txtEdad.Text = "0";
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 186);
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
            this.CboEstadoCivil.Location = new System.Drawing.Point(159, 152);
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
            this.CoboColor.Location = new System.Drawing.Point(160, 185);
            this.CoboColor.Name = "CoboColor";
            this.CoboColor.Size = new System.Drawing.Size(205, 28);
            this.CoboColor.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(154, 253);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 39);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(273, 253);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(135, 39);
            this.BtnGuardar.TabIndex = 10;
            this.BtnGuardar.Text = "&Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkActivo.Location = new System.Drawing.Point(159, 219);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(124, 28);
            this.chkActivo.TabIndex = 12;
            this.chkActivo.Text = "Esta Activo";
            this.toolTip1.SetToolTip(this.chkActivo, "Seleccionar La Opcion para activar la persona");
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Fecha. Nac.";
            // 
            // TxtFechaNac
            // 
            this.TxtFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TxtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtFechaNac.Location = new System.Drawing.Point(160, 93);
            this.TxtFechaNac.Name = "TxtFechaNac";
            this.TxtFechaNac.Size = new System.Drawing.Size(197, 27);
            this.TxtFechaNac.TabIndex = 14;
            this.TxtFechaNac.ValueChanged += new System.EventHandler(this.TxtFechaNac_ValueChanged);
            // 
            // ControlErrores
            // 
            this.ControlErrores.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(496, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(496, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "*";
            // 
            // DtListado
            // 
            this.DtListado.AllowUserToAddRows = false;
            this.DtListado.AllowUserToDeleteRows = false;
            this.DtListado.AllowUserToOrderColumns = true;
            this.DtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.DtListado.Location = new System.Drawing.Point(12, 335);
            this.DtListado.Name = "DtListado";
            this.DtListado.ReadOnly = true;
            this.DtListado.RowTemplate.Height = 24;
            this.DtListado.Size = new System.Drawing.Size(610, 202);
            this.DtListado.TabIndex = 17;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.TxtBuscar.Location = new System.Drawing.Point(12, 307);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(271, 27);
            this.TxtBuscar.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Cliente";
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Activo";
            this.Column4.FalseValue = "";
            this.Column4.HeaderText = "Activo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.TrueValue = "";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FechaNacimiento";
            this.Column2.HeaderText = "F Nac.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "EstadoCivil";
            this.Column3.HeaderText = "Estado C.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 549);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.DtListado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtFechaNac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkActivo);
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
            this.Load += new System.EventHandler(this.FrmPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ControlErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtListado)).EndInit();
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
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker TxtFechaNac;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider ControlErrores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView DtListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}