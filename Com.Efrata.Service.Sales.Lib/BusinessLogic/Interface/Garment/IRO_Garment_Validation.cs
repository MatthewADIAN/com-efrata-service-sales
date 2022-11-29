﻿using Com.Efrata.Service.Sales.Lib.Models.CostCalculationGarments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Sales.Lib.BusinessLogic.Interface.Garment
{
    public interface IGarment_BudgetValidationPPIC
    {
        Task<int> ValidateROGarment(CostCalculationGarment model, Dictionary<long, string> productDicts);
    }
}
