using OpenQA.Selenium;
using TestProjectAlinImobiliare.Drivers;

namespace TestProjectAlinImobiliare;

public class TestBase
{
    protected IWebDriver driver;
    protected string BaseUrl = "http://127.0.0.1/licenta/";

    [SetUp]
    public void Setup()
    {
        driver = WebDriverFactory.CreateChrome();
        driver.Navigate().GoToUrl(BaseUrl);
    }

    [TearDown]
    public void TearDown()
    {
        driver.Close();
    }
}
