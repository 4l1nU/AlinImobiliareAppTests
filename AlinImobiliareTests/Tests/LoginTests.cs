using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Support.UI;
namespace TestProjectAlinImobiliare.Tests
{
    public class LoginTests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Login_WithValidCredentialsFromTestParameters_ShouldRedirect()
        {
            string? User = TestContext.Parameters["user"];
            string? Password = TestContext.Parameters["password"];
            LoginPage lg = new LoginPage(driver);
            driver.Navigate().GoToUrl(TestContext.Parameters["login_url"]);
            lg.Login(User, Password);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Url == TestContext.Parameters["home_url"] + "profile/");

            Assert.That(driver.Url == TestContext.Parameters["home_url"] + "profile/");
        }

        [TearDown]
        public void TearDown() { driver.Dispose(); }
    }
}