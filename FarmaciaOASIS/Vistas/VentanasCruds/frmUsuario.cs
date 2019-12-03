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
            try
            {
                var reg = CargarDatos();
                if (_esNuevo)
                {
                    if (_objUsuario.Insertar(reg) && _objUsuario.VerificarUsuarioRepetido(ciTextBox.Text) == true)
                    {
                        MessageBox.Show("USUARIO REGISTRADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    { MessageBox.Show("YA EXISTE UN USUARIO CON CI: '" + reg.Ci + "'", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

                }
                else
                {
                    if (_objUsuario.Modificar(reg))
                    {
                        MessageBox.Show("USUARIO MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void CelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
