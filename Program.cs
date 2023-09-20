using System;

namespace Uppgift_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt hoppade Elin i längdhopp?");
            float X = float.Parse(Console.ReadLine());
            Console.WriteLine("Hu långt hoppade Alma i längdhopp?");
            float Y = float.Parse(Console.ReadLine());
            float Z = X - Y;
            Console.WriteLine("Elin hoppade" + Z + "meter längre äm Alma");
        }
    }
}