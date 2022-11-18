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
    public partial class frmVentaxRango : Form
    {
        public frmVentaxRango()
        {
            InitializeComponent();
        }

        private void frmVentaxRango_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtVentasxRango' Puede moverla o quitarla según sea necesario.
            this.dtVentasxRangoTableAdapter.Fill(this.dsCine.dtVentasxRango);

            this.reportViewer1.RefreshReport();
        }
    }
}
