using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomationETI.Keywords;
using TestAutomationETI.Locators;

namespace TestAutomationETI.Pages
{
    public class DragAndDropPage : BasePage
    {
        public DragAndDropPage(IWebDriver driver, WebDriverWait wait)
            : base(driver, wait, PageTitles.DRAG_AND_DROP_PAGE_TITLE, CssLocators.ITEM_FRIED_CHICKEN)
        {
            TestContext.Progress.WriteLine("Drag and Drop page loaded.");
        }

        public void DragAndDropItems(string itemToDragAndDrop, string endItem)
        {
            ActionKeywords.Click(_driver, itemToDragAndDrop);
            ActionKeywords.DragAndDrop(_driver, itemToDragAndDrop, CssLocators.DROIP_LOCATION);
            ActionKeywords.WaitPageByCssSelector(_wait, new TimeSpan(0, 0, 30), endItem);
            TestContext.Progress.WriteLine("Items dragged successfully.");
        }
    }
}
