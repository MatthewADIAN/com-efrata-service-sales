using Com.Efrata.Service.Sales.Lib.BusinessLogic.Interface.Garment;
using Com.Efrata.Service.Sales.Lib.Services;
using Com.Efrata.Service.Sales.Lib.ViewModels.Garment;
using Com.Efrata.Service.Sales.WebApi.Utilities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Com.Efrata.Service.Sales.WebApi.Controllers.Garment.MonitoringControllers
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/report/latest-available-budgets")]
    [Authorize]
    public class LatestAvailableBudgetReportController : BaseMonitoringController<LatestAvailableBudgetReportViewModel, ILatestAvailableBudgetReportFacade>
    {
        private readonly static string apiVersion = "1.0";

        public LatestAvailableBudgetReportController(IIdentityService identityService, ILatestAvailableBudgetReportFacade facade) : base(identityService, facade, apiVersion)
        {
        }
    }
}
