using FarmaciaOASIS.Controladores;
using FarmaciaOASIS.Data;
using FarmaciaOASIS.Vistas.VentanasCruds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace FarmaciaOASIS.Vistas.VentanasCruds
{
    public partial class frmVentaProductos : Form
    {
        ClienteController _objCliente = new ClienteController();
        MedicamentoController _med = new MedicamentoController();
        DetalleFacturaController _objDFac = new DetalleFacturaController();
        FacturaController _Factura = new FacturaController();
        int _Sesion=0;
        

        public frmVentaProductos(int pIDSesion)
        {
            InitializeComponent();
            clienteBindingSource.DataSource = _objCliente.Listar("0");
            medicamentoBindingSource.DataSource = _med.Listar("0");
            detalleFacturaBindingSource.DataSource = _objDFac.Listar(1);
            _Sesion = pIDSesion;
        }
        private void frmVentaProductos_Load(object sender, EventArgs e)
        {
            limpiar();
            //detalleFacturaBindingSource.AddNew();
            btnRegProd.Enabled = false;
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            clienteBindingSource.AddNew();
            panelCliente.Visible = true;
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
            

            //

            try
            {
                var reg = CargarDatos();
                if (_objCliente.Insertar(reg) && _objCliente.VerificarClienterepetido(ciTextBox.Text) == true)
                {
                    //MessageBox.Show("soy me");
                    MessageBox.Show("CLIENTE REGISTRADO SATISFACTORIAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCiClie.Text = ciTextBox.Text;
                    nombreLabel2.Text = nombreTextBox.Text;
                    apellidoLabel2.Text = apellidoTextBox.Text;
                    panelCliente.Visible = false;
                    clienteBindingSource.DataSource = _objCliente.BuscarPorCI(ciTextBox.Text);
                    txtCiClie.Focus();
                    habilitar();
                    //Close();
                }
                else
                { MessageBox.Show("YA EXISTE UN CLIENTE CON CI: '" + reg.Ci + "'", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            }
            catch (Exception)
            {

                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE!!", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //
            

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            panelCliente.Visible = false;
            habilitar();
        }

        //panel de REGISTRAR PRODUCTOS
        private void BtnAceptarRP_Click(object sender, EventArgs e)
        {

            //medicamentoDataGridView.

            if (NomMed == "" || txtCantAComprar.Text == "")
                MessageBox.Show("Seleccione una fila", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int CantActualProd = Convert.ToInt32(cantidadLabel3.Text);
                if(Convert.ToInt32(txtCantAComprar.Text)<=CantActualProd)
                {
                    txtCant.Text = txtCantAComprar.Text;
                    //procedimiento de calculo de precio en txt y llevado de info a comprar a textbox
                    btnColocarProd.Visible = true;

                    calcularPrecio();
                    btnColocarProd.Enabled = true;
                    btnColocarProd.Focus();
                    habilitar();
                }
                else

                {
                    MessageBox.Show("NO HAY SUFICIENTES UNIDADES", "AVISO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                

            }
            txtTotal.Enabled = false;
            txtCant.Enabled = false;
            btnRegistrarCliente.Enabled = false;
            btnBuscarCliente.Enabled = false;

        }
        private void MedicamentoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NomMed = this.medicamentoDataGridView.Rows[e.RowIndex].Cells["NomMed"].Value.ToString();
            PUnit = this.medicamentoDataGridView.Rows[e.RowIndex].Cells["PUnit"].Value.ToString();
            CodMed = this.medicamentoDataGridView.Rows[e.RowIndex].Cells["CodMed"].Value.ToString();
        }

        private void BtnRegProd_Click(object sender, EventArgs e)
        {
            medicamentoBindingSource.DataSource = _med.Listar(txtBuscarMedicamento.Text);
            txtBuscarMedicamento.Focus();
            PanelRegProducto.Visible = true;
            Inhabilitar();

        }

        private void Inhabilitar()
        {
            btnRegProd.Enabled = false;
            btnRegistrarCliente.Enabled = false;
            apellidoLabel2.Enabled = false;
            nombreLabel2.Enabled = false;
            txtCiClie.Enabled = false;
            txtTotal.Enabled = false;
            txtCant.Enabled = false;
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnBuscarCliente.Enabled = false;
        }
        private void habilitar()
        {
            btnRegProd.Enabled = true;
            btnRegistrarCliente.Enabled = true;
            apellidoLabel2.Enabled = true;
            nombreLabel2.Enabled = true;
            txtCiClie.Enabled = true;
            txtTotal.Enabled = true;
            txtCant.Enabled = true;
            btnEliminar.Enabled = true;
            btnRegistrar.Enabled = true;
            btnLimpiar.Enabled = true;
            btnBuscarCliente.Enabled = true;
        }
        private void BtnCancelarRP_Click(object sender, EventArgs e)
        {
            PanelRegProducto.Visible = false;
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

        //PARA LA FATURA O EL dgvINDEPENDIENTE
        private void calcularPrecio()
        {
            if (txtCant.Text == "")
            {
                int Total;
                //txtCant.Text = txtCantAComprar.Text;
                Total = Convert.ToInt32(txtCantAComprar.Text) * Convert.ToInt32(pUnitLabel1.Text);
                txtTotal.Text = Convert.ToString(Total);
                PanelRegProducto.Visible = false;
            }
            else
            {
                int Total;
                //txtCant.Text = txtCantAComprar.Text;
                Total = Convert.ToInt32(txtCant.Text) * Convert.ToInt32(pUnitLabel1.Text);
                txtTotal.Text = Convert.ToString(Total);
                PanelRegProducto.Visible = false;
            }

        }

        public static string NomMed;
        public static string PUnit;
        public static string CodMed;



        public static int cont_fila = 0;
        public static double total;
        private void BtnColocarProd_Click(object sender, EventArgs e)
        {
            /*dgvVentas.Rows.Add(codMedLabel1.Text, nomMedLabel1.Text, pUnitLabel1.Text, txtCant.Text, txtTotal.Text);
            sumaTotalDGV();
            limpiar();
            btnColocarProd.Enabled = false;
            */
            bool existe = false;
            int num_fila = 0;
            
            if (cont_fila == 0)
            {
                dgvVentas.Rows.Add(codMedLabel1.Text, nomMedLabel1.Text, pUnitLabel1.Text, txtCant.Text, txtTotal.Text);
                cont_fila++;
            }
            else
            {
                
                foreach (DataGridViewRow Fila in dgvVentas.Rows)
                {
                    if (Fila.Cells[0].Value.ToString() == codMedLabel1.Text)
                    {
                        existe = true;
                        num_fila = Fila.Index;
                    }
                }
                if (existe == true)
                {
                    dgvVentas.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCant.Text) + Convert.ToDouble(dgvVentas.Rows[num_fila].Cells[3].Value)).ToString();
                    double importe = Convert.ToDouble(dgvVentas.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dgvVentas.Rows[num_fila].Cells[3].Value);
                    dgvVentas.Rows[num_fila].Cells[4].Value = importe;
                }
                else
                {

                    dgvVentas.Rows.Add(codMedLabel1.Text, nomMedLabel1.Text, pUnitLabel1.Text, txtCant.Text);
                    double costo = Convert.ToDouble(dgvVentas.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dgvVentas.Rows[cont_fila].Cells[3].Value);
                    dgvVentas.Rows[cont_fila].Cells[4].Value = costo;
                    cont_fila++;
                }
            }
            sumaTotalDGV();
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
            nombreLabel2.Text = "";
            apellidoLabel2.Text = "";
            txtCiClie.Text = "";
            ciLabel1.Text = "";
            codClienteLabel2.Text = "";
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {

            //preparacion para Factura
            facturaBindingSource.AddNew();
            var regFactura = (Factura)facturaBindingSource.Current;

            //CARGAR DATOS para Factura
            regFactura.CodCliente = Convert.ToInt32(codClienteLabel2.Text);
            regFactura.Fecha = DateTime.Now;
            if (_Factura.Insertar(regFactura))
            {
                MessageBox.Show("se creo una nueva factura");

            }
            ////----------------------------------------------------------/////

            //CALCULO DE LA ULTIMA FACTURA
            int UltimaFactura = Convert.ToInt32(_Factura.BuscarElMax());
            MessageBox.Show(Convert.ToString(UltimaFactura));

            string codigo, nombre, precio, cantidad, costo;
            //---------FACTURA---------------------------------------------------//
            string numfact, nom, cinit, fechaf;
            //int cantprod = 7;
            numfact = Convert.ToString(UltimaFactura);
            cinit = ciLabel1.Text;
            nom = nombreLabel2.Text + " " + apellidoLabel2.Text;
            fechaf = Convert.ToString(DateTime.Now);
            //sumtotalprec = "753.30";
            string ruta = @"c:\FarmaciaOasis";

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 15, 15, 20, 25);

            DirectoryInfo di = Directory.CreateDirectory(ruta);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("c://FarmaciaOasis//Factura " + numfact + ".pdf", FileMode.Create));
            doc.Open();
            //imagen
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("facturalogo.png");
            logo.ScalePercent(20);
            logo.SetAbsolutePosition(doc.PageSize.Width - 140, doc.PageSize.Height - 90);
            doc.Add(logo);

            //imagen

            //BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            Font times = new Font(iTextSharp.text.Font.NORMAL, 16, 1);
            //BaseFont bfTimes2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            Font times2 = new Font(iTextSharp.text.Font.NORMAL, 10, 1);
            Paragraph Titulo = new Paragraph("Factura", times);
            Titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(Titulo);
            Paragraph numf = new Paragraph("Nombre: " + nom + "\nNº FACTURA: " + numfact, times2);
            numf.Alignment = Element.ALIGN_LEFT;
            doc.Add(numf);
            Paragraph nit = new Paragraph("Fecha: " + fechaf + "\nCI/NIT: " + cinit, times2);
            nit.Alignment = Element.ALIGN_LEFT;
            doc.Add(nit);
            Paragraph dato1 = new Paragraph(" ", times2);
            dato1.Alignment = Element.ALIGN_LEFT;
            doc.Add(dato1);
            //lista
            /*List lista = new List(List.UNORDERED);
            lista.SetListSymbol("\u2022");
            lista.IndentationLeft =30;
            lista.Add("Ms");
            lista.Add("Ms2");
            lista.Add("Ms2");
            lista.Add("Ms2");
            lista.Add("Ms2");
            doc.Add(lista);*/
            //TABLA
            PdfPTable tabla = new PdfPTable(4);

            PdfPCell Titulos = new PdfPCell(new Phrase("Detalle", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            Titulos.Colspan = 4;
            Titulos.HorizontalAlignment = 1;
            tabla.AddCell(Titulos);

            PdfPCell t1 = new PdfPCell(new Phrase("Cantidad", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            t1.HorizontalAlignment = 1;
            tabla.AddCell(t1);
            //tabla.AddCell(new Phrase("Cantidad",HorizontalAlignment.Center,));
            PdfPCell t2 = new PdfPCell(new Phrase("Concepto", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            t2.HorizontalAlignment = 1;
            tabla.AddCell(t2);
            PdfPCell t3 = new PdfPCell(new Phrase("Precio Unitario", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            t3.HorizontalAlignment = 1;
            tabla.AddCell(t3);
            PdfPCell t4 = new PdfPCell(new Phrase("Subtotal", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            t4.HorizontalAlignment = 1;
            tabla.AddCell(t4);

            double c1, c2, subt, totalprods = 0;
            //int colcont = 0, totalprods = 0;
            //quant = Convert.ToInt32(dataGridView1.Rows.Count.ToString());
            //---------FACTURA----------------------------
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                //preparacion para Detalle Factura
                detalleFacturaBindingSource.AddNew();
                var reg = (DetalleFactura)detalleFacturaBindingSource.Current;

                //CARGAR DATOS para Detalle Factura
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

                //CARGANDO AL ENTITY
                reg.NoFactura = UltimaFactura;
                reg.NoAutorizacion = Convert.ToInt32(txtNoAutorizacion.Text);
                reg.CodMed = Convert.ToInt32(codigo);
                reg.CantMed = Convert.ToInt32(cantidad);
                reg.Precio = Convert.ToInt32(precio);
                reg.CodUsuario = _Sesion;

                SendToMedicamentoForUpdate(Convert.ToInt32(codigo), Convert.ToInt32(cantidad)); //Actualizando en Base de datos la Cantidad
                //---------FACTURA----------------------------
                tabla.AddCell(cantidad);
                tabla.AddCell(nombre);
                tabla.AddCell(precio);
                c1 = Convert.ToDouble(cantidad);
                c2 = Convert.ToDouble(precio);
                subt = c1 * c2;
                totalprods = subt + totalprods;
                tabla.AddCell(Convert.ToString(subt));
                //---------FACTURA----------------------------
                //INSERTACION para Detalle Factura
                if (_objDFac.Insertar(reg))
                {
                    MessageBox.Show("se inserto correctamente");

                }

            }
            //---------FACTURA----------------------------
            PdfPCell total = new PdfPCell(new Phrase("TOTAL:                    " + totalprods, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK)));
            total.Colspan = 4;
            total.HorizontalAlignment = 2;
            tabla.AddCell(total);
            doc.Add(tabla);

            doc.Close();
            // num factura en nombre
            System.Diagnostics.Process.Start("C:\\FarmaciaOasis\\Factura " + numfact + ".pdf");
            //---------FACTURA----------------------------
        }

        private void SendToMedicamentoForUpdate(int codigo, int cantidad)
        {
            medicamentoBindingSource.DataSource = _med.BuscarPorPK(codigo);
            var reg = CargarDatosForMedicamentoForUpdate();
            reg.Cantidad = reg.Cantidad - cantidad;
            if(_med.Modificar(reg))
            {
                MessageBox.Show("se actualizo en tabla la cantidad");
            }

        }
        private Medicamento CargarDatosForMedicamentoForUpdate()
        {
            var reg = (Medicamento)medicamentoBindingSource.Current;
            return reg;
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            dgvVentas.Rows.Clear();
            clienteBindingSource.DataSource = _objCliente.Listar("0");
            txtCiClie.Text = "";
            lblTotal.Text = "0";
        }

        private void TxtCiClie_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {

                var reg = (Cliente)clienteBindingSource.Current;
                clienteBindingSource.DataSource = _objCliente.BuscarPorCI(txtCiClie.Text);
                if (codClienteLabel2.Text != "")
                {
                    btnRegProd.Enabled = true;
                }
                else { btnRegProd.Enabled = false; }

            }


        }
        private string ObtenerDatosSesion()
        {
            var reg = (DetalleFactura)detalleFacturaBindingSource.Current;
            //FormMenuPrincipal MenuP = new FormMenuPrincipal();
            var MenuP = new FormMenuPrincipal();
            string res1 = MenuP.codUsuarioLabel1.Text;
            MessageBox.Show(res1);
            return res1;
        }

        private void TxtCiClie_KeyPress(object sender, KeyPressEventArgs e)
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

        

        private void TxtCant_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNoAutorizacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CiTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtCantAComprar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            clienteBindingSource.DataSource = _objCliente.Listar("");
            panelBuscarCliente.Visible = true;
            txtBuscarCliente.Focus();
        }

        private void BtnSelecCliente_Click(object sender, EventArgs e)
        {
            panelBuscarCliente.Visible = false;
            txtCiClie.Text = ciLabel1.Text;
            btnRegProd.Enabled = true;
        }

        private void TxtCiClie_TextChanged(object sender, EventArgs e)
        {
            btnRegProd.Enabled = false;
            btnEliminar.Enabled = false;
            btnRegistrar.Enabled = false;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            clienteBindingSource.DataSource = _objCliente.Listar(txtBuscarCliente.Text);
        }
    }
}
