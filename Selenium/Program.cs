using System;
using Tahzoo.SeleniumCode.Properties;
using Tahzoo.SeleniumCode.Samples;

namespace Tahzoo.SeleniumCode
{
    class Program
    {
        static void Main(string[] args)
        {
            GoogleSuggest.Search4Cheese();

            var urlOfCheeseSelectorPage = String.Format("http://{0}/cheesSelector.html", Settings.Default.hostname);
            new CheeseSelector().SelectCheese(urlOfCheeseSelectorPage);

            new CheeseSelector().SelectEdamCheese(urlOfCheeseSelectorPage);
        }
    }
}
