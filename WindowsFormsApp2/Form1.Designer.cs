namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.opcion6 = new System.Windows.Forms.Button();
            this.opcion9 = new System.Windows.Forms.Button();
            this.opcion8 = new System.Windows.Forms.Button();
            this.opcion7 = new System.Windows.Forms.Button();
            this.opcion5 = new System.Windows.Forms.Button();
            this.opcion4 = new System.Windows.Forms.Button();
            this.opcion3 = new System.Windows.Forms.Button();
            this.opcion2 = new System.Windows.Forms.Button();
            this.opcion1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "SELECCIONE UNA OPCION:";
            // 
            // opcion6
            // 
            this.opcion6.Location = new System.Drawing.Point(265, 353);
            this.opcion6.Name = "opcion6";
            this.opcion6.Size = new System.Drawing.Size(269, 37);
            this.opcion6.TabIndex = 23;
            this.opcion6.Text = "Tabla de Posiciones";
            this.opcion6.UseVisualStyleBackColor = true;
            this.opcion6.Click += new System.EventHandler(this.Opcion6_Click);
            // 
            // opcion9
            // 
            this.opcion9.Location = new System.Drawing.Point(265, 520);
            this.opcion9.Name = "opcion9";
            this.opcion9.Size = new System.Drawing.Size(269, 37);
            this.opcion9.TabIndex = 22;
            this.opcion9.Text = "Salir";
            this.opcion9.UseVisualStyleBackColor = true;
            this.opcion9.Click += new System.EventHandler(this.Opcion9_Click);
            // 
            // opcion8
            // 
            this.opcion8.Location = new System.Drawing.Point(265, 464);
            this.opcion8.Name = "opcion8";
            this.opcion8.Size = new System.Drawing.Size(269, 37);
            this.opcion8.TabIndex = 21;
            this.opcion8.Text = "Restaurar Liga";
            this.opcion8.UseVisualStyleBackColor = true;
            this.opcion8.Click += new System.EventHandler(this.Opcion8_Click);
            // 
            // opcion7
            // 
            this.opcion7.Location = new System.Drawing.Point(265, 408);
            this.opcion7.Name = "opcion7";
            this.opcion7.Size = new System.Drawing.Size(269, 37);
            this.opcion7.TabIndex = 20;
            this.opcion7.Text = "Tabla de Goleadores";
            this.opcion7.UseVisualStyleBackColor = true;
            this.opcion7.Click += new System.EventHandler(this.Opcion7_Click);
            // 
            // opcion5
            // 
            this.opcion5.Location = new System.Drawing.Point(265, 296);
            this.opcion5.Name = "opcion5";
            this.opcion5.Size = new System.Drawing.Size(269, 37);
            this.opcion5.TabIndex = 19;
            this.opcion5.Text = "Tabla de Resultado";
            this.opcion5.UseVisualStyleBackColor = true;
            this.opcion5.Click += new System.EventHandler(this.Opcion5_Click);
            // 
            // opcion4
            // 
            this.opcion4.Location = new System.Drawing.Point(265, 244);
            this.opcion4.Name = "opcion4";
            this.opcion4.Size = new System.Drawing.Size(269, 37);
            this.opcion4.TabIndex = 18;
            this.opcion4.Text = "Ingresar Resultados";
            this.opcion4.UseVisualStyleBackColor = true;
            this.opcion4.Click += new System.EventHandler(this.Opcion4_Click);
            // 
            // opcion3
            // 
            this.opcion3.Location = new System.Drawing.Point(265, 187);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(269, 37);
            this.opcion3.TabIndex = 17;
            this.opcion3.Text = "Mostrar Liga";
            this.opcion3.UseVisualStyleBackColor = true;
            this.opcion3.Click += new System.EventHandler(this.Opcion3_Click);
            // 
            // opcion2
            // 
            this.opcion2.Location = new System.Drawing.Point(265, 135);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(269, 37);
            this.opcion2.TabIndex = 16;
            this.opcion2.Text = "Gestionar Jugadores";
            this.opcion2.UseVisualStyleBackColor = true;
            this.opcion2.Click += new System.EventHandler(this.Opcion2_Click);
            // 
            // opcion1
            // 
            this.opcion1.AccessibleName = "";
            this.opcion1.Location = new System.Drawing.Point(265, 75);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(269, 37);
            this.opcion1.TabIndex = 15;
            this.opcion1.Text = "Gestionar Equipos";
            this.opcion1.UseVisualStyleBackColor = true;
            this.opcion1.Click += new System.EventHandler(this.Opcion1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opcion6);
            this.Controls.Add(this.opcion9);
            this.Controls.Add(this.opcion8);
            this.Controls.Add(this.opcion7);
            this.Controls.Add(this.opcion5);
            this.Controls.Add(this.opcion4);
            this.Controls.Add(this.opcion3);
            this.Controls.Add(this.opcion2);
            this.Controls.Add(this.opcion1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button opcion6;
        private System.Windows.Forms.Button opcion9;
        private System.Windows.Forms.Button opcion8;
        private System.Windows.Forms.Button opcion7;
        private System.Windows.Forms.Button opcion5;
        private System.Windows.Forms.Button opcion4;
        private System.Windows.Forms.Button opcion3;
        private System.Windows.Forms.Button opcion2;
        private System.Windows.Forms.Button opcion1;
    }
}

