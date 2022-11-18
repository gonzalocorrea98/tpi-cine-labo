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
    public partial class FrmSalas : Form
    {
        public FrmSalas()
        {
            InitializeComponent();
            EsconderReportes();
        }

        private void EsconderReportes()
        {
            rptButacasVip.Hide();
            rptMenosDe10.Hide();
            rptSalas.Hide();
        }

        private void FrmSalas_Load(object sender, EventArgs e)
        {
            rptSalas.Show();

            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtTodasLasSalas' Puede moverla o quitarla según sea necesario.
            this.dtTodasLasSalasTableAdapter.Fill(this.dsCine.dtTodasLasSalas);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtMenos10Butacas' Puede moverla o quitarla según sea necesario.
            this.dtMenos10ButacasTableAdapter.Fill(this.dsCine.dtMenos10Butacas);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dsButacasVip' Puede moverla o quitarla según sea necesario.
            this.dsButacasVipTableAdapter.Fill(this.dsCine.dsButacasVip);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dsDescuentoTarjeta' Puede moverla o quitarla según sea necesario.
            this.dsDescuentoTarjetaTableAdapter.Fill(this.dsCine.dsDescuentoTarjeta);

            this.rptButacasVip.RefreshReport();
            this.rptMenosDe10.RefreshReport();
            this.rptSalas.RefreshReport();
        }

        private void btnMenosDe10_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptMenosDe10.Show();
        }

        private void btnButacasVip_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptButacasVip.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void FrmSalas_MouseDown(object sender, MouseEventArgs e)
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

        private void btnSalas_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptSalas.Show();
        }
    }
}
