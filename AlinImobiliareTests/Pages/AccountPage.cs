using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAlinImobiliare.Pages
{
    public class AccountPage
    {
        private readonly IWebDriver driver;

        public AccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Tabs
        public IWebElement LoginTab => driver.FindElement(By.Id("tab-login"));
        public IWebElement RegisterTab => driver.FindElement(By.Id("tab-register"));

        // Login fields
        public IWebElement LoginEmail => driver.FindElement(By.Id("loginName"));
        public IWebElement LoginPassword => driver.FindElement(By.Id("loginPassword"));
        public IWebElement LoginButton => driver.FindElement(By.Name("login_submit"));

        // Logout button
        public IWebElement LogoutButton => driver.FindElement(By.LinkText("Ieși din cont"));

        // Register fields
        public IWebElement FirstName => driver.FindElement(By.Name("first_name"));
        public IWebElement LastName => driver.FindElement(By.Name("last_name"));
        public IWebElement RegisterEmail => driver.FindElement(By.Id("registerEmail"));
        public IWebElement RegisterPassword => driver.FindElement(By.Id("registerPassword"));
        public IWebElement RegisterButton => driver.FindElement(By.Name("submit"));

        // Messages (simple locator)
        public IWebElement Body => driver.FindElement(By.TagName("body"));

        public void Login(string email, string password)
        {
            LoginEmail.SendKeys(email);
            LoginPassword.SendKeys(password);
            LoginButton.Click();
        }
    }
}
