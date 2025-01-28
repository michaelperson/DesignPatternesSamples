using CarteDeCreditFactory.Interface;
using CarteDeCreditFactory.Models;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string killerType = "";
        Console.WriteLine("Veuillez choisir un nom de sérial killer");
        Console.WriteLine("Bundy, Jack, Dahmer, Garavito,Xinhai, orange ou liste");
        killerType = Console.ReadLine();
        Console.WriteLine("");
        List<ISerialKiller> killerList = SerialKillerFactory.CreateKillerList();
        if (killerType.ToLower() == "liste")
        {
            foreach (var killer in killerList)
            {
                Console.WriteLine($"Nom : {killer.GetName()}");
                Console.WriteLine($"Surnom : {killer.GetSurname()}");
                Console.WriteLine($"Genre des victimes : {killer.GetVictimGenre()}");
                Console.WriteLine($"Nombre total de victimes : {killer.GetProduction()}");
                Console.WriteLine($"Nombre d'années d'activité : {killer.GetAnnualActivity()}");
                Console.WriteLine($"Taux annuel moyen : {killer.GetAnnualRate()} victimes/an");
                Console.WriteLine("------------------------------------\n");
            }
        }        

        try
        {
            ISerialKiller killerDetails = SerialKillerFactory.CreateKiller(killerType);
           
            Console.WriteLine(" ---- Détails du sérial killer ----\n");
            Console.WriteLine($"Nom : {killerDetails.GetName()}");
            Console.WriteLine($"Surnom : {killerDetails.GetSurname()}");
            Console.WriteLine($"Genre des victimes : {killerDetails.GetVictimGenre()}");
            Console.WriteLine($"Nombre total de victimes : {killerDetails.GetProduction()}");
            Console.WriteLine($"Nombre d'années d'activité : {killerDetails.GetAnnualActivity()}");
            Console.WriteLine($"Taux annuel moyen : {killerDetails.GetAnnualRate()} victimes/an");
        }
        catch (ArgumentException ex)
        {
            // Message d'erreur clair pour l'utilisateur
            Console.WriteLine($"\nErreur : {ex.Message}");
        }
        catch (Exception ex)
        {
            // Pour toute autre erreur
            Console.WriteLine($"\nUne erreur inattendue s'est produite : {ex.Message}");
        }


    }

}