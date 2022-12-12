using SauceDemoTesting.Driver;
using SauceDemoTesting.Page;
using OpenQA.Selenium;

namespace SauceDemoTesting.Tests
{
    public class Tests
    {
        LoginPage _loginPage;
        InventoryPage _inventoryPage;

        [SetUp]
        public void BeforeScenario()
        {
            WebDrivers.Initialize();
            _loginPage = new LoginPage();
            _inventoryPage = new InventoryPage();
        }

        [TearDown]
        public void ClosePage()
        {
            WebDrivers.Shutdown();
        }

        [Test]
        public void TC01_FillUsernameAndPasswordWithValidData_ShouldInventoryPageDisplayed()
        {
            _loginPage.Login("standard_user", "secret_sauce");
            Assert.That(_inventoryPage.URLInventoryPage, Is.EqualTo(WebDrivers.Instance.Url));
        }

        [Test]
        public void TC02_FillValidUsernameAndInvalidPassword_ItShouldNotBeLogged()
        {
            _loginPage.Login("standard_user", "secret");
            Assert.That(_loginPage.ErrorText, Is.EqualTo(_loginPage.ErrorMessage.Text));
        }

        [Test]
        public void TC03_FillInvalidUsernameAndValidPassword_ItShouldNotBeLogged()
        {
            _loginPage.Login("standard", "secret_sauce");
            Assert.That(_loginPage.ErrorText, Is.EqualTo(_loginPage.ErrorMessage.Text));
        }

        [Test]
        public void TC04_FillInvalidUsernameAndInvalidPassword_ItShouldNotBeLogged()
        {
            _loginPage.Login("standard", "secret");
            Assert.That(_loginPage.ErrorText, Is.EqualTo(_loginPage.ErrorMessage.Text));
        }

        [Test]
        public void TC05_DoNotEnterDataIntoTheFields_ItShouldNotBeLogged()
        {
            _loginPage.Login("", "");
            Assert.That(_loginPage.ErrorTextWithNoData, Is.EqualTo(_loginPage.ErrorMessage.Text));
        }
    }
}