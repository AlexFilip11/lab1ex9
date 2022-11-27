using System;

namespace lab1ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //interschimbam doua numere intregi
            int x, y, aux;
            Console.WriteLine("Introduceti doua numere intregi");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            aux = x;
            x = y;
            y = aux;
            Console.WriteLine("Valori interschimbate, noul x este " + x + " iar y este " + y);
        }
    }
}
