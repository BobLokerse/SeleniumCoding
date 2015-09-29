using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Tahzoo.SeleniumCode.PmTool.PageObjects
{
    /// <summary>
    /// Page object for opportunity page, with a detail selected
    /// </summary>
    public class OpportunitiesDetailsPage : OpportunitiesBasicPage
    {
        public OpportunitiesDetailsPage(IWebDriver driver)
            : base(driver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "#opportunity-view .panel-heading h3")]
        private IWebElement PanelTitle { get; set; }

        [FindsBy(How = How.CssSelector, Using = "table#opportunity-itc-list tbody tr")]
        private IList<IWebElement> Itcs { get; set; }

        public string GetTitle()
        {
            Support.Waiter.WaitForElement(_driver, By.CssSelector("#opportunity-view .panel-heading h3"));
            return PanelTitle.Text;
        }

        public int CountItcs()
        {
            // wait for the "no itc yet" message to disappear and the table to appear
            Support.Waiter.WaitForElement(_driver, By.CssSelector("#opportunity-itc-list"));

            try
            {
                return Itcs.Count;
            }
            catch
            {
                if (_driver is EdgeDriver)
                {
                    // it seems the Edge driver can't handle empty selections?
                    return 0;
                }

                throw;
            }
        }

        public ItcDetailsPage SelectItc(int index)
        {
            var editbtn = _driver.FindElement(By.CssSelector("#opportunity-itc-list tbody tr:nth-of-type(" + index + ") a:first-of-type"));
            editbtn.Click();
            return new ItcDetailsPage(_driver);
        }
    }
}
