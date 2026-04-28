namespace Epsi.Atelier3;

public class HeureVocale
{
    public string Convertir(DateTime time)
    {

        string[] heuresEnLettres = 
        [
            "minuit", "une", "deux", "trois", "quatre", "cinq", 
            "six", "sept", "huit", "neuf", "dix", "onze", 
            "douze", "une", "deux", "trois", "quatre", "cinq", 
            "six", "sept", "huit", "neuf", "dix", "onze"
        ];

        int heure = time.Hour;
        string heureTexte = heuresEnLettres[heure];
        return $"{heureTexte} heures pile";   
        }
}