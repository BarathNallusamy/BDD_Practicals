using System;
using TechTalk.SpecFlow;
using BDD_Calculator;
using NUnit.Framework;

namespace BDD_Calculator_Test
{
    [Binding]
    public class CalculatorFeatureSteps
    {
        private Calculator _calculator;
        private int _results;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }
        
        [Given(@"I enter (.*) and (.*) into the calculator")]
        public void GivenIEnterAndIntoTheCalculator(int num1, int num2)
        {
            _calculator.Num1 = num1;
            _calculator.Num2 = num2;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _results = _calculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _results = _calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            _results = _calculator.Multiply();
        }

        [When(@"I press divide")]
        public void WhenIPressDivide()
        {
            _results = _calculator.Divide();
        }

        [Then(@"a DivideByZero Exception should be thrown with the exception message ""(.*)"" when I press Divide")]
        public void ThenADivideByZeroExceptionShouldBeThrownWithTheExceptionMessageWhenIPressDivide(string expectedResults)
        {
            Assert.That(() => _calculator.Divide(), Throws.Exception.With.Message.EqualTo(expectedResults));
        }



        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResults)
        {
            Assert.That(_results, Is.EqualTo(expectedResults));
        }
    }
}
