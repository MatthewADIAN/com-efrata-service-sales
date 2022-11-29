using Com.Efrata.Service.Sales.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Efrata.Service.Sales.Lib.ViewModels.ProductionOrder
{
    public class ProductionOrder_RunWidthViewModel : BaseViewModel, IValidatableObject
    {
        public double? Value{ get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
