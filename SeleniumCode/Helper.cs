
using System;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Tahzoo.SeleniumCode
{
    public class Helper
    {
        public static void WaitTillAlertIsPresent(RemoteWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }
    }
}
