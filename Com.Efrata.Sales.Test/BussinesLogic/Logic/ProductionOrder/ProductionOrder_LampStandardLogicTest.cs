﻿using Com.Efrata.Service.Sales.Lib;
using Com.Efrata.Service.Sales.Lib.BusinessLogic.Logic.ProductionOrder;
using Com.Efrata.Service.Sales.Lib.Models.ProductionOrder;
using Com.Efrata.Service.Sales.Lib.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Xunit;

namespace Com.Efrata.Sales.Test.BussinesLogic.Logic.ProductionOrder
{
    public class ProductionOrder_LampStandardLogicTest
    {
        private const string ENTITY = "ProductionOrder_LampStandard";
        [MethodImpl(MethodImplOptions.NoInlining)]
        public string GetCurrentMethod()
        {
            StackTrace st = new StackTrace();
            StackFrame sf = st.GetFrame(1);

            return string.Concat(sf.GetMethod().Name, "_", ENTITY);
        }

        private SalesDbContext _dbContext(string testName)
        {
            DbContextOptionsBuilder<SalesDbContext> optionsBuilder = new DbContextOptionsBuilder<SalesDbContext>();
            optionsBuilder
                .UseInMemoryDatabase(testName)
                .ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning));

            SalesDbContext dbContext = new SalesDbContext(optionsBuilder.Options);

            return dbContext;
        }

        public Mock<IServiceProvider> GetServiceProvider(string testname)
        {
            IIdentityService identityService = new IdentityService { Username = "Username", Token = "Token Test" };
            var serviceProvider = new Mock<IServiceProvider>();

            serviceProvider
                .Setup(x => x.GetService(typeof(IdentityService)))
                .Returns(identityService);

            serviceProvider.Setup(s => s.GetService(typeof(SalesDbContext)))
                .Returns(_dbContext(testname));

            return serviceProvider;
        }

        [Fact]
        public void Read_With_EmptyKeyword_Return_Success()
        {
            string testName = GetCurrentMethod();
            var dbContext = _dbContext(testName);
            IIdentityService identityService = new IdentityService { Username = "Username" };
            var model = new ProductionOrder_LampStandardModel()
            {
               Code = "Code",
               Description = "Description"
            };

            dbContext.ProductionOrder_LampStandard.Add(model);
            dbContext.SaveChanges();
            ProductionOrder_LampStandardLogic unitUnderTest = new ProductionOrder_LampStandardLogic(GetServiceProvider(testName).Object, identityService, dbContext);

            var result = unitUnderTest.Read(1, 1, "{}", new List<string>() { "" }, null, "{}");
            Assert.True(0 < result.Data.Count);
            Assert.NotEmpty(result.Data);
        }
    }
}
