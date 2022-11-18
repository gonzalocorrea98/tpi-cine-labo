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
    public partial class frmRecurrentes : Form
    {
        public frmRecurrentes()
        {
            InitializeComponent();
        }

        private void ReporteRecurrentes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtRecurrentes' Puede moverla o quitarla según sea necesario.
            this.dtRecurrentesTableAdapter.Fill(this.dsCine.dtRecurrentes);

            this.reportViewer1.RefreshReport();
        }
    }
}
