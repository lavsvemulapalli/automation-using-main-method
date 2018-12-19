using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        IWebDriver d;
        [SetUp]
        public void Intilize()
        {

            d = new ChromeDriver();
           
            d.Manage().Window.Maximize();
            
        }
        [TestCase]
        public void test1()
        {
            d.Navigate().GoToUrl("https://www.facebook.com/");
            d.FindElement(By.Name("firstname")).SendKeys("lavanya");
            d.FindElement(By.Name("lastname")).SendKeys("vemulapalli");
            d.FindElement(By.Name("reg_email__")).SendKeys("vlavanya10@gmail.com");
            d.FindElement(By.Name("reg_passwd__")).SendKeys("lavanya1");
            //SelectElement day = new SelectElement(d.FindElement(By.Id("day")));
            //day.SelectByValue("10");
            //SelectElement month = new SelectElement(d.FindElement(By.Id("month")));
            //month.SelectByValue("8");
            //SelectElement year = new SelectElement(d.FindElement(By.Id("year")));
            //year.SelectByValue("1989");
            //d.FindElement(By.Name("sex")).Click();
            Thread.Sleep(5000);



        }

        [TestCase]
        public void test2()
        {
            d.Navigate().GoToUrl("https://www.facebook.com/");
            SelectElement day = new SelectElement(d.FindElement(By.Id("day")));
            day.SelectByValue("10");
            SelectElement month = new SelectElement(d.FindElement(By.Id("month")));
            month.SelectByValue("8");
            SelectElement year = new SelectElement(d.FindElement(By.Id("year")));
            year.SelectByValue("1989");
            d.FindElement(By.Name("sex")).Click();
            Thread.Sleep(5000);
        }



        [TearDown]
        public void OneTimetear()
        {
           d.Quit();
}







    }
}
