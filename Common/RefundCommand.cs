using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class RefundCommand : Command
    {
        public RefundCommand() : base("Refund", "r")
        {

        }
        public override void ExecuteCommand(MoneyHandling moneyHandling)
        {
            moneyHandling.Refund();
        }
    }
}
