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
    class Demo
    {
        [SetUp]
        public void Intilize()
        {

            Common.d = new ChromeDriver();
            Common.d.Manage().Window.Maximize();
            Common.d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);


        }
        [TestCase]
        public void test1()
        {
            Common.d.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/TimeMaterial/Create");
            Common.textbox(Common.d, "UserName", "ray", "Id");
            Common.textbox(Common.d, "Password", "123123", "Id");
            Common.button(Common.d, "//*[@id='loginForm']/form/div[3]/input[1]", "Xpath");
             Common.d.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]")).Click();
            Common.d.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();
            
            //SelectElement opt = new SelectElement(Common.d.FindElement(By.Id("TypeCode_listbox")));
            //opt.SelectByText("Time");
            Common.textbox(Common.d, "//*[@id='Code']", "1234", "Xpath");
            Common.textbox(Common.d, "Description", "QA", "Name");
            Thread.Sleep(5000);
            Common.d.FindElement(By.CssSelector("#TimeMaterialEditForm > div > div:nth-child(11) > div > span.k-widget.k-numerictextbox > span > input.k-formatted-value.k-input")).SendKeys("2000");
            Thread.Sleep(5000);
            Common.button(Common.d, "//input[@id='files']","Xpath");
            Thread.Sleep(5000);
           // Common.d.FindElement(By.XPath("//input[@id='files']")).Click();
            AutoItX3 auto = new AutoItX3();
            auto.WinActivate("Open");
            Thread.Sleep(2000);
            auto.Send("D:\\download.jpg");
            auto.Send("{Enter}");
          
            Thread.Sleep(5000);
            Common.button(Common.d, "SaveButton", "Id");






            Thread.Sleep(5000);



        }



        [TearDown]
        public void OneTimetear()
        {
            Common.d.Quit();
        }
    }
}
