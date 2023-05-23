using PIDeffine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Collections;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;


namespace PIDeffine
{
    internal class Pedido
    {
        int idPedido;
        int idCliente;
        DateTime fecha;
        decimal importeTotal;
        string direccion;

        public static List<Pedido> pedidoRealizado = new List<Pedido>();
        public int IdPedido { get { return idPedido; } set { idPedido = value; } }
        public int IdCliente { get { return idCliente; } set { idCliente = value; } }
        DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public decimal PrecioTotal { get { return importeTotal; } set { importeTotal = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }


        public Pedido(int idClie, DateTime fech, decimal precioTot, string dir)
        {
            idCliente = idClie;
            fecha = fech;
            importeTotal = precioTot;
            direccion = dir;
        }

        //public static List<Producto> Carrito(int idProduct)
        //{
            
        //}

        public static decimal ComprobarImporteTotal(int idProducto)
        {
            string consulta = String.Format("SELECT precio FROM Productos WHERE idProducto = '{0}'", idProducto);
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            return 0;
        }

        public static void AgregarPedido(int idCliente, DateTime fecha, decimal importeTotal, string direccion)
        {
            

            MySqlConnection conexion = ConBD.Conexion;
            Pedido nuevoPedido = new Pedido(idCliente, fecha, importeTotal, direccion);
            string consulta = "INSERT INTO Pedidos (IdCliente, Fecha, ImporteTotal, Direccion) VALUES (@idCliente, @fecha, @importeTotal, @direccion)";
            MySqlCommand comando = new MySqlCommand(consulta, ConBD.Conexion);
            // ...
            comando.Parameters.AddWithValue("@idCliente", nuevoPedido.idCliente);
            comando.Parameters.AddWithValue("@fecha", nuevoPedido.fecha);
            comando.Parameters.AddWithValue("@importeTotal", nuevoPedido.importeTotal);
            comando.Parameters.AddWithValue("@direccion", nuevoPedido.direccion);
            comando.ExecuteNonQuery();
        }

        public static int RecogerIdPedido(int idCliente, string fecha, string direccion, decimal importeTotal)
        {
            int idPedido = 0;
            string consulta = String.Format("SELECT IdPedido FROM Pedidos WHERE IdCliente = '{0}' AND fecha = '{1}' AND Direccion = '{2}' AND " +
                "ImporteTotal = '{3}'", idCliente, fecha, direccion, importeTotal);
            MySqlCommand command = new MySqlCommand(consulta, ConBD.Conexion);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    idPedido = reader.GetInt32("IdPedido");
                }
            }

            return idPedido;
        }
    }
}
