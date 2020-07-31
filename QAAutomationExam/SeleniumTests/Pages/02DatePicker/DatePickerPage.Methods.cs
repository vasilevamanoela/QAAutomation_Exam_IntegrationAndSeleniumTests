using OpenQA.Selenium;
using POMHomework.Pages;
using StabilizeTestsDemos.ThirdVersion;

namespace QAAutomationExam.SeleniumTests.Pages._02DatePicker
{
    public partial class DatePickerPage : BasePage
    {
        public DatePickerPage(WebDriver driver) 
            : base(driver)
        {
        }

        public override string Url => "https://www.demoqa.com/date-picker";

        public void RemoveDate()
        {
            SelectDateSection.WrappedElement.SendKeys(Keys.Control + "a" + Keys.Backspace);
        }

        public void HoverADay(WebElement element)
        {
            Builder
                .MoveToElement(element.WrappedElement)
                .Perform();
        }
    }
}
