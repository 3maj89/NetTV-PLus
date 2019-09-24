using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras;
using System;

namespace Pages
{

    class PromotionsPage
    {
        //IWebDriver driver;
        //WebDriverWait wait;
        //IWebElement element;

        private IWebElement WaitForElementClickability(IWebDriver driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(condition: ExpectedConditions.ElementToBeClickable(locator));
            return element;
        }

        private IWebElement WaitForElementVisibility(IWebDriver driver, By locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
            return element;
        }

        public void ClickOnElement(IWebDriver driver, By locator)
        {
            IWebElement element = WaitForElementClickability(driver, locator);
            element.Click();
        }

        public IWebElement FindElement(IWebDriver driver, By locator)
        {
            IWebElement element = WaitForElementVisibility(driver, locator);
            return element;
        }

        public IWebElement VerifyElementInCart(IWebDriver driver, By locator)
        {
            IWebElement element = WaitForElementVisibility(driver, locator);
            
            return element;
        }

        private void OpenDevicesStep(IWebDriver driver)
        {
            driver.Url = "https://www.toolsqa.com/selenium-webdriver/c-sharp/webelement-commands-in-c/";
            ClickOnElement(driver, By.CssSelector("button[data-qa=button.FirstPlan]"));
        }

        public void OpenBoxPromotion(IWebDriver driver)
        {
            OpenDevicesStep(driver);
            ClickOnElement(driver, By.CssSelector("button[data-qa=button.Box]"));
        }

        public void OpenNoBoxPromotion(IWebDriver driver)
        {
            OpenDevicesStep(driver);
            ClickOnElement(driver, By.CssSelector("button[data-qa=button.NoBox]"));
        }

        public void ClickOnFirstBoxPromotion(IWebDriver driver, By locator)
        {
            OpenBoxPromotion(driver);
            ClickOnElement(driver, By.CssSelector(""));
        }
        public void ClickOnSecondBoxPromotion(IWebDriver driver, By locator)
        {
            OpenBoxPromotion(driver);
            ClickOnElement(driver, By.CssSelector(""));
        }
        public void ClickOnThirdBoxPromotion(IWebDriver driver, By locator)
        {
            OpenBoxPromotion(driver);
            ClickOnElement(driver, By.CssSelector(""));
        }
    }
}
