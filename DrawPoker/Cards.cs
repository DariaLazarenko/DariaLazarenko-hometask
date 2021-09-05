using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawPoker
{
    class Cards
    {
        public CardSuit suit { get; set; }
        public CardRank rank { get; set; }
    }

    public enum CardSuit
    {
        sprades,
        hearts,
        diamonds,
        clubs
    }

    public enum CardRank
    {
        Ace,
        King,
        Queen,
        Jack,
        Ten,
        Nine,
        Eight,
        Seven,
        Six,
        Five,
        Four,
        Three,
        Two
    }
}
