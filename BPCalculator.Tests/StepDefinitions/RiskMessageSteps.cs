using TechTalk.SpecFlow;
using BPCalculator;
using Xunit;

namespace BPCalculator.Tests.StepDefinitions
{
    [Binding]
    public class RiskMessageSteps
    {
        private BloodPressure _bp = new BloodPressure();

        [Given(@"the risk systolic value is (.*)")]
        public void GivenTheRiskSystolicValueIs(int systolic)
        {
            _bp.Systolic = systolic;
        }

        [Given(@"the risk diastolic value is (.*)")]
        public void GivenTheRiskDiastolicValueIs(int diastolic)
        {
            _bp.Diastolic = diastolic;
        }

        [When(@"I compute the blood pressure category")]
        public void WhenIComputeTheCategory()
        {
            var _ = _bp.Category; 
        }

        [Then(@"the risk message should be ""(.*)""")]
        public void ThenTheRiskMessageShouldBe(string expectedMessage)
        {
            Assert.Equal(expectedMessage, _bp.RiskMessage);
        }
    }
}
