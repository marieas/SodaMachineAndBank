using Common;
using System.Collections.Generic;

namespace Bank
{
    public class ATM
    {
        List<Command> _commands;
        MoneyHandling _moneyHandling;
        public ATM()
        {
            _commands = new List<Command>();
            _commands.AddMoneyHandlingCommands();
            _commands.PrintCommands();
        }
    }
}
