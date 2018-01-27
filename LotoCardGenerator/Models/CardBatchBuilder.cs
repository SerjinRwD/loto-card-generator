using System.Collections.Generic;

namespace LotoCardGenerator.Models
{
    public class CardBatchBuilder
    {
        public NumbersPool NumbersPool { get; set; }
        public RowsHash RowsHash { get; set; }
        public List<Card> Cards { get; set; }

        public List<Card> Build()
        {
            var b = new CardBuilder();
            var l = new List<Card>();

            for(int i = 0; i < 6; i++)
            {
                l.Add(b.Build(RowsHash, NumbersPool));
            }

            return l;
        }
    }
}
