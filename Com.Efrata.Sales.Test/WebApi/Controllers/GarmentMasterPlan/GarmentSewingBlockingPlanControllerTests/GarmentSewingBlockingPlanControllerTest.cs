using Com.Efrata.Sales.Test.WebApi.Utils;
using Com.Efrata.Service.Sales.Lib.BusinessLogic.Interface.GarmentMasterPlan.GarmentSewingBlockingPlanInterfaces;
using Com.Efrata.Service.Sales.Lib.Models.GarmentSewingBlockingPlanModel;
using Com.Efrata.Service.Sales.Lib.ViewModels.GarmentSewingBlockingPlanViewModels;
using Com.Efrata.Service.Sales.WebApi.Controllers.GarmentMasterPlan.GarmentSewingBlockingPlanControllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Efrata.Sales.Test.WebApi.Controllers.GarmentMasterPlan.GarmentSewingBlockingPlanControllerTests
{
    public class GarmentSewingBlockingPlanControllerTest : BaseControllerTest<GarmentSewingBlockingPlanController, GarmentSewingBlockingPlan, GarmentSewingBlockingPlanViewModel, IGarmentSewingBlockingPlan>
    {
        protected override GarmentSewingBlockingPlanViewModel ViewModel
        {
            get
            {
                var viewModel = base.ViewModel;
                viewModel.Items = new List<GarmentSewingBlockingPlanItemViewModel>
                {
                    new GarmentSewingBlockingPlanItemViewModel()
                };
                return viewModel;
            }
        }

        
    }
}
