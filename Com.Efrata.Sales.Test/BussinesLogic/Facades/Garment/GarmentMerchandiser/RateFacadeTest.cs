using Com.Efrata.Sales.Test.BussinesLogic.DataUtils.Garment.GarmentMerchandiser;
using Com.Efrata.Sales.Test.BussinesLogic.Utils;
using Com.Efrata.Service.Sales.Lib;
using Com.Efrata.Service.Sales.Lib.BusinessLogic.Facades;
using Com.Efrata.Service.Sales.Lib.BusinessLogic.Logic;
using Com.Efrata.Service.Sales.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Efrata.Sales.Test.BussinesLogic.Facades.Garment.GarmentMerchandiser
{
    public class RateFacadeTest : BaseFacadeTest<SalesDbContext, RateFacade, RateLogic, Rate, RateDataUtil>
    {
        private const string ENTITY = "Rate";

        public RateFacadeTest() : base(ENTITY)
        {
        }
    }
}
