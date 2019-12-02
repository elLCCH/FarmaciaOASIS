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
        ClienteController _objCliente = new ClienteController();
        
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
                clienteBindingSource.DataSource = _objCliente.BuscarPorCI(_cuenta);
                label1.Text = "MODIFICAR CLIENTE";
            }
        }
        
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            
            
            
            var reg = CargarDatos();
            
            
            ////PROCEDIMIENTO NORMAL DE CRUD
            if (_esNuevo)
            {
                
                if (_objCliente.Insertar(reg) && _objCliente.VerificarClienterepetido(ciTextBox.Text)==true)
                {
                    //MessageBox.Show("soy me");
                    MessageBox.Show("CLIENTE REGISTRADO SATISFACTORIAMENTE","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Close();
                }
                else
                { MessageBox.Show("YA EXISTE UN CLIENTE CON CI: '" + reg.Ci + "'", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            else
            {
                if (_objCliente.Modificar(reg))
                {
                    MessageBox.Show("CLIENTE MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
