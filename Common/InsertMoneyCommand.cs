using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class InsertMoneyCommand : Command
    {
        public InsertMoneyCommand() : base("Insert money", "i")
        {

        }
        public override void ExecuteCommand(MoneyHandling moneyHandling)
        {
            moneyHandling.InsertFunds();
        }
    }
}
