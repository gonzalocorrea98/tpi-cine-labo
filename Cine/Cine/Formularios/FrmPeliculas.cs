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
    public partial class FrmPeliculas : Form
    {
        public FrmPeliculas()
        {
            InitializeComponent();
            EsconderReportes();
        }

        private void EsconderReportes()
        {
            rptMasVistas.Hide();
            rptSpielberg.Hide();
            rptPeliculas.Hide();
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            rptPeliculas.Show();

            // TODO: esta línea de código carga datos en la tabla 'dsCine.dsTodasLasPeliculas' Puede moverla o quitarla según sea necesario.
            this.dsTodasLasPeliculasTableAdapter.Fill(this.dsCine.dsTodasLasPeliculas);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtRecaudacionSpielberg' Puede moverla o quitarla según sea necesario.
            this.dtRecaudacionSpielbergTableAdapter.Fill(this.dsCine.dtRecaudacionSpielberg);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtClasificaiconesMasVistas' Puede moverla o quitarla según sea necesario.
            this.dtClasificaiconesMasVistasTableAdapter.Fill(this.dsCine.dtClasificaiconesMasVistas);

            this.rptMasVistas.RefreshReport();
            this.rptSpielberg.RefreshReport();
            this.rptPeliculas.RefreshReport();
        }

        private void btnMasVistas_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptMasVistas.Show();
        }

        private void btnSpielberg_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptSpielberg.Show();
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

        private void FrmPeliculas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptPeliculas.Show();
        }
    }
}
