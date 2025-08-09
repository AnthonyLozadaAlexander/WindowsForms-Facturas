namespace FacturasProjects.Facturas
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
            label9 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNumTelefonico = new TextBox();
            txtCedula = new TextBox();
            txtPrecioU = new TextBox();
            txtNomProducto = new TextBox();
            txtTotal = new TextBox();
            txtCantJ = new TextBox();
            txtResultado = new TextBox();
            btnIngresar = new Button();
            btnCalcular = new Button();
            btnEditar = new Button();
            btnBuscar = new Button();
            tabla = new DataGridView();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("CaskaydiaMono NF", 9.163636F, FontStyle.Bold);
            label1.Location = new Point(20, 110);
            label1.Name = "label1";
            label1.Size = new Size(63, 16);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("CaskaydiaMono NF", 9.163636F, FontStyle.Bold);
            label2.Location = new Point(20, 148);
            label2.Name = "label2";
            label2.Size = new Size(63, 16);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("CaskaydiaMono NF", 9.163636F, FontStyle.Bold);
            label3.Location = new Point(20, 184);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 0;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("CaskaydiaMono NF", 9.163636F, FontStyle.Bold);
            label4.Location = new Point(145, 227);
            label4.Name = "label4";
            label4.Size = new Size(63, 16);
            label4.TabIndex = 0;
            label4.Text = "Cedula:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("CaskaydiaMono NF", 9.163636F, FontStyle.Bold);
            label5.Location = new Point(116, 284);
            label5.Name = "label5";
            label5.Size = new Size(103, 16);
            label5.TabIndex = 0;
            label5.Text = "NTelefonico:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("CaskaydiaMono NF", 9.163636F, FontStyle.Bold);
            label6.Location = new Point(114, 341);
            label6.Name = "label6";
            label6.Size = new Size(127, 16);
            label6.TabIndex = 0;
            label6.Text = "NombreProducto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("CaskaydiaMono NF", 9.163636F, FontStyle.Bold);
            label7.Location = new Point(114, 413);
            label7.Name = "label7";
            label7.Size = new Size(127, 16);
            label7.TabIndex = 0;
            label7.Text = "PrecioUnitario:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("CaskaydiaMono NF", 9.163636F, FontStyle.Bold);
            label8.Location = new Point(98, 481);
            label8.Name = "label8";
            label8.Size = new Size(143, 16);
            label8.TabIndex = 0;
            label8.Text = "CantidadJuguetes:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("CaskaydiaMono NF", 9.163636F, FontStyle.Bold);
            label9.Location = new Point(145, 557);
            label9.Name = "label9";
            label9.Size = new Size(55, 16);
            label9.TabIndex = 0;
            label9.Text = "Total:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(101, 100);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(165, 26);
            txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(101, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 26);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(98, 179);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(168, 26);
            txtApellido.TabIndex = 1;
            // 
            // txtNumTelefonico
            // 
            txtNumTelefonico.Location = new Point(76, 303);
            txtNumTelefonico.Name = "txtNumTelefonico";
            txtNumTelefonico.Size = new Size(190, 26);
            txtNumTelefonico.TabIndex = 1;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(76, 246);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(190, 26);
            txtCedula.TabIndex = 1;
            // 
            // txtPrecioU
            // 
            txtPrecioU.Location = new Point(76, 432);
            txtPrecioU.Name = "txtPrecioU";
            txtPrecioU.Size = new Size(190, 26);
            txtPrecioU.TabIndex = 1;
            // 
            // txtNomProducto
            // 
            txtNomProducto.Location = new Point(76, 360);
            txtNomProducto.Name = "txtNomProducto";
            txtNomProducto.Size = new Size(190, 26);
            txtNomProducto.TabIndex = 1;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(76, 585);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(190, 26);
            txtTotal.TabIndex = 1;
            // 
            // txtCantJ
            // 
            txtCantJ.Location = new Point(76, 509);
            txtCantJ.Name = "txtCantJ";
            txtCantJ.Size = new Size(190, 26);
            txtCantJ.TabIndex = 1;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(378, 472);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(764, 327);
            txtResultado.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("CaskaydiaMono NF", 11.7818184F, FontStyle.Bold);
            btnIngresar.Location = new Point(40, 660);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(123, 38);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("CaskaydiaMono NF", 11.7818184F, FontStyle.Bold);
            btnCalcular.Location = new Point(41, 713);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(117, 35);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("CaskaydiaMono NF", 11.7818184F, FontStyle.Bold);
            btnEditar.Location = new Point(176, 662);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(125, 36);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("CaskaydiaMono NF", 11.7818184F, FontStyle.Bold);
            btnBuscar.Location = new Point(176, 712);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(125, 36);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tabla
            // 
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Location = new Point(378, 89);
            tabla.Name = "tabla";
            tabla.RowHeadersWidth = 47;
            tabla.Size = new Size(764, 377);
            tabla.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("CaskaydiaMono NF", 22.2545452F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(41, 24);
            label10.Name = "label10";
            label10.Size = new Size(377, 40);
            label10.TabIndex = 0;
            label10.Text = "Factura Jugueteria";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1171, 813);
            Controls.Add(tabla);
            Controls.Add(btnBuscar);
            Controls.Add(btnEditar);
            Controls.Add(btnCalcular);
            Controls.Add(btnIngresar);
            Controls.Add(txtResultado);
            Controls.Add(txtNomProducto);
            Controls.Add(txtCantJ);
            Controls.Add(txtTotal);
            Controls.Add(txtPrecioU);
            Controls.Add(txtCedula);
            Controls.Add(txtNumTelefonico);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label1);
            Name = "Form1";
            Text = "FormJugueteria";
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
        private Label label9;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNumTelefonico;
        private TextBox txtCedula;
        private TextBox txtPrecioU;
        private TextBox txtNomProducto;
        private TextBox txtTotal;
        private TextBox txtCantJ;
        private TextBox txtResultado;
        private Button btnIngresar;
        private Button btnCalcular;
        private Button btnEditar;
        private Button btnBuscar;
        private DataGridView tabla;
        private Label label10;
    }
}
