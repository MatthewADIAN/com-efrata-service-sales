using Com.Efrata.Service.Sales.Lib.Models.GarmentSalesContractModel;
using Com.Efrata.Service.Sales.Lib.Services;
using Com.Efrata.Service.Sales.Lib.Utilities;
using Com.Efrata.Service.Sales.Lib.Utilities.BaseClass;
using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.Efrata.Service.Sales.Lib.BusinessLogic.Logic.GarmentSalesContractLogics
{
    public class GarmentSalesContractItemLogic : BaseLogic<GarmentSalesContractItem>
    {
        public GarmentSalesContractItemLogic(IServiceProvider serviceProvider, IIdentityService identityService, SalesDbContext dbContext) : base(identityService, serviceProvider, dbContext)
        {
        }

        public override ReadResponse<GarmentSalesContractItem> Read(int page, int size, string order, List<string> select, string keyword, string filter)
        {
            throw new NotImplementedException();
        }


        public override void UpdateAsync(long id, GarmentSalesContractItem model)
        {
            EntityExtension.FlagForUpdate(model, IdentityService.Username, "sales-service");
            DbSet.Update(model);
        }

        public override async Task DeleteAsync(long id)
        {
            var model = await ReadByIdAsync(id);

            EntityExtension.FlagForDelete(model, IdentityService.Username, "sales-service", true);
            DbSet.Update(model);
        }
    }
}
