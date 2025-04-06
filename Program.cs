using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double calculMoyennex(int [] somme,int nbre)
        {
            int notes = 0;
            for(int k = 0; k<nbre; k++)
            {
                notes = notes + somme[k];
            }

            double moyenne = notes / nbre;
            return moyenne;
        }
        static void Main(string[] args)
        {
            // taille du tableau
            Console.Write("Veuillez saisir le nombre de notes : ");
            int nbre = int.Parse(Console.ReadLine());

            // déclaration du tableau
            int[] tableau = new int[nbre];

            // saisie des notes
            for(int k = 0; k < nbre; k++)
            {
                Console.Write("Veuillez saisir la note numéro " + (k + 1) + "" + ": ");
                tableau[k] = int.Parse(Console.ReadLine());
            }

            Console.Write("La moyenne est " + calculMoyennex(tableau, nbre));
            Console.ReadLine();

        }
    }
}
