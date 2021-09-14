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

    }
}
