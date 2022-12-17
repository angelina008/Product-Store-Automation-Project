using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class CategoriesCommands : CategoriesElements
    {
        public CategoriesCommands(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnCategoriesTitle()
        {
            CategoriesTitle().Click();
            Thread.Sleep(1500);
        }

        public void ClickOnCategoriesPhones()
        {
            CategoriesPhones().Click();
            Thread.Sleep(1500);
        }

        public void ClickOnCategoriesLaptops()
        {
            CategoriesLaptops().Click();
            Thread.Sleep(1500);
        }

        public void ClickOnCategoriesMonitors()
        {
            CategoriesMonitors().Click();
            Thread.Sleep(1500);
        }

        public void ClickOnProductName(int i)
        {
            ProductName(i).Click();
            Thread.Sleep(500);
        }
    }
}
