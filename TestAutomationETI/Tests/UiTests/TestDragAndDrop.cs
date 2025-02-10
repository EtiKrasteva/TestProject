using NUnit.Framework.Internal;
using OpenQA.Selenium;
using TestAutomationETI.Keywords;
using TestAutomationETI.Locators;
using TestAutomationETI.Pages;
using TestAutomationETI.Tests.UiTests;

namespace TestAutomationETI.UiTests
{
    [TestFixture]
    public class TestDragAndDrop : BaseUiTest
    {
        [TestCase(CssLocators.ITEM_FRIED_CHICKEN, CssLocators.PLATE_FRIED_CHICKEN)]
        [TestCase(CssLocators.ITEM_ICE_CREAM, CssLocators.PLATE_ICE_CREAM)]
        [TestCase(CssLocators.ITEM_HAMBURGTER, CssLocators.PLATE_HAMBURGTER)]
        public void DragAndDropTest(string startItem , string endItem)
        {
            // Navigate to Home Page .
            ActionKeywords.NavigateToPage(driver, configuration.UIConfig.Url);
            var homePage = new HomePage(driver, wait);

            // Go to Drag and Drop Page .
            var dragAndDropPage = homePage.NavigateToDragAndDropPage();

            // Drag and Drop item .
            dragAndDropPage.DragAndDropItems(startItem, endItem);

            // Assert Item .
            Assert.IsNotNull(driver.FindElement(By.CssSelector(endItem)));
            TestContext.Progress.WriteLine("Asserted Item is dragged and test passed.");
        }
    }
}