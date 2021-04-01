using BCQAExam.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BCQAExam.Steps
{
    [Binding]
    public class CreateAnAccountStep : BaseStepDefinition
    {
        private NavigationPage NavigationPage = new NavigationPage();
        private RegistrationPage RegistrationPage = new RegistrationPage();
        private MyAccountPage MyAccountPage = new MyAccountPage();
        private dynamic _ScenarioData;

        [Given(@"I am in the create an account page")]
        public void GivenIAmInTheCreateAnAccountPage()
        {
            NavigationPage.NavigateToHomePage();
            NavigationPage.NavigateToLoginPage();
            _ScenarioData = table.CreateDynamicInstance();
            RegistrationPage.Login((string)_ScenarioData.Email);
        }

        [When(@"I enter my personal infomation")]
        public void WhenIEnterMyPersonalInfomation(Table table)
        {
            RegistrationPage.EnterMyPersonalInformation();
            _ScenarioData = table.CreateDynamicInstance();
            RegistrationPage.Login((string)_ScenarioData.FirstName, (string)_ScenarioData.LastName, (string)_ScenarioData.Password);
        }

        [And(@"I enter my address")]
        public void AndIEnterMyAddress()
        {
            RegistrationPage.EnterMyAddress();
            _ScenarioData = table.CreateDynamicInstance();
            RegistrationPage.Login((string)_ScenarioData.Company, (string)_ScenarioData.Address, (string)_ScenarioData.Address2, (string)_ScenarioData.City, (string)_ScenarioData.PostalCode, (string)_ScenarioData.AdditionalInformation, (string)_ScenarioData.HomePhone, (string)_ScenarioData.MobilePhone, (string)_ScenarioData.AssignAddress);
        }

        [And(@"I click register button")]
        public void AndIClickRegisterButton()
        {
            RegistrationPage.RegisterButton();
        }

        [Then(@"I should be redirected to my Account Page")]
        public void ThenIShouldBeRedirectedToMyAccountPage()
        {
            MyAccountPage.AssertAccountName2();
        }
    }
}
