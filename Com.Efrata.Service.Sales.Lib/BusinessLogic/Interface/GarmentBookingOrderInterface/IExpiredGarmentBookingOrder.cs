using Com.Efrata.Service.Sales.Lib.Models.GarmentBookingOrderModel;
using Com.Efrata.Service.Sales.Lib.Utilities;
using Com.Efrata.Service.Sales.Lib.Utilities.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Sales.Lib.BusinessLogic.Interface.GarmentBookingOrderInterface
{
    public interface IExpiredGarmentBookingOrder : IBaseFacade<GarmentBookingOrder>
    {
        int BOCancelExpired(List<GarmentBookingOrder> list, string user);
        ReadResponse<GarmentBookingOrder> ReadExpired(int page, int size, string order, List<string> select, string keyword, string filter);
    }
}
