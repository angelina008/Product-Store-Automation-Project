using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class AboutUsPopUpCommands : AboutUsPopUpElements
    {
        public AboutUsPopUpCommands(IWebDriver driver) : base(driver){ }

        public void ClickOnXButton()
        {
            PopUpXButton().Click();
            Thread.Sleep(200);
        }
    }
}
