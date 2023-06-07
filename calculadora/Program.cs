using Ejercicio01.Clases;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personas personas = new Personas();
            personas.PedirDatos();
        }
    }
}
