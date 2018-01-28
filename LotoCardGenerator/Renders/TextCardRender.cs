using System;
using System.Text;
using LotoCardGenerator.Models;

namespace LotoCardGenerator.Renders
{
    public class TextCardRender : ICardRender
    {
        public StringBuilder builder;

        public void Render(Card card)
        {
            if(card == null)
            {
                throw new ArgumentNullException(nameof(card));
            }

            if(builder == null)
            {
                throw new InvalidOperationException("Свойство builder не задано");
            }

            for(var row = Card.MIN_ROW_ID; row <= Card.MAX_ROW_ID; row++)
            {
                builder.Append('|');

                for(var column = Card.MIN_COLUMN_ID; column <= Card.MAX_COLUMN_ID; column++)
                {
                    var c = card[row, column] == Card.NO_VALUE
                        ? "XX"
                        : card[row, column] == Card.EMPTY_VALUE
                            ? "  "
                            : card[row, column].ToString();

                    c = c.Length == 1
                        ? " " + c
                        : c;

                    builder.Append($"{c}|");
                }

                builder.AppendLine();
            }
        }
    }
}
