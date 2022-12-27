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
            Thread.Sleep(700);
        }

        public void ClickOnCancelButton()
        {
            CancelButton().Click();
            Thread.Sleep(700);
        }

        public void ClickOnLogInButton()
        {
            LogInButton().Click();
            Thread.Sleep(700);
        }

        public void InsertTextInUsernameTextBox(string username)
        {
            LogInUsernameTextBox().Click();
            LogInUsernameTextBox().Clear();
            LogInUsernameTextBox().SendKeys(username);
            Thread.Sleep(700);
        }

        public void InsertTextInPasswordTextBox(string password)
        {
            LogInPasswordTextBox().Click();
            LogInPasswordTextBox().Clear();
            LogInPasswordTextBox().SendKeys(password);
            Thread.Sleep(700);
        }

        public void RemoveTextFromUsernameTextBox()
        {
            LogInUsernameTextBox().Click();
            LogInUsernameTextBox().Clear();
            Thread.Sleep(700);
        }

        public void RemoveTextFromPasswordTextBox()
        {
            LogInPasswordTextBox().Click();
            LogInPasswordTextBox().Clear();
            Thread.Sleep(700);
        }
    }
}
