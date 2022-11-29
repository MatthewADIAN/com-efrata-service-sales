using Com.Efrata.Sales.Test.WebApi.Utils;
using Com.Efrata.Service.Sales.Lib.BusinessLogic.Interface.GarmentMasterPlan.MaxWHConfirmInterfaces;
using Com.Efrata.Service.Sales.Lib.Models.GarmentMasterPlan.MaxWHConfirmModel;
using Com.Efrata.Service.Sales.Lib.ViewModels.GarmentMasterPlan.MaxWHConfirmViewModels;
using Com.Efrata.Service.Sales.WebApi.Controllers.GarmentMasterPlan.MaxWHConfirmControllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Sales.Test.WebApi.Controllers.GarmentMasterPlan.MaxWHConfirmControllerTests
{
    public class MaxWHConfirmControllerTest : BaseControllerTest<MaxWHConfirmController, MaxWHConfirm, MaxWHConfirmViewModel, IMaxWHConfirmFacade>
    {
        protected override MaxWHConfirmViewModel ViewModel
        {
            get
            {
                var viewModel = base.ViewModel;
                
                return viewModel;
            }
        }
    }
}
