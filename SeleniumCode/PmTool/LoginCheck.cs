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
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
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
