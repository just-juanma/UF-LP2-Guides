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
            string str = "Josefina Herrera Juan Manuel Pampa Team Lorenzo Alegre";
            string neuquen = "neuquen";
            string nose = "Me gustan las verduras";
            Console.WriteLine("La cantidad de digitos del numero " + n + " es: "+ nDigitos(n));
            Console.WriteLine("Inversa de " + n2 + " es: " + invertirRecursivo(n2));
            Console.WriteLine("Inversa de " + str + " es: " + invertirString(str));
            Console.WriteLine("La palabra " + neuquen);
            if (isPalindromo(neuquen)) Console.WriteLine(" es palindromo");
            else Console.WriteLine(" no es palindromo");
            Console.WriteLine("La cantidad de vocales es: " + nVocales(nose));
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

        static string invertirString(string cadena) {
            int temp = cadena.Length - 1;
            if (temp == 0) return cadena;
            else
                return cadena[temp] + invertirString(cadena.Remove(temp));

        }

        /// <summary>
        /// No es recursion realmente (paja)
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        static bool isPalindromo(string cadena)
        {
            int temp = cadena.Length - 1;
            if (temp == 1 || temp == 0) return true;
            else
                return String.Equals(cadena, invertirString(cadena));
        }

        /// <summary>
        /// SOLO CONSIDERAMOS MAYUSCULAS Y MINUSCULAS, NO TILDES NI NADA RARO EN ESPAñOL.. SALUDOS!!!!
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        static uint nVocales(string cadena)
        {
            int temp = cadena.Length - 1, cont = 0;
            if (temp == 0) return (uint)cont;
            else
            {
                if     (cadena[temp] == 'a' ||
                        cadena[temp] == 'e' ||
                        cadena[temp] == 'i' ||
                        cadena[temp] == 'o' ||
                        cadena[temp] == 'u' ||
                        cadena[temp] == 'A' ||
                        cadena[temp] == 'E' ||
                        cadena[temp] == 'I' ||
                        cadena[temp] == 'O' ||
                        cadena[temp] == 'U') cont++;
                return (uint)cont + nVocales(cadena.Remove(temp));
            }
        }

    }
}
