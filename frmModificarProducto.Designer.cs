﻿namespace Desafio2
{
    partial class frmModificarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnModificar = new Button();
            numStock = new NumericUpDown();
            lbl5 = new Label();
            numPrecio = new NumericUpDown();
            lbl4 = new Label();
            numCosto = new NumericUpDown();
            lbl3 = new Label();
            txtUsuario = new TextBox();
            lbl2 = new Label();
            txtDescripcion = new TextBox();
            lbl1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(348, 445);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(125, 42);
            btnModificar.TabIndex = 21;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // numStock
            // 
            numStock.Location = new Point(348, 292);
            numStock.Name = "numStock";
            numStock.Size = new Size(125, 27);
            numStock.TabIndex = 20;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.BackColor = Color.Transparent;
            lbl5.ForeColor = Color.Black;
            lbl5.Location = new Point(323, 269);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(45, 20);
            lbl5.TabIndex = 19;
            lbl5.Text = "Stock";
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(348, 216);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(125, 27);
            numPrecio.TabIndex = 18;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.Transparent;
            lbl4.ForeColor = Color.Black;
            lbl4.Location = new Point(323, 193);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(91, 20);
            lbl4.TabIndex = 17;
            lbl4.Text = "Precio Venta";
            // 
            // numCosto
            // 
            numCosto.Location = new Point(348, 135);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(125, 27);
            numCosto.TabIndex = 16;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.ForeColor = Color.Black;
            lbl3.Location = new Point(323, 112);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(47, 20);
            lbl3.TabIndex = 15;
            lbl3.Text = "Costo";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(348, 385);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 14;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.ForeColor = Color.Black;
            lbl2.Location = new Point(323, 351);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(76, 20);
            lbl2.TabIndex = 13;
            lbl2.Text = "Id Usuario";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(348, 58);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(125, 27);
            txtDescripcion.TabIndex = 12;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.ForeColor = Color.Black;
            lbl1.Location = new Point(323, 24);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(87, 20);
            lbl1.TabIndex = 11;
            lbl1.Text = "Descripción";
            // 
            // frmModificarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 499);
            Controls.Add(btnModificar);
            Controls.Add(numStock);
            Controls.Add(lbl5);
            Controls.Add(numPrecio);
            Controls.Add(lbl4);
            Controls.Add(numCosto);
            Controls.Add(lbl3);
            Controls.Add(txtUsuario);
            Controls.Add(lbl2);
            Controls.Add(txtDescripcion);
            Controls.Add(lbl1);
            Name = "frmModificarProducto";
            Text = "frmModificarProducto";
            Load += frmMdificarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificar;
        private NumericUpDown numStock;
        private Label lbl5;
        private NumericUpDown numPrecio;
        private Label lbl4;
        private NumericUpDown numCosto;
        private Label lbl3;
        private TextBox txtUsuario;
        private Label lbl2;
        private TextBox txtDescripcion;
        private Label lbl1;
    }
}