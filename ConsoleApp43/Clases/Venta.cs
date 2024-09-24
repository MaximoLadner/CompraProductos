using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43.Clases
{
    public class Venta
    {
        private string _fecha;
        private Producto _productoVendido;
        private int _cantidad;
        private Cliente _client;
        public Venta(string fecha, Producto productoVendido, int cantidad, Cliente client)
        {
            _fecha = fecha;
            _productoVendido = productoVendido;
            _cantidad = cantidad;
            _client = client;
        }
        public string Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public Producto ProductoVendido
        {
            get { return _productoVendido; }
            set { _productoVendido = value; }
        }
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public Cliente Client
        {
            get { return _client; }
            set { _client = value; }
        }
        public void MostrarVenta()
        {
            Console.WriteLine($"Fecha de la venta: {Fecha}\nProdcuto: {ProductoVendido.Nombre}\n Cantidad: {Cantidad}\nCliente: {Client.Nombre}\nel total" +
                $" de la venta es de {CalcularTotal()}");
        }
        public double CalcularTotal()
        {
           double total = 0;
           total = ProductoVendido.Precio * Cantidad;
            return total;
        }
    }
}
