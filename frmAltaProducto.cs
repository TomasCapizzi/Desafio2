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
    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Descripcion = txtDescripcion.Text;
            producto.Costo = numCosto.Value;
            producto.PrecioVenta = numPrecio.Value;
            producto.Stock = numStock.Value;
            producto.IdUsuario = int.Parse(txtUsuario.Text);

            Contexto.CrearProducto(producto);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {

        }
    }
}