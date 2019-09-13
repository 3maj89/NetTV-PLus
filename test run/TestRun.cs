using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support;
using System;

namespace TestRun
{
    class Run
    {
        IWebDriver driver;
       
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\nevena.cukucan\\Desktop\\AUTOMATIZACIJA\\novintv-paidco");
        }
        [Test]
        public void test()
        {
            driver.Url= "https://nettvplus.wm.rs/oec/checkout/app/packages";
            IWebElement element = driver.FindElement(By.CssSelector(""));
            element.Click();

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
