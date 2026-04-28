using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> heuresEnLettres = new Dictionary<int, string>()
        {
            {0, "minuit"}, {1, "une"}, {2, "deux"}, {3, "trois"}, {4, "quatre"},
            {5, "cinq"}, {6, "six"}, {7, "sept"}, {8, "huit"}, {9, "neuf"},
            {10, "dix"}, {11, "onze"}, {12, "douze"}, {13, "une"}, {14, "deux"},
            {15, "trois"}, {16, "quatre"}, {17, "cinq"}, {18, "six"}, {19, "sept"},
            {20, "huit"}, {21, "neuf"}, {22, "dix"}, {23, "onze"}
        };

        Console.Write("Ton heure sous format 00h00 : ");
        string input = Console.ReadLine();

        if (!string.IsNullOrEmpty(input) && input.Length >= 2)
        {
            string heureString = input.Substring(0, 2);

            if (int.TryParse(heureString, out int heureAffichee))
            {
                string heureTexte = heuresEnLettres.ContainsKey(heureAffichee)
                                    ? heuresEnLettres[heureAffichee]
                                    : heureAffichee.ToString();

                if (heureAffichee <= 12)
                {
                    if (heureAffichee == 0)
                    {
                        Console.WriteLine("Il est minuit.");
                    }
                    else if (heureAffichee == 12)
                    {
                        Console.WriteLine("Il est midi.");
                    }
                    else
                    {
                        Console.WriteLine($"Il est {heureTexte} heure(s) du matin.");
                    }
                }
                else if (heureAffichee > 12 && heureAffichee < 16)
                {
                    Console.WriteLine($"Il est {heureTexte} heure(s) de l'après-midi.");
                }
                else
                {
                    Console.WriteLine($"Il est {heureTexte} heure(s) du soir.");
                }
            }
            else
            {
                Console.WriteLine("Erreur : Les deux premiers caractères doivent être des chiffres.");
            }
        }
        else
        {
            Console.WriteLine("Erreur : Format invalide. Utilise bien le format 00h00.");
        }
    }
}