﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundModeWinForms.Models
{
    abstract class PlaygroundElement : IInformative, IHavingHistory, IRandomlyDistributed
    {
        public string Name { get; protected set; } // Качеля, горка и т.п.
        public int Capacity { get; protected set; } // Сколько человек может находиться на элементе одновременно
        public bool Free { get; protected set; } = true; // true - есть свободное место, false - нет
        public readonly History History = new History();

        protected PlaygroundElement(int capacity)
        {
            Capacity = capacity;
        }

        public List<Person> PeopleOnElementList { get; private set } = new List<Person>();

        public void AddPersonOnElement(Person person)
        {
            if (PeopleOnElementList.Count == Capacity)
            {
                throw new Exception("Lack of space on the element");
            }
            else
            {
                PeopleOnElementList.Add(person);
            }
        }

        public void SaveStateInHistory()
        {
            History.SaveStateInHistory(this);
        }

        public abstract string GetInfo(); // Для получния информации об обЪекте для пользователя
        public abstract double DistributionFunction(double x);
    }
}
