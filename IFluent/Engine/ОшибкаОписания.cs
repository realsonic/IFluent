using System;

namespace IFluent.Engine
{
    internal class ОшибкаОписания : Exception
    {
        public ОшибкаОписания(Текст сообщение) : base(сообщение) { }
    }
}