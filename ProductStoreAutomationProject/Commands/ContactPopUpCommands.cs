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
            Thread.Sleep(200);
        }

        public void ClickOnCloseButton()
        {
            CloseButton().Click();
            Thread.Sleep(700);
        }

        public void ClickOnSendMessageButton()
        {
            SendMessageButton().Click();
            Thread.Sleep(700);
        }

        public void InsertTextInContactEmailTextBox(string email)
        {
            ContactEmailTextBox().Click();
            ContactEmailTextBox().Clear();
            ContactEmailTextBox().SendKeys(email);
            Thread.Sleep(700);
        }

        public void InsertTextInContactNameTextBox(string name)
        {
            ContactNameTextBox().Click();
            ContactNameTextBox().Clear();
            ContactNameTextBox().SendKeys(name);
            Thread.Sleep(700);
        }

        public void InsertTextInMessageTextBox(string message)
        {
            MessageTextBox().Click();
            MessageTextBox().Clear();
            MessageTextBox().SendKeys(message);
            Thread.Sleep(700);
        }

        public void RemoveTextFromContactEmailTextBox()
        {
            ContactEmailTextBox().Click();
            ContactEmailTextBox().Clear();
            Thread.Sleep(700);
        }

        public void RemoveTextFromContactNameTextBox()
        {
            ContactNameTextBox().Click();
            ContactNameTextBox().Clear();
            Thread.Sleep(700);
        }
    }
}
