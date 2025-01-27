using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wonka.Models.Specialized;

namespace Wonka.Models
{
    public class ChocolateShop
    {
        private readonly DarkChocolateMaker _darkMaker = new();
        private readonly MilkChocolateMaker _milkMaker = new();
        private readonly WhiteChocolateMaker _whiteMaker = new();

        public ChocolateStatus MakeSpecialAssortment()
        {
            var status1 = _darkMaker.MakeSpecialDark();
            var status2 = _milkMaker.MakeMilkTreat();
            var status3 = _whiteMaker.MakeWhiteDelight();

            return ChocolateFactory.Instance.GetStatus();
        }
    }
}
