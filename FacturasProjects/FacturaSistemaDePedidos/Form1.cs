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
    }
}