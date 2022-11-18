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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
            EsconderReportes();
        }
    

        private void EsconderReportes()
        {
            rptFrecuentes.Hide();
            rptClientesAgosto.Hide();
            rptTodos.Hide();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            rptTodos.Show();

            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtClientesAgosto' Puede moverla o quitarla según sea necesario.
            this.dtClientesAgostoTableAdapter.Fill(this.dsCine.dtClientesAgosto);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtTodosLosClientes' Puede moverla o quitarla según sea necesario.
            this.dtTodosLosClientesTableAdapter.Fill(this.dsCine.dtTodosLosClientes);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtClientesAgosto' Puede moverla o quitarla según sea necesario.
            this.dtClientesAgostoTableAdapter.Fill(this.dsCine.dtClientesAgosto);
            // TODO: esta línea de código carga datos en la tabla 'dsCine.dtRecurrentes' Puede moverla o quitarla según sea necesario.
            this.dtRecurrentesTableAdapter.Fill(this.dsCine.dtRecurrentes);
            this.rptFrecuentes.RefreshReport();
            this.rptClientesAgosto.RefreshReport();
            this.rptTodos.RefreshReport();
            this.rptClientesAgosto.RefreshReport();
            
        }


        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        //Vuelve al Home
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptTodos.Show();
        }

        private void btnFrecuentes_Click(object sender, EventArgs e)
        {
           
            EsconderReportes();
            rptFrecuentes.Show();

        }

        private void btnDeAgosto_Click(object sender, EventArgs e)
        {
            EsconderReportes();
            rptClientesAgosto.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome frmHome = new frmHome();
            frmHome.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
