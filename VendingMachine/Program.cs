using VendingMachine.Data;
using VendingMachine.Models;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var soda = new Sodas("Coca Cola", TODO);
            var soda2 = new Sodas("Fanta", TODO);
            Console.WriteLine(soda.Examine());
            Console.WriteLine(soda2.Examine());
            var vendingMachine = new VendingMachineServices();
            vendingMachine.InsertMoney(50);
            Console.WriteLine(vendingMachine.MoneyPool);
            vendingMachine.InsertMoney(500);
            Console.WriteLine(vendingMachine.MoneyPool);

        }                                                       
    }
}