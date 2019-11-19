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
    public partial class opcion1 : Form
    {
        List<string> lista;
        string jugador;
        FileStream fs = null;
        BinaryWriter bw = null;
        BinaryReader br = null;


        public opcion1()
        {
            InitializeComponent();
        }

        private void Opcion1_Load(object sender, EventArgs e)
        {
            lista = new List<string>();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("equipos.dat", FileMode.Append, FileAccess.Write);
                bw = new BinaryWriter(fs);
                string equipos = textBox1.Text;
                dataGridView1.Rows.Add(equipos);
                dataGridView1.ClearSelection();
                bw.Write(equipos);
                MessageBox.Show("Los datos fueron almacenados ");
                textBox1.Clear();
                textBox1.Focus();

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
            Console.ReadLine();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
        }
    }
}
