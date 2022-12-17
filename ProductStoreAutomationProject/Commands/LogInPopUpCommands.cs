using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class LogInPopUpCommands : LogInPopUpElements
    {
        public LogInPopUpCommands(IWebDriver driver) : base(driver) { }

        public void ClickOnXButton()
        {
            PopUpXButton().Click();
            Thread.Sleep(200);
        }
    }
}
