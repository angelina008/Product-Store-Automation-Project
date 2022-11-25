using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreAutomationProject.Tests
{
    class MainTest
    {
        string url = "https://www.demoblaze.com/index.html";
        public IWebDriver driver;
        public MainTest() { }

        //public MainTest(IWebDriver driver) { this.driver = driver; }

        [SetUp]
        public void SetUp()
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
        }

        [TearDown]
        public void TearDown() { driver.Quit(); }
    }
}
