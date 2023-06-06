using System;
using TechTalk.SpecFlow;

namespace TAclassday5.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions
    {
        [Given(@"\[context]I am logged into TurnUp portal successfully\.")]
        public void GivenContextIAmLoggedIntoTurnUpPortalSuccessfully_()
        {
            throw new PendingStepException();
        }

        [When(@"\[action]I Navigate to Time and Material page")]
        public void WhenActionINavigateToTimeAndMaterialPage()
        {
            throw new PendingStepException();
        }

        [When(@"I Create a Time and Material record")]
        public void WhenICreateATimeAndMaterialRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"\[outcome]The Record should be created successfully\.")]
        public void ThenOutcomeTheRecordShouldBeCreatedSuccessfully_()
        {
            throw new PendingStepException();
        }
    }
}
