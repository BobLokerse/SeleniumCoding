using System;
using System.Collections.Generic;
using OpenQA.Selenium;
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

        [FindsBy(How = How.CssSelector, Using = "div[ui-view=right] h3")]
        private IWebElement PanelTitle { get; set; }

        public string GetTitle()
        {
            Support.Waiter.WaitForElement(_driver, By.CssSelector("div[ui-view=right] h3"));
            return PanelTitle.Text;
        }
    }
}
