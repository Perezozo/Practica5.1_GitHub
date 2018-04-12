namespace JDPEREA_PracticaGithub
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
            this.button1 = new System.Windows.Forms.Button();
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.aluNota = new System.Windows.Forms.TextBox();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar Alumno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(23, 73);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(217, 22);
            this.aluNombre.TabIndex = 1;
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(246, 74);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(55, 22);
            this.aluNota.TabIndex = 2;
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(48, 132);
            this.listaAlumnos.Multiline = true;
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(316, 249);
            this.listaAlumnos.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 425);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.aluNombre);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Practica GitHub JDPerea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.TextBox aluNota;
        private System.Windows.Forms.TextBox listaAlumnos;
    }
}

