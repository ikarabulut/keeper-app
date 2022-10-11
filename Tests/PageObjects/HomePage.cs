using OpenQA.Selenium;

namespace Tests.PageObjects;

public class HomePage
{
    private readonly IWebDriver _webDriver;
    private readonly By _headerBy = By.CssSelector("header");
    private readonly By _titleBy = By.Name("title");
    private readonly By _contentBy = By.Name("content");
    private readonly By _submitButtonBy = By.Name("addNote");
    private readonly By _deleteButtonBy = By.Name("deleteNote");

    public HomePage(IWebDriver webDriver)
    {
        _webDriver = webDriver;
        _webDriver.Navigate().GoToUrl("http://localhost:3000/home");
    }

    public IWebElement ClickContent()
    {
        IWebElement contentInput = _webDriver.FindElement(_contentBy);
        contentInput.Click();
        return contentInput;
    }

    public void SetContent(string content)
    {
        IWebElement contentInput = ClickContent();
        contentInput.SendKeys(content);
    }

    public void SetTitle(string title)
    {
        IWebElement titleInput = _webDriver.FindElement(_titleBy);
        titleInput.SendKeys(title);
    }

    public void SubmitNewNote()
    {
        IWebElement submitButton = _webDriver.FindElement(_submitButtonBy);
        submitButton.Submit();
    }

    public Boolean TitleFieldDisplayed()
    {
        IWebElement titleInput = _webDriver.FindElement(_titleBy);
        return titleInput.Displayed;
    }

    public String GetHeaderText()
    {
        return _webDriver.FindElement(_headerBy).Text;
    }

    public void DeleteNote(string title)
    {
        IWebElement locatedNote = _webDriver.FindElement(By.Name(title));
        IWebElement deleteButton = locatedNote.FindElement(_deleteButtonBy);
        deleteButton.Submit();
    }
    public Boolean NoteIsDisplayed(string title)
    {
        IWebElement locatedNote = _webDriver.FindElement(By.Name(title));
        return locatedNote.Displayed;
    }
}
