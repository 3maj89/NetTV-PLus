using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestRun
{
    class Run
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("D:\\casovi_automatizacije\\VSC");
        }
        [Test]
        public void test()
        {
            driver.Url= "https://nunit.org/docs/2.4.2/assertions.html";
            

        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
