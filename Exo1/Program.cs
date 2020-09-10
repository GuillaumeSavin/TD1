using System;

namespace Exo1
{
    class Program
    {
        public static void inverseEntier(ref int x, ref int y)
        {
            int temp = 0;
            
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            
            Console.WriteLine("Veuillez saisir l'entier a :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir l'entier b :");
            b = int.Parse(Console.ReadLine());
            
            inverseEntier(ref a, ref b);

            Console.WriteLine("Inversion Entier a = " + a + " et b = " + b);

        }
    }
}