using System;

namespace Exo4
{
    class Program
    {
        public static void sasieValeurMactriceInt(int [,] matEntier)
        {
            int valSaisie = 0;
            int nbrLigne = matEntier.GetLength(0);
            int nbrColonne = matEntier.GetLength(1);
            
            for (int i = 0; i < nbrLigne; i++)
            {
                for (int j = 0; j < nbrColonne; j++)
                {
                    Console.WriteLine("Veuillez saisir un entier (" + (i + 1) + "/" + nbrLigne + ", " + (j + 1) + "/" + nbrColonne + ") :");    
                    valSaisie = int.Parse(Console.ReadLine());
                    matEntier[i, j] = valSaisie;
                }
            }
            
            Console.WriteLine();
        }

        public static void affichageMatriceInt(int[,] matEntier)
        {
            String str = "[";
            
            for (int i = 0; i < matEntier.Length; i ++)
            {
                str += matEntier[i];

                if (i < matEntier.Length - 1)
                {
                    str += ", ";
                }
            }

            str += "]";
            
            Console.WriteLine("Affichage Tableau :\n" + str + "\n");
        }
        static void Main(string[] args)
        {
            int nbrLigne = 0;
            int nbrColonne = 0;
            Console.WriteLine("Veuillez saisir le nombre de ligne de la matrice :");
            nbrLigne = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le nombre de colonne de la matrice :");
            nbrColonne = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            int[,] matEntier = new int[nbrLigne, nbrColonne];
            
            Console.WriteLine("Nombre Ligne : " + matEntier.GetLength(0));
            Console.WriteLine("Nombre Colonne : " + matEntier.GetLength(1));
            
            

            sasieValeurMactriceInt(matEntier);
            
            //affichageMatriceInt(tabEntier);
        }
    }
}