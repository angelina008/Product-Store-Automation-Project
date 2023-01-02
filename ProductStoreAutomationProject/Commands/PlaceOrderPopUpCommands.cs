using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;

namespace ProductStoreAutomationProject.Commands
{
    class PlaceOrderPopUpCommands : PlaceOrderPopUpElements
    {
        public PlaceOrderPopUpCommands(IWebDriver driver) : base(driver)
        {
        }

        public void ClickOnXButton()
        {
            PopUpXButton().Click();
            Thread.Sleep(700);
        }

        public void ClickOnCloseButton()
        {
            CloseButton().Click();
            Thread.Sleep(700);
        }

        public void ClickOnPurchaseButton()
        {
            PurchaseButton().Click();
            Thread.Sleep(700);
        }

        public void ClickOnOKButton()
        {
            OkNewPopUp().Click();
            Thread.Sleep(700);
        }

        public void InsertTextInNameTextBox(string name)
        {
            PlaceOrderNameTextBox().Click();
            PlaceOrderNameTextBox().Clear();
            PlaceOrderNameTextBox().SendKeys(name);
            Thread.Sleep(700);
        }

        public void InsertTextInCountryTextBox(string country)
        {
            PlaceOrderCountryTextBox().Click();
            PlaceOrderCountryTextBox().Clear();
            PlaceOrderCountryTextBox().SendKeys(country);
            Thread.Sleep(700);
        }

        public void InsertTextInCityTextBox(string city)
        {
            PlaceOrderCityTextBox().Click();
            PlaceOrderCityTextBox().Clear();
            PlaceOrderCityTextBox().SendKeys(city);
            Thread.Sleep(700);
        }

        public void InsertTextInCreditCardTextBox(string card)
        {
            PlaceOrderCreditCardTextBox().Click();
            PlaceOrderCreditCardTextBox().Clear();
            PlaceOrderCreditCardTextBox().SendKeys(card);
            Thread.Sleep(700);
        }

        public void InsertTextInMonthTextBox(string month)
        {
            PlaceOrderMonthTextBox().Click();
            PlaceOrderMonthTextBox().Clear();
            PlaceOrderMonthTextBox().SendKeys(month);
            Thread.Sleep(700);
        }

        public void InsertTextInYearTextBox(string year)
        {
            PlaceOrderYearTextBox().Click();
            PlaceOrderYearTextBox().Clear();
            PlaceOrderYearTextBox().SendKeys(year);
            Thread.Sleep(700);
        }

        public void RemoveTextFromNameTextBox()
        {
            PlaceOrderNameTextBox().Click();
            PlaceOrderNameTextBox().Clear();
            Thread.Sleep(700);
        }

        public void RemoveTextFromCreditCardTextBox()
        {
            PlaceOrderCreditCardTextBox().Click();
            PlaceOrderCreditCardTextBox().Clear();
            Thread.Sleep(700);
        }
    }
}
