using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace VSC.Steps
{
    class IsButtonContinueClickable_Steps
    {

        [Given(@"that I selected Box option")]
        public void GivenThatISelectedBoxOption()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"button Continue is inactive\.")]
        public void ThenButtonContinueIsInactive_()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"button Continue is active")]
        public void ThenButtonContinueIsActive()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
