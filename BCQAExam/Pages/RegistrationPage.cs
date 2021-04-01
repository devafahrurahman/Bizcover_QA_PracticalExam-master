using BCQAExam.Core;
using OpenQA.Selenium;

namespace BCQAExam.Pages
{
    public class RegistrationPage : BasePage
    {
        private IWebElement CheckEmail => Driver.FindControl(By.Id("email_create"));
        private IWebElement CreateAnAccountButton => Driver.FindControl(By.Id("SubmitCreate"));

        public void CheckMyEmail(string email = null)
        {
            CheckEmail.SendKeys(email);
            CreateAnAccountButton.Click;
        }

        private IWebElement CreateAnAccountPage => Driver.FindControl(By.Xpath("//h1[contains(text(),'Create an account')]"));
        private IWebElement PersonalInfomation => Driver.FindControl(By.Xpath("//h3[contains(text(),'Your personal information')]"));


        public void AssertCreateAnAccountPage()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual("CREATE AN ACCOUNT", CreateAnAccountPage.Text);
                Assert.AreEqual("YOUR PERSONAL INFORMATION", PersonalInfomation.Text);
            });
        }


        private IWebElement Tittle => Driver.FindControl(By.Id("id_gender1"));
        private IWebElement Firstname => Driver.FindControl(By.Id("customer_firstname"));
        private IWebElement LastName => Driver.FindControl(By.Id("customer_lastname"));
        private IWebElement Password => Driver.FindControl(By.Id("passwd"));
        private IWebElement Days = driver.FindElement(By.Id("days"));
        private IWebElement Months = driver.FindElement(By.Id("months"));
        private IWebElement Years = driver.FindElement(By.Id("years"));

        public void EnterMyPersonalInformation(string sFirstName = null, string sLastName = null, string sPassword = null)
        {
            Tittle.Click();
            Firstname.SendKeys(sFirstName);
            LastName.SendKeys(sLastName);
            Password.SendKeys(sPassword);
            Days.SelectByValue("14");
            Months.SelectByValue("12");
            Years.SelectByValue("1996");
        }

        private IWebElement Company => Driver.FindControl(By.Id("company"));
        private IWebElement Address => Driver.FindControl(By.Id("address1"));
        private IWebElement Address2 => Driver.FindControl(By.Id("address2"));
        private IWebElement City => Driver.FindControl(By.Id("city"));
        private IWebElement Country => Driver.FindControl(By.Id("id_country"));
        private IWebElement State => Driver.FindControl(By.Id("id_state"));
        private IWebElement PostalCode => Driver.FindControl(By.Id("postcode"));
        private IWebElement AddInformation => Driver.FindControl(By.Id("other"));
        private IWebElement HomePhone => Driver.FindControl(By.Id("phone"));
        private IWebElement MobilePhone => Driver.FindControl(By.Id("phone_mobile"));
        private IWebElement AssignAnAddress => Driver.FindControl(By.Id("alias"));


        public void EnterMyAddress(string sCompany = null, string sAddress = null, string sAddress2 = null, string sCity = null, string sPostalCode = null, string sAddInformation = null, string sHomePhone = null, string sMobilePhone = null, string sAssignAnAddress = null)
        {
            Company.SendKeys(sCompany);
            Address.SendKeys(sAddress);
            Address2.SendKeys(sAddress2);
            City.SendKeys(sCity);
            Country.SelecyByValue("10");
            State.SelecyByValue("21");
            PostalCode.SendKeys(sPostalCode);
            AddInformation.SendKeys(sAddInformation);
            HomePhone.SendKeys(sHomePhone);
            MobilePhone.SendKeys(sHomePhone);
        }

        private IWebElement RegisterBtn => Driver.FindControl(By.Id("submitAccount"));

        public void RegisterButton()
        {
           RegisterBtn.Click()
        }



    }
}