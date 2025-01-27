// See https://aka.ms/new-console-template for more information
using Wonka.Models;

Console.WriteLine("Woka - Singleton & Factory");
var shop = new ChocolateShop();

Console.WriteLine("🏭 Bienvenue dans la chocolaterie !");

// Afficher l'état initial
DisplayStatus(ChocolateFactory.Instance.GetStatus());

Console.WriteLine("\n📦 Préparation d'un assortiment spécial...");
var finalStatus = shop.MakeSpecialAssortment();

Console.WriteLine("\n✨ Assortiment terminé ! État final de la chocolaterie :");
DisplayStatus(finalStatus);

static void DisplayStatus(ChocolateStatus status)
{
    Console.WriteLine($"🍫 Chocolat noir : {status.DarkChocolateLevel}%");
    Console.WriteLine($"🥛 Chocolat au lait : {status.MilkChocolateLevel}%");
    Console.WriteLine($"⚪ Chocolat blanc : {status.WhiteChocolateLevel}%");
    Console.WriteLine($"🔥 En chauffe : {(status.IsHeating ? "Oui" : "Non")}");
}