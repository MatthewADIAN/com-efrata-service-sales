using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Com.Efrata.Service.Sales.Lib.Helpers;
using Com.Efrata.Service.Sales.Lib.Models.Spinning;

namespace Com.Efrata.Sales.Test.Helpers
{
  public  class ObjectExtensionTest
    {
        [Fact]
        public void should_Success_Clone()
        {
            //Setup
            SpinningSalesContractModel model =new  SpinningSalesContractModel();

            //Act
            var dataObj = JsonConvert.SerializeObject(model);
            var resultCopy = dataObj.Clone<string>();

            //Assert
            Assert.Equal(dataObj, resultCopy);
            Assert.NotSame(dataObj, resultCopy);

        }
    }
}
