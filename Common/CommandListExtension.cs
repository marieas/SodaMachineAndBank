using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public static class CommandListExtension
    {
        public static void PrintCommands(this List<Command> commands)
        {
            foreach (var command in commands)
            {
                Console.WriteLine($"{command.Description} => {command.Key}");
            }
        }

        public static void AddMoneyHandlingCommands(this List<Command> commands)
        {
            commands.Add(new InsertMoneyCommand());
            commands.Add(new RefundCommand());
            commands.Add(new BuyItemCommand());
        }

        public static void FindAndExecuteCommand(this List<Command> commandList, string command, MoneyHandling moneyHandling)
        {
            var selectedCommand = commandList.Where(x => x.Key == command).FirstOrDefault();
            if (selectedCommand == null)
            {
                Console.WriteLine("unknown command");
                return;
            }
            else
            {
                selectedCommand.ExecuteCommand(moneyHandling);
            }
        }
    }
}
