
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Tahzoo.SeleniumCode.Samples.PageObjects;



namespace Tahzoo.SeleniumCode_Tests.Samples.PageObjectTests
{
    [TestClass]
    public class GooglePagePageObjectTest
    {
        private IWebDriver _driver;


        [TestMethod]
        public void RunTests()
        {
            try
            {
                _driver = new FirefoxDriver();

                string homepage = "http://google.co.uk";

                string searchTerm = "Manual testing is long";

                GooglePage pageObject = new GooglePage();

                pageObject.OpenPage(homepage, (FirefoxDriver) _driver);
                pageObject.SearchFor(searchTerm, (FirefoxDriver) _driver);
                
                // Does not work yet
                // http://stackoverflow.com/questions/12082946/selenium-webdriver-org-openqa-selenium-elementnotvisibleexception-element-is-n
                //pageObject.ClickSearch((FirefoxDriver) _driver);
            }
            finally
            {
                _driver.Close();
            }

        }
    }

}