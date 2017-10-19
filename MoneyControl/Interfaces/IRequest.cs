using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControl.Interfaces
{
    interface IRequest
    {
        void Add(int sum);
        void Withdraw(int sum, ICategory category);
        void GetStat(ICategory category);
        List<KeyValuePair<int, ICategory>> GetAllStat();
    }
}
