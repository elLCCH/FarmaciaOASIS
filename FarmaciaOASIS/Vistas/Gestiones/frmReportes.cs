using FarmaciaOASIS.Controladores;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace FarmaciaOASIS.Vistas.Gestiones
{
    public partial class frmReportes : frmGestion
    {
        DetalleFacturaController _DFac = new DetalleFacturaController();
        MedicamentoController _med = new MedicamentoController();
        FacturaController _Fac = new FacturaController();
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            Graficacion();
            ListarTodo();
            
            txtBusqueda.Focus();
        }

        private void Graficacion()
        {
            int mes1 = Graficar(-30, 0); //ultimos 30 dias
            int mes2 = Graficar(-60, -30); //hace 2 meses
            int mes3 = Graficar(-90, -60); //hace 3 meses
            int mes4 = Graficar(-120, -90); //hace 4 meses
            int mes5 = Graficar(-150, -120); //hace 5 meses
            //vectores con los datos
            string[] series = { "ULTIMOS 30 DIAS", "HACE 2 MESES", "HACE 3 MESES", "HACE 4 MESES", "HACE 5 MESES" };
            int[] puntos = { mes1, mes2, mes3, mes4, mes5 };

            //cambiar la combiacion de colores
            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < series.Length; i++)
            {
                //titulos
                Series serie = chart1.Series.Add(series[i]);
                //cant
                serie.Label = puntos[i].ToString();
                serie.Points.Add(puntos[i]);
            }
        }

        private int Graficar(int pIni,int pFin)
        {

            DateTime date1 = DateTime.Now.AddDays(pIni);
            DateTime date2 = DateTime.Now.AddDays(pFin);


            facturaBindingSource.DataSource = _Fac.ListarPorFecha(date1, date2);

            //operacion de sumacion entre las fechas
            int TotalPagoGrafica = 0;
            foreach (DataGridViewRow row in facturaDataGridView.Rows)
            {
                int numFac = Convert.ToInt32(row.Cells["NoFactura"].Value);

                detalleFacturaBindingSource.DataSource = _DFac.Listar(numFac);
               // MessageBox.Show("ya se listo");

                foreach (DataGridViewRow row1 in detalleFacturaDataGridView.Rows)
                {
                    TotalPagoGrafica = TotalPagoGrafica + (Convert.ToInt32(row1.Cells["ColPre"].Value)) * (Convert.ToInt32(row1.Cells["ColCant"].Value));

                }
            }
            return TotalPagoGrafica;
        }

        private void Listar(string pBuscar)
        {

            detalleFacturaBindingSource.DataSource = _DFac.Listar(Convert.ToInt32(pBuscar));
            // clienteDataGridView.Columns["imagen"].Visible = false;

        }
        private void ListarTodo()
        {

            detalleFacturaBindingSource.DataSource = _DFac.ListarTodo();
            btnRegistrar.Enabled = false;

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
                    if(detalleFacturaDataGridView.Rows.Count != 0)
                    {
                        Listar(txtBusqueda.Text);
                        ListarSeleccionado();
                        btnRegistrar.Enabled = true;
                    }
                    else
                    {
                        btnRegistrar.Enabled = false;
                        MessageBox.Show("NO SE ENCONTRÓ NINGUNA FACTURA!", "AVISO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }

            }
        }

        private void ListarSeleccionado()
        {
            int TotalPago = 0;
            foreach (DataGridViewRow row in detalleFacturaDataGridView.Rows)
            {
                TotalPago = TotalPago + (Convert.ToInt32(row.Cells["ColPre"].Value)) * (Convert.ToInt32(row.Cells["ColCant"].Value));
                lblTotal.Text = Convert.ToString(TotalPago);
            }
        }

        private void sumaTotalDGV()
        {
            try
            {
                //---------FACTURA---------------------------------------------------//
                string numfact, nom, cinit, fechaf;
                //int cantprod = 7;
                numfact = noFacturaLabel1.Text;
                //this.detalleFacturaDataGridView.Rows[0].Cells[0].Value.ToString();
                cinit = ciLabel1.Text;
                nom = nombreLabel1.Text + " " + apellidoLabel1.Text;
                fechaf = fechaLabel1.Text;
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

                //int TotalPago = 0;
                string cantidad, PrecU, nommed;
                foreach (DataGridViewRow row in detalleFacturaDataGridView.Rows)
                {
                    string i = "";

                    /////AQUI VIENE LA FUNCION DEL NOMBRE DEL MEDICAMNTO
                    /////nommed = _med.ObtenerNombreMed(Convert.ToInt32(row.Cells["CodMed"].Value));
                    ///
                    int CodMedicamento = Convert.ToInt32(row.Cells["CodMed"].Value);
                    medicamentoBindingSource.DataSource = _med.ListarPorCodMed(CodMedicamento);

                    nommed = nomMedLabel1.Text;
                    MessageBox.Show(nommed);
                    //


                    cantidad = Convert.ToString(row.Cells["ColCant"].Value);
                    PrecU = Convert.ToString(row.Cells["ColPre"].Value);
                    
                    //---------FACTURA----------------------------
                    tabla.AddCell(cantidad);
                    tabla.AddCell(nommed);
                    tabla.AddCell(PrecU);
                    c1 = Convert.ToDouble(cantidad);
                    c2 = Convert.ToDouble(PrecU);
                    subt = c1 * c2;
                    totalprods = subt + totalprods;
                    tabla.AddCell(Convert.ToString(subt));
                    //---------FACTURA----------------------------
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
            catch (Exception e)
            {

                MessageBox.Show("El archivo ya esta abierto"+e.Message);
            }
            
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            sumaTotalDGV();
            btnRegistrar.Enabled = false;
        }

        private void TxtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Button1_Click(object sender, EventArgs e)
        {



            //poniendo las fechas iniciales y finales
            //DateTime date1 = Convert.ToDateTime(textBox1.Text);
            //DateTime date2 = Convert.ToDateTime(textBox2.Text);


        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            panelGanancias.Visible = true;
        }

        private void BtnAceptarGanacias_Click(object sender, EventArgs e)
        {
            panelGanancias.Visible = false;
        }
    }
}
