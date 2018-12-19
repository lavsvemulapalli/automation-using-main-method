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
    class PGDemo
    {
       
        [SetUp]
        public void Intilising()
        {
           Common1.d = new ChromeDriver();
            Common1.d.Manage().Window.Maximize();
            Common1.d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
        }
        [TestCase]
        public void test1()
        {
            Common1.d.Navigate().GoToUrl("http://qaautomation.co.nz/deliveryform/");
            Thread.Sleep(4000);
            Common1 a = new Common1();
            a.fn.SendKeys("lavanya");
            a.ln.SendKeys("vemulapalli");
            a.email.SendKeys("vlavanya10@gmail.com");
            a.phno.SendKeys("123456");
            a.cash.Click();
            Thread.Sleep(4000);
            SelectElement opt = new SelectElement(Common1.d.FindElement(By.Id("hugeit_preview_textbox_28")));
            opt.SelectByText("New York");
            Thread.Sleep(2000);
            a.city.SendKeys("aaa");
            a.add1.SendKeys("abc");
            a.add2.SendKeys("hhhh");
            a.zip.SendKeys("1234");
            a.order.Click();
        }
        [TearDown]
        public void closing()
        {
            Common1.d.Quit();
        }

    }
}
