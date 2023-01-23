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
            Thread.Sleep(700);
        }

        public void ClickOnCloseButton()
        {
            CloseButton().Click();
            Thread.Sleep(600);
        }

        public void ClickOnSingUpButton()
        {
            SingUpButton().Click();
            Thread.Sleep(1000);
        }

        public void InsertTextInUsernameTextBox(string username)
        {
            SingUpUsernameTextBox().Click();
            SingUpUsernameTextBox().Clear();
            SingUpUsernameTextBox().SendKeys(username);
            Thread.Sleep(700);
        }

        public void InsertTextInPasswordTextBox(string password)
        {
            SingUpPasswordTextBox().Click();
            SingUpPasswordTextBox().Clear();
            SingUpPasswordTextBox().SendKeys(password);
            Thread.Sleep(700);
        }

        public void RemoveTextFromUsernameTextBox()
        {
            SingUpUsernameTextBox().Click();
            SingUpUsernameTextBox().Clear();
            Thread.Sleep(700);
        }

        public void RemoveTextFromPasswordTextBox()
        {
            SingUpPasswordTextBox().Click();
            SingUpPasswordTextBox().Clear();
            Thread.Sleep(700);
        }
    }
}
