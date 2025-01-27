using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wonka.Models.Specialized
{
    public class WhiteChocolateMaker
    {
        public ChocolateStatus MakeWhiteDelight()
        {
            var (success, status) = ChocolateFactory.Instance.MakeChocolate(ChocolateType.White, 10);
            return status;
        }
    }
}
