using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyControl.Interfaces;

namespace MoneyControl.SQL
{
    class Request : IRequest
    {
        public void Add(int sum)
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<int, ICategory>> GetAllStat()
        {
            throw new NotImplementedException();
        }

        public void GetStat(ICategory category)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(int sum, ICategory category)
        {
            throw new NotImplementedException();
        }
    }
}
