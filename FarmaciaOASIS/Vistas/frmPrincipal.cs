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

namespace FarmaciaOASIS.Vistas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            MenuAdministrador(150);
        }
        private void SituarBotones(int y)
        {
            //btnChofer.Location = new Point(3, y);
            //btnVehiculos.Location = new Point(3, y = y + 50);
            //btnCerrarSesion.Location = new Point(3, y = y + 50);
        }
        //abrir dentro de panel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Funcion que permite abrir un formulario dentro del panel
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(fh);
            this.PanelPrincipal.Tag = fh;
            fh.Show();
        }

        
        private void Pbxrecorrer_Click(object sender, EventArgs e)
        {
            if (PanelMenuVertical.Width == 250)
                PanelMenuVertical.Width = 70;
            else
                PanelMenuVertical.Width = 250;
        }
        private void MenuAdministrador(int y)
        {
            //btnChofer.Location = new Point(3, y);
            //btnVehiculos.Location = new Point(3, y = y + 50);
            //btnUsuarios.Location = new Point(3, y = y + 50);
            //btnCerrarSesion.Location = new Point(3, y = y + 50);

            //btnServicios.Visible = false;
            //btnPasajero.Visible = false;
            //PanelTipoPasajero.Visible = false;
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
    }
}
