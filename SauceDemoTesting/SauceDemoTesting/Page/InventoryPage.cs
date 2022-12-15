using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SauceDemoTesting.Driver;

namespace SauceDemoTesting.Page
{
    public class InventoryPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public string URLInventoryPage = "https://www.saucedemo.com/inventory.html";

        public void Alert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public IWebElement ProductSortContainer => driver.FindElement(By.CssSelector("select.product_sort_container"));
        public IWebElement Onesie => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        public IWebElement BikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement BoltTShirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement CartWithProduct => driver.FindElement(By.CssSelector("#shopping_cart_container .shopping_cart_badge"));
        public IWebElement CartWithoutProduct => driver.FindElement(By.CssSelector("#shopping_cart_container "));

        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(ProductSortContainer);
            element.SelectByText(text);
        }
    }
}
