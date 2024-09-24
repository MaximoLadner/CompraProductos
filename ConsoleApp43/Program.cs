using ConsoleApp43.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> products = new List<Producto>
            {
                new Producto("Auriculares inalambricos",10000,"KH003"),
                new Producto("Iphone 14 pro max",1000000,"OP533"),
                new Producto("Cargador de iphone",15000,"LQ834")
            };
            Console.WriteLine("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de telefono: ");
            double telefono = double.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nombre, telefono,"KA131");
            Console.WriteLine("cliente registrado");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Aqui tienes las opciones de poductos que puedes comprar: ");
            string eleccion;
            int total = 0;
            do
            {
                foreach (var item in products)
                {
                    item.MostrarDetalles();
                    Console.WriteLine("---------------------------------");
                }
                Console.WriteLine("Que desea comprar?(escriba 'salir' si no quiere mas nada) ");
                eleccion = Console.ReadLine();
                Console.WriteLine("Que cantidad desea comprar de " + eleccion);
                int cantidad = int.Parse(Console.ReadLine());
                foreach(var item in products)
                {
                    if(eleccion == item.Nombre)
                    {
                        item.MostrarDetalles();
                        total += cantidad;
                        Venta unaVenta = new Venta("23/09/2024", item, total, cliente);
                        unaVenta.CalcularTotal();
                        unaVenta.MostrarVenta();
                    }
                }
                Console.ReadLine();
            } while (eleccion == "salir");
            
        }
    }
}
