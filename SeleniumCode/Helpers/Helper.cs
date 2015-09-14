using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Tahzoo.SeleniumCode.Helpers
{
    public class WaitHelper
    {
        public static void WaitTillAlertIsPresent(RemoteWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }

        public static void WaitUntilCondition(Func<IWebDriver, bool> condition, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(condition);
        }
    }
}
