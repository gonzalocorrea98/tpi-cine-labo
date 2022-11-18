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
    public partial class frmClientesAgosto : Form
    {
        public frmClientesAgosto()
        {
            InitializeComponent();
        }

        private void frmClientesAgosto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtClientesAgosto' Puede moverla o quitarla según sea necesario.
            this.dtClientesAgostoTableAdapter.Fill(this.dsCine.dtClientesAgosto);

            this.reportViewer1.RefreshReport();
        }
    }
}
