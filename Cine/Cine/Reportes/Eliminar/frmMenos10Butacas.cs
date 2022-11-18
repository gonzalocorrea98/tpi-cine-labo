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
    public partial class frmMenos10Butacas : Form
    {
        public frmMenos10Butacas()
        {
            InitializeComponent();
        }

        private void frmMenos10Butacas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtMenos10Butacas' Puede moverla o quitarla según sea necesario.
            this.dtMenos10ButacasTableAdapter.Fill(this.dsCine.dtMenos10Butacas);

            this.reportViewer1.RefreshReport();
        }
    }
}
