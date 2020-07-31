using OpenQA.Selenium;
using StabilizeTestsDemos.ThirdVersion;
using System.Collections.Generic;

namespace QAAutomationExam.SeleniumTests.Pages._02DatePicker
{
    public partial class DatePickerPage 
    {
        public WebElement SelectDateSection => Driver.FindExistingElement(By.XPath("//input[@id='datePickerMonthYearInput']"));

        public List<WebElement> Days => Driver.FindElements(By.XPath("//div[@class='react-datepicker__month']//div[contains(@class, 'react-datepicker__day') and not(contains(@class, 'outside-month'))]"));
    }
}
