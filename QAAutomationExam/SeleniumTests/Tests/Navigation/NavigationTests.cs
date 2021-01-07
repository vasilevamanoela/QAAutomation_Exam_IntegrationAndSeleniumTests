using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using QAAutomationExam.SeleniumTests.Pages.Navigation;

namespace QAAutomationExam.SeleniumTests.Tests.Navigation
{
    [TestFixture]
    public class NavigationTests : BaseTest
    {
        private NavigationPage _navigationPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _navigationPage = new NavigationPage(Driver);
            _navigationPage.NavigateTo();
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Driver.TakeScreenshot();
            }

            Driver.Quit();
        }

        [Test]
        [TestCase("Auto Complete")]
        [TestCase("Date Picker")]
        public void WidgetsSectionNameDisplayed_When_NavigateToWidgetsSection(string subsectionName)
        {
            _navigationPage.NavigateToWidgetsSubsection(subsectionName);

            _navigationPage.AssertCorrectSubsectionTitles(subsectionName, _navigationPage.PageHeader);
        }
    }
}
