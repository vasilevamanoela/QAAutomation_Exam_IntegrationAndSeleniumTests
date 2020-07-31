using POMHomework.Pages;
using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace QAAutomationExam.SeleniumTests.Pages.Navigation
{
    public partial class NavigationPage : BasePage
    {
        public NavigationPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "http://www.demoqa.com/";

        public void NavigateToWidgetsSubsection(string subsectionName)
        {
            WidgetsSectionsButtons.ScrollTo().Click();
            SideBarMenu(subsectionName).ScrollTo().ToBeVisible().Click();
        }
    }
}
