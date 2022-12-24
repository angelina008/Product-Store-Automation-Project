using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Elements
{
    class CategoriesElements : MainTest
    {
        DriverCommands driverCommands;
        public CategoriesElements(IWebDriver driver) : base(driver)
        {
            driverCommands = new(driver);
        }

        public IWebElement ProductName(int i)
        {
            return driverCommands.FindElementUntilClickable(By.XPath($"//*[@id=\"tbodyid\"]/div[{i}]/div/div/h4/a"));
        }

        public int NumberOfProducts()
        {
            return driver.FindElements(By.XPath("//*[@id=\"tbodyid\"]/div")).Count;
        }

        public IWebElement CategoriesTable()
        {
            return driverCommands.FindElementUntilVisible(By.XPath("//*[@id=\"contcont\"]/div/div[1]/div"));
        }

        public IWebElement CategoriesTitle()
        {
            return driverCommands.FindElementUntilClickable(By.Id("cat"));
        }
        
        public IWebElement CategoriesPhones()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"itemc\"][1]"));
        }

        public IWebElement CategoriesLaptops()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"itemc\"][2]"));
        }

        public IWebElement CategoriesMonitors()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"itemc\"][3]"));
        }

        public IWebElement ProductListPreviousButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"prev2\"]"));
        }

        public IWebElement ProductListNextButton()
        {
            return driverCommands.FindElementUntilClickable(By.XPath("//*[@id=\"next2\"]"));
        }
    }
}
