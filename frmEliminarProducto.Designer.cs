namespace Desafio2
{
    partial class frmEliminarProducto
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
            btnEliminar = new Button();
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
            // btnEliminar
            // 
            btnEliminar.Location = new Point(325, 454);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 41);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // numStock
            // 
            numStock.Location = new Point(325, 301);
            numStock.Name = "numStock";
            numStock.Size = new Size(150, 27);
            numStock.TabIndex = 20;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.BackColor = Color.Transparent;
            lbl5.ForeColor = Color.Black;
            lbl5.Location = new Point(325, 278);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(45, 20);
            lbl5.TabIndex = 19;
            lbl5.Text = "Stock";
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(325, 225);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(150, 27);
            numPrecio.TabIndex = 18;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.Transparent;
            lbl4.ForeColor = Color.Black;
            lbl4.Location = new Point(325, 202);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(91, 20);
            lbl4.TabIndex = 17;
            lbl4.Text = "Precio Venta";
            // 
            // numCosto
            // 
            numCosto.Location = new Point(325, 144);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(150, 27);
            numCosto.TabIndex = 16;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.ForeColor = Color.Black;
            lbl3.Location = new Point(325, 121);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(47, 20);
            lbl3.TabIndex = 15;
            lbl3.Text = "Costo";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(325, 394);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 27);
            txtUsuario.TabIndex = 14;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.ForeColor = Color.Black;
            lbl2.Location = new Point(325, 360);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(76, 20);
            lbl2.TabIndex = 13;
            lbl2.Text = "Id Usuario";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(325, 67);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 27);
            txtDescripcion.TabIndex = 12;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.ForeColor = Color.Black;
            lbl1.Location = new Point(325, 33);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(87, 20);
            lbl1.TabIndex = 11;
            lbl1.Text = "Descripción";
            // 
            // frmEliminarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(btnEliminar);
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
            Name = "frmEliminarProducto";
            Text = "frmEliminarProducto";
            Load += frmEliminarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
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