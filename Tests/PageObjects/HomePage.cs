using OpenQA.Selenium;

namespace Tests.PageObjects;

public class HomePage
{
    private readonly IWebDriver _webDriver;
    private readonly By _headerBy = By.CssSelector("header");


    public HomePage(IWebDriver webDriver)
    {
        _webDriver = webDriver;
        _webDriver.Navigate().GoToUrl("http://localhost:3000/home");
    }

    public String getHeaderText()
    {
        return _webDriver.FindElement(_headerBy).Text;
    }
}
