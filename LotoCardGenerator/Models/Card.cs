using System;
using System.Text;

namespace LotoCardGenerator.Models
{
    public class Card
    {
        public const int NO_VALUE = -1;
        public const int EMPTY_VALUE = 0;
        public const int MIN_VALUE = 1;
        public const int MAX_VALUE = 90;

        public const int ROWS_COUNT = 3;
        public const int COLUMNS_COUNT = 9;

        public const int EMPTY_CELLS_IN_ROW_COUNT = 4;
        public const int VALUE_CELLS_IN_ROW_COUNT = CELLS_COUNT - EMPTY_CELLS_IN_ROW_COUNT;
        public const int MIN_VALUE_CELLS_IN_COLUMN_COUNT = 1;
        public const int MAX_VALUE_CELLS_IN_COLUMN_COUNT = ROWS_COUNT;

        public const int CELLS_COUNT = COLUMNS_COUNT * ROWS_COUNT;
        public const int EMPTY_CELLS_COUNT = ROWS_COUNT * EMPTY_CELLS_IN_ROW_COUNT;
        public const int VALUE_CELLS_COUNT = CELLS_COUNT - EMPTY_CELLS_COUNT;

        public const int MIN_ROW_ID = 1;
        public const int MAX_ROW_ID = ROWS_COUNT;
        public const int MIN_COLUMN_ID = 1;
        public const int MAX_COLUMN_ID = COLUMNS_COUNT;

        private int[,] _cells;

        public int this[int row, int column]
        {
            get
            {
                if (row < MIN_ROW_ID || row > MAX_ROW_ID)
                {
                    throw new ArgumentOutOfRangeException(nameof(row), $"Значение должно быть между {MIN_ROW_ID} и {MAX_ROW_ID}");
                }

                if (column < MIN_COLUMN_ID || column > MAX_COLUMN_ID)
                {
                    throw new ArgumentOutOfRangeException(nameof(column), $"Значение должно быть между {MIN_COLUMN_ID} и {MAX_COLUMN_ID}");
                }

                return _cells[row - 1, column - 1];
            }

            set
            {
                if (row < MIN_ROW_ID || row > MAX_ROW_ID)
                {
                    throw new ArgumentOutOfRangeException(nameof(row), $"Номер строки должен быть между {MIN_ROW_ID} и {MAX_ROW_ID}");
                }

                if (column < MIN_COLUMN_ID || column > MAX_COLUMN_ID)
                {
                    throw new ArgumentOutOfRangeException(nameof(column), $"Номер столбца должен быть между {MIN_COLUMN_ID} и {MAX_COLUMN_ID}");
                }

                if (value < MIN_VALUE || value > MAX_VALUE)
                {
                    if (!(value == EMPTY_VALUE || value == NO_VALUE))
                    {
                        throw new ArgumentOutOfRangeException(nameof(column), $"Значение должно быть между {MIN_VALUE} и {MAX_VALUE}");
                    }
                }

                _cells[row - 1, column - 1] = value;
            }
        }

        public int GetEmptyCellsInRowCount(int row)
        {
            if (row < MIN_ROW_ID || row > MAX_ROW_ID)
            {
                throw new ArgumentOutOfRangeException(nameof(row), $"Номер строки должен быть между {MIN_ROW_ID} и {MAX_ROW_ID}");
            }

            var cnt = 0;

            for (int column = 0; column < COLUMNS_COUNT; column++)
            {
                if (_cells[row - 1, column] == EMPTY_VALUE)
                {
                    cnt++;
                }
            }

            return cnt++;
        }

        public int GetEmptyCellsInColumnsCount(int column)
        {
            if (column < MIN_COLUMN_ID || column > MAX_COLUMN_ID)
            {
                throw new ArgumentOutOfRangeException(nameof(column), $"Номер столбца должен быть между {MIN_COLUMN_ID} и {MAX_COLUMN_ID}");
            }

            var cnt = 0;

            for (int row = 0; row < ROWS_COUNT; row++)
            {
                if (_cells[row, column - 1] == EMPTY_VALUE)
                {
                    cnt++;
                }
            }

            return cnt++;
        }

        public bool HasNoValueCells()
        {
            for (int row = 0; row < ROWS_COUNT; row++)
            {
                for (int column = 0; column < COLUMNS_COUNT; column++)
                {
                    if(_cells[row, column] == NO_VALUE)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public string RowToString(int row)
        {
            if (row < MIN_ROW_ID || row > MAX_ROW_ID)
            {
                throw new ArgumentOutOfRangeException(nameof(row), $"Номер строки должен быть между {MIN_ROW_ID} и {MAX_ROW_ID}");
            }

            StringBuilder b = new StringBuilder();

            for(int column = MIN_COLUMN_ID; column <= MAX_COLUMN_ID; column++)
            {
                var value = _cells[row - 1, column - 1];

                if(value == NO_VALUE)
                {
                    b.Append('X');
                }
                else if(value == EMPTY_VALUE)
                {
                    b.Append(' ');
                }
                else
                {
                    b.Append(value.ToString());
                }
            }

            return b.ToString();
        }

        public Card()
        {
            _cells = new int[ROWS_COUNT, COLUMNS_COUNT];

            for (int row = 0; row < ROWS_COUNT; row++)
            {
                for (int column = 0; column < COLUMNS_COUNT; column++)
                {
                    _cells[row, column] = NO_VALUE;
                }
            }
        }
    }
}
