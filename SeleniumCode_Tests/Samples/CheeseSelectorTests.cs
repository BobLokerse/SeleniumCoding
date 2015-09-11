using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tahzoo.SeleniumCode.Properties;
using Tahzoo.SeleniumCode.Samples;

namespace Tahzoo.SeleniumCode_Tests.Samples
{
    [TestClass()]
    public class CheeseSelectorTests
    {
        [TestMethod()]
        public void SelectCheese_OneByOne_Test()
        {
            var urlOfCheeseSelectorPage = String.Format("http://{0}/Pages/cheeseSelector.html", Settings.Default.hostname);
            new CheeseSelector().SelectCheese(urlOfCheeseSelectorPage);
        }

        [TestMethod()]
        public void SelectCheese_EdamCheese_Test()
        {
            var urlOfCheeseSelectorPage = String.Format("http://{0}/Pages/cheeseSelector.html", Settings.Default.hostname);

            new CheeseSelector().SelectEdamCheese(urlOfCheeseSelectorPage);
        }
    }
}
