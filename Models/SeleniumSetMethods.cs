using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SimproV.Models
{
    class SeleniumSetMethods
    {
        // Enter text
        public static void EnterText(string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                Configuration.driver.FindElement(By.Id(element)).SendKeys(value);
            }
            if (elementtype == "Name")
            {
                Configuration.driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }
        // Click into a button, checkbox, option
        public static void MouseClick(string element, string elementtype)
        {
            if (elementtype == "Id")
            {
                Configuration.driver.FindElement(By.Id(element)).Click();
            }
            if (elementtype == "Name")
            {
                Configuration.driver.FindElement(By.Name(element)).Click();
            }
        }
        // Select Drop down control
        public static void SelectDropDown(string element, string value, string elementtype)
        {
            if (elementtype == "Id")
            {
                new SelectElement(Configuration.driver.FindElement(By.Id(element))).SelectByText(value);
            }
            if (elementtype == "Name")
            {
                new SelectElement(Configuration.driver.FindElement(By.Name(element))).SelectByText(value);
            }
        }
    }
}
