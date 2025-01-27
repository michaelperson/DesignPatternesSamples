using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonka.Models
{
    public record ChocolateStatus
    {
        public int DarkChocolateLevel { get; init; }
        public int MilkChocolateLevel { get; init; }
        public int WhiteChocolateLevel { get; init; }
        public bool IsHeating { get; init; }
    }
}
