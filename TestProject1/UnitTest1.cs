using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://127.0.0.1/licenta");

            Assert.That(driver.Url, Is.EqualTo("http://127.0.0.1/licenta/"));
            Assert.That(driver.Title, Is.EqualTo("Acasa"));
        }

        [TearDown]
        public void TearDown() { driver.Dispose(); }
    }
}