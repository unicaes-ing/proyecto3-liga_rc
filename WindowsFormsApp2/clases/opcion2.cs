using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2.clases
{
    public partial class opcion2 : Form
    {
        string jugador;
        string pos;
        int goles;
        FileStream fs = null;
        BinaryWriter bw = null;
        BinaryReader br = null;
        public opcion2()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string jugador = textBox1.Text;
            string pos = textBox2.Text;
            int goles = int.Parse(textBox3.Text);
            dataGridView1.Rows.Add(jugador, pos, goles);
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("jugadores.dat", FileMode.Append, FileAccess.Write);
                bw = new BinaryWriter(fs);
                string equipos = textBox1.Text;
                string pos =textBox2.Text;
                goles = Convert.ToInt32(textBox3.Text);
                dataGridView1.Rows.Add(equipos,pos,goles);
                dataGridView1.ClearSelection();
                bw.Write(equipos);
                MessageBox.Show("Los datos fueron almacenados ");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                textBox2.Focus();
                textBox3.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese correctamente los datos");
            }
            finally
            {
                if (bw != null) bw.Close();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
