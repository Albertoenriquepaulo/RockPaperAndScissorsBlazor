using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperAndScissorsApp.Helpers
{
    public class Hand
    {
        public OptionRPS Selection { get; set; }
        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LosesAgainst { get; set; }
        public string Image { get; set; }
        public string Border { get; set; }

        public string PlayAgainst(Hand opponnennHand)
        {
            if (Selection == opponnennHand.Selection)
            {
                return GameStatus.Draw;
            }
            if (LosesAgainst == opponnennHand.Selection)
            {
                return GameStatus.Loss;
            }
            return GameStatus.Victory;
        }
    }
}
