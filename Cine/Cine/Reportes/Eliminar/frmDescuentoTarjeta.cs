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
    public partial class frmDescuentoTarjeta : Form
    {
        public frmDescuentoTarjeta()
        {
            InitializeComponent();
        }

        private void frmDescuentoTarjeta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dsDescuentoTarjeta' Puede moverla o quitarla según sea necesario.
            this.dsDescuentoTarjetaTableAdapter.Fill(this.dsCine.dsDescuentoTarjeta);

            this.reportViewer1.RefreshReport();
        }
    }
}
