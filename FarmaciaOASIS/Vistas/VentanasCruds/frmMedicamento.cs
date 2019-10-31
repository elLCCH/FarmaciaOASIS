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
    public partial class frmMedicamento : frmVentanaDatos
    {
        MedicamentoController _objUsuario = new MedicamentoController();
        private string _cuenta;
        private bool _esNuevo;
        public frmMedicamento()
        {
            _esNuevo = true;
            InitializeComponent();

        }
        public frmMedicamento(string pCuenta)
        {
            _cuenta = pCuenta;
            _esNuevo = false;
            InitializeComponent();
        }

        private void frmMedicamento_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
            {
                medicamentoBindingSource.AddNew();
            }
            else
            {
                medicamentoBindingSource.DataSource = _objUsuario.BuscarPorPK(Convert.ToInt32(_cuenta));
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

        private Medicamento CargarDatos()
        {
            var reg = (Medicamento)medicamentoBindingSource.Current;
            //reg.FechaNac = DateTime.Now;
            return reg;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
