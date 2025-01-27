using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonka.Models.Specialized
{
    public class DarkChocolateMaker
    {
        public ChocolateStatus MakeSpecialDark()
        {
             
            var (success, status) = ChocolateFactory.Instance.MakeChocolate(ChocolateType.Dark, 20);
            return status;
        }
    }
}
