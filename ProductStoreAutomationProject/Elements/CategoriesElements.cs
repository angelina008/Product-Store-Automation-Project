using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreAutomationProject.Elements
{
    class CategoriesElements : MainTest
    {
        public CategoriesElements(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement ProductName(int i)
        {
            return driver.FindElement(By.XPath($"//*[@id=\"tbodyid\"]/div[{i}]/div/div/h4/a"));
        }

        public int NumberOfProducts()
        {
            return driver.FindElements(By.XPath("//*[@id=\"tbodyid\"]/div")).Count;
        }

        public IWebElement CategoriesTable()
        {
            return driver.FindElement(By.XPath("//*[@id=\"contcont\"]/div/div[1]/div"));
        }

        public IWebElement CategoriesTitle()
        {
            return driver.FindElement(By.Id("cat"));
        }
        
        public IWebElement CategoriesPhones()
        {
            return driver.FindElement(By.XPath("//*[@id=\"itemc\"][1]"));
        }

        public IWebElement CategoriesLaptops()
        {
            return driver.FindElement(By.XPath("//*[@id=\"itemc\"][2]"));
        }

        public IWebElement CategoriesMonitors()
        {
            return driver.FindElement(By.XPath("//*[@id=\"itemc\"][3]"));
        }
    }
}
