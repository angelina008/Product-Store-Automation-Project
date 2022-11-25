using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroBankAutomationProject.Tests
{
    class HomePageTest : MainTest
    {

        [Test]
        public void Test()
        {
            IWebElement button = driver.FindElement(By.Id("online-banking"));
            button.Click();
            Thread.Sleep(1000);
        }
    }
}
