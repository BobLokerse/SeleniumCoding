using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace Tahzoo.SeleniumCode.Samples
{
    public class CheeseSelector
    {
        public static void SelectCheese(string url)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl(url);

            IWebElement select = driver.FindElement(By.TagName("select"));
            IList<IWebElement> allOptions = select.FindElements(By.TagName("option"));
            foreach (var option in allOptions)
            {
                System.Console.WriteLine("Value is:" + option.GetAttribute("value"));
                option.Click();
            }

            driver.Quit();
        }
    }
}
