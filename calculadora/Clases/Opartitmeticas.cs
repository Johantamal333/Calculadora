using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Funciones
{
    public class Oparitmeticas
    {
        public int Suma(int num1, int num2)
        {
            return (num1 + num2 );

        }
        public int Resta(int num1, int num2)
        {
            return (num1 - num2);
        }

        public int Multiplicacion(int num1, int num2)
        {
            return (num1 * num2);
        }
        public int Cambiopeso(int num1, int num2 = 18)
        {
            return (num1 * num2);

        }



    }


}
