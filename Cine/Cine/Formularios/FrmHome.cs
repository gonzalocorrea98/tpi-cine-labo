using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Cine.Reportes;
using Cine.Formularios;

namespace Cine
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel12_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //Cierra la aplicacion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Sale al Login
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Abre Form Mejoras
        private void btnMejoras_Click(object sender, EventArgs e)
        {   
            frmSugerenciasMejoras mejoras = new frmSugerenciasMejoras();
            mejoras.Show();
        }


        //******************* BOTONES ********************
        private void btnEntradas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.FrmEntradas form = new Formularios.FrmEntradas();
            form.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.FrmClientes form = new Formularios.FrmClientes();
            form.ShowDialog();

        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.FrmFunciones form = new Formularios.FrmFunciones();
            form.ShowDialog();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.FrmPeliculas form = new Formularios.FrmPeliculas();
            form.ShowDialog();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formularios.FrmSalas form = new Formularios.FrmSalas();
            form.ShowDialog();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
