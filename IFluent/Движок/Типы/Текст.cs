namespace IFluent.Движок.Типы
{
    internal class Текст
    {
        private readonly string _string;

        private Текст(string @string)
        {
            _string = @string;
        }

        public static implicit operator string(Текст текст)
        {
            return текст._string;
        }

        public static implicit operator Текст(string @string)
        {
            return new Текст(@string);
        }

        public override string ToString()
        {
            return _string;
        }
    }
}