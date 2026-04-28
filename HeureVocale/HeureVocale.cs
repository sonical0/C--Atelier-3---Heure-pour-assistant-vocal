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

        for (int i = heuresEnLettres.Length - 1; i >= 0; i--)
        {
            if (time.Hour < 12 && time.Hour == i)
            {
                return $"{heuresEnLettres[i]} heures pile";
            }
            if (time.Hour >= 13 && time.Hour < 16)
            {
                return $"{heuresEnLettres[i]} ";
            }
            if (time.Hour >= 16 && time.Hour < 23)
            {
                return $"{heuresEnLettres[i]} heures du soir";
            }
        }

        int heure = time.Hour;
        string heureTexte = heuresEnLettres[heure];
        return $"{heureTexte} heures pile";   
        }
}