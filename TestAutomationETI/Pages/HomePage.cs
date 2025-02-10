using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomationETI.Keywords;
using TestAutomationETI.Locators;

namespace TestAutomationETI.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver, WebDriverWait wait) 
            : base(driver, wait, PageTitles.HOME_PAGE_TITLE, CssLocators.DROPDOWN_PILL_HOME_PAGE) 
        {
            TestContext.Progress.WriteLine("Home Page is Loaded");
        }

        public DragAndDropPage NavigateToDragAndDropPage()
        {
            ActionKeywords.Click(_driver, CssLocators.DROPDOWN_PILL_HOME_PAGE);
            TestContext.Progress.WriteLine("Clicked and went to Drag and Drop Page");
            return new DragAndDropPage(_driver, _wait);
        }
    }
}
