using System.Data;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FacturasProjects.Facturas
{
    public partial class Form1 : Form
    {
        private List<string> nombreList = new List<string>();
        private List<string> apellidoList = new List<string>();
        private List<int> telefonoList = new List<int>();
        private List<int> codigoList = new List<int>();
        private List<string> nombreProductoList = new List<string>();
        private List<double> precioUList = new List<double>();
        private List<int> cantidadList = new List<int>();

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            Text = "Factura Jugueteria";
            MaximizeBox = false;
            txtTotal.Enabled = false; // Deshabilitar el campo Total para que no se pueda editar
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtApellido.Text) ||
               string.IsNullOrWhiteSpace(txtNumTelefonico.Text) ||
               string.IsNullOrWhiteSpace(txtCodigo.Text) ||
               string.IsNullOrWhiteSpace(txtNomProducto.Text) ||
               string.IsNullOrWhiteSpace(txtPrecioU.Text) ||
               string.IsNullOrWhiteSpace(txtCantJ.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantJ.Text, out int cantidad)) { MessageBox.Show("Cantidad debe ser un n�mero entero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (!double.TryParse(txtPrecioU.Text, out double precioU)) { MessageBox.Show("Precio Unitario debe ser un n�mero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (!int.TryParse(txtNumTelefonico.Text, out int telefono)) { MessageBox.Show("Tel�fono debe ser un n�mero entero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (!int.TryParse(txtCodigo.Text, out int codigo)) { MessageBox.Show("C�digo debe ser un n�mero entero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (!txtNombre.Text.All(char.IsLetter) || !txtApellido.Text.All(char.IsLetter)) { MessageBox.Show("Nombre y apellido deben contener solo texto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombreProducto = txtNomProducto.Text;
            // int telefono = Convert.ToInt32(txtNumTelefonico.Text);
            // int codigo = Convert.ToInt32(txtCodigo.Text);
            // double precioU = Convert.ToDouble(txtPrecioU.Text);
            // int cantidad = Convert.ToInt32(txtCantJ.Text);

            for (int i = 0; i < nombreList.Count; i++)
            {

                if (codigoList[i].Equals(codigo))
                {
                    MessageBox.Show("El c�digo ingresado ya se encuentra registrado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (precioU <= 0)
            {
                MessageBox.Show("El precio unitario debe ser mayor a cero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            nombreList.Add(nombre);
            apellidoList.Add(apellido);
            telefonoList.Add(telefono);
            codigoList.Add(codigo);
            nombreProductoList.Add(nombreProducto);
            precioUList.Add(precioU);
            cantidadList.Add(cantidad);

            // Crear una nueva fila en el DataGridView, en orden de agregar los datos ingresados
            tabla.Rows.Add(nombre, apellido, telefono, codigo, nombreProducto, precioU, cantidad);

            limpiarTxt(); // funcion para limpiar los txt
            MessageBox.Show("Datos Ingresados Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void limpiarTxt()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtNumTelefonico.Clear();
            txtCodigo.Clear();
            txtNomProducto.Clear();
            txtPrecioU.Clear();
            txtCantJ.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configurar las columnas del DataGridView
            tabla.AutoGenerateColumns = false;
            tabla.Columns.Clear();

            tabla.Columns.Add("Nombre", "Nombre");
            tabla.Columns.Add("Apellido", "Apellido");
            tabla.Columns.Add("Telefono", "Telefono");
            tabla.Columns.Add("Codigo", "Codigo");
            tabla.Columns.Add("Nombre Producto", "Nombre Producto");
            tabla.Columns.Add("Precio Unitario", "Precio Unitario");
            tabla.Columns.Add("Cantidad", "Cantidad");
            tabla.Columns.Add("Total", "Total");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (codigoList.Count == 0)
            {
                MessageBox.Show("No hay datos en el sistema para calcular el total.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tabla.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar al menos una fila para calcular el total.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = tabla.CurrentRow.Index;

            double subTotal = precioUList[index] * cantidadList[index];
            double iva = subTotal * 0.10; // Calcular el IVA (10% del subtotal)
            double total = subTotal + iva;

            if (total > 2000)
            {
                MessageBox.Show("Su compra obtendra un descuento del 1%", "Descuento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aplicar descuento del 1% si el total es mayor a 2000
                double descuentoEspecial = total * 0.01;
                total = total - descuentoEspecial;
            }

            txtTotal.Text = total.ToString();
            // Replace the line in btnCalcular_Click method
            tabla.Rows[index].Cells["Total"].Value = total;



        }

        private int obtenerCodigoValido()
        {
            while (true)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el c�digo del producto:", "C�digo del Producto", "");

                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("El codigo no puede estar vacio.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1; // Indica que no se ingres� un c�digo v�lido
                }

                int codigoBuscar;
                if(int.TryParse(input, out codigoBuscar))
                {
                    if (codigoList.Contains(codigoBuscar))
                    {
                        MessageBox.Show("El codigo ingresado ya existe. Ingrese un nuevo codigo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    else
                    {
                        return codigoBuscar; // Retorna el c�digo valido
                    }
                }

                if(!int.TryParse(input, out codigoBuscar))
                {
                    MessageBox.Show("El codigo debe ser un numero entero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    continue; // Vuelve a solicitar el c�digo
                }
                
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (codigoList.Count == 0)
            {
                MessageBox.Show("No hay datos en el sistema para buscar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int codigoBuscado = obtenerCodigoValido();
            if(codigoBuscado == -1)
            {
                return;
            }

            bool encontrado = false;

            for (int i = 0; i < codigoList.Count; i++)
            {
                if (codigoList[i].Equals(codigoBuscado))
                {
                    MessageBox.Show($"Producto encontrado: {nombreProductoList[i]} - Precio Unitario: {precioUList[i]} - Cantidad: {cantidadList[i]}", "Producto Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    tabla.ClearSelection();
                    tabla.Rows[i].Selected = true;

                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (codigoList.Count == 0)
            {
                MessageBox.Show("No hay datos en el sistema para buscar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tabla.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar al menos una fila para editar la factura.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
              string.IsNullOrWhiteSpace(txtApellido.Text) ||
              string.IsNullOrWhiteSpace(txtNumTelefonico.Text) ||
              string.IsNullOrWhiteSpace(txtCodigo.Text) ||
              string.IsNullOrWhiteSpace(txtNomProducto.Text) ||
              string.IsNullOrWhiteSpace(txtPrecioU.Text) ||
              string.IsNullOrWhiteSpace(txtCantJ.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            if (!int.TryParse(txtCantJ.Text, out int cantidad)) { MessageBox.Show("Cantidad debe ser un n�mero entero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (!double.TryParse(txtPrecioU.Text, out double precioU)) { MessageBox.Show("Precio Unitario debe ser un n�mero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (!int.TryParse(txtNumTelefonico.Text, out int telefono)) { MessageBox.Show("Tel�fono debe ser un n�mero entero.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (!txtNombre.Text.All(char.IsLetter) || !txtApellido.Text.All(char.IsLetter)) { MessageBox.Show("Nombre y apellido deben contener solo texto.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            int index = tabla.CurrentRow.Index;
            int nuevoCodigo = obtenerCodigoValido();

            if (nuevoCodigo == -1)
            {
                return;
            }

            for (int i = 0; i < nombreList.Count; i++)
            {

                if (codigoList[i].Equals(nuevoCodigo))
                {
                    MessageBox.Show("El c�digo ingresado ya se encuentra registrado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Actualizar los datos en las listas
            codigoList[index] = nuevoCodigo;
            nombreList[index] = txtNombre.Text;
            apellidoList[index] = txtApellido.Text;
            telefonoList[index] = telefono;
            nombreProductoList[index] = txtNomProducto.Text;
            precioUList[index] = precioU;
            cantidadList[index] = cantidad;

            double subtotal = precioUList[index] * cantidadList[index];
            double iva = subtotal * 0.10;
            double total = subtotal + iva;

            tabla.Rows[index].Cells["Total"].Value = total;

        }
    }
}
