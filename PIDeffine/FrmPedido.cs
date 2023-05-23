using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIDeffine
{
    public partial class FrmPedido : Form
    {
        //string consulta = String.Format("SELECT IdCliente FROM Clientes WHERE Correo='{0}'", )  
        // Pedido pedido = new Pedido();
        private string nombre;
        public FrmPedido()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }
        public FrmPedido(string nombre)
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
            this.nombre = nombre;
        }
        public FrmPedido(string productName, decimal productPrice, Image productImage)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.productImage = productImage;
        }
        public string NombreProducto { get; set; }
        public decimal PrecioProducto { get; set; }
        public byte[] ImagenProducto { get; set; }

        public FrmPedido(string descripcion, decimal precio, byte[] imagen)
        {
            this.descripcion = descripcion;
            this.precio = precio;
            this.imagen = imagen;
        }

        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private string productName;
        private decimal productPrice;
        private Image productImage;
        private string descripcion;
        private decimal precio;
        private byte[] imagen;

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            if (ImagenProducto != null)
            {
                using (MemoryStream ms = new MemoryStream(ImagenProducto))
                {
                    productImage = Image.FromStream(ms);
                }
                pcbProd1.Image = productImage;
            }
            lblNomProd.Text = NombreProducto;
            lblPrecioProducto.Text = Convert.ToString(PrecioProducto);
            MostrarStock();
        }

        private void MostrarStock()
        {
            int cant = 0;
            string[] tallas = { "XS", "S", "M", "L", "XL", "XXL" };
            RadioButton[] radioButtons = { rdbXS, rdbS, rdbM, rdbL, rdbXL, rdbXXL };

            for (int i = 0; i < tallas.Length; i++)
            {
                //Mostrar el stock disponible de cada talla
                //radioButtons[i].Text = radioButtons[i].Text + " (" + (Producto.StockDisponible(lblNomProd.Text, tallas[i])).ToString() + ")";


                // Obtener el texto existente sin el número
                string textoExistente = radioButtons[i].Text;
                int indiceParentesis = textoExistente.IndexOf('(');
                string textoSinNumero = textoExistente.Substring(0, indiceParentesis);

                // Obtener el nuevo número
                int nuevoNumero = (Producto.StockDisponible(lblNomProd.Text, tallas[i])) - cant;

                // Concatenar el nuevo número al texto sin número
                string nuevoTexto = textoSinNumero + "(" + nuevoNumero.ToString() + ")";

                radioButtons[i].Text = nuevoTexto;
                //Si no hay stock, desactivar el radio button
                if (!Producto.ComprobarStock(lblNomProd.Text, tallas[i], 1))
                {
                    radioButtons[i].Enabled = false;
                }
            }

            //Mostrar correctamente el stock disponible si el producto ya está en el carrito
            for (int j = 0; j < Producto.carrito.Count; j++)
            {
                for (int k = 0; k < tallas.Length; k++)
                {
                    if (Producto.carrito[j].Descripcion == lblNomProd.Text && Producto.carrito[j].Talla == tallas[k])
                    {
                        cant = Producto.carrito[j].Cantidad;
                        // Obtener el texto existente sin el número
                        string textoExistente = radioButtons[k].Text;
                        int indiceParentesis = textoExistente.IndexOf('(');
                        string textoSinNumero = textoExistente.Substring(0, indiceParentesis);

                        // Obtener el nuevo número
                        int nuevoNumero = (Producto.StockDisponible(lblNomProd.Text, tallas[k])) - cant;

                        // Concatenar el nuevo número al texto sin número
                        string nuevoTexto = textoSinNumero + "(" + nuevoNumero.ToString() + ")";

                        radioButtons[k].Text = nuevoTexto;
                    }
                }
            }
        }
    
            

        private void lblVerGuia_Click(object sender, EventArgs e)
        {
            FrmGuiaDeTallas frmguiadetallas = new FrmGuiaDeTallas();
            frmguiadetallas.Show();
        }

        private void bttAnyadir_Click(object sender, EventArgs e)
        {
            string detalles = lblNomProd.Text;
            string talla = "";
            int cantidad = ((int)nudCantidad.Value);
            if (rdbXS.Checked)
            {
                talla = "XS";
            }
            else if (rdbS.Checked)
            {
                talla = "S";
            }
            else if (rdbM.Checked)
            {
                talla = "M";
            }
            else if (rdbL.Checked)
            {
                talla = "L";
            }
            else if (rdbXL.Checked)
            {
                talla = "XL";
            }
            else if (rdbXXL.Checked)
            {
                talla = "XXL";
            }

            ConBD.AbrirConexion();


            
            bool productoEncontrado = false;
            bool suficienteStock = false;

            for (int i = 0; i < Producto.carrito.Count; i++)
            {
                if (Producto.carrito[i].Descripcion == detalles && Producto.carrito[i].Talla == talla)
                {
                    productoEncontrado = true;
                    int nuevaCant = Producto.carrito[i].Cantidad + cantidad;
                    if (Producto.ComprobarStock(detalles, talla, nuevaCant))
                    {
                        suficienteStock = true;
                        Producto.carrito[i].Cantidad = nuevaCant;
                        Producto.carrito[i].Subtotal = Producto.carrito[i].Precio * nuevaCant;
                        break;
                    }
                }
            }

            if (!productoEncontrado)
            {
                if (Producto.ComprobarStock(detalles, talla, cantidad))
                {
                    Producto.RecogerDatosProducto(detalles, talla, cantidad);
                    suficienteStock = true;
                }
            }

            if (suficienteStock)
            {
                MostrarStock();
                MessageBox.Show("Producto agregado correctamente al carrito");
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de la talla seleccionada");
            }

            ConBD.CerrarConexion();
        }
    
    

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lblTallas_Click(object sender, EventArgs e)
        {

        }

        private void lblContacta_MouseEnter(object sender, EventArgs e)
        {
            lblContacta.ForeColor = Color.Aqua;
        }

        private void lblContacta_MouseLeave(object sender, EventArgs e)
        {
            lblContacta.ForeColor = Color.White;

        }

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmTienda frm = new FrmTienda();
            frm.Show();
            this.Hide();
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

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

        private void pcbCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frmcarrito = new FrmCarrito();
            frmcarrito.Show();
            this.Close();
        }

        private void lblContacta_Click(object sender, EventArgs e)
        {
   
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
    }
}
