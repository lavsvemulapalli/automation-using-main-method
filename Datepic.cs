using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Datepic
    {

        IWebDriver d;
        [SetUp]
        public void Intilize()
        {

            d = new ChromeDriver();
            d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);

            d.Manage().Window.Maximize();

        }
        [TestCase]
        public void test1()
        {
            d.Navigate().GoToUrl("https://www.skyscanner.co.nz/");
            IJavaScriptExecutor js = (IJavaScriptExecutor)d;
           d.FindElement(By.XPath("//*[@id='origin-fsc-search']")).SendKeys("Auckland International (AKL)");
            Thread.Sleep(2000);
            d.FindElement(By.XPath("//*[@id='destination-fsc-search']")).SendKeys("Hyderabad (HYD)");
            Thread.Sleep(2000);
            js.ExecuteScript("document.getElementById('depart-fsc-datepicker-input').value='15/08/2018'");
            Thread.Sleep(2000);
            js.ExecuteScript("document.getElementById('return-fsc-datepicker-input').value='31/12/2018'");
            Thread.Sleep(2000);
            
            d.FindElement(By.XPath("//*[@id='fsc-class-travellers-trigger-1PZXn']/span")).Click();
           
            d.FindElement(By.XPath("//*[@id='cabin-class-travellers-popover']/div/div/div[1]/div/button[2]")).Click();
            Thread.Sleep(2000);
            d.FindElement(By.XPath("//*[@id='cabin-class-travellers-popover']/footer/button")).Click();
            Thread.Sleep(2000);

            d.FindElement(By.XPath("//*[@id='flights-search-controls-root']/div/div/form/div[3]/button")).Click();

            Thread.Sleep(25000);

          



        }

        



        [TearDown]
        public void OneTimetear()
        {
            d.Quit();
        }
    }
}
