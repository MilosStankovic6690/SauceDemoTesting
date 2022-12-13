using OpenQA.Selenium;
using SauceDemoTesting.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTesting.Page
{
    public class CartPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement RemoveOnesie => driver.FindElement(By.Id("remove-sauce-labs-onesie"));
        public IWebElement RemoveBoltTShirt => driver.FindElement(By.CssSelector("#remove-sauce-labs-bolt-t-shirt"));
        public IWebElement ContinueShoppingButton => driver.FindElement(By.Id("continue-shopping"));
    }
}
