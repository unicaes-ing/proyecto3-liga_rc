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
    public partial class opcion4 : Form
    {
        int resul;
        FileStream fs = null;
        BinaryWriter bw = null;
        BinaryReader br = null;
        public opcion4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("resultados.dat", FileMode.Append, FileAccess.Write);
                bw = new BinaryWriter(fs);
                string re1 = textBox1.Text;
                string re2 = textBox2.Text;
                bw.Write(re1);
                bw.Write(re2);
                MessageBox.Show("Los datos fueron agregados ");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                textBox2.Focus();
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

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
