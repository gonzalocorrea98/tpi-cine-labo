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
    public partial class frmVentaOnline : Form
    {
        public frmVentaOnline()
        {
            InitializeComponent();
        }

        private void frmVentaOnline_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtVentaOnline' Puede moverla o quitarla según sea necesario.
            this.dtVentaOnlineTableAdapter.Fill(this.dsCine.dtVentaOnline);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
