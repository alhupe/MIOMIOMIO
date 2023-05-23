using PIDeffine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Data;

namespace PIDeffine
{
    internal class Producto
    {
        int idProducto;
        string descripcion;
        string talla;
        string genero;
        string color;
        decimal precio;
        int stock;
        Image imagen;
        int cantidad;
        decimal subtotal;
        public int IdProducto { get { return idProducto; } }
        public string Descripcion { get { return descripcion; } }
        public string Talla { get { return talla; } }
        public string Genero { get { return genero; } }
        public string Color { get { return color; } }
        public decimal Precio { get { return precio; } }
        public int Stock { get { return stock; } }
        public Image Imagen { get { return imagen; } set { imagen = value; } }
        public int Cantidad { get { return cantidad; } set { cantidad = value; } }
        public decimal Subtotal { get { return subtotal; } set { subtotal = value; } }



        public static List<Producto> carrito = new List<Producto>();

        public Producto(string desc, string tall, string gen, string col, decimal prec, int sto, Image img)
        {
            descripcion = desc;
            talla = tall;
            genero = gen;
            color = col;
            precio = prec;
            stock = sto;
            imagen = img;
        }

        public Producto(int id, string desc, string tall, string gen, string col, decimal prec, int sto, Image img, int cant)
        {
            idProducto = id;
            descripcion = desc;
            talla = tall;
            genero = gen;
            color = col;
            precio = prec;
            stock = sto;
            imagen = img;
            cantidad = cant;
        }

        public Producto(int id, string desc, string tall, string gen, string col, decimal prec, int sto, Image img, int cant, decimal sub)
        {
            idProducto = id;
            descripcion = desc;
            talla = tall;
            genero = gen;
            color = col;
            precio = prec;
            stock = sto;
            imagen = img;
            cantidad = cant;
            subtotal = sub;
        }

        public Producto(int id, string desc, string tall, string gen, string col, decimal prec, int sto, Image img)
        {
            idProducto = id;
            descripcion = desc;
            talla = tall;
            genero = gen;
            color = col;
            precio = prec;
            stock = sto;
            imagen = img;
        }

        public Producto()
        {
        }


        public static DataTable ListarProductos()
        {
            ConBD.AbrirConexion();
            DataTable dataTable = new DataTable();
            string consulta = "SELECT * FROM Productos";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            dataTable.Load(reader);

            reader.Close();
            ConBD.CerrarConexion();
            return dataTable;
        }


        //public static List<Producto> ListarProductos()
        //{
        //    ConBD.AbrirConexion();
        //    List<Producto> lista = new List<Producto>();
        //    string consulta = String.Format("SELECT * FROM Productos");
        //    MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
        //    MySqlDataReader reader = comando.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Producto product = new Producto(reader.GetInt32("idProducto"), reader.GetString("Descripcion"), reader.GetString("Talla"), reader.GetString("Genero"), reader.GetString("Color"), reader.GetDecimal("Precio"), reader.GetInt32("Stock"), reader.GetByte("Imagen"));
        //        lista.Add(product);
        //    }
        //    reader.Close();
        //    ConBD.CerrarConexion();
        //    return lista;
        //}

