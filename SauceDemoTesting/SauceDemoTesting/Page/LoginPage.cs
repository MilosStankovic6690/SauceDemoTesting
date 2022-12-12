using OpenQA.Selenium;
using SauceDemoTesting.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTesting.Page
{
    public class LoginPage
    {
        IWebDriver driver = WebDrivers.Instance;

        public IWebElement UserName => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));
        public IWebElement ErrorMessage => driver.FindElement(By.CssSelector("div[class=\"error-message-container error\"]"));
        public string ErrorText = "Epic sadface: Username and password do not match any user in this service";
        public string ErrorTextWithNoData = "Epic sadface: Username is required";
        public void Login(string name, string password)
        {
            UserName.SendKeys(name);
            Password.SendKeys(password);
            LoginButton.Submit();
        }
    }
}
