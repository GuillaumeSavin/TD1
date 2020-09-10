using System;

namespace Exo2
{
    class Program
    {
        public static void saisieChaineCaractere(ref String str)
        {
            str = Console.ReadLine();
        }
        
        static void Main(string[] args)
        {
            String str = "";
            
            Console.WriteLine("Veuillez rentrer une chaîne de caractère :");
            
            saisieChaineCaractere(ref str);
            
            Console.WriteLine("Voici la chaîne que vous avez rentré : " + str);
        }
    }
}