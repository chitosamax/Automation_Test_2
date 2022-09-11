using System;
using TechTalk.SpecFlow;
using TestProject2.PageObject;

namespace TestProject2.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();
        }


        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }
        
        [Given(@"I enter my First name")]
        public void GivenIEnterMyFirstName()
        {
            registrationPage.EnterFirstName();
        }
        
        [Given(@"I enter my Last Name")]
        public void GivenIEnterMyLastName()
        {
            registrationPage.EnterLastName();
        }
        
        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            registrationPage.EnterEmail();
        }
        
        [Given(@"I enter my contact number")]
        public void GivenIEnterMyContactNumber()
        {
            registrationPage.EnterContactNumber();
        }

        //[Given(@"I click on the gender")]
        //public void GivenIClickOnTheGender()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Given(@"I click on Hobbies")]
        //public void GivenIClickOnHobbies()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        [Given(@"I enter Password")]
        public void GivenIEnterPassword()
        {
            registrationPage.EnterPassword();
        }

        [Given(@"i confirm password")]
        public void GivenIRe_EnterPassword()
        {
            ScenarioContext.Current.Pending();
        }

        //[When(@"I click on the submit button")]
        //public void WhenIClickOnTheSubmitButton()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"I should register successfully")]
        //public void ThenIShouldRegisterSuccessfully()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}
