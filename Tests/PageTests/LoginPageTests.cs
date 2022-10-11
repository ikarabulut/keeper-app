using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Tests.PageObjects;

namespace Tests.PageTests;

public class LoginPageTests : IDisposable
{
    private readonly IWebDriver _webDriver;
    private readonly LoginPage _loginPage;

    public LoginPageTests()
    {
        _webDriver = new ChromeDriver(SetOptions());
        _loginPage = new LoginPage(_webDriver);
    }

    private static ChromeOptions SetOptions()
    {
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("headless");
        return options;
    }

    public void Dispose()
    {
        _webDriver.Quit();
    }

    [Fact]
    public void LoginPage_LoginWithInValidCredentials_DisplaysInvalidCredentialsError()
    {
        _loginPage.SetUsername("invalidUsername");
        _loginPage.SetPassword("invalidPassword");

        _loginPage.LoginInvalidUser();

        Assert.True(_loginPage.InvalidCredentialsErrorDisplayed());
    }

    [Fact]
    public void LoginPage_LoginWithValidCredentials_SendsUserToHomePage()
    {
        var validUsername = "test";
        var validPassword = "password";
        _loginPage.SetUsername(validUsername);
        _loginPage.SetPassword(validPassword);

        HomePage home = _loginPage.LoginValidUser();

        Assert.Equal("Keeper", home.getHeaderText());
    }

}
