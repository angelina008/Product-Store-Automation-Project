using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class TopMenuBarElements : MainTest
    {
        public TopMenuBarElements(IWebDriver driver) : base(driver) { }

        public IWebElement ProductStoreLogo()
        {
            return driver.FindElement(By.Id("nava"));
        }

        public IWebElement TopMenuBarHomeTab()
        {
            return driver.FindElement(By.XPath("//*[@id=\"navbarExample\"]/ul/li[1]/a")); 
        }

        public IWebElement TopMenuBarContactTab()
        {
            return driver.FindElement(By.XPath("//*[@id=\"navbarExample\"]/ul/li[2]/a"));
        }

        public IWebElement TopMenuBarAboutUsTab()
        {
            return driver.FindElement(By.XPath("//*[@id=\"navbarExample\"]/ul/li[3]/a"));
        }

        public IWebElement TopMenuBarCartTab()
        {
            return driver.FindElement(By.XPath("//*[@id=\"navbarExample\"]/ul/li[4]/a"));
        }

        public IWebElement TopMenuBarLogInTab()
        {
            return driver.FindElement(By.XPath("//*[@id=\"navbarExample\"]/ul/li[5]/a"));
        }

        public IWebElement TopMenuBarSingUpTab()
        {
            return driver.FindElement(By.XPath("//*[@id=\"signin2\"]"));
        }
    }
}
