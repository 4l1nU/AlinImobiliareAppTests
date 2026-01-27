using TestProjectAlinImobiliare.Pages;

namespace TestProjectAlinImobiliare;

public class AccountTests : TestBase
{
    private AccountPage page;

    [SetUp]
    public void Init()
    {
        driver.Navigate().GoToUrl(BaseUrl + "authentication.php");
        page = new AccountPage(driver);
    }

    //UI TESTS

    [Test]
    public void LoginTab_ShouldBeVisible()
    {
        Assert.That(page.LoginTab.Displayed);
    }

    [Test]
    public void RegisterTab_ShouldBeVisible()
    {
        Assert.That(page.RegisterTab.Displayed);
    }

    //REGISTER TESTS

    [Test]
    public void Register_WithValidData_ShouldShowSuccessMessage()
    {
        page.RegisterTab.Click();
        Thread.Sleep(1000);

        page.FirstName.SendKeys("Test");
        page.LastName.SendKeys("User");
        page.RegisterEmail.SendKeys("testuser" + System.Guid.NewGuid() + "@mail.com");
        page.RegisterPassword.SendKeys("Password123!");

        page.RegisterButton.Click();
        Thread.Sleep(2000);

        Assert.That(page.Body.Text.Contains("Mail trimis") || page.Body.Text.Contains("succes"));

    }

    [Test]
    public void Register_WithEmptyFields_ShouldNotSubmit()
    {
        page.RegisterTab.Click();
        Thread.Sleep(1000);

        page.RegisterButton.Click();
        Thread.Sleep(1000);

        Assert.That(page.FirstName.GetAttribute("validationMessage") != "");
    }

    //LOGIN TESTS

    [Test]
    public void Login_WithValidCredentials_ShouldRedirect()
    {
        page.LoginEmail.SendKeys("scornea.a@gmail.com");
        page.LoginPassword.SendKeys("scornea");
        page.LoginButton.Click();

        Thread.Sleep(2000);

        Assert.That(driver.Url.Contains("profile/"));
    }

    [Test]
    public void Login_WithInvalidCredentials_ShouldShowError()
    {
        page.LoginEmail.SendKeys("wrong@mail.com");
        page.LoginPassword.SendKeys("wrongpass");
        page.LoginButton.Click();

        Thread.Sleep(1000);

        Assert.That(page.Body.Text.Contains("Date introduse invalide!"));
    }

    //TAB FUNCTIONALITY TEST

    [Test]
    public void RegisterTab_Click_ShouldShowRegisterForm()
    {
        page.RegisterTab.Click();
        Thread.Sleep(1000);

        Assert.That(page.FirstName.Displayed);
    }
}
