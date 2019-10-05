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
            this.SuspendLayout();
            // 
            // colTextBox1
            // 
            this.colTextBox1.ControlSource = null;
            this.colTextBox1.Formulario = this;
            this.colTextBox1.Location = new System.Drawing.Point(148, 130);
            this.colTextBox1.Name = "colTextBox1";
            this.colTextBox1.NextControlOnKeyEnter = true;
            this.colTextBox1.NullText = "Hola Mundo";
            this.colTextBox1.Requiered = false;
            this.colTextBox1.Size = new System.Drawing.Size(235, 22);
            this.colTextBox1.TabIndex = 2;
            // 
            // colTextBox2
            // 
            this.colTextBox2.ControlSource = null;
            this.colTextBox2.Formulario = this;
            this.colTextBox2.Location = new System.Drawing.Point(148, 159);
            this.colTextBox2.Name = "colTextBox2";
            this.colTextBox2.NextControlOnKeyEnter = true;
            this.colTextBox2.NullText = null;
            this.colTextBox2.Requiered = false;
            this.colTextBox2.Size = new System.Drawing.Size(235, 22);
            this.colTextBox2.TabIndex = 1;
            // 
            // colTextBox3
            // 
            this.colTextBox3.ControlSource = null;
            this.colTextBox3.Formulario = this;
            this.colTextBox3.Location = new System.Drawing.Point(148, 198);
            this.colTextBox3.Name = "colTextBox3";
            this.colTextBox3.NextControlOnKeyEnter = true;
            this.colTextBox3.NullText = null;
            this.colTextBox3.Requiered = false;
            this.colTextBox3.Size = new System.Drawing.Size(235, 22);
            this.colTextBox3.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

