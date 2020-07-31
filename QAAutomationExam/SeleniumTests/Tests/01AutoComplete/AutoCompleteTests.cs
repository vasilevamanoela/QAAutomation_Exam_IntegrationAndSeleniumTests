using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using QAAutomationExam.SeleniumTests.Pages._01;

namespace QAAutomationExam.SeleniumTests.Tests._01
{
    [TestFixture]
    public class AutoCompleteTests : BaseTest
    {
        private AutoCompletePage _autoCompletePage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _autoCompletePage = new AutoCompletePage(Driver);
            _autoCompletePage.NavigateTo();
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
        public void OnlyOneOptionIsShown_When_WriteColorInAutoComplete()
        {
            _autoCompletePage.WriteColorRed(_autoCompletePage.MyltipleContainer);
            _autoCompletePage.WriteRe(_autoCompletePage.MyltipleContainer);

            _autoCompletePage.AssertColorDisplayed(_autoCompletePage.GreenColor);
            _autoCompletePage.AssertCorrectColor("Green", _autoCompletePage.GreenColor);
        }
    }
}
