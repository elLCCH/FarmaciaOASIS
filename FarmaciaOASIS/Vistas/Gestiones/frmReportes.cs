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

        private void frmReportes_Load(object sender, EventArgs e)
        {
            ListarTodo();
        }

        

        private void Listar(string pBuscar)
        {

            detalleFacturaBindingSource.DataSource = _DFac.Listar(Convert.ToInt32(pBuscar));
            // clienteDataGridView.Columns["imagen"].Visible = false;

        }
        private void ListarTodo()
        {

            detalleFacturaBindingSource.DataSource = _DFac.ListarTodo();

        }





        private void TxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if(txtBusqueda.Text=="")
                {
                    ListarTodo();
                    lblTotal.Text = "";
                }
                else
                {
                    Listar(txtBusqueda.Text);
                    sumaTotalDGV();
                }
                
            }
        }

        private void sumaTotalDGV()
        {
            int TotalPago = 0;
            foreach (DataGridViewRow row in detalleFacturaDataGridView.Rows)
            {
                TotalPago = TotalPago + (Convert.ToInt32(row.Cells["ColPre"].Value))* (Convert.ToInt32(row.Cells["ColCant"].Value));
            }
            lblTotal.Text = Convert.ToString(TotalPago);

        }


    }
}
