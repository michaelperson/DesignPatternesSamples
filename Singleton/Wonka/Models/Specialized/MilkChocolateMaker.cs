using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonka.Models.Specialized
{
    public class MilkChocolateMaker
    {
        public ChocolateStatus MakeMilkTreat()
        {
            var (success, status) = ChocolateFactory.Instance.MakeChocolate(ChocolateType.Milk, 15);
            return status;
        }
    }
}