        public static byte[] CargarImagen(string nombre)
        {
            string consulta = "SELECT Imagen from Producto WHERE descripcion='" + nombre + "';";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            byte[] img = null;
            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    img = (byte[])(reader["Imagen"]);

                }
            }
            reader.Close();
            return img;
        }

        public static List<Producto> FiltrarProducto(string consulta)
        {
            List<Producto> prod = new List<Producto>();
            MySqlCommand command = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("IdProducto");
                string descripcion = (string)reader["Descripcion"];
                string talla = (string)reader["Talla"];
                string genero = (string)reader["Genero"];
                string color = (string)reader["Color"];
                decimal precio = (decimal)reader["Precio"];
                int stock = (int)reader["Stock"];
                byte[] img = (byte[])(reader["Imagen"]);
                Image imagen = null;
                if (img != null)
                {
                    try
                    {
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        imagen = (Image)converter.ConvertFrom(img);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Error converting image: " + ex.Message);
                    }

                    Producto producto = new Producto(descripcion, talla, genero, color, precio, stock, imagen);
                    prod.Add(producto);
                }
            }
            reader.Close();
            return prod;
        }
        public static void AgregarProducto(string descripcion, string talla, string genero, string color, decimal precio, int stock, Image imagen)
        {
            MySqlConnection conexion = ConBD.Conexion;
            Producto nuevoProducto = new Producto(descripcion, talla, genero, color, precio, stock, imagen);
            string consulta = "INSERT INTO Productos (Descripcion, Talla, Genero, Color, Precio, Stock, Imagen) VALUES (@descripcion, @talla, @genero, @color, @precio, @stock, @imagen)";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            // ...
            comando.Parameters.AddWithValue("@descripcion", nuevoProducto.descripcion);
            comando.Parameters.AddWithValue("@talla", nuevoProducto.talla);
            comando.Parameters.AddWithValue("@genero", nuevoProducto.genero);
            comando.Parameters.AddWithValue("@color", nuevoProducto.color);
            comando.Parameters.AddWithValue("@precio", nuevoProducto.precio);
            comando.Parameters.AddWithValue("@stock", nuevoProducto.stock);

            // Convertir la imagen a una matriz de bytes
            byte[] imagenBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                nuevoProducto.imagen.Save(ms, nuevoProducto.imagen.RawFormat);
                imagenBytes = ms.ToArray();
            }

            comando.Parameters.AddWithValue("@imagen", imagenBytes);
            comando.ExecuteNonQuery();
            // ...

        }

        public static void BorrarProducto(int idProducto)
        {
            string consulta = String.Format("DETELE FROM Productos WHERE IdProducto = '{0}'", idProducto);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
        }

        public static bool ComprobarStock(string descripcion, string talla, int cantidad)
        {
            string consulta = String.Format("SELECT stock FROM Productos WHERE Descripcion = '{0}' AND Talla = '{1}' AND Stock >= '{2}'", descripcion, talla, cantidad);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }

        public static int StockDisponible(string descripcion, string talla)
        {
            int stock = 0;
            string consulta = String.Format("SELECT stock FROM Productos WHERE Descripcion = '{0}' AND Talla = '{1}'", descripcion, talla);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                stock = reader.GetInt32("stock");
            }
            reader.Close();
            return stock;
        }


        public static decimal ComprobarPrecio(int idProducto)
        {
            string consulta = String.Format("SELECT precio FROM Productos WHERE idProducto = '{0}'", idProducto);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            decimal precioProducto = 0;
            if (reader.Read())
            {
                precioProducto = reader.GetDecimal(0);
            }

            reader.Close();
            return precioProducto;
        }

        public static void ComprobarClaveValida(string clave)
        {

        }


        public static List<Producto> CargarProductos(string consulta)
        {
            List<Producto> prod = new List<Producto>();
            MySqlCommand command = new MySqlCommand(consulta, ConBD.Conexion);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32("IdProducto");
                string descripcion = (string)reader["Descripcion"];
                string talla = (string)reader["Talla"];
                string genero = (string)reader["Genero"];
                string color = (string)reader["Color"];
                decimal precio = (decimal)reader["Precio"];
                int stock = (int)reader["Stock"];
                byte[] img = (byte[])(reader["Imagen"]);
                Image imagen = null;
                if (img != null)
                {
                    try
                    {
                        System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
                        imagen = (Image)converter.ConvertFrom(img);
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Error converting image: " + ex.Message);
                    }

                    Producto producto = new Producto(descripcion, talla, genero, color, precio, stock, imagen);
                    prod.Add(producto);
                }
            }
            reader.Close();
            return prod;
        }

        public static void RecogerDatosProducto(string descripcion, string talla, int cant)
        {
            string consulta = String.Format("SELECT * FROM Productos WHERE Descripcion = '{0}' AND Talla = '{1}'", descripcion, talla);
            MySqlCommand command = new MySqlCommand(consulta, ConBD.Conexion);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("IdProducto");
                    string desc = (string)reader["Descripcion"];
                    string tall = (string)reader["Talla"];
                    string genero = (string)reader["Genero"];
                    string color = (string)reader["Color"];
                    decimal precio = (decimal)reader["Precio"];
                    int stock = (int)reader["Stock"];
                    byte[] imagenBytes = (byte[])reader["Imagen"];
                    Image imagen;

                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        imagen = Image.FromStream(ms);
                    }


                    Producto alCarrito = new Producto(id, desc, tall, genero, color, precio, stock, imagen, cant, (Convert.ToDecimal(cant) * precio));
                    Producto.carrito.Add(alCarrito);
                }
            }
        }

        public static void RestarStock(int idProducto, int cantidad)
        {
            
            string consulta = String.Format("UPDATE Productos SET Stock = Stock - '{1}' WHERE IdProducto = '{0}'", idProducto, cantidad);
            MySqlCommand command = new MySqlCommand(consulta, ConBD.Conexion);
            command.ExecuteNonQuery();
        }

        public static void AgregarDetallesPedido(int idPedido, int idProducto, int cantidad, decimal subtotal)
        {
            string consulta = String.Format("INSERT INTO Detalle_Pedido (IdPedido, IdProducto, Cantidad, Subtotal) " +
                "VALUES ('{0}', '{1}', '{2}', '{3}')", idPedido, idProducto, cantidad, subtotal);
            MySqlCommand command = new MySqlCommand(consulta, ConBD.Conexion);
            command.ExecuteNonQuery();
        }
    }
}
