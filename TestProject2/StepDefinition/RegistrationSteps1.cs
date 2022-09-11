using System;
using TechTalk.SpecFlow;

namespace TestProject2.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        [Given(@"i confirm Password")]
        public void GivenIConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
