using System;
using System.Collections.Generic;
using Common;

namespace MoreObjectOrientation
{
    public class SodaMachine
    {
        List<Command> _commands;
        MoneyHandling _moneyHandling;
        List<Product> _sodaList;

        public SodaMachine()
        {
            _commands = new List<Command>();
            _commands.AddMoneyHandlingCommands();            
            _commands.PrintCommands();

            _sodaList = new List<Product>();
            _sodaList.Add(new Product("1", 28, "Cola"));
        }
    }
}
