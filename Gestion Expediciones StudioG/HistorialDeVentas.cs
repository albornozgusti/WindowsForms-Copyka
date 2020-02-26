using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Expediciones_StudioG
{
    public partial class HistorialDeVentas : Form
    {
        public HistorialDeVentas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HistorialDeVentas_Load(object sender, EventArgs e)
        {

        }

        private void HistorialDeVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

        }
    }
}
