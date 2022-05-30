using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public static class Metodos
    {
        //1
        public static int SumaMultiplos (int n)
        {   
           
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("La suma de los múltiplos de 3 y 5 menores a " + n + " es: " + suma);

            return suma;
        }

        //2
        public static string CamelCase(string str)
        {
            string[] words = str.Split(' ', '-', '_');
            string result = "";
            foreach (string word in words)
            {
                result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
            }

            Console.WriteLine(result);

            return result;
        }

        //3
        public static string invertirPalabras(string frase)
        {
            string[] palabras = frase.Split(' ');
            string fraseInvertida = "";
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i].Length > 5)
                {
                    string palabraInvertida = "";
                    for (int j = palabras[i].Length - 1; j >= 0; j--)
                    {
                        palabraInvertida += palabras[i][j];
                    }
                    fraseInvertida += palabraInvertida + " ";
                }
                else
                {
                    fraseInvertida += palabras[i] + " ";
                }
            }

            Console.WriteLine(fraseInvertida);

            return fraseInvertida;

        }


    }
}
