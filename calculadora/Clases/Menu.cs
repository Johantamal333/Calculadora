using Ejercicio01.Funciones;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Funciones
{
    internal class Menu
    {
        public void Opciones()
        {
            Console.WriteLine("ingresa una de las operaciones");
            Console.WriteLine("1: suma");
            Console.WriteLine("2: resta");
            Console.WriteLine("3: multiplicacion");
            int opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("ingresa el primer valor");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresa el segundo valor");
            int num2 = int.Parse(Console.ReadLine());
            Oparitmeticas operacion = new Oparitmeticas();
            switch (opcion)
            {
                case 1:
                    int result = operacion.Suma(num1, num2);
                    Console.WriteLine("el resultado es " + result);
                    break;
                case 2:
                    int result2 = operacion.Resta(num1, num2);
                    Console.WriteLine("el resultado es " + result2);
                    break;
                case 3:
                    int result3 = operacion.Multiplicacion(num1, num2);
                    Console.WriteLine(" El resultadp es" + result3);
                    break;
                case 4:
                    int result4 = operacion.Cambiopeso(num1);
                    Console.WriteLine(" eol resultado es" + result4);
                    break;
                default:
                    Console.WriteLine(" no hay esa opcion q triste");
                    break;
            }
        }
    }
}