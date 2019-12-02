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
        MedicamentoController _objMedicamento = new MedicamentoController();
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
                label1.Text = "         REGISTRAR\n     MEDICAMENTO";
            }
            else
            {
                medicamentoBindingSource.DataSource = _objMedicamento.BuscarPorPK(Convert.ToInt32(_cuenta));
                label1.Text = "         MODIFICAR\n     MEDICAMENTO";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var reg = CargarDatos();
            if (_esNuevo)
            { 
                if (_objMedicamento.Insertar(reg) && _objMedicamento.VerificarMedicamentoRepetido(nomMedTextBox.Text) == true)
                {
                    MessageBox.Show("MEDICAMENTO REGISTRADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                { MessageBox.Show("YA EXISTE UN MEDICAMENTO LLAMADO: '" + reg.NomMed + "'", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
            else
            {
                if (_objMedicamento.Modificar(reg))
                {
                    MessageBox.Show("MEDICAMENTO MODIFICADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CantidadTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PUnitTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
