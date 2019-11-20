using FarmaciaOASIS.Controladores;
using FarmaciaOASIS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FarmaciaOASIS.Vistas
{
    public partial class frmLogin : Form
    {
        UsuarioController _User = new UsuarioController();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogAceptar_Click(object sender, EventArgs e)
        {
            if (_User.Autenticar(txtuser.Text, txtpass.Text))
            {
                //var reg = (Usuario)usuarioBindingSource.Current;
                //usuarioBindingSource.DataSource = _User.ObtenerIDUsuario(txtuser.Text, txtpass.Text);
                this.Hide();
                FormMenuPrincipal frm = new FormMenuPrincipal(txtuser.Text, txtpass.Text);
                frm.ShowDialog();


            }
            else
                MessageBox.Show("NO OK");
        }
    }
}
