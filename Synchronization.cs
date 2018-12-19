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
    class Synchronization
    {
        IWebDriver d;
        [SetUp]
        public void Intilize()
        {

            d = new ChromeDriver();

            d.Manage().Window.Maximize();
           d.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(1);

        }
        [TestCase]
        public void test1()
        {

            d.Navigate().GoToUrl("https://www.veethi.com/places/india_banks-ifsc-codes.html");
            SelectElement bank = new SelectElement(d.FindElement(By.Id("selBank")));
            bank.SelectByValue("3");
      
            SelectElement state = new SelectElement(d.FindElement(By.Id("selState")));
            state.SelectByValue("1");
            //// Wait<IWebDriver>
           // IWait<IWebDriver> wait = new FluentWait<IWebDriver>(d)
            // .withTimeout(timeoutSeconds, TimeUnit.SECONDS)
            // .pollingEvery(500, TimeUnit.MILLISECONDS)
            // .ignoring(NoSuchElementException.class);

            SelectElement city = new SelectElement(d.FindElement(By.Id("selCity")));
            city.SelectByValue("2");
            WebDriverWait wait1 = new WebDriverWait(d, TimeSpan.FromMinutes(1));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.Id("selBranch")));
            SelectElement branch = new SelectElement(d.FindElement(By.Id("selBranch")));
            branch.SelectByValue("UTIB0000515");
            Thread.Sleep(3000);






        }

        



        [TearDown]
        public void OneTimetear()
        {
            d.Quit();
        }


    }
}
