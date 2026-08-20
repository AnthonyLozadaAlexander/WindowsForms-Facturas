namespace FacturasProjects.FacturaSistemaDePedidos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtMesa = new TextBox();
            txtCliente = new TextBox();
            txtPlato = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            txtTotal = new TextBox();
            cboCategoria = new ComboBox();
            btnRegistrar = new Button();
            btnCalcular = new Button();
            btnBuscar = new Button();
            btnEliminar = new Button();
            tabla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 17.01818F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(285, 34);
            label1.TabIndex = 0;
            label1.Text = "Sistema De Pedidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold);
            label2.Location = new Point(59, 121);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 1;
            label2.Text = "N Mesa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold);
            label3.Location = new Point(59, 183);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 2;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold);
            label4.Location = new Point(59, 243);
            label4.Name = "label4";
            label4.Size = new Size(84, 28);
            label4.TabIndex = 3;
            label4.Text = "Plato:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold);
            label5.Location = new Point(346, 45);
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 4;
            label5.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold);
            label6.Location = new Point(59, 318);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 5;
            label6.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold);
            label7.Location = new Point(59, 376);
            label7.Name = "label7";
            label7.Size = new Size(120, 28);
            label7.TabIndex = 6;
            label7.Text = "Cantidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 13.7454548F, FontStyle.Bold);
            label8.Location = new Point(59, 434);
            label8.Name = "label8";
            label8.Size = new Size(84, 28);
            label8.TabIndex = 7;
            label8.Text = "TOTAL:";
            // 
            // txtMesa
            // 
            txtMesa.Font = new Font("Cascadia Code", 9.163636F, FontStyle.Bold);
            txtMesa.Location = new Point(197, 126);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(139, 24);
            txtMesa.TabIndex = 8;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Cascadia Code", 9.163636F, FontStyle.Bold);
            txtCliente.Location = new Point(197, 185);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(139, 24);
            txtCliente.TabIndex = 9;
            // 
            // txtPlato
            // 
            txtPlato.Font = new Font("Cascadia Code", 9.163636F, FontStyle.Bold);
            txtPlato.Location = new Point(197, 248);
            txtPlato.Name = "txtPlato";
            txtPlato.Size = new Size(139, 24);
            txtPlato.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Cascadia Code", 9.163636F, FontStyle.Bold);
            txtPrecio.Location = new Point(197, 318);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(139, 24);
            txtPrecio.TabIndex = 12;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Cascadia Code", 9.163636F, FontStyle.Bold);
            txtCantidad.Location = new Point(197, 381);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(139, 24);
            txtCantidad.TabIndex = 13;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Font = new Font("Cascadia Code", 9.163636F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(197, 434);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(139, 24);
            txtTotal.TabIndex = 14;
            // 
            // cboCategoria
            // 
            cboCategoria.Font = new Font("Cascadia Code", 9.163636F, FontStyle.Bold);
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Items.AddRange(new object[] { "Entrada", "Plato Fuerte", "Postre Bebida" });
            cboCategoria.Location = new Point(484, 50);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(139, 26);
            cboCategoria.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(55, 508);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(132, 46);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(200, 508);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(132, 46);
            btnCalcular.TabIndex = 17;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(55, 577);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(132, 46);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Cascadia Code", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(200, 577);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 46);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // tabla
            // 
            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(473, 121);
            tabla.Name = "tabla";
            tabla.ReadOnly = true;
            tabla.RowHeadersWidth = 47;
            tabla.Size = new Size(680, 542);
            tabla.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 796);
            Controls.Add(tabla);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(btnCalcular);
            Controls.Add(btnRegistrar);
            Controls.Add(cboCategoria);
            Controls.Add(txtTotal);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecio);
            Controls.Add(txtPlato);
            Controls.Add(txtCliente);
            Controls.Add(txtMesa);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formulario ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtMesa;
        private TextBox txtCliente;
        private TextBox txtPlato;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
        private TextBox txtTotal;
        private ComboBox cboCategoria;
        private Button btnRegistrar;
        private Button btnCalcular;
        private Button btnBuscar;
        private Button btnEliminar;
        private DataGridView tabla;
    }
}
