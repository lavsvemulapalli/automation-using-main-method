using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  
    class Common
    {

        public Common()
        {
            PageFactory.InitElements(Common.d, this);
        }


        public static IWebDriver d { get; set; }
        [FindsBy(How = How.Name, Using = "your-name")]
        public IWebElement box { get; set; }
        [FindsBy(How = How.Name, Using = "your-email")]

        public IWebElement email { get; set; }

        [FindsBy(How = How.Name, Using = "your-subject")] public IWebElement subject;
        [FindsBy(How = How.Name, Using = "your-message")] public IWebElement message;


        public static void textbox(IWebDriver d, String element, string value, string elementtype)

        {
            if (elementtype == "Name")
                d.FindElement(By.Name(element)).SendKeys(value);
            if (elementtype == "Id")
                d.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Xpath")
                d.FindElement(By.XPath(element)).SendKeys(value);
        }
        public static void button(IWebDriver d, String element,  string elementtype)

        {
            if (elementtype == "Name")
                d.FindElement(By.Name(element)).Click();
           else if (elementtype == "Id")
                d.FindElement(By.Id(element)).Click();
            else if (elementtype == "Xpath")
                d.FindElement(By.XPath(element)).Click();

        }


    }
    
   
      

}
