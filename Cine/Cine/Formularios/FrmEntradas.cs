using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine.Formularios
{
    public partial class FrmEntradas : Form
    {
        public FrmEntradas()
        {
            InitializeComponent();
            EsconderReportes();
        }

        private void EsconderReportes()
        {
            rptDescuentoTarjeta.Hide();
            rptVentaOnline.Hide();
            rptVentaPorRango.Hide();
            rptEntradas.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmEntradas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtTodasLasEntradas' Puede moverla o quitarla según sea necesario.
            this.dtTodasLasEntradasTableAdapter.Fill(this.dsCine.dtTodasLasEntradas);
            rptEntradas.Show();

            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtVentasxRango' Puede moverla o quitarla según sea necesario.
            this.dtVentasxRangoTableAdapter.Fill(this.dsCine.dtVentasxRango);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtVentaOnline' Puede moverla o quitarla según sea necesario.
            this.dtVentaOnlineTableAdapter.Fill(this.dsCine.dtVentaOnline);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dsDescuentoTarjeta' Puede moverla o quitarla según sea necesario.
            this.dsDescuentoTarjetaTableAdapter.Fill(this.dsCine.dsDescuentoTarjeta);

            this.rptDescuentoTarjeta.RefreshReport();
            this.rptVentaOnline.RefreshReport();
            this.rptVentaPorRango.RefreshReport();
            this.rptEntradas.RefreshReport();
        }

        private void btnDescuentoTarjeta_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptDescuentoTarjeta.Show();
        }

        private void btnVentaOnline_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptVentaOnline.Show();
        }

        private void btnVentaPorRango_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptVentaPorRango.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmHome = new frmHome();
            frmHome.ShowDialog();
            
        }

        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmEntradas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEntradas_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptEntradas.Show();
        }
    }
}
