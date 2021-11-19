using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public abstract class Command
    {
        public string Description { get; private set; }
        public string Key { get; private set; }

        public Command(string description, string key)
        {
            Description = description;
            Key = key;
        }
        public abstract void ExecuteCommand(MoneyHandling moneyHandling);

    }
}
