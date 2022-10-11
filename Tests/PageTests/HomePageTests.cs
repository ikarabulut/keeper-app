using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Tests.PageObjects;

namespace Tests.PageTests;

public class HomePageTests : IDisposable
{
    private readonly IWebDriver _webDriver;
    private readonly HomePage _homePage;

    public HomePageTests()
    {
        _webDriver = new ChromeDriver(SetOptions());
        _homePage = new HomePage(_webDriver);
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
    public void HomePage_OnLoad_ShouldNotDisplayTitleField_ForNewNote()
    {
        Assert.Throws<NoSuchElementException>(() => _homePage.TitleFieldDisplayed());
    }

    [Fact]
    public void HomePage_WhenContentClicked_ShouldDisplayTitleField_ForNewNote()
    {
        _homePage.ClickContent();

        Assert.True(_homePage.TitleFieldDisplayed());
    }

    [Fact]
    public void HomePage_WhenNoteIsSubmitted_ShouldDisplayNewNote()
    {
        _homePage.SetContent("test note");
        _homePage.SetTitle("note");

        _homePage.SubmitNewNote();

        Assert.True(_homePage.NoteIsDisplayed("note"));
    }

    [Fact]
    public void HomePage_WhenDeleteIsClicked_ShouldDeleteSelectedNote()
    {
        _homePage.SetContent("test note");
        _homePage.SetTitle("note");
        _homePage.SubmitNewNote();

        _homePage.DeleteNote("note");

        Assert.Throws<NoSuchElementException>(() => _homePage.NoteIsDisplayed("note"));
    }

    [Fact]
    public void HomePage_WhenUserSubmitsTwoNotes_BothNotesShouldBeDisplayed()
    {
        _homePage.SetContent("test note");
        _homePage.SetTitle("note");
        _homePage.SubmitNewNote();
        _homePage.SetContent("test note 2");
        _homePage.SetTitle("note 2");
        _homePage.SubmitNewNote();

        Assert.True(_homePage.NoteIsDisplayed("note"));
        Assert.True(_homePage.NoteIsDisplayed("note 2"));
    }
}
