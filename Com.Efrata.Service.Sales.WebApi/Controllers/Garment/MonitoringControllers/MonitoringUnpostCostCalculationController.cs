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
    [Route("v{version:apiVersion}/monitoring/unpost-cost-calculations")]
    [Authorize]
    public class MonitoringUnpostCostCalculationController : BaseMonitoringController<MonitoringUnpostCostCalculationViewModel, IMonitoringUnpostCostCalculationFacade>
    {
        private readonly static string apiVersion = "1.0";

        public MonitoringUnpostCostCalculationController(IIdentityService identityService, IMonitoringUnpostCostCalculationFacade facade) : base(identityService, facade, apiVersion)
        {
        }
    }
}
