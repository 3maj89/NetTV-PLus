using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using VSC.Pages;

namespace VSC.Steps
{
    [Binding]

    class VerifyCartInfo_Steps
    {
        private readonly Promotions _promotionsCartDetails;

        public VerifyCartInfo_Steps(Promotions promotionsCartDetails)
        {
            _promotionsCartDetails = promotionsCartDetails;
        }

        [Given(@"that I select Box option")]
        public void GivenThatISelectBoxOption()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select ""(.*)"" Promotion")]
        public void WhenISelectPromotion(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"in Cart I see ""(.*)""\.")]
        public void ThenInCartISee_(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I select Subscription ""(.*)""")]
        public void WhenISelectSubscription(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"in Cart I see ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""\.")]
        public void ThenInCartISee_(string p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"that I select No Box option")]
        public void GivenThatISelectNoBoxOption()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"in Cart I see ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void ThenInCartISee(string p0, string p1, string p2, string p3, string p4)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
