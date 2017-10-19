using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MoneyControl.Interfaces;

namespace MoneyControl.Models
{
    class Account : IAccount
    {
        public Account()
        {
            
        }

        public void Add(int sum)
        {
           
        }

        public int GetBalance(int sum, ICategory category)
        {
            throw new NotImplementedException();
        }

        public int GetBalanceBetween(DateTime dateBefore, DateTime dateAfter)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int sum)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int sum, ICategory category)
        {
            throw new NotImplementedException();
        }

        public int GetBalance()
        {
            throw new NotImplementedException();
        }
    }
}
