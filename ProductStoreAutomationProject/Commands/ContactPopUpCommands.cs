using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class ContactPopUpCommands : ContactPopUpElements
    {
        public ContactPopUpCommands(IWebDriver driver) : base(driver){ }

        public void ClickOnXButton()
        {
            PopUpXButton().Click();
        }
    }
}
