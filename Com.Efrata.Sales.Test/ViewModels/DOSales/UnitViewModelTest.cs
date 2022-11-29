﻿using Com.Efrata.Service.Sales.Lib.ViewModels.DOSales;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Com.Efrata.Sales.Test.ViewModels.DOSales
{
    public class UnitViewModelTest
    {
        [Fact]
        public void should_Success_Instantiate()
        {
            UnitViewModel viewModel = new UnitViewModel()
            {
                name = "name"
            };

            Assert.Equal("name", viewModel.name);
        }
    }
}
