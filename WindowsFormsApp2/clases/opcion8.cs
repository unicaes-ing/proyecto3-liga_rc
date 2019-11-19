using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.clases
{
    public partial class opcion8 : Form
    {
        public opcion8()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Eliminaron los resultados");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
