using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Models
{
    public abstract class Product
    {
        public string? ProductName { get; set; }
        public int ProductPrice { get; set; }
        public abstract string Examine();
        public abstract void Use();

    }
}
