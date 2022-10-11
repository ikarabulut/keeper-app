using OpenQA.Selenium;

namespace Tests.PageObjects;

public class HomePage
{
    private IWebDriver _webDriver;
    private readonly By _usernameBy = By.Name("username");
    private readonly By _passwordBy = By.Name("password");
    private readonly By _signinBy = By.Name("signin");

    public HomePage(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }
}

/*
public void setName(string name)
{
    IWebElement repoNameInput = webDriver.FindElement(By.Name("repoNameInput"));
    repoNameInput.Click();
    repoNameInput.SendKeys(name);
}

public void setDescription(string description)
{
    IWebElement repoDescriptionInput = webDriver.FindElement(By.Name("repoDescriptionInput"));
    repoDescriptionInput.Click();
    repoDescriptionInput.SendKeys(description);
}

public void SubmitRepo()
{
    IWebElement repoSubmitButton = webDriver.FindElement(By.Name("submitButton"));
    repoSubmitButton.Click();
}

public void DeleteRepo(string repoName)
{
    IWebElement deleteRepoNameInput = webDriver.FindElement(By.Name("deleteRepoInput"));
    deleteRepoNameInput.Click();
    deleteRepoNameInput.SendKeys(repoName);
    IWebElement repoDeleteButton = webDriver.FindElement(By.Name("deleteButton"));
    repoDeleteButton.Click();
}

public Boolean GetSuccessAlert()
{
    IWebElement repoSubmitButton = webDriver.FindElement(By.Id("successAlert"));
    return repoSubmitButton.Displayed;
}

public Boolean GetFailureAlert()
{
    IWebElement repoSubmitButton = webDriver.FindElement(By.Id("failureAlert"));
    return repoSubmitButton.Displayed;
}
*/
