using Com.Efrata.Sales.Test.BussinesLogic.Utils;
using Com.Efrata.Service.Sales.Lib.BusinessLogic.Facades;
using Com.Efrata.Service.Sales.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Efrata.Sales.Test.BussinesLogic.DataUtils
{
    public class ArticleColorDataUtil : BaseDataUtil<ArticleColorFacade, ArticleColor>
    {
        public ArticleColorDataUtil(ArticleColorFacade facade) : base(facade)
        {
        }

        public override Task<ArticleColor> GetNewData()
        {
            return Task.FromResult(new ArticleColor()
            {
                Name = "das",
                Description = "des"
            });
        }
    }
}
