using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class SingUpPopUpCommands : SingUpPopUpElements
    {
        public SingUpPopUpCommands(IWebDriver driver) : base(driver){ }

        public void ClickOnXButton()
        {
            PopUpXButton().Click();
            Thread.Sleep(200);
        }
    }
}
