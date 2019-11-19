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
    public partial class opcion5 : Form
    {
        int resul;
        string equi1, equi2;
        FileStream fs = null;
        BinaryWriter bw = null;
        BinaryReader br = null;
        public opcion5()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream("resultados.dat", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                dataGridView1.Rows.Clear();
                while (true)
                {
                    equi1 = br.ReadString();
                    equi2 = br.ReadString();
                    dataGridView1.Rows.Add(equi1,equi2);
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
    }
}
