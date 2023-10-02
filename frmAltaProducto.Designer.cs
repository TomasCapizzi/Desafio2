namespace Desafio2
{
    partial class frmAltaProducto
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
            lbl1 = new Label();
            txtDescripcion = new TextBox();
            txtUsuario = new TextBox();
            lbl2 = new Label();
            lbl3 = new Label();
            numCosto = new NumericUpDown();
            numPrecio = new NumericUpDown();
            lbl4 = new Label();
            numStock = new NumericUpDown();
            lbl5 = new Label();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.ForeColor = Color.White;
            lbl1.Location = new Point(112, 31);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(87, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(112, 65);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(150, 27);
            txtDescripcion.TabIndex = 1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(112, 392);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 27);
            txtUsuario.TabIndex = 3;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.ForeColor = Color.White;
            lbl2.Location = new Point(112, 358);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(76, 20);
            lbl2.TabIndex = 2;
            lbl2.Text = "Id Usuario";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.ForeColor = Color.White;
            lbl3.Location = new Point(112, 119);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(47, 20);
            lbl3.TabIndex = 4;
            lbl3.Text = "Costo";
            // 
            // numCosto
            // 
            numCosto.Location = new Point(112, 142);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(150, 27);
            numCosto.TabIndex = 5;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(112, 223);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(150, 27);
            numPrecio.TabIndex = 7;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.Transparent;
            lbl4.ForeColor = Color.White;
            lbl4.Location = new Point(112, 200);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(91, 20);
            lbl4.TabIndex = 6;
            lbl4.Text = "Precio Venta";
            // 
            // numStock
            // 
            numStock.Location = new Point(112, 299);
            numStock.Name = "numStock";
            numStock.Size = new Size(150, 27);
            numStock.TabIndex = 9;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.BackColor = Color.Transparent;
            lbl5.ForeColor = Color.White;
            lbl5.Location = new Point(112, 276);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(45, 20);
            lbl5.TabIndex = 8;
            lbl5.Text = "Stock";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(112, 452);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 41);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmAltaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 524);
            Controls.Add(btnAgregar);
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
            Name = "frmAltaProducto";
            Text = "frmAltaProducto";
            Load += frmAltaProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtDescripcion;
        private TextBox txtUsuario;
        private Label lbl2;
        private Label lbl3;
        private NumericUpDown numCosto;
        private NumericUpDown numPrecio;
        private Label lbl4;
        private NumericUpDown numStock;
        private Label lbl5;
        private Button btnAgregar;
    }
}