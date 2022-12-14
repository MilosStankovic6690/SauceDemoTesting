using OpenQA.Selenium;
using SauceDemoTesting.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTesting.Page
{
    public class CheckoutPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ItemTotal => driver.FindElement(By.CssSelector(".summary_subtotal_label"));
        public IWebElement TotalPrice => driver.FindElement(By.CssSelector(".summary_total_label"));
        public IWebElement FinishButton => driver.FindElement(By.Id("finish"));
    }
}
