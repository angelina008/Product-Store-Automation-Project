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

        public int NumberOfProductsInCart()
        {
            return driver.FindElements(By.XPath("//*[@id=\"tbodyid\"]/tr")).Count;
        }

        public IWebElement DeleteButtonInRow(int i)
        {
            return driverCommands.FindElementUntilClickable(By.XPath($"//*[@id=\"tbodyid\"]/tr[{i}]/td[4]/a"));
        }

        public IWebElement PlaceOrderButton()
        {
            return driverCommands.FindElementUntilVisible(By.XPath("//*[@id=\"page-wrapper\"]/div/div[2]/button"));
        }
    }
}
