namespace IFluent.Движок.Типы
{
    internal class Логика
    {
        private readonly bool _bool;

        private Логика(bool @bool)
        {
            _bool = @bool;
        }

        public static implicit operator bool(Логика логика)
        {
            return логика._bool;
        }

        public static implicit operator Логика(bool @bool)
        {
            return new Логика(@bool);
        }

        public override string ToString()
        {
            return _bool.ToString();
        }
    }
}