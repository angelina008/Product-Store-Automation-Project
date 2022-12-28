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

        public void ScrollToEndOfPage()
        {
            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control);
            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.End);
            Thread.Sleep(1300);
        }

        public void ScrollToTopOfPage()
        {
            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control);
            driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Home);
            Thread.Sleep(1300);
        }

        public void ClickOkOnPopUp()
        {
            Thread.Sleep(1500);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(1000);
        }

        public string ReturnMessageFromPopUp()
        {
            Thread.Sleep(1500);
            return driver.SwitchTo().Alert().Text;
        }
    }
}
