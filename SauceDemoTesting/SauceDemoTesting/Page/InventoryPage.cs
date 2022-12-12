using OpenQA.Selenium;
using SauceDemoTesting.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemoTesting.Page
{
    public class InventoryPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public string URLInventoryPage = "https://www.saucedemo.com/inventory.html";
    }
}
