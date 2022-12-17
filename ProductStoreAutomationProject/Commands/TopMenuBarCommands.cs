using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class TopMenuBarCommands : TopMenuBarElements
    {
        public TopMenuBarCommands(IWebDriver driver) : base(driver){ }

        public void ClickOnProductStoreLogo()
        {
            ProductStoreLogo().Click();
            Thread.Sleep(500);
        }

        public void ClickOnHomeTab()
        {
            TopMenuBarHomeTab().Click();
            Thread.Sleep(500);
        }

        public void ClickOnContactTab()
        {
            TopMenuBarContactTab().Click();
            Thread.Sleep(500);
        }

        public void ClickOnAboutUsTab()
        {
            TopMenuBarAboutUsTab().Click();
            Thread.Sleep(500);
        }

        public void ClickOnCartTab()
        {
            TopMenuBarCartTab().Click();
            Thread.Sleep(500);
        }

        public void ClickOnLogInTab()
        {
            TopMenuBarLogInTab().Click();
            Thread.Sleep(500);
        }

        public void ClickOnSingUpTab()
        { 
            TopMenuBarSingUpTab().Click();
            Thread.Sleep(500);
        }
    }
}
