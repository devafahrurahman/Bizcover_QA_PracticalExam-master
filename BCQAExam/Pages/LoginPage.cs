using BCQAExam.Core;
using OpenQA.Selenium;

namespace BCQAExam.Pages
{
    public class LoginPage : BasePage
    {
        private IWebElement Email => Driver.FindControl(By.Id("email"), true);

        private IWebElement Password => Driver.FindControl(By.Id("passwd"));

        private IWebElement LoginButton => Driver.FindControl(By.Id("SubmitLogin"));

        public void Login(string email = null, string password = null)
        {
            Email.Clear();
            Email.SendKeys(email);
            Password.Clear();
            Password.SendKeys(password);
            LoginButton.Click();
        }
    }
}
