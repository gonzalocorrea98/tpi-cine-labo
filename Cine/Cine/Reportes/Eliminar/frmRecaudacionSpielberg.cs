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
    public partial class frmRecaudacionSpielberg : Form
    {
        public frmRecaudacionSpielberg()
        {
            InitializeComponent();
        }

        private void frmRecaudacionSpielberg_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtRecaudacionSpielberg' Puede moverla o quitarla según sea necesario.
            this.dtRecaudacionSpielbergTableAdapter.Fill(this.dsCine.dtRecaudacionSpielberg);

            this.reportViewer1.RefreshReport();
        }
    }
}
