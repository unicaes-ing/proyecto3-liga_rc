using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Opcion1_Click(object sender, EventArgs e)
        {
            clases.opcion1 opcion1 = new clases.opcion1();
            opcion1.Show();
        }

        private void Opcion9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Opcion2_Click(object sender, EventArgs e)
        {
            clases.opcion2 opcion2 = new clases.opcion2();
            opcion2.Show();
        }

        private void Opcion3_Click(object sender, EventArgs e)
        {
            clases.opcion3 opcion3 = new clases.opcion3();
            opcion3.Show();
        }

        private void Opcion4_Click(object sender, EventArgs e)
        {
            clases.opcion4 opcion4 = new clases.opcion4();
            opcion4.Show();
        }

        private void Opcion5_Click(object sender, EventArgs e)
        {
            clases.opcion5 opcion5 = new clases.opcion5();
            opcion5.Show();
        }

        private void Opcion6_Click(object sender, EventArgs e)
        {
            clases.opcion6 opcion6 = new clases.opcion6();
            opcion6.Show();
        }

        private void Opcion7_Click(object sender, EventArgs e)
        {
            clases.opcion7 opcion7 = new clases.opcion7();
            opcion7.Show();
        }

        private void Opcion8_Click(object sender, EventArgs e)
        {
            clases.opcion8 opcion8 = new clases.opcion8();
            opcion8.Show();
        }
    }
}
