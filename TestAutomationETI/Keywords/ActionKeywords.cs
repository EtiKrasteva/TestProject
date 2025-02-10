using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationETI.Keywords
{
    public static class ActionKeywords
    {
        public static void NavigateToPage(IWebDriver driver, string url) => driver.Navigate().GoToUrl(url);

        public static void WaitPageByCssSelector(WebDriverWait waitDriver, TimeSpan time, string cssSelector) 
            => waitDriver.Until(c => c.FindElement(By.CssSelector(cssSelector)));

        public static void Click(IWebDriver driver, string cssSelector) => driver.FindElement(By.CssSelector(cssSelector)).Click();

        public static IWebElement Find(IWebDriver driver, string cssSelector) => driver.FindElement(By.CssSelector(cssSelector));

        public static void DragAndDrop(IWebDriver driver, string cssSelectorStart, string cssSelectorEnd)
        {
            var startBox = driver.FindElement(By.CssSelector(cssSelectorStart));
            var endBox = driver.FindElement(By.CssSelector(cssSelectorEnd));

            var builder = new Actions(driver);
            var dragAndDropAction = builder.ClickAndHold(onElement: startBox).MoveToElement(endBox).Release(endBox).Build();

            dragAndDropAction.Perform();
        }
    }
}
