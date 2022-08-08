using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args) // try changing different values
        {
            //// exercise 1
            //int n = 5; 
            //Console.WriteLine("The number of digits of the number " + n + " is: " + nDigits(n));

            //// exercise 2
            //int n = 784; // change this number to the number you want to know its number of digits
            //Console.WriteLine("Inverse of " + n + " is: " + invertRecursive(n));

            //// exercise 3
            //string str = "By Josefina Herrera and Juan M. Kapnik";
            //Console.WriteLine("Inverse of " + str + " is: " + invertString(str));

            //// exercise 4
            //string palindrome = "neuquen";
            //if (isPalindrome(palindrome)) Console.WriteLine(" is palindrome");
            //else Console.WriteLine(" is not palindrome");

            //// exercise 5
            //string vowels = "I like vegetables";
            //Console.WriteLine("The number of vowels in " + vowels + " is: " + nVowels(vowels));

            //// exercise 6
            //uint n = 5;
            //Console.WriteLine("The sum of the squares of " + n + " is: " + sumSquares(n));

            //// exercise 7
            //int[] arr = { 26, 32, 43, 65 };
            //Console.WriteLine("The sum of the array is: " + sumArray(arr));

            //// exercise 8
            //int n1 = 5, n2 = 3;
            //Console.WriteLine("C(" + n1 + "," + n2 + ") is " + C(n1, n2));
            //n1 += 4; n2 += 1;
            //Console.WriteLine("C(" + n1 + "," + n2 + ") is " + C(n1, n2));
        }


        /// <summary>
        /// Base case: the number is one digit when n < 10
        /// Recursive case: take out the last digit for each call to the function
        /// Remember that for exercise 2 this function was modified, accepting any signed int
        /// In case you want to do this exercise correctly (as per the guide), change what the function returns to 'uint', and the parameter to 'uint'
        /// </summary>
        /// <param name="n">Number to count its digits</param>
        /// <returns>Quantity of digits of the number</returns>

        static int nDigits(int n) {
            if (n < 10) return 1;
            else
            return 1 + nDigits(n / 10);
        }

        /// <summary>
        /// Base case: the inverse of a number n < 10, is that same number
        /// Recusive case: Use the last digit (n % 10) to multiply it by the decimal base (10) ^ n - 1, where n 
        /// is the number of digits (the previous function is used)
        /// </summary>
        /// <param name="n">Number to find its inverse</param>
        /// <seealso cref="https://docs.microsoft.com/en-us/dotnet/api/system.math?view=net-6.0"/>
        /// <returns>Inverse of a number</returns>
        static int invertRecursive(int n) {
            if (n < 10) return n;
            else            
                return (int)(Math.Pow(10, nDigits(n) - 1)) * (n % 10) + invertRecursive(n / 10);                      
        }

        /// <summary>
        /// Base case: string has no characters
        /// Recursive case: add the last letter at the beginning and delete the last letter of the original string
        /// </summary>
        /// <param name="ch">Character array (string)</param>
        /// <seealso cref="https://docs.microsoft.com/en-us/dotnet/api/system.string.remove?view=net-6.0"/>
        /// <returns>String reverse</returns>
        static string invertString(string ch) {
            if (ch.Length - 1 == 0) return ch;
            else
                return ch[ch.Length - 1] + invertString(ch.Remove(ch.Length - 1));

        }

        /// <summary>
        /// Base case: if the string length is n <= 1, in which case it is a palindrome because it has one or less letters.
        /// Recursive case: that of the previous function
        /// If we use the function from the other exercise, and look for if it is equal to the original word, no further recursion is necessary
        /// </summary>
        /// <param name="ch">Character array (string)</param>
        /// <seealso cref="https://docs.microsoft.com/en-us/dotnet/api/system.string?view=net-6.0"/>
        /// <returns>If its palindrome, or not</returns>
        static bool isPalindrome(string ch)
        { 
            if (ch.Length - 1 <= 1) return true;
            else
                return String.Equals(ch, invertString(ch));
        }

        /// <summary>
        /// Base case: the length of the word is 1
        /// Recursive case: verify that the character is a vowel(here we test both lower and upper case) and
        /// return the counter with the vowel counted(or not), and delete the last character.
        /// This exercise could surely have been performed in a more optimal way. We feel that recursion is not very useful in this case
        /// </summary>
        /// <param name="ch">Character array (string)</param>
        /// <returns>Vowels total</returns>
        static int nVowels(string ch)
        {
            int temp = ch.Length - 1, cont = 0;
            if (temp == 0) return cont;
            else
            {
                if     (ch[temp] == 'a' ||
                        ch[temp] == 'e' ||
                        ch[temp] == 'i' ||
                        ch[temp] == 'o' ||
                        ch[temp] == 'u' ||
                        ch[temp] == 'A' ||
                        ch[temp] == 'E' ||
                        ch[temp] == 'I' ||
                        ch[temp] == 'O' ||
                        ch[temp] == 'U') cont++;
                return cont + nVowels(ch.Remove(temp));
            }
        }

        /// <summary>
        /// Base case: that the number is 0, since its square is 0
        /// Recursive case: I add the number squared, while we are approaching the base case (n - 1).
        /// </summary>
        /// <param name="n">number to find its sum of squares</param>
        /// <returns>sum of squares</returns>
        static uint sumSquares(uint n)
        {
            if (n == 0) return 0;
            else
                return (uint)Math.Pow(n, 2) + sumSquares(n - 1);
        }

        /// <summary>
        /// Base case: array length to be 1
        /// Recursive case: I add the value in the last position, and remove it from the array.
        /// </summary>
        /// <param name="arr">array to calculate their sum</param>
        /// <seealso cref="https://docs.microsoft.com/en-us/dotnet/api/system.array.getvalue?view=net-6.0"/>
        /// <seealso cref="https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take?view=net-6.0"/>
        /// <returns>combined element</returns>
        static int sumArray(int[] arr)
        {
            if (arr.Length <= 1) return (int)arr.GetValue(arr.Length - 1);
            else
                return (int)arr.GetValue(arr.Length - 1) + sumArray(arr.Take(arr.Length - 1).ToArray());
        }

        /// <summary>
        /// Base case: the exercise tells me that C(n,0) = C(n,n) = 1
        /// Recursive case: the exercise tells me that the combinatorial formula can be expressed as C(n - 1, r - 1) + C(n - 1, r)
        /// </summary>
        /// <param name="n">Set of n items</param>
        /// <param name="r">Subset of n items</param>
        /// <returns>combinatorial calculation</returns>
        static int C(int n, int r)
        {
            if (r == 0 || n == r) return 1;
            else
                return C(n - 1, r - 1) + C(n - 1, r);
        }
    }
}
