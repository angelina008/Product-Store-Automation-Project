using OpenQA.Selenium;
using ProductStoreAutomationProject.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStoreAutomationProject.Asserts
{
    class CategoriesAsserts : CategoriesElements
    {
        public CategoriesAsserts(IWebDriver driver) : base(driver)
        {
        }

        public bool CategoriesTableDisplayed()
        {
            return CategoriesTable() != null && CategoriesTable().Displayed;
        }

        public bool ProductNameIsEqualTo(int i, string productName)
        {
            return ProductName(i).Text != null && ProductName(i).Text == productName;
        }


    }
}
