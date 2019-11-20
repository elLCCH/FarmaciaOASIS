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

namespace FarmaciaOASIS.Vistas.VentanasCruds
{
    public partial class frmUsuario : frmVentanaDatos
    {
        UsuarioController _objUsuario = new UsuarioController();
        private string _cuenta;
        private bool _esNuevo;
        public frmUsuario()
        {
            _esNuevo = true;
            InitializeComponent();

        }
        public frmUsuario(string pCuenta)
        {
            _cuenta = pCuenta;
            _esNuevo = false;
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
            {
                usuarioBindingSource.AddNew();
                label1.Text = "REGISTRAR USUARIO";
            }
            else
            {
                usuarioBindingSource.DataSource = _objUsuario.BuscarPorPK(_cuenta);
                label1.Text = "MODIFICAR USUARIO";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var reg = CargarDatos();
            if (_esNuevo)
            {
                if (_objUsuario.Insertar(reg))
                {
                    MessageBox.Show("se inserto correctamente");
                    Close();
                }
            }
            else
            {
                if (_objUsuario.Modificar(reg))
                {
                    MessageBox.Show("modificacion exitosa");
                    Close();
                }
            }
        }

        private Usuario CargarDatos()
        {
            var reg = (Usuario)usuarioBindingSource.Current;
            //reg.FechaNac = DateTime.Now;
            return reg;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
