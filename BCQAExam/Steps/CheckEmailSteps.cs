using BCQAExam.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BCQAExam.Steps
{
    [Binding]
    public class CheckEmailStep : BaseStepDefinition
    {
        private NavigationPage NavigationPage = new NavigationPage();
        private RegistrationPage RegistrationPage = new RegistrationPage();
        private dynamic _ScenarioData;

        [Given(@"I am in the home page of the system")]
        public void GivenIAmInTheHomePageOfTheSystem()
        {
            NavigationPage.NavigateToHomePage();
        }

        [When(@"I enter my email")]
        public void WhenIEnterMyEmail(Table table)
        {
            NavigationPage.NavigateToLoginPage();
            _ScenarioData = table.CreateDynamicInstance();
            RegistrationPage.Login((string)_ScenarioData.Email);
        }

        [And(@"My email is not registered")]
        public void AndMyEmailIsNotRegistered()
        {
            RegistrationPage.AssertCreateAnAccountPage();
        }

        [Then(@"I should be redirected to account creation page")]
        public void ThenIShouldBeRedirectedToAccountCreationPage()
        {
            RegistrationPage.AssertCreateAnAccountPage();
        }
    }
}
