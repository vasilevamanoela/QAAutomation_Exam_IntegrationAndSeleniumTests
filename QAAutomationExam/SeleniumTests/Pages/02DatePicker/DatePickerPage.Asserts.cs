using NUnit.Framework;
using POMHomework.Utilities.Extensions;
using StabilizeTestsDemos.ThirdVersion;

namespace QAAutomationExam.SeleniumTests.Pages._02DatePicker
{
    public partial class DatePickerPage 
    {
        public void AssertBackgroundColor(string color, WebElement element)
        {
            Assert.AreEqual(color, element.GetCssColorBackground());
        }

        public void AssertColor(string color, WebElement element)
        {
            Assert.AreEqual(color, element.GetCssColorInside());
        }
    }
}
