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
    public partial class opcion3 : Form
    {
        string equipo;
        string jugador;
        FileStream fs = null;
        BinaryWriter bw = null;
        BinaryReader br = null;
        public opcion3()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("equipos.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                dataGridView1.Rows.Clear();
                while (true)
                {
                    equipo = br.ReadString();
                    jugador = br.ReadString();
                    dataGridView1.Rows.Add(equipo, jugador);
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                if (br != null) br.Close();
                dataGridView1.ClearSelection();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
