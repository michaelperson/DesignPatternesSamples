using CarteDeCreditFactory.Interface;
using FactorySerialKiller.Models;

namespace CarteDeCreditFactory.Models
{
    public class SerialKillerFactory
    {       
        public static ISerialKiller CreateKiller(string killerType )
        {
            if (string.IsNullOrWhiteSpace(killerType))
            {
                throw new ArgumentException("Le nom du sérial killer ne peut pas être vide ou nul.");
            }
            

            return killerType.ToLower() switch
            {
                "bundy" => new Bundy(),
                "jack" => new Jack(),
                "dahmer" => new Dahmer(),
                "garavito" => new Garavito(),
                "xinhai" => new Xinhai(),
                "orange"=> new Trump(2025),

                _ => throw new ArgumentException($"Le nom du sérial killer '{killerType}' n'est pas valide ou pas pris en charge."),
            };
        }

        public static List<ISerialKiller> CreateKillerList()
        {
            return new List<ISerialKiller>
            {
                new Bundy(),
                new Jack(),
                new Dahmer(),
                new Garavito(),
                new Xinhai(), 
                new Trump(2025)
            };
        }

    }
}
