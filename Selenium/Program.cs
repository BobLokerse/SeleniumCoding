using Tahzoo.SeleniumCode.Samples;

namespace Tahzoo.SeleniumCode
{
    class Program
    {
        static void Main(string[] args)
        {
            GoogleSuggest.Search4Cheese();

            var urlOfCheeseSelectorPage = "http://localhost/HTMLsamples/cheesSelector.html";
            CheeseSelector.SelectCheese(urlOfCheeseSelectorPage);
        }
    }
}
