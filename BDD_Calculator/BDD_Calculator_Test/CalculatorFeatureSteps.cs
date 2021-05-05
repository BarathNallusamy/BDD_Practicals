using System;
using TechTalk.SpecFlow;

namespace BDD_Calculator_Test
{
    [Binding]
    public class CalculatorFeatureSteps
    {
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter (.*) and (.*) into the calculator")]
        public void GivenIEnterAndIntoTheCalculator(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
