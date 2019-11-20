using FarmaciaOASIS.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaOASIS.Vistas.Gestiones
{
    public partial class frmReportes : frmGestion
    {
        DetalleFacturaController _DFac = new DetalleFacturaController();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmGestionarClientes_Load(object sender, EventArgs e)
        {
            Listar(txtBusqueda.Text);
        }

        

        private void Listar(string pBuscar)
        {

            detalleFacturaBindingSource.DataSource = _DFac.Listar(Convert.ToInt32(pBuscar));
            // clienteDataGridView.Columns["imagen"].Visible = false;

        }

        



        private void TxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Listar(txtBusqueda.Text);
            }
        }

        

        
    }
}
