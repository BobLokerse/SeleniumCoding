using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tahzoo.SeleniumCode.Samples;

namespace Tahzoo.SeleniumCode_Tests.Samples
{
    [TestClass()]
    public class GoogleSuggestTests
    {
        [TestMethod()]
        public void Search4Cheese_Test()
        {
            GoogleSuggest.Search4Cheese();
        }
    }
}
