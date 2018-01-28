namespace LotoCardGenerator.Models
{
    public class CardBuilder
    {
        public Card Build(NumbersPool pool)
        {
            var card = new Card();

            // Распределение пустых ячеек
            for (var row = Card.MIN_ROW_ID; row <= Card.MAX_ROW_ID; row++)
            {
                while (card.GetEmptyCellsInRowCount(row) < Card.EMPTY_CELLS_IN_ROW_COUNT)
                {
                    var column = Helpers.RandomHelper.Next(Card.MIN_COLUMN_ID, Card.MAX_COLUMN_ID + 1);

                    if (card.GetEmptyCellsInColumnsCount(column) < 2)
                    {
                        card[row, column] = Card.EMPTY_VALUE;
                    }
                }
            }

            // Распределение чисел
            for (var column = Card.MIN_COLUMN_ID; column <= Card.MAX_COLUMN_ID; column++)
            {
                var valuesCount = Card.MAX_VALUE_CELLS_IN_COLUMN_COUNT - card.GetEmptyCellsInColumnsCount(column);

                for (var i = 0; i < valuesCount; i++)
                {
                    var value = pool.GetNextNumber(column);

                    for (var row = Card.MIN_ROW_ID; row <= Card.MAX_ROW_ID; row++)
                    {
                        if(card[row, column] == Card.NO_VALUE)
                        {
                            card[row, column] = value;
                            pool.MarkValue(column, value);
                            break;
                        }
                    }
                }
            }

            return card;
        }
    }
}
