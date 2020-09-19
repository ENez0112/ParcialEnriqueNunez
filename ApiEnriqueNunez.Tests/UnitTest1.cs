using System;
using ApiEnriqueNunez.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiEnriqueNunez.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGet()
        {
            // ARRANGE
            CountriesController controller = new CountriesController();
            // ACT
            var lista = controller.GetCountries();
            // ASSERT
            Assert.IsNotNull(lista);
        }
    }
}
