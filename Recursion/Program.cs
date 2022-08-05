using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5; // cambiar este numero por el que quieras saber su cantidad de digitos
            int n2 = 784;
            Console.WriteLine("La cantidad de digitos del numero " + n + " es: "+ nDigitos(n));
            Console.WriteLine("Inversa de " + n2 + " es: " + invertirRecursivo(n2));
        }
        /// <summary>
        /// Recursion de la cantidad de digitos de un numero. (seguir)
        /// Recordar que para el ejercicio 2 esta funcion fue modificada, aceptando cualquier int signed
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int nDigitos(int n) {
            if (n < 10) return 1;
            else
            return 1 + nDigitos(n / 10);
        }

        static int invertirRecursivo(int n) {
            int temp = nDigitos(n);
            if (n == 0) return n;
            else            
                return (int)(Math.Pow(10, temp - 1)) * (n % 10) + invertirRecursivo(n / 10);                      
        }

        //static string invertirString()
    }
}
