using System;
using System.Collections.Generic;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Tahzoo.SeleniumCode.Helpers;

namespace Tahzoo.SeleniumCode.Samples
{
    public class CheeseSelector
    {
        private IWebDriver _driver;

        /// <summary>
        /// Basic way of selecting options of a select element.
        /// </summary>
        public void SelectCheese(string url)
        {
            try
            {
                _driver = Browser.GetFirefoxDriver();

                _driver.Navigate().GoToUrl(url);

                IWebElement select = _driver.FindElement(By.TagName("select"));
                IList<IWebElement> allOptions = select.FindElements(By.TagName("option"));
                foreach (var option in allOptions)
                {
                    System.Console.WriteLine("Value is:" + option.GetAttribute("value"));
                    option.Click();
                }
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine("An Invalid operations exception occured: " + ex.Message);
                Debug.WriteLine("An Invalid operations exception occured: " + ex.Message);
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

        /// <summary>
        /// Uses the Webdriver's support classes, with a better selecting method.
        /// </summary>
        public void SelectEdamCheese(string url)
        {
            try
            {
                _driver = Browser.GetFirefoxDriver();

                _driver.Navigate().GoToUrl(url);

                var select = new SelectElement(_driver.FindElement(By.TagName("select")));
                select.DeselectAll();
                select.SelectByText("Edam");
            }
            catch (OpenQA.Selenium.Support.UI.UnexpectedTagNameException ex)
            {
                Console.WriteLine("An exception occured, while selecting the tag: " + ex.Message);
                Debug.WriteLine("An exception occured, while selecting the tag: " + ex.Message);
            }
            catch (System.InvalidOperationException ex)
            {
                Console.WriteLine("An Invalid operations exception occured: " + ex.Message);
                Debug.WriteLine("An Invalid operations exception occured: " + ex.Message);
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
