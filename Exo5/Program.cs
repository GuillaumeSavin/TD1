using System;

namespace Exo5
{
    class Program
    {
        public static void sasieValeurMactriceInt(int [][] matEntier, int[] nbrColonne)
        {
            int valSaisie = 0;
            int nbrLigne = matEntier.GetLength(0);
            //int nbrColonne = matEntier.GetLength(1);
            
            for (int i = 0; i < nbrLigne; i++)
            {
                for (int j = 0; j < nbrColonne[i]; j++)
                {
                    Console.WriteLine("Veuillez saisir un entier (" + (i + 1) + "/" + nbrLigne + ", " + (j + 1) + "/" + nbrColonne[i] + ") :");    
                    valSaisie = int.Parse(Console.ReadLine());
                    matEntier[i][j] = valSaisie;
                }
            }
            
            Console.WriteLine();
        }

        public static void affichageMatriceInt(int[][] matEntier, int[] nbrColonne)
        {
            String str = "[";
            
            for (int i = 0; i < matEntier.GetLength(0); i ++)
            {
                for (int j = 0; j < nbrColonne[i]; j++)
                {
                    str += matEntier[i][j];
                    if (j < nbrColonne[i] - 1)
                    {
                        str += ", ";
                    }
                }
                
                if (i < matEntier.GetLength(0) - 1)
                {
                    str += "],\n[";
                }

                if (i == matEntier.GetLength(0))
                {
                    str += "]";
                }

                
            }

            str += "]";
            
            Console.WriteLine("Affichage Matrice Déchiqueté :\n" + str + "\n");
        }
        
        static void Main(string[] args)
        {
            int nbrLigne = 0;
            Console.WriteLine("Veuillez saisir le nombre de ligne de la matrice :");
            nbrLigne = int.Parse(Console.ReadLine());
            int[] nbrColonne = new int[nbrLigne];
            int[][] matEntier = new int[nbrLigne][];
            for (int i = 0; i < nbrLigne; i++)
            {
                Console.WriteLine("Veuillez saisir le nombre de colonne de la matrice de la ligne : " + (i + 1) + "/" + nbrLigne);
                nbrColonne[i] = int.Parse(Console.ReadLine());
                matEntier[i] = new int[nbrColonne[i]];
            }
            Console.WriteLine();
            
            
            
            

            sasieValeurMactriceInt(matEntier, nbrColonne);
            
            affichageMatriceInt(matEntier, nbrColonne);
        }
    }
}