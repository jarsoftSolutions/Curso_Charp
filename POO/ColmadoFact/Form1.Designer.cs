namespace ColmadoFact
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.colTextBox1 = new ColmadoFact.MyControls.Editors.ColTextBox(this.components);
            this.colTextBox2 = new ColmadoFact.MyControls.Editors.ColTextBox(this.components);
            this.colTextBox3 = new ColmadoFact.MyControls.Editors.ColTextBox(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir1 = new ColmadoFact.MyControls.UI.BtnSalir(this.components);
            this.btnGrabar1 = new ColmadoFact.MyControls.UI.BtnGrabar(this.components);
            this.btnNuevo1 = new ColmadoFact.MyControls.UI.BtnNuevo(this.components);
            this.baseCheckBox1 = new ColmadoFact.MyControls.UI.BaseCheckBox(this.components);
            this.SuspendLayout();
            // 
            // colTextBox1
            // 
            this.colTextBox1.ControlSource = null;
            this.colTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.colTextBox1.Formulario = this;
            this.colTextBox1.Location = new System.Drawing.Point(148, 130);
            this.colTextBox1.Name = "colTextBox1";
            this.colTextBox1.NextControlOnKeyEnter = true;
            this.colTextBox1.NullText = "Hola Mundo";
            this.colTextBox1.Requiered = false;
            this.colTextBox1.Size = new System.Drawing.Size(235, 22);
            this.colTextBox1.TabIndex = 2;
            this.colTextBox1.Text = "Hola Mundo";
            this.colTextBox1.UsertDigited = false;
            // 
            // colTextBox2
            // 
            this.colTextBox2.ControlSource = null;
            this.colTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.colTextBox2.Formulario = this;
            this.colTextBox2.Location = new System.Drawing.Point(148, 159);
            this.colTextBox2.Name = "colTextBox2";
            this.colTextBox2.NextControlOnKeyEnter = true;
            this.colTextBox2.NullText = null;
            this.colTextBox2.Requiered = false;
            this.colTextBox2.Size = new System.Drawing.Size(235, 22);
            this.colTextBox2.TabIndex = 1;
            this.colTextBox2.UsertDigited = false;
            // 
            // colTextBox3
            // 
            this.colTextBox3.ControlSource = null;
            this.colTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(157)))), ((int)(((byte)(155)))));
            this.colTextBox3.Formulario = this;
            this.colTextBox3.Location = new System.Drawing.Point(148, 198);
            this.colTextBox3.Name = "colTextBox3";
            this.colTextBox3.NextControlOnKeyEnter = true;
            this.colTextBox3.NullText = null;
            this.colTextBox3.Requiered = false;
            this.colTextBox3.Size = new System.Drawing.Size(235, 22);
            this.colTextBox3.TabIndex = 0;
            this.colTextBox3.UsertDigited = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir1
            // 
            this.btnSalir1.Formulario = null;
            this.btnSalir1.Location = new System.Drawing.Point(495, 200);
            this.btnSalir1.Name = "btnSalir1";
            this.btnSalir1.PuedeSeguir = false;
            this.btnSalir1.Size = new System.Drawing.Size(119, 32);
            this.btnSalir1.TabIndex = 4;
            this.btnSalir1.Text = "Salir";
            this.btnSalir1.UseVisualStyleBackColor = true;
            // 
            // btnGrabar1
            // 
            this.btnGrabar1.Formulario = null;
            this.btnGrabar1.Location = new System.Drawing.Point(342, 294);
            this.btnGrabar1.Name = "btnGrabar1";
            this.btnGrabar1.PuedeSeguir = false;
            this.btnGrabar1.Size = new System.Drawing.Size(135, 39);
            this.btnGrabar1.TabIndex = 5;
            this.btnGrabar1.Text = "btnGrabar1";
            this.btnGrabar1.UseVisualStyleBackColor = true;
            // 
            // btnNuevo1
            // 
            this.btnNuevo1.Formulario = null;
            this.btnNuevo1.Location = new System.Drawing.Point(160, 284);
            this.btnNuevo1.Name = "btnNuevo1";
            this.btnNuevo1.PuedeSeguir = false;
            this.btnNuevo1.Size = new System.Drawing.Size(113, 35);
            this.btnNuevo1.TabIndex = 6;
            this.btnNuevo1.Text = "btnNuevo1";
            this.btnNuevo1.UseVisualStyleBackColor = true;
            // 
            // baseCheckBox1
            // 
            this.baseCheckBox1.AutoSize = true;
            this.baseCheckBox1.Location = new System.Drawing.Point(148, 90);
            this.baseCheckBox1.Name = "baseCheckBox1";
            this.baseCheckBox1.Size = new System.Drawing.Size(131, 21);
            this.baseCheckBox1.TabIndex = 7;
            this.baseCheckBox1.Text = "baseCheckBox1";
            this.baseCheckBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.baseCheckBox1);
            this.Controls.Add(this.btnNuevo1);
            this.Controls.Add(this.btnGrabar1);
            this.Controls.Add(this.btnSalir1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colTextBox3);
            this.Controls.Add(this.colTextBox2);
            this.Controls.Add(this.colTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.Editors.ColTextBox colTextBox1;
        private MyControls.Editors.ColTextBox colTextBox3;
        private MyControls.Editors.ColTextBox colTextBox2;
        private System.Windows.Forms.Button button1;
        private MyControls.UI.BtnSalir btnSalir1;
        private MyControls.UI.BtnGrabar btnGrabar1;
        private MyControls.UI.BtnNuevo btnNuevo1;
        private MyControls.UI.BaseCheckBox baseCheckBox1;
    }
}

