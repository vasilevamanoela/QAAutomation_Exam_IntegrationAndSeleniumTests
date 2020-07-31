using NUnit.Framework;
using StabilizeTestsDemos.ThirdVersion;

namespace QAAutomationExam.SeleniumTests.Pages.Navigation
{
    public partial class NavigationPage 
    {
        public void AssertCorrectSubsectionTitles(string subsectionName, WebElement element)
        {
            Assert.AreEqual(subsectionName, element.Text);
        }
    }
}
