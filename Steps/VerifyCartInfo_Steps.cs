using NUnit.Framework;
using OpenQA.Selenium;
using Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;


namespace Steps
{
    [Binding]

    class VerifyCartInfo_Steps
    {
        private readonly PromotionsPage _promotions;

        public VerifyCartInfo_Steps(PromotionsPage promotions)
        {
            _promotions = promotions;
        }

        [Given(@"that I select Box option")]
        public void GivenThatISelectBoxOption()
        {
            //promotions.OpenBoxPromotion();
        }

        [When(@"I select ""(.*)"" Promotion")]
        public void WhenISelectPromotion(string p0)
        {
            //_promotions.FindElement(driver, locator).Click();
        }

        [Then(@"in Cart I see ""(.*)""\.")]
        public void ThenInCartISee_(string p0)
        {
            
        }

        [When(@"I select Subscription ""(.*)""")]
        public void WhenISelectSubscription(string p0)
        {
            
        }

        [Then(@"in Cart I see ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""\.")]
        public void ThenInCartISee_(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
        {
            
        }

        [Given(@"that I select No Box option")]
        public void GivenThatISelectNoBoxOption()
        {
            
        }

        [Then(@"in Cart I see ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void ThenInCartISee(string p0, string p1, string p2, string p3, string p4)
        {
            
        }

    }
}
