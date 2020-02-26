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
    public partial class ConsultaDvd : Form
    {
        public ConsultaDvd()
        {
            InitializeComponent();
        }

        private void ConsultaDvd_Load(object sender, EventArgs e)
        {

        }

        private void ConsultaDvd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
