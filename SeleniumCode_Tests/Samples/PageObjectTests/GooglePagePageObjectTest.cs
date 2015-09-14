
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

                GooglePage googlePage = new GooglePage();

                googlePage.OpenPage(homepage, (FirefoxDriver) _driver);
                googlePage.SearchFor(searchTerm, (FirefoxDriver) _driver);
                googlePage.PageTitle((FirefoxDriver)_driver);
                googlePage.Close((FirefoxDriver)_driver);
            }
            finally
            {
                _driver.Close();
            }

        }
    }

}