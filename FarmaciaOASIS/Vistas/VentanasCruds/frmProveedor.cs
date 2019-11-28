﻿using FarmaciaOASIS.Controladores;
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
    public partial class frmProveedor : frmVentanaDatos
    {
        ProveedorController _objUsuario = new ProveedorController();
        private string _cuenta;
        private bool _esNuevo;
        public frmProveedor()
        {
            _esNuevo = true;
            InitializeComponent();

        }
        public frmProveedor(string pCuenta)
        {
            _cuenta = pCuenta;
            _esNuevo = false;
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
            {
                proveedorBindingSource.AddNew();
                label1.Text = "REGISTRAR PROVEEDOR";
            }
            else
            {
                proveedorBindingSource.DataSource = _objUsuario.BuscarPorPK(Convert.ToInt32(_cuenta));
                label1.Text = "MODIFICAR PROVEEDOR";
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

        private Proveedor CargarDatos()
        {
            var reg = (Proveedor)proveedorBindingSource.Current;
            //reg.FechaNac = DateTime.Now;
            return reg;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
