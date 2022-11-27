using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreAutomationProject.Tests
{
    class HomePageCombinedTest : MainTest
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
