using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace ProductStoreAutomationProject
{
    class DriverCommands : MainTest
    {
        WebDriverWait webDriverWait;
        public DriverCommands(IWebDriver driver) : base(driver)
        {
            webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        public void WaitUntilElementDisappears(By locator)
        {
            webDriverWait.Until(ExpectedConditions.InvisibilityOfElementLocated(locator));
        }

        public void WaitUntilElementIsVisible(By locator)
        {
            webDriverWait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public void WaitUntilElementIsClickable(By locator)
        {
            webDriverWait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void WaitUntilElementIsLoaded(By locator)
        {
            webDriverWait.Until(ExpectedConditions.ElementExists(locator));
        }


        public IWebElement FindElementUntilVisible(By locator)
        {
            WaitUntilElementIsVisible(locator);
            return driver.FindElement(locator);
        }

        public IWebElement FindElementUntilClickable(By locator)
        {
            WaitUntilElementIsClickable(locator);
            return driver.FindElement(locator);
        }

        public IWebElement FindElementUntilLoaded(By locator)
        {
            WaitUntilElementIsLoaded(locator);
            return driver.FindElement(locator);
        }
    }
}
