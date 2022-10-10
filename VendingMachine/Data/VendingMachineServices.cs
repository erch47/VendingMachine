using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Models;

namespace VendingMachine.Data
{
    public class VendingMachineServices : IVending
    {
        private readonly int[] _denominations = new int[] {1, 5, 10, 20, 50, 100, 500, 1000};

        public double MoneyPool { get; set; }
        
        public Product? Purchase(Product? product)
        {
            Console.Write("Choose product: ");
            string pickProduct = Console.ReadLine();

            return MoneyPool >= product.ProductPrice ? product : null;
        }

        public List<string> ShowAll()
        {
            throw new NotImplementedException();
        }

        public string Details()
        {
            throw new NotImplementedException();
        }

        public void InsertMoney(double money)
        {
            this.MoneyPool = money;
        }

        public Dictionary<int, int> EndTransaction()
        {
            Dictionary<int, int> change = new Dictionary<int, int>();
            double money = this.MoneyPool;

            return change;
        }
    }
}
