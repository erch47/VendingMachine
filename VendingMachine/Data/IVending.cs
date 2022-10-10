using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Models;

namespace VendingMachine.Data
{
    public interface IVending
    {
        Product? Purchase(Product? product);
        List<string> ShowAll();
        string Details();
        void InsertMoney(double money);
        Dictionary<int, int> EndTransaction();

    }
}
