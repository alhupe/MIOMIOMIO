using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDeffine
{
    public partial class FrmCarrito : Form
    {

        public FrmCarrito()
        {
            InitializeComponent();
        }
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }

        private void paneldecontrol_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void paneldecontrol_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            DialogResult logOut = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logOut == DialogResult.Yes)
            {
                FrmInicio frm = new FrmInicio();
                frm.Show();
                this.Hide();
            }
        }

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmTienda frm = new FrmTienda();
            frm.Show();
            this.Hide();
        }

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form formulario = Application.OpenForms[i];

                formulario.Close();
                formulario.Dispose();
            }
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            btnConfCompra.Visible = false;
            grbComprar.Visible = false;
            dgvCarrito.DataSource = Producto.carrito;

            dgvCarrito.Columns["IdProducto"].Visible = false;
            dgvCarrito.Columns["Stock"].Visible = false;
            dgvCarrito.Columns["Imagen"].Visible = false;
        }

        private void CargarProductos()
        {
            ConBD.AbrirConexion();

            string consulta = "SELECT * FROM Detalles_Pedido";

            MySqlCommand command = new MySqlCommand(consulta, ConBD.Conexion);

            DataTable dataTable = new DataTable();

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                dataTable.Load(reader);
            }

            dgvCarrito.DataSource = dataTable;
            ConBD.CerrarConexion();
        }

        private void bttEliminarCarrito_Click(object sender, EventArgs e)
        {
            Producto.carrito.Clear();
            MessageBox.Show("Se ha eliminado el carrito");
            dgvCarrito.Visible = false;
        }

        private void bttComprar_Click(object sender, EventArgs e)
        {
            dgvCarrito.Visible = false;
            grbComprar.Visible = true;
            btnConfCompra.Visible = true;
            txtCliente.Text = Cliente.clienteLogeado[0].Nombre + " " + Cliente.clienteLogeado[0].Apellidos;
            txtCorreo.Text = Cliente.clienteLogeado[0].Correo;
            string direccion = txtDireccion.Text;

        }

        private void btnConfCompra_Click(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text;
            int idCliente = Cliente.clienteLogeado[0].IdCliente;
            string fechaString = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime fecha = DateTime.ParseExact(fechaString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            ConBD.AbrirConexion();
            
            for (int i = 0; i < Producto.carrito.Count; i++)
            {
                int idProd = Producto.carrito[i].IdProducto;
                int cantidad = Producto.carrito[i].Cantidad;
                Producto.RestarStock(idProd, cantidad);
            }

            decimal importeTotal = 0;
            for (int i = 0; i < Producto.carrito.Count; i++)
            {
                importeTotal += Producto.carrito[i].Subtotal;
            }

            Pedido.AgregarPedido(idCliente, fecha, importeTotal, direccion);
            int idPedido = Pedido.RecogerIdPedido(idCliente, fechaString, direccion, importeTotal);

            for (int i = 0; i < Producto.carrito.Count; i++)
            {
                Producto.AgregarDetallesPedido(idPedido, Producto.carrito[i].IdProducto, Producto.carrito[i].Cantidad, Producto.carrito[i].Subtotal);
            }

            MessageBox.Show("Tu compra se ha realizado correctamente. Gracias por confiar en nostros");
            ConBD.CerrarConexion();
            
        }

        private void bttFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
