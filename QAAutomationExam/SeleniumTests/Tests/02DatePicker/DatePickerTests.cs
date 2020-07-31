using NUnit.Framework;
using NUnit.Framework.Interfaces;
using POMHomework.Tests._01GoogleSearch;
using QAAutomationExam.SeleniumTests.Pages._02DatePicker;
using System;

namespace QAAutomationExam.SeleniumTests.Tests._02DatePicker
{
    [TestFixture]
    public class DatePickerTests : BaseTest
    {
        private DatePickerPage _datePickerPage;

        [SetUp]
        public void SetUp()
        {
            Initialize();
            _datePickerPage = new DatePickerPage(Driver);
            _datePickerPage.NavigateTo();
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
        public void RandomDaySuccessfullySelectedAndColorsExists_When_PickARandomDayFromDatePicker()
        {
            //Arrange
            _datePickerPage.RemoveDate();
            var random = new Random();
            var randomDay = random.Next(_datePickerPage.Days.Count);

            //Act
            _datePickerPage.Days[randomDay].Click();
            _datePickerPage.SelectDateSection.Click();

            //Assert
            _datePickerPage.AssertBackgroundColor("rgba(33, 107, 165, 1)", _datePickerPage.Days[randomDay]);
            _datePickerPage.AssertColor("rgba(255, 255, 255, 1)", _datePickerPage.Days[randomDay]);
        }

        [Test]
        public void RandomDaySuccessfullyHoveredAndColorsExists_When_HoveredARandomDayFromDatePicker()
        {
            //Arrange
            _datePickerPage.RemoveDate();
            var random = new Random();
            var randomDay = random.Next(_datePickerPage.Days.Count);

            //Act
            _datePickerPage.Days[randomDay].Click();
            _datePickerPage.SelectDateSection.Click();
            _datePickerPage.HoverADay(_datePickerPage.Days[randomDay]);

            //Assert
            _datePickerPage.AssertBackgroundColor("rgba(29, 93, 144, 1)", _datePickerPage.Days[randomDay]);
            _datePickerPage.AssertColor("rgba(255, 255, 255, 1)", _datePickerPage.Days[randomDay]);
        }

        [Test]
        public void AnyOtherDaySuccessfullyHoveredAndColorsExists_When_HoveredARandomDayFromDatePicker()
        {
            //Arrange
            _datePickerPage.RemoveDate();
            var random = new Random();
            var randomDay = random.Next(_datePickerPage.Days.Count);

            //Act
            _datePickerPage.HoverADay(_datePickerPage.Days[randomDay]);

            //Assert
            _datePickerPage.AssertBackgroundColor("rgba(240, 240, 240, 1)", _datePickerPage.Days[randomDay]);
            _datePickerPage.AssertColor("rgba(0, 0, 0, 1)", _datePickerPage.Days[randomDay]);
        }
    }
}
