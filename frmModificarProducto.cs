﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2
{
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        private Producto _producto;
        public frmModificarProducto(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            _producto.Descripcion = txtDescripcion.Text;
            _producto.Costo = numCosto.Value;
            _producto.PrecioVenta = numPrecio.Value;
            _producto.Stock = numStock.Value;
            _producto.IdUsuario = int.Parse(txtUsuario.Text);

            Contexto.ModificarProducto(_producto);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void frmMdificarProducto_Load(object sender, EventArgs e)
        {
            this.txtUsuario.Text = _producto.IdUsuario.ToString();
            this.txtDescripcion.Text = _producto.Descripcion;
            this.numCosto.Value = _producto.Costo;
            this.numPrecio.Value = _producto.PrecioVenta;
            this.numStock.Value = _producto.Stock;
        }
    }
}
