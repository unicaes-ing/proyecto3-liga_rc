namespace WindowsFormsApp2.clases
{
    partial class opcion5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equip2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equip3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equip4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equip5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de resultados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.equip2,
            this.equip3,
            this.equip4,
            this.equip5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 171);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Regresar a Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Equipo 1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // equip2
            // 
            this.equip2.HeaderText = "equipo 2";
            this.equip2.MinimumWidth = 8;
            this.equip2.Name = "equip2";
            this.equip2.Width = 150;
            // 
            // equip3
            // 
            this.equip3.HeaderText = "equipo 3";
            this.equip3.MinimumWidth = 8;
            this.equip3.Name = "equip3";
            this.equip3.Width = 150;
            // 
            // equip4
            // 
            this.equip4.HeaderText = "equipo 4";
            this.equip4.MinimumWidth = 8;
            this.equip4.Name = "equip4";
            this.equip4.Width = 150;
            // 
            // equip5
            // 
            this.equip5.HeaderText = "equipo 5";
            this.equip5.MinimumWidth = 8;
            this.equip5.Name = "equip5";
            this.equip5.Width = 150;
            // 
            // opcion5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "opcion5";
            this.Text = "opcion5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn equip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn equip3;
        private System.Windows.Forms.DataGridViewTextBoxColumn equip4;
        private System.Windows.Forms.DataGridViewTextBoxColumn equip5;
    }
}