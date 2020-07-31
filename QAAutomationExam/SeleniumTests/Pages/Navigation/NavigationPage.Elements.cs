using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace QAAutomationExam.SeleniumTests.Pages.Navigation
{
    public partial class NavigationPage 
    {
        public WebElement WidgetsSectionsButtons =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='Widgets']/ancestor::div[contains(@class, 'top-card')]"));

        public WebElement SideBarMenu(string subsectionName) =>
            Driver.FindElement(By.XPath($"//*[normalize-space(text())='{subsectionName}']"));

        public WebElement PageHeader => Driver.FindElement(By.ClassName("main-header")); 
    }
}
