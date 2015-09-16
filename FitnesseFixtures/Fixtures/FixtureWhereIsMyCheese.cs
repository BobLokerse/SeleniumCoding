using System;
using Tahzoo.SeleniumCode.Properties;
using Tahzoo.SeleniumCode.Samples;

namespace Tahzoo.FitnesseFixtures.Fixtures
{
    public class FixtureWhereIsMyCheese : fit.ColumnFixture
    {
        public void WhereIsMyCheese()
        {
            var hostname = Settings.Default.hostname;
            var urlOfCheeseLocatorPage = String.Format("http://{0}/Pages/cheeseLocator.html", hostname);
            new CheeseLocator().WhereIsMyCheese(urlOfCheeseLocatorPage);
        }
    }
}
