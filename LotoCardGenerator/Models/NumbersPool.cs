using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoCardGenerator.Models
{
    public class NumbersPool
    {
        private Dictionary<int, NumberSet> _sets;

        public const int MIN_COLUMN_ID = 1;
        public const int MAX_COLUMN_ID = 9;

        public int GetNextNumber(int columnId)
        {
            if(columnId < MIN_COLUMN_ID || columnId > MAX_COLUMN_ID)
            {
                throw new ArgumentOutOfRangeException(nameof(columnId), $"Значение должно быть между {MIN_COLUMN_ID} и {MAX_COLUMN_ID}");
            }

            return _sets[columnId].GetNextNumber();
        }

        public void MarkValue(int columnId, int value)
        {
            if (columnId < MIN_COLUMN_ID || columnId > MAX_COLUMN_ID)
            {
                throw new ArgumentOutOfRangeException(nameof(columnId), $"Значение должно быть между {MIN_COLUMN_ID} и {MAX_COLUMN_ID}");
            }

            _sets[columnId].MarkValue(value, true);
        }

        public void Reset()
        {
            for(int i = MIN_COLUMN_ID; i <= MAX_COLUMN_ID; i++)
            {
                _sets[i].Reset();
            }
        }

        public NumbersPool()
        {
            _sets = new Dictionary<int, NumberSet>();

            _sets.Add(1, new NumberSet(1, 9));
            _sets.Add(2, new NumberSet(10, 19));
            _sets.Add(3, new NumberSet(20, 29));
            _sets.Add(4, new NumberSet(30, 39));
            _sets.Add(5, new NumberSet(40, 49));
            _sets.Add(6, new NumberSet(50, 59));
            _sets.Add(7, new NumberSet(60, 69));
            _sets.Add(8, new NumberSet(70, 79));
            _sets.Add(9, new NumberSet(80, 90));
        }
    }
}
