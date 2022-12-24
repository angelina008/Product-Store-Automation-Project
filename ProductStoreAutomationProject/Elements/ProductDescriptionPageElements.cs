using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class ProductDescriptionPageElements : MainTest
    {
        DriverCommands driverCommands;
        public ProductDescriptionPageElements(IWebDriver driver) : base(driver)
        {
            driverCommands = new(driver);
        }

        public IWebElement ProductNameTitle()
        {
            return driverCommands.FindElementUntilVisible(By.XPath("//*[@id=\"tbodyid\"]/h2"));
        }

        public IWebElement ProductPrice()
        {
            return driverCommands.FindElementUntilVisible(By.XPath("//*[@id=\"tbodyid\"]/h3"));
        }

        public IWebElement ProductDescription()
        {
            return driverCommands.FindElementUntilVisible(By.Id("more-information"));
        }

        public IWebElement AddToCartButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"tbodyid\"]/div[2]/div/a"));
        }

        public IWebElement ProductPhoto()
        {
            return driverCommands.FindElementUntilVisible(By.XPath("//*[@id=\"imgp\"]/div/img"));
        }
    }
}
