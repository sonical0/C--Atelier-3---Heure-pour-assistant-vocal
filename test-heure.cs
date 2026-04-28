Console.WriteLine("Entrez l'heure actuelle (0-23) :");
int heure = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Entrez les minutes actuelles (0-59) :");
int minute = Convert.ToInt32(Console.ReadLine());

if (heure < 0 || heure > 23 || minute < 0 || minute > 59)
{
    Console.WriteLine("Heure ou minute invalide. Veuillez entrer des valeurs valides.");
    return;
}

if (heure == 0 && minute == 0)
{
    Console.WriteLine("Il est minuit.");
}
else if (heure == 12 && minute == 0)
{
    Console.WriteLine("Il est midi.");
}
else
{
    string momentDeLaJournee;
    string heureEnLettres;

    if (heure == 0)
    {
        momentDeLaJournee = "du matin";
        heureEnLettres = "minuit";
    }
    else if (heure == 12)
    {
        momentDeLaJournee = "de l'après-midi";
        heureEnLettres = "midi";
    }
    else if (heure >= 1 && heure <= 11)
    {
        momentDeLaJournee = "du matin";
        heureEnLettres = NombreEnLettres(heure) + (heure == 1 ? " heure" : " heures");
    }
    else
    {
        momentDeLaJournee = "de l'après-midi";
        heureEnLettres = NombreEnLettres(heure - 12) + ((heure - 12) == 1 ? " heure" : " heures");
    }

    string minuteEnLettres;

    if (minute == 0)
    {
        minuteEnLettres = "pile";
    }
    else if (minute == 1)
    {
        minuteEnLettres = "une minute";
    }
    else
    {
        minuteEnLettres = NombreEnLettres(minute);
    }

    Console.WriteLine($"Il est {heureEnLettres} {minuteEnLettres} {momentDeLaJournee}.");
}

string NombreEnLettres(int nombre)
{
    string[] zeroASeize =
    {
        "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf",
        "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize"
    };

    if (nombre >= 0 && nombre <= 16)
    {
        return zeroASeize[nombre];
    }

    if (nombre == 17)
    {
        return "dix-sept";
    }

    if (nombre == 18)
    {
        return "dix-huit";
    }

    if (nombre == 19)
    {
        return "dix-neuf";
    }

    if (nombre >= 20 && nombre <= 59)
    {
        string[] dizaines = { "", "", "vingt", "trente", "quarante", "cinquante" };
        int dizaine = nombre / 10;
        int unite = nombre % 10;

        if (unite == 0)
        {
            return dizaines[dizaine];
        }

        if (unite == 1)
        {
            return dizaines[dizaine] + " et un";
        }

        return dizaines[dizaine] + "-" + zeroASeize[unite];
    }

    return nombre.ToString();
}
