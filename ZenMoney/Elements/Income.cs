using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenMoney.Elements
{
    class Income
    {
        DateTime Date { get; set; }
        int Amount { get; set; }
        string IncomeType { get; set; }

        public void Add (DateTime date, int amount, string incomeType)
        {
            date = Date;
            amount = Amount;
            incomeType = IncomeType;
        }
    }
}
