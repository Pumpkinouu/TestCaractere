//ETML
//Auteur      : Danilo Zivanovic
//Date        : 14.11.2023
//Descritpion :  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////// Déclarations des variables ///////////

            char chrCaractere;
            string strCarType;

            ////////// Programme principal /////////////////

            /// Affichage du titre 
            Console.WriteLine("Programme de test d'un caractère entré au clavier");
            Console.WriteLine("-------------------------------------------------");

            /// Affichage de l'action a effectuer pour l'utilisateur
            Console.Write("Taper un caractère quelconque: ");
            chrCaractere = Convert.ToChar(Console.ReadLine());

            /// Vérfie le caractère saisie par l'utilisateur et en fonction envoie la bonne phrase
            if (char.IsUpper(chrCaractere))
            {
                strCarType = "une lettre majusucle";
            }
            else if (char.IsLower(chrCaractere))
            {
                strCarType = "une lettre miniscule";
            }
            else if (char.IsNumber(chrCaractere))
            {
                strCarType = "un chiffre";
            }
            else
            {
                strCarType = "caractère spécial";
            }
            Console.WriteLine("\n\nLe caractère {0} est {1}, son code ASCII est {2}", chrCaractere, strCarType, Convert.ToInt32(chrCaractere));

            /// Demande a l'utilisateur d'appuyez sur une touche pour continuer
            Console.Write("\nAppuyez sur une touche pour continuer...");
            Console.ReadLine();
        }
    }
}
