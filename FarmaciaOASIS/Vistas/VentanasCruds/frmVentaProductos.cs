using FarmaciaOASIS.Controladores;
using FarmaciaOASIS.Data;
using FarmaciaOASIS.Vistas.VentanasCruds;
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
    public partial class frmVentaProductos : Form
    {
        ClienteController _objUsuario = new ClienteController();
        MedicamentoController _med = new MedicamentoController();
        DetalleFacturaController _objFac = new DetalleFacturaController();
        public frmVentaProductos()
        {
            InitializeComponent();
            clienteBindingSource.DataSource = _objUsuario.Listar("");
            medicamentoBindingSource.DataSource = _med.Listar("");
            detalleFacturaBindingSource.DataSource = _objFac.Listar(1);
        }

        private void frmVentaProductos_Load(object sender, EventArgs e)
        {
            limpiar();
            //detalleFacturaBindingSource.AddNew();
            
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            panelxd.Visible = true;
            Inhabilitar();
        }
        private Cliente CargarDatos()
        {
            var reg = (Cliente)clienteBindingSource.Current;
            //reg.FechaNac = DateTime.Now;
            return reg;
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var reg = CargarDatos();
            if (_objUsuario.Insertar(reg))
            {
                //MessageBox.Show("soy me");
                MessageBox.Show("se inserto correctamente");
                txtCiClie.Text = ciTextBox.Text;
                txtNombreCliente.Text = nombreTextBox.Text;
                txtApellidoCliente.Text = apellidoTextBox.Text;
                panelxd.Visible = false;
                habilitar();
                //Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelxd.Visible = false;
            habilitar();
        }

        private void BtnAceptarRP_Click(object sender, EventArgs e)
        {
            
            //medicamentoDataGridView.
            
            if (NomMed == "" || txtCantAComprar.Text == "")
                MessageBox.Show("Seleccione una fila", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                btnColocarProd.Visible = true;
                calcularPrecio();
                btnColocarProd.Enabled = true;
                habilitar();
            }
            
        }

        private void calcularPrecio()
        {
            if (txtCant.Text == "")
            {
                int Total;
                txtCant.Text = txtCantAComprar.Text;
                Total = Convert.ToInt32(txtCantAComprar.Text) * Convert.ToInt32(pUnitLabel1.Text);
                txtTotal.Text = Convert.ToString(Total);
                PanelMed.Visible = false;
            }
            else
            {
                int Total;
                //txtCant.Text = txtCantAComprar.Text;
                Total = Convert.ToInt32(txtCant.Text) * Convert.ToInt32(pUnitLabel1.Text);
                txtTotal.Text = Convert.ToString(Total);
                PanelMed.Visible = false;
            }
            
        }

        public static string NomMed;
        public static string PUnit;
        public static string CodMed;
        private void MedicamentoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NomMed = this.medicamentoDataGridView.Rows[e.RowIndex].Cells["NomMed"].Value.ToString();
            PUnit = this.medicamentoDataGridView.Rows[e.RowIndex].Cells["PUnit"].Value.ToString();
            CodMed = this.medicamentoDataGridView.Rows[e.RowIndex].Cells["CodMed"].Value.ToString();
        }

        private void BtnRegProd_Click(object sender, EventArgs e)
        {
            medicamentoBindingSource.DataSource = _med.Listar(txtBuscarMedicamento.Text);
            PanelMed.Visible = true;
            Inhabilitar();

        }

        private void Inhabilitar()
        {
            btnRegProd.Enabled = false;
            btnRegistrarCliente.Enabled = false;
            txtApellidoCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtCiClie.Enabled = false;
            txtTotal.Enabled = false;
            txtCant.Enabled = false;
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = false;
        }
        private void habilitar()
        {
            btnRegProd.Enabled = true;
            btnRegistrarCliente.Enabled = true;
            txtApellidoCliente.Enabled = true;
            txtNombreCliente.Enabled = true;
            txtCiClie.Enabled = true;
            txtTotal.Enabled = true;
            txtCant.Enabled = true;
            btnEliminar.Enabled = true;
            btnRegistrar.Enabled = true;
        }
        private void BtnCancelarRP_Click(object sender, EventArgs e)
        {
            PanelMed.Visible = false;
            habilitar();
        }
        private Medicamento CargarDatosMedicamento()
        {
            var reg = (Medicamento)clienteBindingSource.Current;
            //reg.FechaNac = DateTime.Now;
            return reg;
        }

        private void TxtBuscarMedicamento_TextChanged(object sender, EventArgs e)
        {
            medicamentoBindingSource.DataSource = _med.Listar(txtBuscarMedicamento.Text);
        }

        

        private void TxtCant_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                calcularPrecio();
            }
            
        }

        private void BtnColocarProd_Click(object sender, EventArgs e)
        {
            dgvVentas.Rows.Add(codMedLabel1.Text, nomMedLabel1.Text, pUnitLabel1.Text, txtCant.Text, txtTotal.Text);
            sumaTotalDGV();
            limpiar();
            btnColocarProd.Enabled = false;
        }

        private void sumaTotalDGV()
        {
            int TotalPago = 0;
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                TotalPago = TotalPago + Convert.ToInt32(row.Cells["ColCosto"].Value);
            }
            lblTotal.Text = Convert.ToString(TotalPago);

        }

        private void limpiar()
        {
            codMedLabel1.Text = "";
            nomMedLabel1.Text = "";
            pUnitLabel1.Text = "";
            txtCant.Text = "";
            txtTotal.Text = "";
            txtCantAComprar.Text = "";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            dgvVentas.Rows.RemoveAt(dgvVentas.CurrentRow.Index);
            sumaTotalDGV();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            int ultimoIDFactura = 10;
            string codigo, nombre, precio, cantidad, costo;
            //double sumatoriaTotal = 0;
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                ultimoIDFactura = ultimoIDFactura + 1;
                detalleFacturaBindingSource.AddNew();
                var reg = (DetalleFactura)detalleFacturaBindingSource.Current;
                
                //CARGAR DATOS
                codigo = Convert.ToString(row.Cells["ColCodigo"].Value);
                nombre = Convert.ToString(row.Cells["ColNombre"].Value);
                precio = Convert.ToString(row.Cells["ColPrecio"].Value);
                cantidad = Convert.ToString(row.Cells["ColCantidad"].Value);
                costo = Convert.ToString(row.Cells["ColCosto"].Value);

                //numeroTextBox.Text = Convert.ToString(cont);
                //noFacturaTextBox.Text = "444";
                //noAutorizacionTextBox.Text = "555555";
                //codMedTextBox.Text = codigo;
                //cantMedTextBox.Text = cantidad;
                //precioTextBox.Text = precio;
                //codUsuarioTextBox.Text = "0";

                
                reg.NoFactura = 444;
                reg.NoAutorizacion = 555555;
                reg.CodMed = Convert.ToInt32(codigo);
                reg.CantMed = Convert.ToInt32(cantidad);
                reg.Precio = Convert.ToInt32(precio);
                reg.CodUsuario = 0;
                reg.Numero = ultimoIDFactura;
                //INSERTACION
                if (_objFac.Insertar(reg))
                {
                    MessageBox.Show("se inserto correctamente");

                }

            }
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
