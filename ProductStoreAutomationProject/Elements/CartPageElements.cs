using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class CartPageElements : MainTest
    {
        DriverCommands driverCommands;
        public CartPageElements(IWebDriver driver) : base(driver) 
        {
            driverCommands = new(driver);
        }

        public IWebElement ProductCartTable()
        {
            return driverCommands.FindElementUntilVisible(By.ClassName("table-responsive"));
        }
    }
}
