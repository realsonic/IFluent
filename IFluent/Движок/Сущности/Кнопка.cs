using IFluent.Движок.Типы;

namespace IFluent.Движок.Сущности
{
    internal class Кнопка
    {
        public Текст Надпись { get; }
        public Локация Локация { get; }

        public Кнопка(Текст надпись, Локация локация)
        {
            Надпись = надпись;
            Локация = локация;
        }
    }
}