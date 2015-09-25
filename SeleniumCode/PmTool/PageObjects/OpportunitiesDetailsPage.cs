using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Tahzoo.SeleniumCode.PmTool.PageObjects
{
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
            return PanelTitle.Text;
        }
    }
}
