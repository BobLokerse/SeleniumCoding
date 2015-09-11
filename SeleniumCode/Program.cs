using System;
using Tahzoo.SeleniumCode.Properties;
using Tahzoo.SeleniumCode.Samples;

namespace Tahzoo.SeleniumCode
{
    class Program
    {
        static void Main(string[] args)
        {
            CallSeleniumSamples();
        }

        private static void CallSeleniumSamples()
        {
            GoogleSuggest.Search4Cheese();

            var urlOfCheeseSelectorPage = String.Format("http://{0}/Pages/cheeseSelector.html", Settings.Default.hostname);
            new CheeseSelector().SelectCheese(urlOfCheeseSelectorPage);

            new CheeseSelector().SelectEdamCheese(urlOfCheeseSelectorPage);

            var urlOfCheeseLocatorPage = String.Format("http://{0}/Pages/cheeseLocator.html", Settings.Default.hostname);
            new CheeseLocator().WhereIsMyCheese(urlOfCheeseLocatorPage);
        }
    }
}
