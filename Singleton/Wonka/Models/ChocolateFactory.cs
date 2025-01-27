using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonka.Models
{
    public class ChocolateFactory
    {
        private static ChocolateFactory _instance;
        private static readonly object _lock = new object();

        private int _darkChocolateLevel;
        private int _milkChocolateLevel;
        private int _whiteChocolateLevel;
        private bool _isHeating;

        private ChocolateFactory()
        {
            _darkChocolateLevel = 100;
            _milkChocolateLevel = 100;
            _whiteChocolateLevel = 100;
            _isHeating = false;
        }

        public static ChocolateFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ChocolateFactory();
                        }
                    }
                }
                return _instance;
            }
        }

        public ChocolateStatus GetStatus()
        {
            return new ChocolateStatus
            {
                DarkChocolateLevel = _darkChocolateLevel,
                MilkChocolateLevel = _milkChocolateLevel,
                WhiteChocolateLevel = _whiteChocolateLevel,
                IsHeating = _isHeating
            };
        }

        public (bool success, ChocolateStatus status) MakeChocolate(ChocolateType type, int amount)
        {
            int currentLevel = GetChocolateLevel(type);
            if (currentLevel < amount)
                return (false, GetStatus());

            _isHeating = true;
            Thread.Sleep(1000); // Simulation du temps de préparation
            UpdateChocolateLevel(type, -amount);
            _isHeating = false;

            return (true, GetStatus());
        }

        public void RefillChocolate(ChocolateType type)
        {
            switch (type)
            {
                case ChocolateType.Dark:
                    _darkChocolateLevel = 100;
                    break;
                case ChocolateType.Milk:
                    _milkChocolateLevel = 100;
                    break;
                case ChocolateType.White:
                    _whiteChocolateLevel = 100;
                    break;
            }
        }

        private int GetChocolateLevel(ChocolateType type) => type switch
        {
            ChocolateType.Dark => _darkChocolateLevel,
            ChocolateType.Milk => _milkChocolateLevel,
            ChocolateType.White => _whiteChocolateLevel,
            _ => throw new ArgumentException("Type de chocolat invalide")
        };

        private void UpdateChocolateLevel(ChocolateType type, int amount)
        {
            switch (type)
            {
                case ChocolateType.Dark:
                    _darkChocolateLevel += amount;
                    break;
                case ChocolateType.Milk:
                    _milkChocolateLevel += amount;
                    break;
                case ChocolateType.White:
                    _whiteChocolateLevel += amount;
                    break;
            }
        }
    }
}
