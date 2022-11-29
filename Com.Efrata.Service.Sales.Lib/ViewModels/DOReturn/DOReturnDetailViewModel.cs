using Com.Efrata.Service.Sales.Lib.Utilities;
using Com.Efrata.Service.Sales.Lib.ViewModels.SalesInvoice;
using System.Collections.Generic;

namespace Com.Efrata.Service.Sales.Lib.ViewModels.DOReturn
{
    public class DOReturnDetailViewModel : BaseViewModel
    {
        public SalesInvoiceViewModel SalesInvoice { get; set; }

        public virtual ICollection<DOReturnDetailItemViewModel> DOReturnDetailItems { get; set; }
        public virtual ICollection<DOReturnItemViewModel> DOReturnItems { get; set; }
    }
}
