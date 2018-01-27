namespace LotoCardGenerator.Models
{
    public class Number
    {
        public int Value { get; private set; }
        public bool IsMarked { get; set; }

        public Number(int value)
        {
            Value = value;
            IsMarked = false;
        }
    }
}
