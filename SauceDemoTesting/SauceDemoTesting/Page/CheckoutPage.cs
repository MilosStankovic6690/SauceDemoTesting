using OpenQA.Selenium;
using SauceDemoTesting.Driver;

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
