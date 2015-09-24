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

            IWebElement loginBox = _driver.FindElement(By.Id("username"));
            IWebElement passwordBox = _driver.FindElement(By.Id("password"));

            loginBox.SendKeys(username);
            passwordBox.SendKeys(password);

            IWebElement button = _driver.FindElement(By.CssSelector("button[type=submit]"));
            button.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until((d) => d.FindElement(By.ClassName("errorMessage")).Displayed);

            IWebElement error = _driver.FindElement(By.ClassName("errorMessage"));

            return error.Text == "Failed to log you in. Try again or contact an administrator.";
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
