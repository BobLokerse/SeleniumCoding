using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Tahzoo.SeleniumCode.PmTool.PageObjects
{
    public class ItcDetailsPage : OpportunitiesDetailsPage
    {
        public ItcDetailsPage(IWebDriver driver)
            : base(driver)
        {
            // wait for the totals to fill
            Support.Waiter.WaitForExpression(driver, d =>
            {
                var elt = d.FindElement(By.Id("itc-totals-commercial-value"));
                return elt != null && !String.IsNullOrEmpty(elt.Text);
            });
        }
    }
}
