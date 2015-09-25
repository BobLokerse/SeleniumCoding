using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tahzoo.SeleniumCode.PmTool
{
    public sealed class LoginCheck : IDisposable
    {
        private readonly IWebDriver _driver;

        public LoginCheck(Browser browser)
        {
            _driver = DriverFactory.GetDriver(browser);
        }

        public bool TestFailedLogin(string username, string password)
        {
            _driver.Navigate().GoToUrl("http://test.hajime.site/");

            var page = new PageObjects.LoginPage(_driver);
            page.SetUsername(username);
            page.SetPassword(password);

            try
            {
                var result = page.LoginExpectingFailure(); // expect: result == page
                return result.GetErrorMessage().Contains("Failed");
                // "Failed to log you in. Try again or contact an administrator.";

            }
            catch (WebDriverTimeoutException)
            {
                // probably the login succeeded and the Opportunities pages is shown
                return false;
            }
        }

        public bool TestCorrectLogin(string username, string password)
        {
            _driver.Navigate().GoToUrl("http://test.hajime.site/");

            var page = new PageObjects.LoginPage(_driver);
            page.SetUsername(username);
            page.SetPassword(password);

            try
            {
                var resultpage = page.LoginExpectingSuccess();
                return !ReferenceEquals(resultpage, page);
            }
            catch (Exception)
            {
                return false;
            }

            //IWebElement loginBox = _driver.FindElement(By.Id("username"));
            //IWebElement passwordBox = _driver.FindElement(By.Id("password"));

            //loginBox.SendKeys(username);
            //passwordBox.SendKeys(password);

            //IWebElement button = _driver.FindElement(By.CssSelector("button[type=submit]"));
            //button.Click();

            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            //wait.Until((d) => d.FindElement(By.Id("opportunitySearchText")).Displayed);

        }


        public void Dispose()
        {
            if (_driver != null)
            {
                _driver.Dispose();
            }
        }
    }
}
