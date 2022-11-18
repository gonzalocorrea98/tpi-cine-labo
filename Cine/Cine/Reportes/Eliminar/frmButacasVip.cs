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
    public partial class frmButacasVip : Form
    {
        public frmButacasVip()
        {
            InitializeComponent();
        }

        private void frmButacasVip_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dsButacasVip' Puede moverla o quitarla según sea necesario.
            this.dsButacasVipTableAdapter.Fill(this.dsCine.dsButacasVip);

            this.reportViewer1.RefreshReport();
        }
    }
}
