using SauceDemoTesting.Driver;
using SauceDemoTesting.Page;

namespace SauceDemoTesting.Tests
{
    public class FinalPurchaseTest
    {
        private LoginPage _loginPage;
        private InventoryPage _inventoryPage;
        private CartPage _cartPage;
        private ConfirmationPage _confirmationPage;
        private CheckoutPage _checkoutPage;
        private FinishedPurchasePage _finishedPurchasePage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDrivers.Initialize();
            _loginPage = new LoginPage();
            _inventoryPage = new InventoryPage();
            _cartPage = new CartPage();
            _confirmationPage = new ConfirmationPage();
            _checkoutPage = new CheckoutPage();
            _finishedPurchasePage = new FinishedPurchasePage();
        }

        [TearDown]
        public void ClosePage()
        {
            WebDrivers.Shutdown();
        }

        public string OrderMessage = "THANK YOU FOR YOUR ORDER";

        [Test]
        public void TC01_AddThreeProductsAndCompleteThePurchase_ThePurchaseShouldBeSuccessful()
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
            _checkoutPage.FinishButton.Click();

            Assert.That(OrderMessage, Is.EqualTo(_finishedPurchasePage.OrderFinished.Text));
        }
    }
}
