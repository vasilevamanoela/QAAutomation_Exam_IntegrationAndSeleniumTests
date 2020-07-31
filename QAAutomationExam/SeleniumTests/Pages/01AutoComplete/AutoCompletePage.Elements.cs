using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;

namespace QAAutomationExam.SeleniumTests.Pages._01
{
    public partial class AutoCompletePage 
    {
        public WebElement MyltipleContainer => Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']"));

        public WebElement GreenColor => Driver.FindElement(By.XPath("//div[@id='react-select-2-option-1']"));
    }
}
