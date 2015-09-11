using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tahzoo.SeleniumCode.Properties;
using Tahzoo.SeleniumCode.Samples;


namespace Tahzoo.SeleniumCode_Tests.Samples
{
    /// <summary>
    /// For manually testing Selenium methods (without Fitnesse)
    /// </summary>
    [TestClass()]
    public class CheeseLocatorTests
    {
        [TestMethod()]
        public void WhereIsMyCheese_Test()
        {
            var urlOfCheeseLocatorPage = String.Format("http://{0}/Pages/cheeseLocator.html", Settings.Default.hostname);
            new CheeseLocator().WhereIsMyCheese(urlOfCheeseLocatorPage);
        }
    }
}
