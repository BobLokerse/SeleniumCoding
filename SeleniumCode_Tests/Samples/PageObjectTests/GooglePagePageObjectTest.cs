
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using Tahzoo.SeleniumCode;
using Tahzoo.SeleniumCode.Helpers;
using Tahzoo.SeleniumCode.Samples.PageObjects;



namespace Tahzoo.SeleniumCode_Tests.Samples.PageObjectTests
{
    [TestClass]
    public class GooglePagePageObjectTest
    {
        private IWebDriver _driver;

        [TestMethod]
        public void CallGooglePage()
        {
            try
            {
                string homepage = "http://google.co.uk";
                string searchTerm = "Manual testing is long";


                _driver = Browser.GetFirefoxDriver();
                
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


        [TestMethod]
        public void RunTests()
        {
            try
            {
                _driver = Browser.GetFirefoxDriver();

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