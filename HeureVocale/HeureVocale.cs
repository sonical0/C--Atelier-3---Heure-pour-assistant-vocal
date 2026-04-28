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

        int heure = time.Hour;
        int minute = time.Minute;
        string heureTexte = heuresEnLettres[heure];

        string baseTexte;
        if (heure == 0)
        {
            baseTexte = "minuit";
        }
        else if (heure == 12)
        {
            baseTexte = "midi";
        }
        else
        {
            baseTexte = $"{heureTexte} heures";
        }

        string suffixe = "";
        if (minute == 0 && heure > 0 && heure < 12)
        {
            suffixe = " pile";
        }
        else if (heure >= 13 && heure < 18)
        {
            suffixe = " de l'après-midi";
        }
        else if (heure >= 18)
        {
            suffixe = " du soir";
        }

        if (minute == 0)
        {
            return baseTexte + suffixe;
        }

        string minuteTexte = minute switch
        {
            5 => " cinq",
            10 => " dix",
            15 => " et quart",
            20 => " vingt",
            25 => " vingt-cinq",
            30 => " et demie", 
            
        };

        return baseTexte + minuteTexte + suffixe;
    }
}