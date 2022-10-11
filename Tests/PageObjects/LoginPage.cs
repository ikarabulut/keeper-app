using OpenQA.Selenium;

namespace Tests.PageObjects;

public class LoginPage
{
    private IWebDriver _webDriver;
    private readonly By _usernameBy = By.Name("username");
    private readonly By _passwordBy = By.Name("password");
    private readonly By _signinBy = By.Name("signin");
    private readonly By _invalidCredentialsBy = By.Id("loginError");

    public LoginPage(IWebDriver webDriver)
    {
        _webDriver = webDriver;
        _webDriver.Navigate().GoToUrl("http://localhost:3000/");
    }

    public void SetUsername(string username)
    {
        IWebElement usernameInput = _webDriver.FindElement(_usernameBy);
        usernameInput.Click();
        usernameInput.SendKeys(username);
    }

    public void SetPassword(string password)
    {
        IWebElement passwordInput = _webDriver.FindElement(_passwordBy);
        passwordInput.Click();
        passwordInput.SendKeys(password);
    }

    public HomePage LoginValidUser()
    {
        IWebElement login = _webDriver.FindElement(_signinBy);
        login.Submit();
        return new HomePage(_webDriver);
    }

    public void LoginInvalidUser()
    {
        IWebElement login = _webDriver.FindElement(_signinBy);
        login.Submit();
    }

    public Boolean InvalidCredentialsErrorDisplayed()
    {
        IWebElement invalidCredentialsError = _webDriver.FindElement(_invalidCredentialsBy);
        return invalidCredentialsError.Displayed;
    }
}
