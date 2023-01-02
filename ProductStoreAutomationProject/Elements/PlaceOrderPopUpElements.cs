using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class PlaceOrderPopUpElements : MainTest
    {
        DriverCommands driverCommands;
        public PlaceOrderPopUpElements(IWebDriver driver) : base(driver)
        {
            driverCommands = new(driver);
        }

        public IWebElement PlaceOrderPopUpTitle()
        {
            return driverCommands.FindElementUntilVisible(By.Id("orderModalLabel"));
        }

        public IWebElement PopUpXButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"orderModal\"]/div/div/div[1]/button/span"));
        }

        public IWebElement PlaceOrderNameTextBox()
        {
            return driverCommands.FindElementUntilVisible(By.Id("name"));
        }

        public IWebElement PlaceOrderCountryTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("country"));
        }

        public IWebElement PlaceOrderCityTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("city"));
        }

        public IWebElement PlaceOrderCreditCardTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("card"));
        }

        public IWebElement PlaceOrderMonthTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("month"));
        }

        public IWebElement PlaceOrderYearTextBox()
        {
            return driverCommands.FindElementUntilClickable(By.Id("year"));
        }

        public IWebElement CloseButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"orderModal\"]/div/div/div[3]/button[1]"));
        }

        public IWebElement PurchaseButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"orderModal\"]/div/div/div[3]/button[2]"));
        }

        public IWebElement PurchaseMessageNewPopUp()
        {
            return driverCommands.FindElementUntilVisible(By.XPath("/html/body/div[10]/h2"));
        }

        public IWebElement OkNewPopUp()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("/html/body/div[10]/div[7]/div/button"));
        }

    }
}
