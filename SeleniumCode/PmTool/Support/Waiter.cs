using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tahzoo.SeleniumCode.PmTool.Support
{
    internal static class Waiter
    {
        /// <summary>
        /// Waits for an element to be present & visible.
        /// </summary>
        /// <param name="driver">The webdriver.</param>
        /// <param name="byExpression">The expression to find the element.</param>
        /// <param name="timeoutInSeconds">The timeout in seconds (default 10).</param>
        public static void WaitForElement(IWebDriver driver, By byExpression, int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(d =>
            {
                var elt = d.FindElement(byExpression);
                return elt != null && elt.Displayed;
            });
        }

        /// <summary>
        /// Waits for the specified expression to return true.
        /// </summary>
        /// <param name="driver">The webdriver.</param>
        /// <param name="expression">The expression to test.</param>
        /// <param name="timeoutInSeconds">The timeout in seconds (default 10).</param>
        public static void WaitForExpression(IWebDriver driver, Func<IWebDriver, bool> expression,
            int timeoutInSeconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            wait.Until(expression);
        }
    }
}
