using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenMoney.Elements;
using static ZenMoney.Elements.IncomeForm;

namespace ZenMoney.Handlers
{
    interface IHandlers
    {
        void Handle(CollectedExpencesData dataCollected);

    }

    interface IHandle
    {
        void HandleIncome(CollectedIncomeData dataCollected);
    }

    public class CollectInternalData : IHandlers
    {
        public CollectedExpencesData Data { get; set; }

        public CollectInternalData(CollectedExpencesData data)
        {
            Data = data;
        }

        public void Handle(CollectedExpencesData dataCollected)
        {
            throw new NotImplementedException();
        }
    }
    public class CollectInternaIncomelData : IHandlers
    {
        public CollectedIncomeData Data { get; set; }

        public CollectInternaIncomelData(CollectedIncomeData data)
        {
            Data = data;
        }

        public void Handle(CollectedExpencesData dataCollected)
        {
            throw new NotImplementedException();

        }
    }
}
