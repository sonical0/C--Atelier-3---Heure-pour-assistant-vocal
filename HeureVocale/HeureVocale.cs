namespace Epsi.Atelier3;

public class HeureVocale
{
    public string Convertir(DateTime time)
    {
        string[] heuresEnLettres =
        [
            "minuit", "une", "deux", "trois", "quatre", "cinq",
            "six", "sept", "huit", "neuf", "dix", "onze",
            "midi", "une", "deux", "trois", "quatre", "cinq",
            "six", "sept", "huit", "neuf", "dix", "onze"
        ];

        int heureInitiale = time.Hour;
        int minute = time.Minute;

        // Si la minute dépasse 30, on bascule sur l'heure suivante
        int heureCible = minute > 30 ? (heureInitiale + 1) % 24 : heureInitiale;

        string heureTexte = heuresEnLettres[heureCible];

        // 1. Détermination de la base de l'heure
        string baseTexte;
        if (heureCible == 0)
        {
            baseTexte = "minuit";
        }
        else if (heureCible == 12)
        {
            baseTexte = "midi";
        }
        else
        {
            // Gestion propre du singulier pour "une heure" (1h ou 13h)
            string pluriel = (heureCible % 12 == 1) ? "" : "s";
            baseTexte = $"{heureTexte} heure{pluriel}";
        }

        // 2. Détermination du texte des minutes (inclus les "moins")
        string minuteTexte = minute switch
        {
            5 => " cinq",
            10 => " dix",
            15 => " et quart",
            20 => " vingt",
            25 => " vingt-cinq",
            30 => " et demie",
            35 => " moins vingt-cinq",
            40 => " moins vingt",
            45 => " moins le quart",
            50 => " moins dix",
            55 => " moins cinq",
            _ => ""
        };

        // 3. Détermination du suffixe de fin en fonction de l'heure cible
        string suffixe = "";
        if (minute == 0 && heureCible > 0 && heureCible < 12)
        {
            suffixe = " pile";
        }
        else if (heureCible >= 13 && heureCible < 18)
        {
            suffixe = " de l'après-midi";
        }
        else if (heureCible >= 18)
        {
            suffixe = " du soir";
        }

        // On assemble les trois morceaux
        return baseTexte + minuteTexte + suffixe;
    }
}