using NUnit.Framework;
using OpenQA.Selenium;

namespace ProductStoreAutomationProject.Tests
{
    class PurchaseProductCombinedTest : MainTest
    {

        [Test]
        public void Test()
        {
            IWebElement button = driver.FindElement(By.Id("nava"));
            button.Click();
            Thread.Sleep(1000);
        }
    }
}
