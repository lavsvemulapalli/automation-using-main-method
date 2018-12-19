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
    class DatePickerDemo
    {
        [SetUp]
        public void Intilizing()
        {
           
            Common.d = new ChromeDriver();
            Common.d.Navigate().GoToUrl("https://www.skyscanner.co.nz/");
            Common.d.Manage().Window.Maximize();
            Common.d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
        }

        [TestCase]
        public void Test1()
        {
            Common page = new Common();

            Common.d.FindElement(By.XPath("//*[@id='origin-fsc-search']")).SendKeys("auckland");
            Common.d.FindElement(By.XPath("//*[@id='destination-fsc-search']")).SendKeys("hyderabad");
            Common.d.FindElement(By.XPath("//*[@id='depart-fsc-datepicker-input']")).Click();
            Thread.Sleep(5000);
            Common.d.FindElement(By.XPath("//*[@id='depart-fsc-datepicker-input-popover']/div/div[2]/div/table/tbody/tr[4]/td[6]/button/span")).Click();
            Thread.Sleep(5000);
            Common.d.FindElement(By.XPath("//*[@id='return-fsc-datepicker-input']")).Click();
            Thread.Sleep(5000);
            Common.d.FindElement(By.XPath("//*[@id='return-fsc-datepicker-input-popover']/div/div[2]/div/table/tbody/tr[6]/td[2]/button/span")).Click();
            Thread.Sleep(5000);
            Common.d.FindElement(By.XPath("//*[@id='fsc-class-travellers-trigger-1PZXn']/span")).Click();

           Common.d.FindElement(By.XPath("//*[@id='cabin-class-travellers-popover']/div/div/div[1]/div/button[2]")).Click();
            Thread.Sleep(2000);
            Common.d.FindElement(By.XPath("//*[@id='cabin-class-travellers-popover']/footer/button")).Click();
            Thread.Sleep(2000);

            Common.d.FindElement(By.XPath("//*[@id='flights-search-controls-root']/div/div/form/div[3]/button")).Click();

            Thread.Sleep(30000);



        }

        [TearDown]
        public void Closing()
        {
            Common.d.Quit();
        }


    }
}
