namespace MultilevelInheritance
{
    public class SBIbank
    {
        public static int BalanceAmount = 35000,Amount;
        public void BalanceInfo()
        {
            Console.WriteLine("Available SBI Bank Balance Amount "+BalanceAmount);
        }
    }
    public class GpayPayment : SBIbank
    {
        public void transfer(int amount)
        {
            Amount = amount;
            BalanceAmount = BalanceAmount - Amount;
            Console.WriteLine("The Debited Amount is "+Amount);
            Console.WriteLine("Available SBI Bank Balance Amount "+BalanceAmount);
        }
    }
    public class ICICIbank : GpayPayment
    {
        public static int ICICbalanceAmount = 45000;
       public void ICICbankDetails()
       {
        Console.WriteLine("Available ICIC Bank Balance Amount is "+ICICbalanceAmount);
        ICICbalanceAmount = ICICbalanceAmount +Amount;
        Console.WriteLine("The Credited Amount is "+Amount);
        Console.WriteLine("Total ICIC Bank Balance Amount is "+ICICbalanceAmount);
       }
    }
}