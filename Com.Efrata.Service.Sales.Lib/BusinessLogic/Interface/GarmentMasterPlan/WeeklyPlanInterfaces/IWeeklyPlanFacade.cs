using Com.Efrata.Service.Sales.Lib.Models.GarmentMasterPlan.WeeklyPlanModels;
using Com.Efrata.Service.Sales.Lib.Utilities.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Service.Sales.Lib.BusinessLogic.Interface.Garment.WeeklyPlanInterfaces
{
    public interface IWeeklyPlanFacade : IBaseFacade<GarmentWeeklyPlan>
    {
        List<string> GetYears(string keyword);
        GarmentWeeklyPlanItem GetWeekById(long id);
    }
}
