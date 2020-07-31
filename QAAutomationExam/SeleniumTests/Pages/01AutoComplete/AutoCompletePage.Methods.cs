using OpenQA.Selenium;
using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace QAAutomationExam.SeleniumTests.Pages._01
{
    public partial class AutoCompletePage : BasePage
    {
        public AutoCompletePage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/auto-complete";

        public void WriteColorRed(WebElement element)
        {
            Builder
                .Click(element.WrappedElement)
                .SendKeys("Red" + Keys.Enter)
                .Perform();
        }

        public void WriteRe(WebElement element)
        {
            Builder
                .Click(element.WrappedElement)
                .SendKeys("Re")
                .Perform();
        }     
    }
}
