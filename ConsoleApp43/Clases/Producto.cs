using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43.Clases
{
    public class Producto
    {
        private string _nombre;
        private double _precio;
        private string _Codigo;
        public Producto(string nombre, double precio, string codigo)
        {
            _nombre = nombre;
            _precio = precio;
            _Codigo = codigo;
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double Precio 
        {  
            get { return _precio; } 
            set { _precio = value; }
        }
        public string Codigo 
        { 
            get { return _Codigo; } 
            set { _Codigo = value; }
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}\nPrecio: ${Precio}\nCodigo: {Codigo}");
        }
    }
}
