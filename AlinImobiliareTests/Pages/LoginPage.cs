using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
namespace TestProjectAlinImobiliare
{
    public class LoginPage
    {
        private IWebDriver driver;
        [FindsBy(How = How.Id, Using = "loginName")]
        private IWebElement emailtxt;
        [FindsBy(How = How.Id, Using = "loginPassword")]
        private IWebElement passwordtxt;
        [FindsBy(How = How.Name, Using = "login_submit")]
        private IWebElement loginbtn;
        public LoginPage(IWebDriver driver) { this.driver = driver; PageFactory.InitElements(driver, this); }
        public void login(string username, string password)
        {
            emailtxt.SendKeys(username);
            passwordtxt.SendKeys(password);
            loginbtn.Click();
        }
    }
}