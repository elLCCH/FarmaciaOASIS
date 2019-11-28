using FarmaciaOASIS.Controladores;
using FarmaciaOASIS.Data;
using FarmaciaOASIS.Vistas.Gestiones;
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
    public partial class frmCliente : frmVentanaDatos
    {
        ClienteController _objUsuario = new ClienteController();
        
        private string _cuenta;
        private bool _esNuevo;
        public frmCliente()
        {
            _esNuevo = true;
            InitializeComponent();

        }
        public frmCliente(string pCuenta)
        {
            _cuenta = pCuenta;
            _esNuevo = false;
            InitializeComponent();
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
            {
                clienteBindingSource.AddNew();
                label1.Text = "REGISTRAR CLIENTE";
            }
            else
            {
                clienteBindingSource.DataSource = _objUsuario.BuscarPorCI(_cuenta);
                label1.Text = "MODIFICAR CLIENTE";
            }
        }
        
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var reg = CargarDatos();
            if (_esNuevo)
            {
                if (_objUsuario.Insertar(reg))
                {
                    //MessageBox.Show("soy me");
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

        private Cliente CargarDatos()
        {
            var reg = (Cliente)clienteBindingSource.Current;
            //reg.FechaNac = DateTime.Now;
            return reg;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
