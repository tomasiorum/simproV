using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace SimproV.Models
{
    class SeleniumGetMethods
    {
        /// <summary>
        /// Get text from a html ID or Name tag element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="elementtype"></param>
        /// <returns>Returns boolean or none</returns>
        public static string GetText(string element, string elementtype)
        {
            if (elementtype == "Id")
                return Configuration.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == "Name")
                return Configuration.driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }

        /// <summary>
        /// Find document and is associated message in IDOC 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="elementtype"></param>
        /// <returns>Returns boolean or none</returns>
        public static string GetTextXP(string testfile, string element, string elementtype)
        {
            By id = By.Id("linhas");
            if (elementtype == "B")
                return Configuration.driver.FindElement(id).GetAttribute("value");
            if (elementtype == "P")
                return Configuration.driver.FindElement(id).GetAttribute("value");
            //return Configuration.driver.FindElement(By.XPath(".//div[@id='linhas']//*[contains(text(), '" + testfile + "')]/following::td/p[contains(text(), '" + element + "')]")).GetAttribute("value");
            else return String.Empty;
        }

        /// <summary>
        /// Get text from a DDL - Drop Down List by ID or Name tag element
        /// </summary>
        /// <param name="element"></param>
        /// <param name="elementtype"></param>
        /// <returns>Returns boolean or none</returns>
        public static string GetTextDDL(string element, string elementtype)
        {
            if (elementtype == "Id")
                return new SelectElement(Configuration.driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementtype == "Name")
                return new SelectElement(Configuration.driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
