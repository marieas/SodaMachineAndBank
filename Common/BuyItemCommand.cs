namespace Common
{
    public class BuyItemCommand : Command
    {
        public BuyItemCommand() : base("Buy item", "b")
        {

        }
        public override void ExecuteCommand(MoneyHandling moneyHandling)
        {
            moneyHandling.BuyItem();
        }
    }
}
