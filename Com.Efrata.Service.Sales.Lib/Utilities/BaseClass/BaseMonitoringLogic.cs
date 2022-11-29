using System.Linq;

namespace Com.Efrata.Service.Sales.Lib.Utilities.BaseClass
{
    public abstract class BaseMonitoringLogic<TViewModel>
    {
        public abstract IQueryable<TViewModel> GetQuery(string filterString);
    }
}
