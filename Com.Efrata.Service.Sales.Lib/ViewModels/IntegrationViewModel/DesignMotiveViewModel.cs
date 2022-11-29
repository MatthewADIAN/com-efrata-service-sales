using Com.Efrata.Service.Sales.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Com.Efrata.Service.Sales.Lib.ViewModels.IntegrationViewModel
{
    public class DesignMotiveViewModel : BaseViewModel
    {

        [MaxLength(25)]
        public string Code { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
