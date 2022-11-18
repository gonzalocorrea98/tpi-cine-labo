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
    public partial class frmTop5Agosto : Form
    {
        public frmTop5Agosto()
        {
            InitializeComponent();
        }

        private void frmTop5Agosto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtTo5VendidasAgosto' Puede moverla o quitarla según sea necesario.
            this.dtTo5VendidasAgostoTableAdapter.Fill(this.dsCine.dtTo5VendidasAgosto);

            this.reportViewer1.RefreshReport();
        }
    }
}
