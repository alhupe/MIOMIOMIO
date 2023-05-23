using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using PIDeffine.RecursosLocalizables;


namespace PIDeffine
{
    public partial class FrmTienda : Form
    {
        private List<Producto> productos;
        private List<PictureBox> listaPictureBoxes;
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;
        private bool maximizar = true;

        public FrmTienda()
        {
            InitializeComponent();
            productos = new List<Producto>();
            listaPictureBoxes = new List<PictureBox>();
        }


        private void FrmTienda_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Productos";
            CargarProductos(consulta);
            cmbTalla.Text = "";
            this.MouseDown += new MouseEventHandler(paneldecontrol_MouseDown);
            this.MouseMove += new MouseEventHandler(paneldecontrol_MouseMove);
            this.MouseUp += new MouseEventHandler(paneldecontrol_MouseUp);
        }
        private void AplicarIdioma()
        {
            lblColecciones.Text = StringRecursos.Colecciones;
            lblContacta.Text = StringRecursos.Contacta;
            lblIdioma.Text = StringRecursos.Idioma;
            lblMaximo.Text = StringRecursos.Maximo;
            lblMinimo.Text = StringRecursos.Minimo;
            lblTalla.Text = StringRecursos.Talla;
            lblPrecio.Text = StringRecursos.Precio;
            rdbCamisetas.Text = StringRecursos.Camiseta;
            bttDesign.Text = StringRecursos.Diseño;
            bttFiltrar.Text = StringRecursos.Filtrar;
            rdbPantalones.Text = StringRecursos.Pantalones;
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

        private void pcbMaximizar_Click(object sender, EventArgs e)
        {
            if (maximizar)
            {
                this.WindowState = FormWindowState.Maximized;
                maximizar = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                maximizar = true;
            }
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            // FUNCION QUE CIERRE SESION DE USUARIO

            DialogResult logOut = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logOut == DialogResult.Yes)
            {
                FrmInicio frm = new FrmInicio();
                frm.Show();
                this.Hide();
            }
        }

        private void bttTallaPeque_Click(object sender, EventArgs e)
        {
            // INSERCION SQL MUESTRA LAS TALLAS ORDENADAS DE MAS PEQUEÑAS A MAS GRANDES
        }

        private void bttTallaGrande_Click(object sender, EventArgs e)
        {
            // INSERCION SQL MUESTRA LAS TALLAS ORDENADAS DE MAS GRANDES A MAS PEQUEÑAS

        }

        private void bttCamis_Click(object sender, EventArgs e)
        {
            // MUESTRA UNICAMENTE CAMISETAS
        }

        private void bttPants_Click(object sender, EventArgs e)
        {
            // MUESTRA UNICAMENTE PANTALONES

        }

        private void bttZapas_Click(object sender, EventArgs e)
        {
            // MUESTRA UNICAMENTE ZAPATILLAS

        }

        private void bttDiseño_Click(object sender, EventArgs e)
        {
            // MUESTRA UNICAMENTE EL PRODUCTO DE DISEÑAR TU CAMISETA

        }

        private void lblContacta_Click(object sender, EventArgs e)
        {
            ConBD.CerrarConexion();
            FrmCorreoAyuda frmCorreoAyuda = new FrmCorreoAyuda();
            frmCorreoAyuda.Show();
            this.Close();
        }
        private void FiltrarPrecio(double minPrecio, double maxPrecio)
        {
            if (minPrecio < maxPrecio)
            {
                // INSERCION SELECT PRODUCTOS WHERE PRECIO = minPrecio && PRECIO = MAXPRECIO no se hacer sql perdon(?)
            }
        }

