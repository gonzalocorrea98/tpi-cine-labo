using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.Formularios
{
    public partial class frmSugerenciasMejoras : Form
    {
        public frmSugerenciasMejoras()
        {
            InitializeComponent();
        }

        private void SugerenciasMejoras_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            txtSugerencia.Text = "";
            lblGracias.Visible = true;
        }

        
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
