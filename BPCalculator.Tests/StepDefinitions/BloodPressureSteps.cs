using BPCalculator;
using TechTalk.SpecFlow;
using Xunit;

namespace BPCalculator.Tests.StepDefinitions
{
    [Binding]
    public class BloodPressureSteps
    {
        private BloodPressure? _bp;
        private string? _result;


        [Given(@"the systolic value is (.*)")]
        public void GivenTheSystolicValueIs(int systolic)
        {
            _bp = new BloodPressure();
            _bp.Systolic = systolic;
        }

        [Given(@"the diastolic value is (.*)")]
        public void GivenTheDiastolicValueIs(int diastolic)
        {
            _bp!.Diastolic = diastolic;

        }

        [When(@"I calculate the blood pressure category")]
        public void WhenICalculateTheBloodPressureCategory()
        {
            _result = _bp!.Category.ToString().Replace("PreHigh", "Pre-High") + " Blood Pressure";

        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string expected)
        {
            Assert.Equal(expected, _result);
        }
    }
}
