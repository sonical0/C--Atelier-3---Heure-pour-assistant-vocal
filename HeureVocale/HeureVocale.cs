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
        string heureTexte = heuresEnLettres[heure];

            if (heure == 0)
            {
                return "minuit";
            }
            if (heure == 12)
            {
                return "midi";
            }

            if (heure > 0 && heure < 12)
            {
                return $"{heureTexte} heures pile";
            }

            if (heure >= 13 && heure < 18)
            {
                return $"{heureTexte} heures de l'après-midi";
            }

        return $"{heureTexte} heures du soir";
    }
}