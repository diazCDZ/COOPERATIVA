using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coperativa_Presentacion_CarlosDIAZ
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersona formulario = new frmPersona ();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void coperativaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
