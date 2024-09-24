using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43.Clases
{
    public class Cliente
    {
        private string _nombre;
        private double _telefono;
        private string _codigo;
        public Cliente(string nombre, double telefono, string codigo)
        {
            _nombre = nombre;
            _telefono = telefono;
            _codigo = codigo;
        }
        public string Nombre 
        { 
            get { return _nombre; } 
            set { _nombre = value; }
        }
        public double Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}\nTelefono: {Telefono}\nCodigo: {Codigo}");
        }
    }
}