        //Solo se admiten numeros enteros en el filtro de precio minimo
        private void txtPrecioMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }
        }

        //Admitir solo numeros enteros en el filtro de precio maximo
        private void txtPrecioMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }
        }


        private void bttFiltrar_Click(object sender, EventArgs e)
        {
            string talla = cmbTalla.Text;
            decimal precioMin = 0;
            decimal precioMax = 99999;
            string coleccion = "";
            string consulta = "SELECT * FROM Productos";
            string whereConsulta = "";

            if (txtPrecioMin.Text != "") precioMin = decimal.Parse(txtPrecioMin.Text);
            if (txtPrecioMax.Text != "") precioMax = decimal.Parse(txtPrecioMax.Text);

            if (rdbCamisetas.Checked) coleccion = "Camiseta";
            else if (rdbPantalones.Checked) coleccion = "Pantalon";
            else if (rdTodo.Checked) coleccion = "";
            else if (rdbBandas.Checked) coleccion = "banda";
            else if (rdbSeries.Checked) coleccion = "cineytv";
            else if (rdbVideojuegos.Checked) coleccion = "game";

            if (precioMin <= precioMax)
            {
                whereConsulta += string.Format("Precio >= '{0}' && Precio <= '{1}'", precioMin, precioMax);
                if (!string.IsNullOrEmpty(talla))
                {
                    if (!string.IsNullOrEmpty(whereConsulta))
                    {
                        whereConsulta += " AND ";
                    }
                    whereConsulta += string.Format("Talla LIKE '{0}'", talla);
                }
                if (!string.IsNullOrEmpty(coleccion))
                {
                    if (!string.IsNullOrEmpty(whereConsulta))
                    {
                        whereConsulta += " AND ";
                    }
                    whereConsulta += string.Format("Descripcion LIKE '%{0}%'", coleccion);
                }

                if (!string.IsNullOrEmpty(whereConsulta))
                {
                    consulta += " WHERE " + whereConsulta;
                }
            }
            else
            {
                MessageBox.Show("Introduce correctamente el rango de precios");
                return;
            }

            //if (precioMin != 0 || precioMax != 0 || coleccion != "" || talla != "")
            //{
            //    consulta += " WHERE ";
            //    if (precioMin <= precioMax)
            //    {
            //        whereConsulta += String.Format("Precio >= '{0}' && Precio <= '{1}'", precioMin, precioMax);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Introduce bien el rango de precios");
            //        return;
            //    }
            //}
            //if (coleccion != "")
            //{
            //    whereConsulta += String.Format("Descripcion LIKE '%{0}%'", coleccion);
            //}
            //if (talla != "")
            //{
            //    whereConsulta += String.Format("Talla LIKE '{0}'", talla);
            //}


            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.CerrarConexion();
                    ConBD.AbrirConexion();

                    // Reiniciar los PictureBoxes y limpiar las listas
                    foreach (PictureBox pictureBox in listaPictureBoxes)
                    {
                        pictureBox.Click -= PictureBox_Click; // Desasociar el evento Click
                        pictureBox.Dispose(); // Liberar recursos del PictureBox
                    }
                    listaPictureBoxes.Clear();
                    productos.Clear();

                    // Cargar la nueva lista de productos desde la base de datos o fuente de datos
                    productos = Producto.FiltrarProducto(consulta); // Utilizar la variable de instancia productos

                    panelPrinc.Controls.Clear(); // Limpiar el contenido actual del panel

                    int rowIndex = 0;
                    int columnIndex = 0;
                    int maxColumns = 3;
                    int itemWidth = 208;
                    int itemHeight = 248;
                    int spacingX = 10;
                    int spacingY = 10;

                    HashSet<string> descripcionesUnicas = new HashSet<string>(); // Conjunto para almacenar descripciones únicas

                    foreach (Producto producto in productos)
                    {
                        string descripcion = producto.Descripcion;

                        if (descripcionesUnicas.Contains(descripcion))
                        {
                            // Si la descripción ya existe, pasar al siguiente producto
                            continue;
                        }

                        descripcionesUnicas.Add(descripcion); // Agregar la descripción al conjunto de descripciones únicas

                        // Crear el control de imagen
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(itemWidth, itemHeight);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Image = producto.Imagen;
                        pictureBox.Click += PictureBox_Click;
                        pictureBox.Tag = descripcion; // Asignar la descripción al Tag del PictureBox
                        listaPictureBoxes.Add(pictureBox);

                        // Agregar borde a la imagen
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;

                        // Calcular la posición de la imagen
                        int x = columnIndex * (itemWidth + spacingX);
                        int y = rowIndex * (itemHeight + spacingY);

                        // Establecer la posición de la imagen
                        pictureBox.Location = new Point(x, y);

                        // Agregar la imagen al panel
                        panelPrinc.Controls.Add(pictureBox);

                        // Calcular la siguiente posición
                        columnIndex++;
                        if (columnIndex >= maxColumns)
                        {
                            columnIndex = 0;
                            rowIndex++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConBD.CerrarConexion();
            }
        }


        private void cmbTalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DEPENDIENDO SI LA TALLA ES XS S M L XL O XXL MOSTRARA EN EL FORM LOS PRODUCTOS CON LA TALLA SELECCIONADA
        }

        private void pcbPerfil_Click(object sender, EventArgs e)
        {
            // ABRE EL FORMULARIO CON LA INFORMACIÓN DEL USUARIO
        }

        private void bttFiltrar_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void bttFiltrar_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void IdiomaIngles()
        {
            string cultura = "EN-GB";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
        }
        private void IdiomaSpanish()
        {
            string cultura = "ES-ES";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();

        }

        private void pcbspain_Click(object sender, EventArgs e)
        {
            IdiomaIngles();
            pcbspain.Hide();
            pcbingle.Show();
        }

        private void pcbingle_Click(object sender, EventArgs e)
        {
            IdiomaSpanish();
            pcbingle.Hide();
            pcbspain.Show();
        }
        private void pcbCamiBlanca_Click(object sender, EventArgs e)
        {
            FrmPedido frm = new FrmPedido();
            frm.Show();
            this.Hide();
        }

        private void pcbDisenyo_Click(object sender, EventArgs e)
        {
            FrmDisenyo frm = new FrmDisenyo();
            frm.Show();
            this.Hide();
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
        private void CargarProductos(string consulta)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.CerrarConexion();
                    ConBD.AbrirConexion();
                    productos = Producto.CargarProductos(consulta); // Utilizar la variable de instancia productos
                    panelPrinc.Controls.Clear(); // Limpiar el contenido actual del panel

                    int rowIndex = 0;
                    int columnIndex = 0;
                    int maxColumns = 3;
                    int itemWidth = 208;
                    int itemHeight = 248;
                    int spacingX = 10;
                    int spacingY = 10;

                    HashSet<string> descripcionesUnicas = new HashSet<string>(); // Conjunto para almacenar descripciones únicas

                    foreach (Producto producto in productos)
                    {
                        string descripcion = producto.Descripcion;

                        if (descripcionesUnicas.Contains(descripcion))
                        {
                            // Si la descripción ya existe, pasar al siguiente producto
                            continue;
                        }

                        descripcionesUnicas.Add(descripcion); // Agregar la descripción al conjunto de descripciones únicas

                        // Crear el control de imagen
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(itemWidth, itemHeight);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Image = producto.Imagen;
                        pictureBox.Click += PictureBox_Click;
                        pictureBox.Tag = descripcion; // Asignar la descripción al Tag del PictureBox
                        listaPictureBoxes.Add(pictureBox);

                        // Agregar borde a la imagen
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;

                        // Asignar eventos MouseEnter y MouseLeave
                        pictureBox.MouseEnter += (sender, e) =>
                        {
                            pictureBox.BackColor = Color.FromArgb(168, 168, 168);
                        };

                        pictureBox.MouseLeave += (sender, e) =>
                        {
                            pictureBox.BackColor = Color.FromArgb(41, 41, 41);
                        };

                        // Calcular la posición de la imagen
                        int x = columnIndex * (itemWidth + spacingX);
                        int y = rowIndex * (itemHeight + spacingY);

                        // Establecer la posición de la imagen
                        pictureBox.Location = new Point(x, y);

                        // Agregar la imagen al panel
                        panelPrinc.Controls.Add(pictureBox);

                        // Calcular la siguiente posición
                        columnIndex++;
                        if (columnIndex >= maxColumns)
                        {
                            columnIndex = 0;
                            rowIndex++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConBD.CerrarConexion();
            }
        }



        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void MostrarProductos()
        {
            foreach (Producto producto in productos)
            {
                // Create a PictureBox to display the image
                PictureBox pictureBox = new PictureBox();
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = producto.Imagen;

                // Create a Label to display the product name
                Label label = new Label();
                label.Text = producto.Descripcion;
                label.TextAlign = ContentAlignment.MiddleCenter;

                // Create a FlowLayoutPanel to hold the PictureBox and Label
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Width = 120;
                panel.Height = 160;
                panel.Margin = new Padding(10);
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.FlowDirection = FlowDirection.TopDown;
                panel.WrapContents = false;
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(label);

                // Add the panel to the main FlowLayoutPanel
                panelPrinc.Controls.Add(panel);
            }
        }

        private void bttDesign_Click(object sender, EventArgs e)
        {
            FrmDisenyo frmDisenyo = new FrmDisenyo();
            frmDisenyo.Show();
            this.Close();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.AbrirConexion();
                    List<Producto> productos = Producto.FiltrarProducto("SELECT * FROM Productos");
                    PictureBox pictureBox = (PictureBox)sender;
                    Producto producto = ObtenerProductoDesdePictureBox(pictureBox);

                    // Crear instancia del formulario FrmPedido
                    FrmPedido frmPedido = new FrmPedido();

                    // Asignar los valores del producto al formulario FrmPedido
                    frmPedido.NombreProducto = producto.Descripcion;
                    frmPedido.PrecioProducto = producto.Precio;
                    frmPedido.ImagenProducto = ImageToByteArray(producto.Imagen);

                    // Cerrar el formulario FrmTienda
                    this.Close();

                    // Mostrar el formulario FrmPedido
                    frmPedido.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConBD.CerrarConexion();
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }



        private void pcbCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.Show();
            this.Close();
        }

        private void btnBorrarFiltros_Click(object sender, EventArgs e)
        {

            cmbTalla.Text = "";
            txtPrecioMax.Clear();
            txtPrecioMin.Clear();
            rdTodo.Checked = true;
            string consulta = "";
            consulta = String.Format("SELECT * FROM Productos");

            try
            {
                if (ConBD.Conexion != null)
                {
                    ConBD.CerrarConexion();
                    ConBD.AbrirConexion();

                    // Reiniciar los PictureBoxes y limpiar las listas
                    foreach (PictureBox pictureBox in listaPictureBoxes)
                    {
                        pictureBox.Click -= PictureBox_Click; // Desasociar el evento Click
                        pictureBox.Dispose(); // Liberar recursos del PictureBox
                    }
                    listaPictureBoxes.Clear();
                    productos.Clear();

                    // Cargar la nueva lista de productos desde la base de datos o fuente de datos
                    productos = Producto.FiltrarProducto(consulta); // Utilizar la variable de instancia productos

                    panelPrinc.Controls.Clear(); // Limpiar el contenido actual del panel

                    int rowIndex = 0;
                    int columnIndex = 0;
                    int maxColumns = 3;
                    int itemWidth = 208;
                    int itemHeight = 248;
                    int spacingX = 10;
                    int spacingY = 10;

                    HashSet<string> descripcionesUnicas = new HashSet<string>(); // Conjunto para almacenar descripciones únicas

                    foreach (Producto producto in productos)
                    {
                        string descripcion = producto.Descripcion;

                        if (descripcionesUnicas.Contains(descripcion))
                        {
                            // Si la descripción ya existe, pasar al siguiente producto
                            continue;
                        }

                        descripcionesUnicas.Add(descripcion); // Agregar la descripción al conjunto de descripciones únicas

                        // Crear el control de imagen
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(itemWidth, itemHeight);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Image = producto.Imagen;
                        pictureBox.Click += PictureBox_Click;
                        pictureBox.Tag = descripcion; // Asignar la descripción al Tag del PictureBox
                        listaPictureBoxes.Add(pictureBox);

                        // Agregar borde a la imagen
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;

                        // Calcular la posición de la imagen
                        int x = columnIndex * (itemWidth + spacingX);
                        int y = rowIndex * (itemHeight + spacingY);

                        // Establecer la posición de la imagen
                        pictureBox.Location = new Point(x, y);

                        // Agregar la imagen al panel
                        panelPrinc.Controls.Add(pictureBox);

                        // Calcular la siguiente posición
                        columnIndex++;
                        if (columnIndex >= maxColumns)
                        {
                            columnIndex = 0;
                            rowIndex++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                ConBD.CerrarConexion();
            }
        }

        private Producto ObtenerProductoDesdePictureBox(PictureBox pictureBox)
        {
            string descripcionProducto = (string)pictureBox.Tag; // Obtener la descripción del Tag del PictureBox

            // Buscar el primer producto con la descripción correspondiente
            foreach (Producto producto in productos)
            {
                if (producto.Descripcion == descripcionProducto)
                {
                    return producto;
                }
            }

            return null;
        }
    }
}

