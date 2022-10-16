using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public class Sodas : Product
    {
        private const int SodaVolume = 33;
        private const int SodaCost = 10;

        public Sodas(string sodaName, int productId) : base(sodaName, productId)
        {
            this.ProductName = sodaName;
            this.ProductPrice = SodaCost;
        }
        public override string Examine()
        {
            return $"This is a {SodaVolume} cl can of {ProductName}, it costs {SodaCost} kr.";
        }

        public override void Use()
        {
            Console.WriteLine("Drink your soda!");
        }
    }
}
