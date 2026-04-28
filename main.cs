using System;

class Program
{
    static void Main()
    {
        TraduireHeureMatin("7:00");
        TraduireHeureMatin("1:00");
        TraduireHeureMatin("11:00");
    }

    static void TraduireHeureMatin(string heureFormat)
    {
        string[] lettres = { "", "une", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf", "vingt", "vingt-et-un", "vingt-deux", "vingt-trois", };

        string heureTexte = heureFormat.Split(':')[0];

        if (int.TryParse(heureTexte, out int heure) && heure >= 1 && heure <= 11)
        {
            string marquePluriel = (heure > 1) ? "s" : "";

            Console.WriteLine($"{lettres[heure]} heure{marquePluriel} du matin");
        }
    }
}