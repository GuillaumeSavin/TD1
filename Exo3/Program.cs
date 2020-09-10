using System;

namespace Exo3
{
    class Program
    {
        public static void sasieValeurTableau(int [] tabEntier)
        {
            int valSaisie = 0;
            
            for (int i = 0; i < tabEntier.Length; i++)
            {
                Console.WriteLine("Veuillez saisir un entier (" + (i + 1) + "/" + tabEntier.Length + ") :");
                valSaisie = int.Parse(Console.ReadLine());
                tabEntier[i] = valSaisie;
            }
            
            Console.WriteLine();
        }

        public static void affichageTableauInt(int[] tabEntier)
        {
            String str = "[";
            
            for (int i = 0; i < tabEntier.Length; i ++)
            {
                str += tabEntier[i];

                if (i < tabEntier.Length - 1)
                {
                    str += ", ";
                }
            }

            str += "]";
            
            Console.WriteLine("Affichage Tableau :\n" + str + "\n");
        }

        public static void trierTableauInt(int[] tabEntier)
        {
            int sauv = 0;
            
            for (int i = 0; i < tabEntier.Length - 1; i ++)
            {
                for (int j = i + 1; j < tabEntier.Length; j ++)
                {
                    if (tabEntier[i] > tabEntier[j])
                    {
                        sauv = tabEntier[i];

                        tabEntier[i] = tabEntier[j];
                        tabEntier[j] = sauv;
                    }                    
                }
            }
        }
        
        static void Main(string[] args)
        {
            int taille = 0;
            Console.WriteLine("Veuillez saisir la taille du tableau :");
            taille = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            int[] tabEntier = new int[taille];
            
            

            sasieValeurTableau(tabEntier);
            
            affichageTableauInt(tabEntier);

            Console.WriteLine("Trie du tableau saisie par ordre croissant :");
            trierTableauInt(tabEntier);
            
            affichageTableauInt(tabEntier);

        }
    }
}