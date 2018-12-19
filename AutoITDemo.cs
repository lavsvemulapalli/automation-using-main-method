using AutoItX3Lib;
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
    class AutoITDemo
    {
        [SetUp]
        public void Intilizing()
        {
            
            Common.d = new ChromeDriver();
            Common.d.Navigate().GoToUrl("https://www.google.com/");
            Common.d.Manage().Window.Maximize();
            Common.d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
        }

        [TestCase]
        public void Test1()
        {
            Common page = new Common();
            Common.d.FindElement(By.LinkText("Images")).Click();
            Common.d.FindElement(By.XPath("//*[@id='qbi']")).Click();
            Common.d.FindElement(By.LinkText("Upload an image")).Click();
            Common.d.FindElement(By.Id("qbfile")).Click();


            AutoItX3 auto = new AutoItX3();
            auto.WinActivate("Open");
            Thread.Sleep(3000);
            auto.Send("D:\\download.jpg");
            Thread.Sleep(3000);
            auto.Send("{Enter}");
            Thread.Sleep(9000);



        }

        [TearDown]
        public void Closing()
        {
            Common.d.Quit();
        }

    }
}
