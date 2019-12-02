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
    public partial class frmProveedor : frmVentanaDatos
    {
        ProveedorController _objProveedor = new ProveedorController();
        private string _cuenta;
        private bool _esNuevo;
        public frmProveedor()
        {
            _esNuevo = true;
            InitializeComponent();

        }
        public frmProveedor(string pCuenta)
        {
            _cuenta = pCuenta;
            _esNuevo = false;
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
            {
                proveedorBindingSource.AddNew();
                label1.Text = "REGISTRAR PROVEEDOR";
            }
            else
            {
                proveedorBindingSource.DataSource = _objProveedor.BuscarPorPK(Convert.ToInt32(_cuenta));
                label1.Text = "MODIFICAR PROVEEDOR";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var reg = CargarDatos();
            if (_esNuevo)
            {
                if (_objProveedor.Insertar(reg))
                {
                    MessageBox.Show("PROVEEDOR REGISTRADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                if (_objProveedor.Modificar(reg))
                {
                    MessageBox.Show("PROVEEDOR MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private Proveedor CargarDatos()
        {
            var reg = (Proveedor)proveedorBindingSource.Current;
            //reg.FechaNac = DateTime.Now;
            return reg;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TelfTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
