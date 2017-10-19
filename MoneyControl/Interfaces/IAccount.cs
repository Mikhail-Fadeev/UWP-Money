using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControl.Interfaces
{
    interface IAccount
    {
        void Add(int sum);
        void Withdraw(int sum, ICategory category);
        int GetBalance();
        int GetBalanceBetween(DateTime dateBefore, DateTime dateAfter);

    }
}
