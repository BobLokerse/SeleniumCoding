using Tahzoo.SeleniumCode.Helpers;
using Tahzoo.SeleniumCode.Samples;

namespace Tahzoo.FitnesseFixtures.Fixtures
{
    public class CheeseLocatorWithSeleniumServer :
        fit.ColumnFixture
    {
        public void CheeseLocator()
        {
            var browser = Browser.GetFirefoxServerDriver();

            SeleniumServer.RunCheeseLocatorExample(browser);
        }
    }
}
