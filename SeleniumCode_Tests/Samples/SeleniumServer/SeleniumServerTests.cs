using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tahzoo.SeleniumCode.Samples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tahzoo.SeleniumCode.Samples.Tests
{
    [TestClass()]
    public class SeleniumServerTests
    {
        [TestMethod()]
        [Ignore]
        public void CallSeleniumServer_Test()
        {
            new SeleniumServer().CallSeleniumServerWithFireFox();

            new SeleniumServer().CallSeleniumServerWithChrome();
        }
    }
}
