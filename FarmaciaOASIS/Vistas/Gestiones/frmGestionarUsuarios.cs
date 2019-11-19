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
    public partial class frmGestionarUsuarios : frmGestion
    {
        UsuarioController _objUsuario = new UsuarioController();
        public frmGestionarUsuarios()
        {
            InitializeComponent();
        }

        private void frmGestionarUsuarios_Load(object sender, EventArgs e)
        {
            Listar(txtBusqueda.Text);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            frmUsuario AddUsuario = new frmUsuario();
            AddUsuario.ShowDialog();
            Listar(txtBusqueda.Text);

        }

        private void Listar(string pBuscar)
        {

            usuarioBindingSource.DataSource = _objUsuario.Listar(pBuscar);
            // proveedorDataGridView.Columns["imagen"].Visible = false;

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            frmUsuario AddUser = new frmUsuario(cuentaLabel1.Text);
            AddUser.ShowDialog();
            _objUsuario = new UsuarioController();
            Listar(txtBusqueda.Text);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("ELiminar registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                _objUsuario.Eliminar(cuentaLabel1.Text);
                _objUsuario = new UsuarioController();
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

        private void proveedorDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.proveedorDataGridView.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.proveedorDataGridView.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Delete.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.proveedorDataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.proveedorDataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.proveedorDataGridView.Columns[e.ColumnIndex].Name == "Modificar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.proveedorDataGridView.Rows[e.RowIndex].Cells["Modificar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Update.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.proveedorDataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.proveedorDataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.proveedorDataGridView.Columns[e.ColumnIndex].Name == "Agregar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.proveedorDataGridView.Rows[e.RowIndex].Cells["Agregar"] as DataGridViewButtonCell;
                Icon icoAtomico = new Icon(Environment.CurrentDirectory + @"\\Add.ico"); //Recuerden colocar su icono en la carpeta debug de su proyecto
                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.proveedorDataGridView.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                this.proveedorDataGridView.Columns[e.ColumnIndex].Width = icoAtomico.Width + 8;

                e.Handled = true;
            }
        }

        private void proveedorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.proveedorDataGridView.Columns[e.ColumnIndex].Name == "Eliminar")
            {

                // MessageBox.Show("hola");

                DialogResult res = MessageBox.Show("ELiminar registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    _objUsuario.Eliminar(cuentaLabel1.Text);
                    _objUsuario = new UsuarioController();
                    Listar(txtBusqueda.Text);
                }

            }
            if (this.proveedorDataGridView.Columns[e.ColumnIndex].Name == "Modificar")
            {

                // MessageBox.Show("XD");
                frmUsuario AddUser = new frmUsuario(cuentaLabel1.Text);
                AddUser.ShowDialog();
                _objUsuario = new UsuarioController();
                Listar(txtBusqueda.Text);

            }
            if (this.proveedorDataGridView.Columns[e.ColumnIndex].Name == "Agregar")
            {

                // MessageBox.Show("XD");
                frmUsuario AddUsuario = new frmUsuario();
                AddUsuario.ShowDialog();
                Listar(txtBusqueda.Text);

            }
        }
    }
}
