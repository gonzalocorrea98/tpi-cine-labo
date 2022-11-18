using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.Reportes
{
    public partial class frmClasificacionesMasVistas : Form
    {
        public frmClasificacionesMasVistas()
        {
            InitializeComponent();
        }

        private void frmClasificacionesMasVistas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtClasificaiconesMasVistas' Puede moverla o quitarla según sea necesario.
            this.dtClasificaiconesMasVistasTableAdapter.Fill(this.dsCine.dtClasificaiconesMasVistas);

            this.reportViewer1.RefreshReport();
        }
    }
}
