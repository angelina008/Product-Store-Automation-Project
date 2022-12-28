using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class CartPageCommands : CartPageElements
    {
        public CartPageCommands(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnDeleteButtonInRow(int i)
        {
            DeleteButtonInRow(i).Click();
            Thread.Sleep(1500);
        }

        public void ClickOnPlaceOrderButton()
        {
            PlaceOrderButton().Click();
            Thread.Sleep(1500);
        }
    }
}
