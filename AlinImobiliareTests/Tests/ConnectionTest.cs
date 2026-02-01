using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace TestProjectAlinImobiliare.Tests
{
    public class ConnectionTest
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void AccessingWebsite()
        {
            driver.Navigate().GoToUrl(TestContext.Parameters["home_url"]);

            Assert.That(driver.Url, Is.EqualTo("http://127.0.0.1/licenta/"));
            Assert.That(driver.Title, Is.EqualTo("Acasa"));
        }

        [TearDown]
        public void TearDown() { driver.Dispose(); }
    }
}