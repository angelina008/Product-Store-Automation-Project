using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ProductStoreAutomationProject
{
    class MainTest
    {
        string url = "https://www.demoblaze.com/index.html";
        public IWebDriver driver;
        public MainTest() { }
        public MainTest(IWebDriver driver) { this.driver = driver; }

        [SetUp]
        public void SetUp()
        {
            //driver = new FirefoxDriver();
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.Url = url;
        }

        [TearDown]
        public void TearDown() { driver.Quit(); }
    }
}
