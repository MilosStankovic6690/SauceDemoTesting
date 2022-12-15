using OpenQA.Selenium;
using SauceDemoTesting.Driver;

namespace SauceDemoTesting.Page
{
    public class FinishedPurchasePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement OrderFinished => driver.FindElement(By.CssSelector("#checkout_complete_container .complete-header"));
    }
}
