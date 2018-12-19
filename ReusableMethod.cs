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
    class ReusableMethod
    {
        [SetUp]
        public void set()
        {
            CommonMethods.d = new ChromeDriver();
            CommonMethods.d.Navigate().GoToUrl("http://qaautomation.co.nz/contact-us/");
            CommonMethods.d.Manage().Window.Maximize();
            CommonMethods.d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);
        }

        [TestCase]
        public void test2()
        {
            //CommonMethods cm = new CommonMethods();
            CommonMethods.textbox(CommonMethods.d, "your-name", "lavanya", "Name");
            CommonMethods.textbox(CommonMethods.d, "your-email", "vlavanya10@gmail.com", "Name");
            WebDriverWait wait1 = new WebDriverWait(CommonMethods.d, TimeSpan.FromSeconds(60));
            wait1.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='wpcf7-f4-p87-o1']/form/p[5]/input")));
            CommonMethods.button(CommonMethods.d, "//*[@id='wpcf7-f4-p87-o1']/form/p[5]/input", "Xpath");
            Thread.Sleep(2000);
            

        }
        [TearDown]
        public void closing()
        {
            CommonMethods.d.Quit();
        }
    }
}
