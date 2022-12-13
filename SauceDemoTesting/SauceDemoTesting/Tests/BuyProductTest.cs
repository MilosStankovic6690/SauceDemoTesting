using SauceDemoTesting.Driver;
using SauceDemoTesting.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTesting.Tests
{
    public class BuyProductTest
    {
        private LoginPage _loginPage;
        private InventoryPage _inventoryPage;
        private CartPage _cartPage; 

        [SetUp]
        public void BeforeScenario()
        {
            WebDrivers.Initialize();
            _loginPage = new LoginPage();
            _inventoryPage = new InventoryPage();
            _cartPage= new CartPage();
        }

        [TearDown]
        public void ClosePage()
        {
            WebDrivers.Shutdown();
        }

        [Test]
        public void TC06_AddThreeProductsInCart_ShouldDisplayedThreeProducts()
        {
            _loginPage.Login("standard_user", "secret_sauce");
            _inventoryPage.SelectOption("Price (low to high)");
            _inventoryPage.Onesie.Click();
            _inventoryPage.BikeLight.Click();
            _inventoryPage.BoltTShirt.Click();

            Assert.That("3", Is.EqualTo(_inventoryPage.CartWithProduct.Text));
        }

        [Test]
        public void TC07_AddTwoProductsDeleteThemAndReturnToTheHomePage_ShouldCartBeEmpty()
        {
            _loginPage.Login("standard_user", "secret_sauce");
            _inventoryPage.Onesie.Click();
            _inventoryPage.BoltTShirt.Click();
            _inventoryPage.CartWithProduct.Click();
            _cartPage.RemoveOnesie.Click();
            _cartPage.RemoveBoltTShirt.Click();
            _cartPage.ContinueShoppingButton.Click();
            

            Assert.That(_inventoryPage.CartWithoutProduct.Displayed);
        }
    }
}
