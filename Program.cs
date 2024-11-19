using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPares = numeros.Where(n => n % 2 == 0).ToList();
            var numerosImpares = numeros.Where(n => n % 2 != 0).ToList();
            Console.WriteLine(string.Join(", ", numerosPares));
            Console.WriteLine(string.Join(", ", numerosImpares));
        }
    }
}

