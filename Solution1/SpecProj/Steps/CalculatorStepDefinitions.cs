using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecProj.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the first '(.*)' number is '(.*)'")]
        public void GivenTheFirstNumberIs(int p0, int p1)
        {
            var expected = p0 + 50;

            Assert.AreEqual(expected, p1);
        }

        [Given(@"'(.*)' multiplied by '(.*)' number is '(.*)'")]
        public void GivenMultipliedByNumberIs(int p0, int p1, int p2)
        {
            var acutla = p0 * p1;

            Assert.AreEqual(acutla, p2);
        }

    }
}
