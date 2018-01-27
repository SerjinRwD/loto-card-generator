using System;
using System.Linq;

namespace LotoCardGenerator.Models
{
    public class NumberSet
    {
        private Number[] _numbers;

        public int Min { get; private set; }
        public int Max { get; private set; }
        public int Size => Max - Min + 1;

        public int GetNextNumber()
        {
            var unmarked = _numbers.Where(p => p.IsMarked == false).ToArray();

            if(unmarked == null || unmarked.Length == 0)
            {
                return -1;
            }

            return unmarked[Helpers.RandomHelper.Next(unmarked.Length)].Value;
        }

        public void MarkValue(int value, bool marker)
        {
            int id = -1;

            for (int i = 0; i < _numbers.Length; i++)
            {
                if (_numbers[i].Value == value)
                {
                    id = i;
                    break;
                }
            }

            if (id != -1)
            {
                _numbers[id].IsMarked = marker;
            }
        }

        public void Reset()
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                _numbers[i].IsMarked = false;
            }
        }

        public NumberSet(int min, int max)
        {
            Min = Math.Min(min, max);
            Max = Math.Max(min, max);

            _numbers = new Number[Size];

            for(int i = 0; i < Size; i++)
            {
                _numbers[i] = new Number(Min + i);
            }
        }
    }
}
