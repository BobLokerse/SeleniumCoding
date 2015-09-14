using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Tahzoo.SeleniumCode.Helpers;

namespace Tahzoo.SeleniumCode.Samples
{
    public class CheeseLocator
    {
        private IWebDriver _driver;

        public void WhereIsMyCheese(string url)
        {
            try
            {
                _driver = Browser.GetFirefoxDriver();

                _driver.Navigate().GoToUrl(url);

                _driver.FindElement(By.Id("windowOpener")).Click();

                _driver.SwitchTo().Window("windowName");
                _driver.FindElement(By.Id("CheesyButton")).Click();

                _driver.SwitchTo().Alert().Accept();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("An exception occured: " + ex.Message);
                Debug.WriteLine("An exception occured: " + ex.Message);
            }
            finally
            {
                _driver.Quit();
            }
        }
    }
}
