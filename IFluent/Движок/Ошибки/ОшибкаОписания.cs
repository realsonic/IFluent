using System;
using IFluent.Движок.Типы;

namespace IFluent.Движок.Ошибки
{
    internal class ОшибкаОписания : Exception
    {
        public ОшибкаОписания(Текст сообщение) : base(сообщение) { }
    }
}