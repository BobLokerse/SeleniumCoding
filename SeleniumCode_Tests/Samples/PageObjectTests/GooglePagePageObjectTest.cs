
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

                GooglePage googlePage = new GooglePage(_driver);

                googlePage.OpenPage(homepage);
                googlePage.SearchFor(searchTerm);
                googlePage.PageTitle();
                googlePage.Close();
            }
            finally
            {
                _driver.Close();
            }

        }
    }

}