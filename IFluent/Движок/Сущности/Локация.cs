﻿using IFluent.Движок.Типы;

namespace IFluent.Движок.Сущности
{
    internal class Локация
    {
        public Локация(Игра.ОписаниеИгры.ОписаниеЛокаций.ОписаниеЛокации описаниеЛокации)
        {
            Название = описаниеЛокации.Название;
            Описание = описаниеЛокации.Описание;
        }

        public Локация(Текст название, Текст описание)
        {
            Название = название;
            Описание = описание;
        }

        public Текст Описание { get; }

        public Текст Название { get; }

        public override string ToString()
        {
            return Название;
        }
    }
}