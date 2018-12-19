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
using AutoItX3Lib;
using OpenQA.Selenium;

namespace ConsoleApp4
{
    class PageObject
    {

        [SetUp]
        public void Intilizing()
        {
           
            Common.d = new ChromeDriver();
            Common.d.Navigate().GoToUrl("http://qaautomation.co.nz/contact-us/");
            Common.d.Manage().Window.Maximize();
            Common.d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
        }

        [TestCase]
        public void Test1()
        {
            Common page = new Common();
            page.box.SendKeys("lavanya");
            page.email.SendKeys("vlavanuya10@gmail.com");                
            page.subject.SendKeys("qaselenium");
            page.message.SendKeys("hi");
            Thread.Sleep(3000);





        }

        [TearDown]
        public void Closing()
        {
            Common.d.Quit();
        }






    }
}
