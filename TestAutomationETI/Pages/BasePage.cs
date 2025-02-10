using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomationETI.Keywords;
using TestAutomationETI.Locators;

namespace TestAutomationETI.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver _driver;
        protected WebDriverWait _wait;

        protected BasePage(IWebDriver driver, WebDriverWait wait, string pageTitle, string waitSelector)
        {
            _driver = driver;
            _wait = wait;
            ActionKeywords.WaitPageByCssSelector(_wait, new TimeSpan(0, 0, 30), waitSelector);
            if (driver.Title != (pageTitle))
            {
                throw new ArgumentException($"Incorrect page. Current page is {driver.Url}");
            }            
        }
    }
}
