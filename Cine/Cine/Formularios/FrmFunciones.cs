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
    public partial class FrmFunciones : Form
    {
        public FrmFunciones()
        {
            InitializeComponent();
            
        }


        private void EsconderReportes()
        {
            rptFunciones.Hide();
            rptTop5Agosto.Hide();
        }



        private void FrmFunciones_Load(object sender, EventArgs e)
        {
            rptFunciones.Show();
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtTodasLasFunciones' Puede moverla o quitarla según sea necesario.
            this.dtTodasLasFuncionesTableAdapter.Fill(this.dsCine.dtTodasLasFunciones);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtTo5VendidasAgosto' Puede moverla o quitarla según sea necesario.
            this.dtTo5VendidasAgostoTableAdapter.Fill(this.dsCine.dtTo5VendidasAgosto);

            this.rptTop5Agosto.RefreshReport();
            this.rptFunciones.RefreshReport();
        }

        private void btnDescuentoTarjeta_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptTop5Agosto.Show();
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

        private void FrmFunciones_MouseDown(object sender, MouseEventArgs e)
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

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptFunciones.Show();
        }
    }
}
