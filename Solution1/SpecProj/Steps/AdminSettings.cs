using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecProj.Steps
{
    [Binding]
    public sealed class AdminSettings
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public AdminSettings(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am authenticated to application as '(.*)'")]
        public void GivenIAmAuthenticatedToApplicationAs(string p0)
        {
            
        }

        [When(@"I open settings using menu")]
        public void WhenIOpenSettingsUsingMenu()
        {
        }

        [Then(@"Settings are opened")]
        public void ThenSettingsAreOpened()
        {
        }

        [Then(@"'(.*)' settings are available")]
        public void ThenSettingsAreAvailable(string p0)
        {
            Assert.Pass();
        }

    }
}
