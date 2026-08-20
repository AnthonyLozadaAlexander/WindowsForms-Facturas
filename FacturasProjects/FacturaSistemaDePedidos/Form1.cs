namespace FacturasProjects.FacturaSistemaDePedidos
{
    public partial class Form1 : Form
    {
        // Crear las listas
        private List<int> mesaList = new List<int>();
        private List<string> clienteList = new List<string>();
        private List<string> platoList = new List<string>();
        private List<string> categoriaList = new List<string>();
        private List<double> precioList = new List<double>();
        private List<int> cantidadList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            MaximizeBox = false;
            txtTotal.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabla.AutoGenerateColumns = false;
            tabla.Columns.Clear();

            tabla.Columns.Add("Mesa", "Mesa");
            tabla.Columns.Add("Cliente", "Cliente");
            tabla.Columns.Add("Plato", "Plato");
            tabla.Columns.Add("Categoria", "Categoria");
            tabla.Columns.Add("Precio", "Precio");
            tabla.Columns.Add("Cantidad", "Cantidad");
            tabla.Columns.Add("Total", "Total");
        }

        private void limpiarCampos()
        {
            txtCantidad.Clear();
            cboCategoria.SelectedIndex = -1; // no mostrara ningun valor seleccionado
            txtCliente.Clear();
            txtMesa.Clear();
            txtPlato.Clear();
            txtPrecio.Clear();
            txtTotal.Clear();
        }

        private bool validarMesa(String input, out int mesa)
        {
            if (int.TryParse(input, out mesa))
            {
                if ((mesa >= 1) && (mesa <= 20))
                {
                    return true;
                }
                else
                {
                    mesa = 0;
                    return false;
                }
            }
            else
            {
                mesa = 0;
                return false;
            }
        }

        public Boolean verificarCamposVacios()
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtCliente.Text) || string.IsNullOrWhiteSpace(txtPlato.Text) || string.IsNullOrWhiteSpace(txtMesa.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean verificarSoloLetras(String txt)
        {
            if (!txt.All(char.IsLetter))
            {
                MessageBox.Show("Debe contener solo letras.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Debe seleccionar una categoria", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (verificarCamposVacios())
            {
                MessageBox.Show("Por Favor, Complete todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!validarMesa(txtMesa.Text, out int mesa))
            {
                MessageBox.Show("Numero De Mesa Invalido, Ingrese desde 1 hasta 20", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (mesaList.Contains(mesa))
                {
                    MessageBox.Show("Error: La Mesa Ya Se Encuentra Registrada ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            if (verificarSoloLetras(txtCliente.Text))
            {
                return;
            }

            int numMesa = Int32.Parse(txtMesa.Text);
            string cliente = txtCliente.Text;
            string plato = txtPlato.Text;
            string categoria = cboCategoria.SelectedItem.ToString();
            double precio = Double.Parse(txtPrecio.Text);
            int cantidad = Int32.Parse(txtCantidad.Text);

            mesaList.Add(numMesa);
            clienteList.Add(cliente);
            platoList.Add(plato);
            categoriaList.Add(categoria);
            precioList.Add(precio);
            cantidadList.Add(cantidad);

            int index = mesaList.IndexOf(numMesa);
            tabla.Rows.Add(numMesa, cliente, plato, categoria, precio, cantidad);


        }

        private double calcularTotal(int index)
        {
            double descuento = 0;
            double porcentaje = 0;
            double subtotal = (precioList[index] * cantidadList[index]);
            double iva = subtotal * 0.13;
            double total = subtotal + iva;

            if (categoriaList[index] == "Bebidas")
            {
                descuento = subtotal * 0.05; // se realiza un descuento del 5% (Porcentaje)
                total = total - descuento; // se resta el total - el descuento
            }

            if (total > 50.00)
            {
                porcentaje = total * 0.10;
                MessageBox.Show($"Se sugiera una propina del 10%: {porcentaje}", "Sugerencia de Propina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return total;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int index = 0;
            index = tabla.CurrentRow.Index;
            double total = calcularTotal(index);
            txtTotal.Text = String.Format($"{total:F2}");
            tabla.SelectedCells[6].Value = String.Format($"{total:F2}");

        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}