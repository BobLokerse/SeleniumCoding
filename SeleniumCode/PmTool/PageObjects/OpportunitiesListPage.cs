using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Tahzoo.SeleniumCode.PmTool.PageObjects
{
    public class OpportunitiesListPage
    {
        private readonly IWebDriver _driver;

        public OpportunitiesListPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);

        }
    }
}
