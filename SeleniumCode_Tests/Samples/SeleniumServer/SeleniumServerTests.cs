using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tahzoo.SeleniumCode_Tests.Samples.SeleniumServer
{
    [TestClass()]
    public class SeleniumServerTests
    {
        [TestMethod()]
        [Ignore]
        public void CallSeleniumServer_Test()
        {
            new SeleniumCode.Samples.SeleniumServer().CallSeleniumServerWithFireFox();

            new SeleniumCode.Samples.SeleniumServer().CallSeleniumServerWithChrome();
        }
    }
}
