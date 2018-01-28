using System.Collections.Generic;

namespace LotoCardGenerator.Models
{
    public class CardBatchBuilder
    {
        private NumbersPool _numbersPool;
        private RowsHash _rowsHash;
        private CardBuilder _builder;

        private int _doublesOccurs = 0;
        public int DoublesOccurs { get => _doublesOccurs; }

        public List<Card> Build(int count)
        {
            var l = new List<Card>();
            var attemps = 1000;
            var strings = new List<string>();

            _numbersPool.Reset();
            _rowsHash.Clear();

            for (int i = 0; i < count; i++)
            {
                attemps = 1000;

                while (attemps-- > 0)
                {
                    // генерация карты
                    var card = _builder.Build(_numbersPool);

                    // проверка, что в карте все ячейки заполнены
                    if(card.HasNoValueCells())
                    {
                        _numbersPool.Reset();
                        continue;
                    }

                    // сброс кэша строк
                    strings.Clear();

                    // вычисление строк
                    for(var row = Card.MIN_ROW_ID; row <= Card.MAX_ROW_ID; row++)
                    {
                        strings.Add(card.RowToString(row));
                    }

                    // сверка строк с хэшем строк
                    foreach(var s in strings)
                    {
                        if(_rowsHash.Contains(s))
                        {
                            _doublesOccurs++;
                            continue;
                        }
                    }

                    // регистрация строк в хэше
                    foreach (var s in strings)
                    {
                        if(!_rowsHash.Add(s))
                        {
                            throw new System.Exception("Пропущен дуль!");
                        }
                    }

                    l.Add(card);
                    break;
                }

                if(attemps <= 0)
                {
                    throw new System.Exception("Похоже, комбинации кончились, приятель!");
                }
            }

            return l;
        }

        public CardBatchBuilder()
        {
            _numbersPool = new NumbersPool();
            _rowsHash = new RowsHash();
            _builder = new CardBuilder();
        }
    }
}
