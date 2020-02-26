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
    public partial class Form1 : Form
    {
        
        ConsultaDvd consultaDvd = new ConsultaDvd();
        HistorialDeVentas historialDeVentas = new HistorialDeVentas();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultaDvd_Click(object sender, EventArgs e)
        {
            consultaDvd.Show();
            this.Hide();
        }

        private void btnHistorialVentas_Click(object sender, EventArgs e)
        {
            historialDeVentas.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
