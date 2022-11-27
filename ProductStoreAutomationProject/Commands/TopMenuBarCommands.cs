using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class TopMenuBarCommands : TopMenuBarElements
    {
        public TopMenuBarCommands(IWebDriver driver) : base(driver){ }

        public void ClickOnProductStoreLogo()
        {
            Thread.Sleep(2000); //needs to be changed with other type of waiting
            ProductStoreLogo().Click();
        }

        public void ClickOnHomeTab()
        {
            Thread.Sleep(2000); //needs to be changed with other type of waiting
            TopMenuBarHomeTab().Click();
        }

        public void ClickOnContactTab()
        {
            Thread.Sleep(2000); //needs to be changed with other type of waiting
            TopMenuBarContactTab().Click();
        }

        public void ClickOnAboutUsTab()
        {
            Thread.Sleep(2000); //needs to be changed with other type of waiting
            TopMenuBarAboutUsTab().Click();
        }

        public void ClickOnCartTab()
        {
            Thread.Sleep(2000); //needs to be changed with other type of waiting
            TopMenuBarCartTab().Click();
        }

        public void ClickOnLogInTab()
        {
            Thread.Sleep(2000); //needs to be changed with other type of waiting
            TopMenuBarLogInTab().Click();
        }

        public void ClickOnSingUpTab()
        {
            Thread.Sleep(2000); //needs to be changed with other type of waiting
            TopMenuBarSingUpTab().Click();
        }

    }
}
