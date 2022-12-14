using SauceDemoTesting.Driver;
using SauceDemoTesting.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTesting.Tests
{
    public class TotalPriceCheckTest
    {
        private LoginPage _loginPage;
        private InventoryPage _inventoryPage;
        private CartPage _cartPage;
        private ConfirmationPage _confirmationPage;
        private CheckoutPage _checkoutPage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDrivers.Initialize();
            _loginPage = new LoginPage();
            _inventoryPage = new InventoryPage();
            _cartPage = new CartPage();
            _confirmationPage= new ConfirmationPage();
            _checkoutPage= new CheckoutPage();
        }

        [TearDown]
        public void ClosePage()
        {
            WebDrivers.Shutdown();
        }

        [Test]
        public void TC01_CheckTotalItemPriceOfTheOrderedProducts_ShouldBePriceDisplayed()
        {
            _loginPage.Login("standard_user", "secret_sauce");
            _inventoryPage.Onesie.Click();
            _inventoryPage.BikeLight.Click();
            _inventoryPage.BoltTShirt.Click();
            _inventoryPage.CartWithProduct.Click();
            _cartPage.CheckoutButton.Click();
            _confirmationPage.FirstName.SendKeys("Milos");
            _confirmationPage.LastName.SendKeys("Stankovic");
            _confirmationPage.ZipCode.SendKeys("11000");
            _confirmationPage.ContinueButton.Submit();

            Assert.That(_checkoutPage.ItemTotal.Displayed);
        }

        [Test]
        public void TC02_CheckTotalPriceOfTheOrderedProducts_ShouldBePriceDisplayed()
        {
            _loginPage.Login("standard_user", "secret_sauce");
            _inventoryPage.Onesie.Click();
            _inventoryPage.BikeLight.Click();
            _inventoryPage.BoltTShirt.Click();
            _inventoryPage.CartWithProduct.Click();
            _cartPage.CheckoutButton.Click();
            _confirmationPage.FirstName.SendKeys("Milos");
            _confirmationPage.LastName.SendKeys("Stankovic");
            _confirmationPage.ZipCode.SendKeys("11000");
            _confirmationPage.ContinueButton.Submit();

            Assert.That(_checkoutPage.TotalPrice.Displayed);
        }
    }
}
