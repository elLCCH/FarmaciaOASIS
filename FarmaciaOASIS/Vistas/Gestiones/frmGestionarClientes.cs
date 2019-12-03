using FarmaciaOASIS.Controladores;
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

namespace FarmaciaOASIS.Vistas.Gestiones
{
    public partial class frmGestionarClientes : frmGestion
    {
        ClienteController _objCliente = new ClienteController();
        public frmGestionarClientes()
        {
            InitializeComponent();
        }

        private void frmGestionarClientes_Load(object sender, EventArgs e)
        {
            Listar(txtBusqueda.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmCliente AddUsuario = new frmCliente();
            AddUsuario.ShowDialog();
            Listar(txtBusqueda.Text);

        }

        private void Listar(string pBuscar)
        {

            clienteBindingSource.DataSource = _objCliente.Listar(pBuscar);
            // clienteDataGridView.Columns["imagen"].Visible = false;

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            frmCliente AddUser = new frmCliente(ciLabel1.Text);
            AddUser.ShowDialog();
            _objCliente = new ClienteController();
            Listar(txtBusqueda.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTE REGISTRO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _objCliente.Eliminar(ciLabel1.Text);
                _objCliente = new ClienteController();
                Listar(txtBusqueda.Text);
            }
        }



        private void TxtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Listar(txtBusqueda.Text);
            }
        }

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clienteDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.clienteDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.clienteDataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Delete.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.clienteDataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.clienteDataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.clienteDataGridView.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.clienteDataGridView.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Update.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.clienteDataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.clienteDataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.clienteDataGridView.Columns[e.ColumnIndex].Name == "Agregar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.clienteDataGridView.Rows[e.RowIndex].Cells["Agregar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Add.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.clienteDataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.clienteDataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
        }

        private void clienteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.clienteDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {

                // MessageBox.Show("hola");

                DialogResult res = MessageBox.Show("¿ESTA SEGURO DE ELIMINAR ESTE REGISTRO?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    _objCliente.Eliminar(ciLabel1.Text);
                    _objCliente = new ClienteController();
                    Listar(txtBusqueda.Text);
                }

            }
            if (this.clienteDataGridView.Columns[e.ColumnIndex].Name == "Modificar")
            {

                // MessageBox.Show("XD");
                frmCliente AddUser = new frmCliente(ciLabel1.Text);
                AddUser.ShowDialog();
                _objCliente = new ClienteController();
                Listar(txtBusqueda.Text);

            }
            if (this.clienteDataGridView.Columns[e.ColumnIndex].Name == "Agregar")
            {

                // MessageBox.Show("XD");
                frmCliente AddUsuario = new frmCliente();
                AddUsuario.ShowDialog();
                Listar(txtBusqueda.Text);

            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
